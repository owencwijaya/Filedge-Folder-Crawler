namespace DirectoryTraversal.GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.DirButton = new System.Windows.Forms.Button();
            this.FileInput = new System.Windows.Forms.TextBox();
            this.OccurenceCheckBox = new System.Windows.Forms.CheckBox();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.delaySpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.DirLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delaySpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(471, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Folder Crawler";
            // 
            // OutputPanel
            // 
            this.OutputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OutputPanel.Location = new System.Drawing.Point(462, 143);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(623, 576);
            this.OutputPanel.TabIndex = 1;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputLabel.Location = new System.Drawing.Point(39, 91);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(88, 41);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Input";
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectoryLabel.Location = new System.Drawing.Point(39, 143);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(215, 25);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Choose Starting Directory";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileLabel.Location = new System.Drawing.Point(39, 279);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(142, 25);
            this.FileLabel.TabIndex = 4;
            this.FileLabel.Text = "Input File Name ";
            // 
            // DirButton
            // 
            this.DirButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DirButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DirButton.Location = new System.Drawing.Point(39, 171);
            this.DirButton.Name = "DirButton";
            this.DirButton.Size = new System.Drawing.Size(176, 45);
            this.DirButton.TabIndex = 5;
            this.DirButton.Text = "Choose Folder...";
            this.DirButton.UseVisualStyleBackColor = false;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // FileInput
            // 
            this.FileInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileInput.Location = new System.Drawing.Point(39, 331);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(309, 34);
            this.FileInput.TabIndex = 6;
            this.FileInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileInput_KeyDown);
            // 
            // OccurenceCheckBox
            // 
            this.OccurenceCheckBox.AutoSize = true;
            this.OccurenceCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OccurenceCheckBox.Location = new System.Drawing.Point(39, 371);
            this.OccurenceCheckBox.Name = "OccurenceCheckBox";
            this.OccurenceCheckBox.Size = new System.Drawing.Size(156, 24);
            this.OccurenceCheckBox.TabIndex = 7;
            this.OccurenceCheckBox.Text = "Find all occurences";
            this.OccurenceCheckBox.UseVisualStyleBackColor = true;
            this.OccurenceCheckBox.CheckedChanged += new System.EventHandler(this.OccurenceCheckBox_CheckedChanged);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MethodLabel.Location = new System.Drawing.Point(39, 421);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(179, 25);
            this.MethodLabel.TabIndex = 8;
            this.MethodLabel.Text = "Input Search Method";
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.Checked = true;
            this.BFSButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFSButton.Location = new System.Drawing.Point(39, 449);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(169, 27);
            this.BFSButton.TabIndex = 9;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS (Breadth First)";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DFSButton.Location = new System.Drawing.Point(229, 449);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(158, 27);
            this.DFSButton.TabIndex = 10;
            this.DFSButton.Text = "DFS (Depth First)";
            this.DFSButton.UseVisualStyleBackColor = true;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(39, 546);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(176, 45);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search...";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // delaySpeed
            // 
            this.delaySpeed.LargeChange = 50;
            this.delaySpeed.Location = new System.Drawing.Point(106, 483);
            this.delaySpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delaySpeed.Maximum = 500;
            this.delaySpeed.Minimum = 25;
            this.delaySpeed.Name = "delaySpeed";
            this.delaySpeed.Size = new System.Drawing.Size(214, 56);
            this.delaySpeed.SmallChange = 25;
            this.delaySpeed.TabIndex = 4;
            this.delaySpeed.TickFrequency = 25;
            this.delaySpeed.Value = 25;
            this.delaySpeed.ValueChanged += new System.EventHandler(this.delaySpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delay";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(326, 483);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(48, 20);
            this.delayLabel.TabIndex = 14;
            this.delayLabel.Text = "25 ms";
            // 
            // DirLabel
            // 
            this.DirLabel.Location = new System.Drawing.Point(39, 219);
            this.DirLabel.Name = "DirLabel";
            this.DirLabel.Size = new System.Drawing.Size(395, 45);
            this.DirLabel.TabIndex = 15;
            this.DirLabel.Text = "Chosen directory: ";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(32, 594);
            this.Status.MaximumSize = new System.Drawing.Size(450, 300);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(198, 20);
            this.Status.TabIndex = 16;
            this.Status.Text = "Waiting for search to begin...";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputLabel.Location = new System.Drawing.Point(452, 91);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(113, 41);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Case-sensitive + file extension e.g. \'test.png\'";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 820);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.DirLabel);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delaySpeed);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.BFSButton);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.OccurenceCheckBox);
            this.Controls.Add(this.DirButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.FileInput);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "Folder Crawler";
            ((System.ComponentModel.ISupportInitialize)(this.delaySpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Panel OutputPanel;
        private Label InputLabel;
        private Label DirectoryLabel;
        private Label FileLabel;
        private Button DirButton;
        private TextBox FileInput;
        private CheckBox OccurenceCheckBox;
        private Label MethodLabel;
        private RadioButton BFSButton;
        private RadioButton DFSButton;
        private Button SearchButton;
        private TrackBar delaySpeed;
        private Label label1;
        private Label delayLabel;
        private Label DirLabel;
        private Label Status;
        private Label OutputLabel;
        private Label label2;
    }
}