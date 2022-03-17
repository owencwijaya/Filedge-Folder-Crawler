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
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileInput = new System.Windows.Forms.TextBox();
            this.OccurenceCheckBox = new System.Windows.Forms.CheckBox();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.delaySpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.DirLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.DirButton = new MaterialSkin.Controls.MaterialButton();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.DarkMode = new MaterialSkin.Controls.MaterialButton();
            this.RTF = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.delaySpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputPanel
            // 
            this.OutputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OutputPanel.Location = new System.Drawing.Point(35, 339);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1300, 400);
            this.OutputPanel.TabIndex = 1;
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.DirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DirectoryLabel.Location = new System.Drawing.Point(35, 84);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(233, 25);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Choose Starting Directory";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FileLabel.Location = new System.Drawing.Point(300, 84);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(152, 25);
            this.FileLabel.TabIndex = 4;
            this.FileLabel.Text = "Input File Name ";
            // 
            // FileInput
            // 
            this.FileInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileInput.Location = new System.Drawing.Point(300, 116);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(188, 34);
            this.FileInput.TabIndex = 6;
            this.FileInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileInput_KeyDown);
            // 
            // OccurenceCheckBox
            // 
            this.OccurenceCheckBox.AutoSize = true;
            this.OccurenceCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.OccurenceCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OccurenceCheckBox.Location = new System.Drawing.Point(332, 156);
            this.OccurenceCheckBox.Name = "OccurenceCheckBox";
            this.OccurenceCheckBox.Size = new System.Drawing.Size(156, 24);
            this.OccurenceCheckBox.TabIndex = 7;
            this.OccurenceCheckBox.Text = "Find all occurences";
            this.OccurenceCheckBox.UseVisualStyleBackColor = false;
            this.OccurenceCheckBox.CheckedChanged += new System.EventHandler(this.OccurenceCheckBox_CheckedChanged);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.BackColor = System.Drawing.Color.Transparent;
            this.MethodLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MethodLabel.Location = new System.Drawing.Point(586, 84);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(192, 25);
            this.MethodLabel.TabIndex = 8;
            this.MethodLabel.Text = "Input Search Method";
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.BackColor = System.Drawing.Color.Transparent;
            this.BFSButton.Checked = true;
            this.BFSButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFSButton.Location = new System.Drawing.Point(586, 116);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(151, 24);
            this.BFSButton.TabIndex = 9;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS (Breadth First)";
            this.BFSButton.UseVisualStyleBackColor = false;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.BackColor = System.Drawing.Color.Transparent;
            this.DFSButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DFSButton.Location = new System.Drawing.Point(586, 144);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(142, 24);
            this.DFSButton.TabIndex = 10;
            this.DFSButton.Text = "DFS (Depth First)";
            this.DFSButton.UseVisualStyleBackColor = false;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // delaySpeed
            // 
            this.delaySpeed.BackColor = System.Drawing.SystemColors.Menu;
            this.delaySpeed.LargeChange = 50;
            this.delaySpeed.Location = new System.Drawing.Point(1104, 146);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1046, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delay";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.delayLabel.Location = new System.Drawing.Point(1297, 146);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(43, 17);
            this.delayLabel.TabIndex = 14;
            this.delayLabel.Text = "25 ms";
            // 
            // DirLabel
            // 
            this.DirLabel.AutoSize = true;
            this.DirLabel.BackColor = System.Drawing.Color.Transparent;
            this.DirLabel.Location = new System.Drawing.Point(35, 185);
            this.DirLabel.MaximumSize = new System.Drawing.Size(450, 150);
            this.DirLabel.Name = "DirLabel";
            this.DirLabel.Size = new System.Drawing.Size(112, 17);
            this.DirLabel.TabIndex = 15;
            this.DirLabel.Text = "Starting directory:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(586, 185);
            this.Status.MaximumSize = new System.Drawing.Size(875, 450);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(176, 17);
            this.Status.TabIndex = 16;
            this.Status.Text = "Waiting for search to begin...";
            // 
            // DirButton
            // 
            this.DirButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DirButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DirButton.Depth = 0;
            this.DirButton.HighEmphasis = true;
            this.DirButton.Icon = null;
            this.DirButton.Location = new System.Drawing.Point(35, 118);
            this.DirButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DirButton.Name = "DirButton";
            this.DirButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DirButton.Size = new System.Drawing.Size(137, 36);
            this.DirButton.TabIndex = 17;
            this.DirButton.Text = "CHOOSE FOLDER";
            this.DirButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DirButton.UseAccentColor = false;
            this.DirButton.UseVisualStyleBackColor = true;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(1162, 101);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(78, 36);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DarkMode
            // 
            this.DarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DarkMode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DarkMode.Depth = 0;
            this.DarkMode.HighEmphasis = true;
            this.DarkMode.Icon = null;
            this.DarkMode.Location = new System.Drawing.Point(1295, 73);
            this.DarkMode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DarkMode.Size = new System.Drawing.Size(64, 36);
            this.DarkMode.TabIndex = 19;
            this.DarkMode.Text = "🌞";
            this.DarkMode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DarkMode.UseAccentColor = false;
            this.DarkMode.UseVisualStyleBackColor = true;
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // RTF
            // 
            this.RTF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RTF.Location = new System.Drawing.Point(585, 208);
            this.RTF.Name = "RTF";
            this.RTF.Size = new System.Drawing.Size(750, 125);
            this.RTF.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.RTF);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DirButton);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.DirLabel);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delaySpeed);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.BFSButton);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.OccurenceCheckBox);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.FileInput);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainForm";
            this.Text = "Folder Crawler";
            ((System.ComponentModel.ISupportInitialize)(this.delaySpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel OutputPanel;
        private Label DirectoryLabel;
        private Label FileLabel;
        private TextBox FileInput;
        private CheckBox OccurenceCheckBox;
        private Label MethodLabel;
        private RadioButton BFSButton;
        private RadioButton DFSButton;
        private TrackBar delaySpeed;
        private Label label1;
        private Label delayLabel;
        private Label DirLabel;
        private Label Status;
        private MaterialSkin.Controls.MaterialButton DirButton;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialButton DarkMode;
        private FlowLayoutPanel RTF;
    }
}