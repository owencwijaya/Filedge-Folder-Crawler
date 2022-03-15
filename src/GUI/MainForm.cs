using System.ComponentModel;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;
using DirectoryTraversal.Lib.Algorithms;

using System.Diagnostics;

namespace DirectoryTraversal.GUI
{
    using DirectoryTraversal.Lib;
    public partial class MainForm : Form
    {
        // inisialisasi variabel
        public string path = "";
        public bool isBFS = true;
        public bool isDFS = false;
        public bool allOccurences = false;
        public bool running = false;
        public string fileName = "";
        List<string> foundPaths = new List<string>();
        // inisialisasi graphViewer, worker, dicts
        Graph graph;
        FileInfo filePathRes;
        bool isFound = false;
        int drawDelay = 25;
        GViewer graphViewer = new GViewer();
        public static BackgroundWorker worker = new();
        Dictionary<string, Edge> idToEdges;
        Stopwatch sw = new Stopwatch();
        DirectoryTraversal Traverser = new();
    
        public MainForm()
        {
            InitializeComponent();
            OutputPanel.SuspendLayout();
            OutputPanel.Controls.Add(graphViewer);
            OutputPanel.ResumeLayout();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_CalculateTime);
            worker.WorkerReportsProgress = true;
            graphViewer.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            Traverser.OnFile = OnFile;
            Traverser.OnFound = OnFound;
            Traverser.OnDirectory = OnDirectory;
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult res = fbd.ShowDialog();

                if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirLabel.Text = "Starting directory: " + fbd.SelectedPath;
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

        private void FileInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(sender, e);
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
                string initialAlert = "";
                if (path.Length == 0)
                {
                    initialAlert += "Please select a starting directory!";
                }
                if (this.FileInput.Text.Length == 0)
                {
                    initialAlert += "\nPlease enter a file name!";
                }

                if (initialAlert.Length != 0)
                {
                    System.Windows.Forms.MessageBox.Show(initialAlert,
                        "[ALERT] Incomplete Data");
                    return;
                }
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

                worker.RunWorkerAsync();
            } 
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "You cannot run a new search now because your previous search is running!",
                    "[ALERT] Another process running!");
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
            if (isDFS)
            {
                Traverser.TraverseDFS.Traverse(dirMain.FullName, fileName, allOccurences);
            }
            else 
            {
                Traverser.TraverseBFS.Traverse(dirMain.FullName, fileName, allOccurences);
            }

        }

        void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            string[]? s = e.UserState?.ToString()?.Split('|');
            graphViewer.Graph = null;
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
                    } else if (s[1] == "edge") // draw|edge|from_id|to_id
                    {
                        Edge edge = graph.AddEdge(s[2], s[3]);
                        edge.Attr.Color = isFound ? Color.Black : Color.Red;
                        idToEdges[string.Format("{0}|{1}", s[2], s[3])] = edge;
                    } else if (s[1] == "found")
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
            graphViewer.Graph = graph;
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
            Status.Text = "Elapsed time (animation included): " + sw.ElapsedMilliseconds + " ms\n";
            if (foundPaths.Count != 0)
            {
                if (foundPaths.Count > 1)
                {
                    Status.Text += "Multiple files with same name found: \n";
                }
                foreach (string path in foundPaths)
                {
                    Status.Text += "- " + path + "\n";
                }
            } 
            else
            {
                Status.Text += "\nFile " + fileName + " not found...";
            }
            foundPaths.Clear();
        }

        private void delaySpeed_ValueChanged(object sender, EventArgs e)
        {
            Traverser.DrawDelay = delaySpeed.Value;
            delayLabel.Text = delaySpeed.Value.ToString() + " ms";
            drawDelay = delaySpeed.Value;
        }

        void OnFile(FileInfo File){
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
        
        void OnFound(FileInfo File){
            worker.ReportProgress(0, string.Format(
                "draw|found|{0}",
                File.FullName
            ));
            foundPaths.Add(File.FullName);
        }

        void OnDirectory(DirectoryInfo Directory){
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