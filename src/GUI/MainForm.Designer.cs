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
            ((System.ComponentModel.ISupportInitialize)(this.delaySpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(21, 15);
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
            this.OutputPanel.Location = new System.Drawing.Point(35, 260);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1191, 451);
            this.OutputPanel.TabIndex = 1;
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectoryLabel.Location = new System.Drawing.Point(34, 109);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(215, 25);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Choose Starting Directory";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileLabel.Location = new System.Drawing.Point(310, 109);
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
            this.DirButton.Location = new System.Drawing.Point(34, 141);
            this.DirButton.Name = "DirButton";
            this.DirButton.Size = new System.Drawing.Size(154, 38);
            this.DirButton.TabIndex = 5;
            this.DirButton.Text = "Choose Folder...";
            this.DirButton.UseVisualStyleBackColor = false;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // FileInput
            // 
            this.FileInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileInput.Location = new System.Drawing.Point(310, 141);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(271, 34);
            this.FileInput.TabIndex = 6;
            this.FileInput.TextChanged += new System.EventHandler(this.FileInput_TextChanged);
            this.FileInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileInput_KeyDown);
            // 
            // OccurenceCheckBox
            // 
            this.OccurenceCheckBox.AutoSize = true;
            this.OccurenceCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OccurenceCheckBox.Location = new System.Drawing.Point(425, 181);
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
            this.MethodLabel.Location = new System.Drawing.Point(666, 109);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(179, 25);
            this.MethodLabel.TabIndex = 8;
            this.MethodLabel.Text = "Input Search Method";
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.Checked = true;
            this.BFSButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFSButton.Location = new System.Drawing.Point(666, 133);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(134, 21);
            this.BFSButton.TabIndex = 9;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS (Breadth First)";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DFSButton.Location = new System.Drawing.Point(832, 133);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(126, 21);
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
            this.SearchButton.Location = new System.Drawing.Point(1045, 123);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(154, 38);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search...";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // delaySpeed
            // 
            this.delaySpeed.LargeChange = 50;
            this.delaySpeed.Location = new System.Drawing.Point(724, 162);
            this.delaySpeed.Maximum = 500;
            this.delaySpeed.Minimum = 25;
            this.delaySpeed.Name = "delaySpeed";
            this.delaySpeed.Size = new System.Drawing.Size(187, 56);
            this.delaySpeed.SmallChange = 25;
            this.delaySpeed.TabIndex = 4;
            this.delaySpeed.TickFrequency = 25;
            this.delaySpeed.Value = 25;
            this.delaySpeed.ValueChanged += new System.EventHandler(this.delaySpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(666, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delay";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(917, 162);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(43, 17);
            this.delayLabel.TabIndex = 14;
            this.delayLabel.Text = "25 ms";
            // 
            // DirLabel
            // 
            this.DirLabel.Location = new System.Drawing.Point(34, 192);
            this.DirLabel.Name = "DirLabel";
            this.DirLabel.Size = new System.Drawing.Size(346, 38);
            this.DirLabel.TabIndex = 15;
            this.DirLabel.Text = "Chosen directory: ";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(310, 15);
            this.Status.MaximumSize = new System.Drawing.Size(875, 425);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(176, 17);
            this.Status.TabIndex = 16;
            this.Status.Text = "Waiting for search to begin...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1262, 753);
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
            this.Controls.Add(this.FileInput);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "MainForm";
            this.Text = "Folder Crawler";
            ((System.ComponentModel.ISupportInitialize)(this.delaySpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Panel OutputPanel;
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
    }
}