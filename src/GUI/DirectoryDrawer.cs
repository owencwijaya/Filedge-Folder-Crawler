using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;

namespace DirectoryTraversal.GUI
{
    using DirectoryTraversal.Lib;

    public class DirectoryDrawer
    {
        // inisialisasi variabel
        public string path = "";
        public bool isBFS = true;
        public bool isDFS = false;
        public bool allOccurences = false;
        public bool running = false;
        public string fileName = "";
        public int drawDelay = 25;

        List<string> foundPaths = new List<string>();
        Graph graph;
        bool isFound = false;
        

        // inisialisasi worker, traverser, dicts
        public BackgroundWorker worker = new();
        public DirectoryTraversal Traverser = new();

        Dictionary<string, Edge> idToEdges;
        Stopwatch sw = new Stopwatch();
       
        public Action<Graph>? UpdateGraph;
        public Action<string>? UpdateStatus1;
        public Action<string>? UpdateStatus2;

        public DirectoryDrawer()
        {
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_CalculateTime);
            worker.WorkerReportsProgress = true;
            Traverser.OnFile = OnFile;
            Traverser.OnFound = OnFound;
            Traverser.OnDirectory = OnDirectory;
        }

        void Traverse(string fromDirectory)
        {
            worker.ReportProgress(0, "create");
            isFound = false;
            idToEdges = new();
            DirectoryInfo dirMain = new(fromDirectory);
            worker.ReportProgress(0, string.Format(
                "draw|node|{0}|{1}",
                dirMain.FullName,
                dirMain.Name
            ));
            if (isDFS)
            {
                Traverser.Traverse(dirMain.FullName, fileName, allOccurences, Algorithm.DFS);
            }
            else
            {
                Traverser.Traverse(dirMain.FullName, fileName, allOccurences, Algorithm.BFS);
            }

        }

        void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            string[]? s = e.UserState?.ToString()?.Split('|');
            UpdateGraph.Invoke(null);

            switch (s[0])
            {
                case "create":
                    graph = new Graph(DateTime.Now.Ticks.ToString());
                    break;
                case "draw":
                    if (s[1] == "node") // draw|node|id|label
                    {
                        Node n = graph.AddNode(s[2]);
                        n.LabelText = s[3];
                        n.Attr.Color = isFound ? Color.Black : Color.Red;
                    }
                    else if (s[1] == "edge") // draw|edge|from_id|to_id
                    {
                        Edge edge = graph.AddEdge(s[2], s[3]);
                        edge.Attr.Color = isFound ? Color.Black : Color.Red;
                        idToEdges[string.Format("{0}|{1}", s[2], s[3])] = edge;
                    }
                    else if (s[1] == "found")
                    {
                        isFound = true;
                        Node n = graph.FindNode(s[2]);
                        n.Attr.Color = Color.Green;
                        string child = s[2];
                        string? parent = new FileInfo(s[2]).DirectoryName;
                        while (parent != null && child != path)
                        {
                            Edge edge = idToEdges[string.Format("{0}|{1}", parent, child)];
                            edge.Attr.Color = Color.Green;
                            DirectoryInfo dir = new(parent);
                            n = graph.FindNode(dir.FullName);
                            n.Attr.Color = Color.Green;
                            child = dir.FullName;
                            parent = dir.Parent?.FullName;
                        }
                    }
                    break;
            }
            UpdateGraph?.Invoke(graph);
        }


        void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            sw.Reset();
            sw.Start();
            running = true;
            Traverse(path);
            running = false;
        }

        void Worker_CalculateTime(object? sender, RunWorkerCompletedEventArgs e)
        {
            sw.Stop();
            UpdateStatus1?.Invoke("Elapsed time (animation included): " + sw.ElapsedMilliseconds + " ms\n");
            if (foundPaths.Count != 0)
            {
                if (foundPaths.Count > 1)
                {
                    UpdateStatus2?.Invoke("Multiple files with same name found: \n");
                }
                foreach (string path in foundPaths)
                {
                    UpdateStatus2?.Invoke("- " + path + "\n");
                }
            }
            else
            {
                UpdateStatus1?.Invoke("\nFile " + fileName + " not found...");
            }
            foundPaths.Clear();
        }

        void OnFile(FileInfo File)
        {
            worker.ReportProgress(0, string.Format(
                "draw|node|{0}|{1}", //id pake fullname, nama pake name
                File.FullName,
                File.Name
            ));

            worker.ReportProgress(0, string.Format(
                "draw|edge|{0}|{1}",
                File.DirectoryName, //from_id dari DirMain, to_id dari fullname
                File.FullName
            ));
        }

        void OnFound(FileInfo File)
        {
            worker.ReportProgress(0, string.Format(
                "draw|found|{0}",
                File.FullName
            ));
            foundPaths.Add(File.FullName);
        }

        void OnDirectory(DirectoryInfo Directory)
        {
            worker.ReportProgress(0, string.Format(
                "draw|node|{0}|{1}",
                Directory.FullName,
                Directory.Name
            ));
            worker.ReportProgress(0, string.Format(
                "draw|edge|{0}|{1}",
                Directory.Parent?.FullName,
                Directory.FullName
            ));
        }
    }

}