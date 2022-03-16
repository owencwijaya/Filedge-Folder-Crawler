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
        
        // Inisialisasi graphViewer, Drawer
        GViewer graphViewer = new();
        DirectoryDrawer Drawer = new();
    
        public MainForm()
        {
            InitializeComponent();
            OutputPanel.SuspendLayout();
            OutputPanel.Controls.Add(graphViewer);
            OutputPanel.ResumeLayout();
            graphViewer.Size = new Size(1240, 600);
            graphViewer.AutoSize = true;
            graphViewer.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            Drawer.UpdateGraph = UpdateGraph;
            Drawer.UpdateStatus1 = UpdateStatus1;
            Drawer.UpdateStatus2 = UpdateStatus2;
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult res = fbd.ShowDialog();

                if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirLabel.Text = "Starting directory:\n" + fbd.SelectedPath;
                    Drawer.path = fbd.SelectedPath;
                }
                else
                {
                    MessageBox.Show(
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
            Drawer.isBFS = true;
            if (Drawer.isDFS)
            {
                Drawer.isDFS = false;
            }
        }

        private void OccurenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Drawer.allOccurences = !Drawer.allOccurences;
        }

        private void DFSButton_CheckedChanged(object sender, EventArgs e)
        {
            Drawer.isDFS = true;
            if (Drawer.isBFS)
            {
                Drawer.isBFS = false;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!Drawer.running)
            {
                string initialAlert = "";
                if (Drawer.path.Length == 0)
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
                string alert = "Folder path: " + Drawer.path + "\nMode: ";
                if (Drawer.isBFS)
                {
                    alert += "Breadth First Search\n";
                }
                if (Drawer.isDFS)
                {
                    alert += "Depth First Search\n";
                }
                if (Drawer.allOccurences)
                {
                    alert += "Check all occurences: ENABLED";
                }
                Drawer.fileName = this.FileInput.Text;

                MessageBox.Show(
                  alert
                );
                
                Status.Text = "Searching for file '" + Drawer.fileName + "'...";

                // Start Drawing Travesal Graph
                Drawer.worker.RunWorkerAsync();
            } 
            else
            {
                MessageBox.Show(
                    "You cannot run a new search now because your previous search is running!",
                    "[ALERT] Another process running!");
            }           
        }

        private void delaySpeed_ValueChanged(object sender, EventArgs e)
        {
            Drawer.Traverser.DrawDelay = delaySpeed.Value;
            delayLabel.Text = delaySpeed.Value.ToString() + " ms";
            Drawer.drawDelay = delaySpeed.Value;
        }

        private void FileInput_TextChanged(object sender, EventArgs e)
        {

        }


        // Method Updater
        void UpdateGraph(Graph graph)
        {
            graphViewer.Graph = graph;
        }

        void UpdateStatus1(String text)
        {
            Status.Text =  text;
        }

        void UpdateStatus2(String text)
        {
            Status.Text += text;
        }
    }
}