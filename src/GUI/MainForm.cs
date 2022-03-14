using System.ComponentModel;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;

namespace DirectoryTraversal.GUI
{
    public partial class MainForm : Form
    {
        // inisialisasi variabel
        public string path = "";
        public bool isBFS = false;
        public bool isDFS = false;
        public bool allOccurences = false;
        public bool running = false;
        public string fileName = "";

        // inisialisasi graphViewer, worker, dicts
        Graph graph;
        FileInfo filePathRes;
        bool isFound = false;
        int drawDelay = 250;
        GViewer graphViewer = new();
        BackgroundWorker worker = new();
        Dictionary<string, Edge> idToEdges;

     
        public MainForm()
        {
            InitializeComponent();
            OutputPanel.SuspendLayout();
            OutputPanel.Controls.Add(graphViewer);
            OutputPanel.ResumeLayout();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.WorkerReportsProgress = true;
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult res = fbd.ShowDialog();

                if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    MessageBox.Show(files.Aggregate("", (c, n) => c + n + "\n"));
                    System.Windows.Forms.MessageBox.Show(
                        "Chosen path: " + fbd.SelectedPath +
                        "\nFiles found: " + files.Length.ToString(),
                        "[SUCCESS] Path Identified!"
                        );
                    DirLabel.Text = "Chosen directory: " + fbd.SelectedPath;
                    path = fbd.SelectedPath;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                      "Invalid path! Please try again...",
                      "[WARNING] Invalid Path!"
                    );
                }
            }
        }

        private void BFSButton_CheckedChanged(object sender, EventArgs e)
        {
            isBFS = true;
            if (isDFS)
            {
                isDFS = false;
            }
        }

        private void OccurenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            allOccurences = !allOccurences;
        }

        private void DFSButton_CheckedChanged(object sender, EventArgs e)
        {
            isDFS = true;
            if (isBFS)
            {
                isBFS = false;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                string alert = "Folder path: " + path + "\nMode: ";
                if (isBFS)
                {
                    alert += "Breadth First Search\n";
                }
                if (isDFS)
                {
                    alert += "Depth First Search\n";
                }
                if (allOccurences)
                {
                    alert += "Check all occurences: ENABLED";
                }
                fileName = this.FileInput.Text;

                System.Windows.Forms.MessageBox.Show(
                  alert
                );
                //TODO: Deliver to backend around here
                Status.Text = "Searching for file '" + fileName + "'...";
                running = true;
                worker.RunWorkerAsync();
                running = false;
            } else
            {
                System.Windows.Forms.MessageBox.Show(
                    "You cannot run the search as of now because another search is running!",
                    "[ALERT] Another process running!");
            }

           
        }

   
        void TraverseDFSRecurse(string dirPath)
        {
            DirectoryInfo dirMain = new(dirPath);
            foreach (FileInfo file in dirMain.EnumerateFiles().Reverse())
            {
                worker.ReportProgress(0, string.Format(
                    "draw|node|{0}|{1}", //id pake fullname, nama pake name
                    file.FullName,
                    file.Name
                ));
                worker.ReportProgress(0, string.Format(
                    "draw|edge|{0}|{1}",
                    dirMain.FullName, //from_id dari dirmain, to_id dari fullname
                    file.FullName
                ));
                if (file.Name == fileName)
                {
                    isFound = true;
                    filePathRes = file;
                    worker.ReportProgress(0, string.Format(
                        "draw|found|{0}",
                        file.FullName
                    ));
                }
                Thread.Sleep(drawDelay);
            }
            foreach (DirectoryInfo dir in dirMain.EnumerateDirectories().Reverse())
            {
                worker.ReportProgress(0, string.Format(
                    "draw|node|{0}|{1}",
                    dir.FullName,
                    dir.Name
                ));
                worker.ReportProgress(0, string.Format(
                    "draw|edge|{0}|{1}",
                    dirMain.FullName,
                    dir.FullName
                ));
                Thread.Sleep(drawDelay);
                TraverseDFSRecurse(dir.FullName);
            }
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
            if (isBFS)
            {
                TraverseDFSRecurse(dirMain.FullName);
            }
            else
            {
                TraverseBFS(dirMain.FullName);
            }

        }

        void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            string[]? s = e.UserState?.ToString()?.Split('|');
            switch (s[0])
            {
                case "create":
                    graph = new Graph(DateTime.Now.Ticks.ToString());
                    break;
                case "draw":
                    graphViewer.Graph = new();
                    if (s[1] == "node") // draw|node|id|label
                    {
                        Node n = graph.AddNode(s[2]);
                        n.LabelText = s[3];
                        n.Attr.Color = isFound ? Color.Black : Color.Red;
                    } else if (s[1] == "edge") // draw|edge|from_id|to_id
                    {
                        Edge edge = graph.AddEdge(s[2], s[3]);
                        edge.Attr.Color = isFound ? Color.Black : Color.Red;
                        idToEdges[string.Format("{0}|{1}", s[2], s[3])] = edge;
                    } else if (s[1] == "found")
                    {
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
                    graphViewer.Graph = graph;
                    break;
            }
        }

        
        void TraverseBFS(string fromDirectory)
        {
            DirectoryInfo dirMain = new(fromDirectory);
            Queue<string> q = new Queue<string>();
            List<string> visitedNodes = new List<string>();

            visitedNodes.Add(fromDirectory);
            q.Enqueue(fromDirectory);

            while (q.Count > 0)
            {
                string deqNode = q.Dequeue();
                dirMain = new(deqNode);
                foreach (FileInfo file in dirMain.EnumerateFiles().Reverse())
                {
                    if (!visitedNodes.Contains(file.FullName))
                    {
                        worker.ReportProgress(0, string.Format(
                            "draw|node|{0}|{1}", 
                            file.FullName,
                            file.Name
                            ));
                        worker.ReportProgress(0, string.Format(
                            "draw|edge|{0}|{1}",
                            dirMain.FullName, 
                            file.FullName
                        ));

                        if (file.Name == fileName)
                        {
                            isFound = true;
                            filePathRes = file;
                            worker.ReportProgress(0, string.Format(
                                "draw|found|{0}",
                                file.FullName
                            ));
                        }
                    }
                    Thread.Sleep(drawDelay);
                }
                foreach (DirectoryInfo dir in dirMain.EnumerateDirectories().Reverse())
                {
                    if (!visitedNodes.Contains(dir.FullName))
                    {
                        worker.ReportProgress(0, string.Format(
                             "draw|node|{0}|{1}",
                             dir.FullName,
                             dir.Name
                         ));
                        worker.ReportProgress(0, string.Format(
                            "draw|edge|{0}|{1}",
                            dirMain.FullName,
                            dir.FullName
                        ));
                        Thread.Sleep(drawDelay);
                        q.Enqueue(dir.FullName);
                        visitedNodes.Add(dir.FullName);
                    }
                }
            }
            q.Clear();
            visitedNodes.Clear();
        }

        void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            Traverse(path);
        }

        private void delaySpeed_ValueChanged(object sender, EventArgs e)
        {
            delayLabel.Text = delaySpeed.Value.ToString() + " ms";
            drawDelay = delaySpeed.Value;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}