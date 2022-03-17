using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Text;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Color = Microsoft.Msagl.Drawing.Color;
using DirectoryTraversal.Lib.Algorithms;
using MaterialSkin.Controls;

namespace DirectoryTraversal.GUI
{
    using DirectoryTraversal.Lib;
    public partial class MainForm : MaterialForm
    {
        
        // Inisialisasi graphViewer, Drawer
        GViewer graphViewer = new();
        DirectoryDrawer Drawer = new();
        public MaterialSkin.MaterialSkinManager SkinManager;
        public MainForm()
        {
            InitializeComponent();
            OutputPanel.SuspendLayout();
            OutputPanel.Controls.Add(graphViewer);
            OutputPanel.ResumeLayout();
            graphViewer.Size = new Size(1300, 400);
            graphViewer.BackColor = SystemColors.ButtonShadow;
            graphViewer.AutoSize = true;
            graphViewer.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            Drawer.UpdateGraph = UpdateGraph;
            Drawer.UpdateStatus1 = UpdateStatus1;
            Drawer.UpdateStatus2 = UpdateStatus2;

            SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.EnforceBackcolorOnAllComponents = true;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.BlueGrey800,
                MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE);

            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("LexendDeca-Regular.ttf");
            //DirLabel.Font = new Font(pfc.Families[0], 16);
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

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void DirectoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void DarkMode_Click(object sender, EventArgs e)
        {
            if (SkinManager.Theme == MaterialSkin.MaterialSkinManager.Themes.DARK)
            {
                SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                DarkMode.Text = "🌙";
            } else if (SkinManager.Theme == MaterialSkin.MaterialSkinManager.Themes.LIGHT)
            {
                SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
                DarkMode.Text = "🌞";
            }
        }
    }
}