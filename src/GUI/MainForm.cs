using System.Diagnostics;
using MaterialSkin.Controls;
using MaterialSkin;

namespace DirectoryTraversal.GUI
{

    public partial class MainForm : MaterialForm
    {

        // Inisialisasi Drawer
        readonly DirectoryDrawer Drawer = new();
        public new MaterialSkinManager SkinManager;
        public MainForm()
        {
            InitializeComponent();
            OutputPanel.SuspendLayout();
            Drawer.GraphViewer.Size = new Size(OutputPanel.Width, OutputPanel.Height);
            Drawer.GraphViewer.ForeColor = SystemColors.ButtonShadow;
            OutputPanel.Controls.Add(Drawer.GraphViewer);
            OutputPanel.ResumeLayout();

            Drawer.UpdateStatus = UpdateStatus;
            Drawer.UpdateLink = UpdateLink;

            SkinManager = MaterialSkinManager.Instance;
            SkinManager.EnforceBackcolorOnAllComponents = true;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();

            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Drawer.Path = fbd.SelectedPath;
                SelectedDir.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show(
                  "Invalid path! Please try again...",
                  "[WARNING] Invalid Path!"
                );
            }
        }

        private void FileInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchButton_Click(sender, e);
        }
        private void BFSButton_CheckedChanged(object sender, EventArgs e)
        {
            Drawer.Algorithm = Lib.Algorithm.BFS;
        }

        private void OccurenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Drawer.AllOccurences = !Drawer.AllOccurences;
        }

        private void DFSButton_CheckedChanged(object sender, EventArgs e)
        {
            Drawer.Algorithm = Lib.Algorithm.DFS;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!Drawer.IsRunning)
            {
                string initialAlert = "";
                if (Drawer.Path.Length == 0)
                {
                    initialAlert += "Please select a starting directory!";
                }
                if (FileInput.Text.Length == 0)
                {
                    initialAlert += "\nPlease enter a file name!";
                }
                if (initialAlert.Length != 0)
                {
                    MessageBox.Show(initialAlert,
                        "[ALERT] Incomplete Data");
                    return;
                }
                Drawer.FileName = FileInput.Text;
                foreach(Control c in RTF.Controls)
                {
                    RTF.Controls.Remove(c);
                }
                Status.Text = "Searching for file '" + Drawer.FileName + "'...";

                // Start Drawing Travesal Graph
                Drawer.DrawTraverse();
            }
            else
            {
                MessageBox.Show(
                    "You cannot run a new search now because your previous search is running!",
                    "[ALERT] Another process running!");
            }
        }

        void UpdateStatus(string text)
        {
            Status.Text = text;
        }

        void UpdateLink(string text)
        {
            LinkLabel link = new();
            link.Text = text;
            LinkLabel.Link data = new();
            data.LinkData = text;
            link.Links.Add(data);
            link.MaximumSize = new Size(RTF.Width, 200);
            link.LinkColor = ColorTranslator.FromHtml("#2185a6");
            link.AutoSize = true;
            link.LinkClicked += new LinkLabelLinkClickedEventHandler(
                (sender, e) => Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe",
                @text.Remove(text.LastIndexOf('\\'))));
            RTF.Controls.Add(link);
        }

        private void ThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (SkinManager.Theme == MaterialSkinManager.Themes.DARK)
                SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else if (SkinManager.Theme == MaterialSkinManager.Themes.LIGHT)
                SkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void DelaySpeed_ValueChanged(object sender, int newValue)
        {
            DirectoryDrawer.DrawDelay = newValue;
        }
    }
}