using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;

namespace DirectoryTraversal.GUI
{
    using DirectoryTraversal.Lib;

    public class DirectoryDrawer
    {
        // inisialisasi variabel
        public string Path = "";
        public bool IsRunning = false;
        public string FileName = "";
        public bool AllOccurences = false;
        public Algorithm Algorithm { get; set; }
        public static int DrawDelay {
            set { Traverser.DrawDelay = value; }
        }

        readonly List<string> foundPaths = new();
        Graph graph = new();
        bool isFound = false;

        // inisialisasi worker, traverser, dicts
        readonly BackgroundWorker worker = new();
        static readonly DirectoryTraversal Traverser = new();
        readonly GViewer graphViewer = new();
        public GViewer GraphViewer { get { return graphViewer; } }

        readonly Dictionary<string, Edge> idToEdges = new();
        readonly Stopwatch sw = new();

        public Action<string>? UpdateStatus;
        public Action<string>? UpdateLink;

        public DirectoryDrawer()
        {
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_CalculateTime);
            worker.WorkerReportsProgress = true;

            Traverser.OnFile = OnFile;
            Traverser.OnFound = OnFound;
            Traverser.OnDirectory = OnDirectory;

            graphViewer.Graph = graph;

            graphViewer.AutoSize = true;
            graphViewer.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        }

        public void DrawTraverse()
        {
            worker.RunWorkerAsync();
        }

        void Traverse()
        {
            worker.ReportProgress(0, "create");
            isFound = false;
            idToEdges.Clear();
            DirectoryInfo dirMain = new(Path);
            worker.ReportProgress(0, string.Format(
                "draw|node|{0}|{1}",
                dirMain.FullName,
                dirMain.Name
            ));
            Traverser.Traverse(dirMain.FullName, FileName, AllOccurences, Algorithm);
        }

        void CreateGraph()
        {
            graph = new Graph(DateTime.Now.Ticks.ToString());
        }

        void DrawNodeGraph(string id, string label)
        {
            Node n = graph.AddNode(id);
            n.LabelText = label;
            //n.Attr.Color = isFound ? Color.Black : Color.Red;
            n.Attr.Color = Color.Red;
        }

        void DrawEdgeGraph(string fromId, string toId)
        {
            Edge edge = graph.AddEdge(fromId, toId);
            //edge.Attr.Color = isFound ? Color.Black : Color.Red;
            edge.Attr.Color = Color.Red;
            idToEdges[string.Format("{0}|{1}", fromId, toId)] = edge;
        }

        void DrawFoundGraph(string nodeId)
        {
            isFound = true;
            Node n = graph.FindNode(nodeId);
            n.Attr.Color = Color.Green;
            string child = nodeId;
            string? parent = new FileInfo(nodeId).DirectoryName;
            while (parent != null && child != Path)
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

        void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            string[]? s = e.UserState?.ToString()?.Split('|');
            graphViewer.Graph = null;
            switch (s?[0])
            {
                case "create":
                    CreateGraph();
                    break;
                case "draw":
                    if (s[1] == "node") // draw|node|id|label
                        DrawNodeGraph(s[2], s[3]);
                    else if (s[1] == "edge") // draw|edge|from_id|to_id
                        DrawEdgeGraph(s[2], s[3]);
                    else if (s[1] == "found") // draw|found|node_id
                        DrawFoundGraph(s[2]);
                    break;
            }
            graphViewer.Graph = graph;
        }

        void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            sw.Reset();
            sw.Start();
            IsRunning = true;
            Traverse();
            IsRunning = false;
        }

        void Worker_CalculateTime(object? sender, RunWorkerCompletedEventArgs e)
        {
            sw.Stop();
            UpdateStatus?.Invoke("  | Elapsed time (animation included): " + sw.ElapsedMilliseconds + " ms");
            if (foundPaths.Count != 0)
            {
                if (foundPaths.Count == 1)
                {
                    UpdateStatus?.Invoke("  | File found!");
                }
                else
                {
                    UpdateStatus?.Invoke("  | " + foundPaths.Count + " files found! ");
                }
                foreach (string path in foundPaths)
                    UpdateLink?.Invoke(path);
            }

            else
                UpdateStatus?.Invoke("  | File " + FileName + " not found...");
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