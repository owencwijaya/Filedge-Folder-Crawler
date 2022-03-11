using System;

namespace DirectoryTraversal.GUI
{
    public partial class MainForm : Form
    {

        public string path;
        public Boolean isBFS = false;
        public Boolean isDFS = false;
        public Boolean allOccurences = false;
        public String fileName = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult res = fbd.ShowDialog();

                if(res == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    System.Windows.Forms.MessageBox.Show(
                        "Chosen path: " + fbd.SelectedPath +
                        "\nFiles found: " + files.Length.ToString(),
                        "[SUCCESS] Path Identified!"
                        );
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
        }

    }
}