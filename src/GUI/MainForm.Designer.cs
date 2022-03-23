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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.RTF = new System.Windows.Forms.FlowLayoutPanel();
            this.Status = new MaterialSkin.Controls.MaterialLabel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.delaySpeed = new MaterialSkin.Controls.MaterialSlider();
            this.LabelDrawingDelay = new MaterialSkin.Controls.MaterialLabel();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.DFSButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.BFSButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.LabelSearchMethod = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.LabelInputFileName = new MaterialSkin.Controls.MaterialLabel();
            this.OccurenceCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.FileInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.SelectedDir = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDirectory = new MaterialSkin.Controls.MaterialLabel();
            this.DirButton = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1361, 723);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard5);
            this.tabPage1.Controls.Add(this.materialCard4);
            this.tabPage1.Controls.Add(this.materialCard3);
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1353, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.RTF);
            this.materialCard5.Controls.Add(this.Status);
            this.materialCard5.Controls.Add(this.OutputPanel);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(11, 175);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(1312, 488);
            this.materialCard5.TabIndex = 43;
            // 
            // RTF
            // 
            this.RTF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RTF.AutoScroll = true;
            this.RTF.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RTF.Location = new System.Drawing.Point(17, 400);
            this.RTF.Name = "RTF";
            this.RTF.Size = new System.Drawing.Size(622, 71);
            this.RTF.TabIndex = 37;
            this.RTF.WrapContents = false;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Depth = 0;
            this.Status.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Status.Location = new System.Drawing.Point(17, 13);
            this.Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(203, 19);
            this.Status.TabIndex = 42;
            this.Status.Text = "Waiting for search to begin...";
            // 
            // OutputPanel
            // 
            this.OutputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OutputPanel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.OutputPanel.Location = new System.Drawing.Point(20, 48);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1265, 329);
            this.OutputPanel.TabIndex = 22;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.delaySpeed);
            this.materialCard4.Controls.Add(this.LabelDrawingDelay);
            this.materialCard4.Controls.Add(this.SearchButton);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(964, 17);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(309, 148);
            this.materialCard4.TabIndex = 41;
            // 
            // delaySpeed
            // 
            this.delaySpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delaySpeed.Depth = 0;
            this.delaySpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delaySpeed.Location = new System.Drawing.Point(36, 53);
            this.delaySpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.delaySpeed.Name = "delaySpeed";
            this.delaySpeed.RangeMax = 500;
            this.delaySpeed.RangeMin = 25;
            this.delaySpeed.Size = new System.Drawing.Size(250, 40);
            this.delaySpeed.TabIndex = 25;
            this.delaySpeed.Text = "Delay";
            this.delaySpeed.Value = 25;
            this.delaySpeed.ValueSuffix = " ms";
            this.delaySpeed.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.DelaySpeed_ValueChanged);
            // 
            // LabelDrawingDelay
            // 
            this.LabelDrawingDelay.AutoSize = true;
            this.LabelDrawingDelay.Depth = 0;
            this.LabelDrawingDelay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelDrawingDelay.Location = new System.Drawing.Point(17, 14);
            this.LabelDrawingDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDrawingDelay.Name = "LabelDrawingDelay";
            this.LabelDrawingDelay.Size = new System.Drawing.Size(198, 19);
            this.LabelDrawingDelay.TabIndex = 42;
            this.LabelDrawingDelay.Text = "Input Drawing Delay (in ms)";
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(113, 102);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(78, 36);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.DFSButton);
            this.materialCard3.Controls.Add(this.BFSButton);
            this.materialCard3.Controls.Add(this.LabelSearchMethod);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(692, 17);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(260, 148);
            this.materialCard3.TabIndex = 40;
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DFSButton.Depth = 0;
            this.DFSButton.Location = new System.Drawing.Point(14, 77);
            this.DFSButton.Margin = new System.Windows.Forms.Padding(0);
            this.DFSButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DFSButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Ripple = true;
            this.DFSButton.Size = new System.Drawing.Size(157, 37);
            this.DFSButton.TabIndex = 42;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS (Depth First)";
            this.DFSButton.UseVisualStyleBackColor = true;
            this.DFSButton.Click += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.BackColor = System.Drawing.Color.Transparent;
            this.BFSButton.Checked = true;
            this.BFSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFSButton.Depth = 0;
            this.BFSButton.Location = new System.Drawing.Point(14, 45);
            this.BFSButton.Margin = new System.Windows.Forms.Padding(0);
            this.BFSButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BFSButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Ripple = true;
            this.BFSButton.Size = new System.Drawing.Size(169, 37);
            this.BFSButton.TabIndex = 42;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS (Breadth First)";
            this.BFSButton.UseVisualStyleBackColor = false;
            this.BFSButton.Click += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // LabelSearchMethod
            // 
            this.LabelSearchMethod.AutoSize = true;
            this.LabelSearchMethod.BackColor = System.Drawing.Color.Transparent;
            this.LabelSearchMethod.Depth = 0;
            this.LabelSearchMethod.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelSearchMethod.Location = new System.Drawing.Point(17, 14);
            this.LabelSearchMethod.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelSearchMethod.Name = "LabelSearchMethod";
            this.LabelSearchMethod.Size = new System.Drawing.Size(148, 19);
            this.LabelSearchMethod.TabIndex = 42;
            this.LabelSearchMethod.Text = "Input Search Method";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.LabelInputFileName);
            this.materialCard2.Controls.Add(this.OccurenceCheckBox);
            this.materialCard2.Controls.Add(this.FileInput);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(352, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(327, 148);
            this.materialCard2.TabIndex = 39;
            // 
            // LabelInputFileName
            // 
            this.LabelInputFileName.AutoSize = true;
            this.LabelInputFileName.Depth = 0;
            this.LabelInputFileName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelInputFileName.Location = new System.Drawing.Point(17, 14);
            this.LabelInputFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelInputFileName.Name = "LabelInputFileName";
            this.LabelInputFileName.Size = new System.Drawing.Size(112, 19);
            this.LabelInputFileName.TabIndex = 45;
            this.LabelInputFileName.Text = "Input File Name";
            // 
            // OccurenceCheckBox
            // 
            this.OccurenceCheckBox.AutoSize = true;
            this.OccurenceCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OccurenceCheckBox.Depth = 0;
            this.OccurenceCheckBox.Location = new System.Drawing.Point(18, 103);
            this.OccurenceCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.OccurenceCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OccurenceCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.OccurenceCheckBox.Name = "OccurenceCheckBox";
            this.OccurenceCheckBox.ReadOnly = false;
            this.OccurenceCheckBox.Ripple = true;
            this.OccurenceCheckBox.Size = new System.Drawing.Size(171, 37);
            this.OccurenceCheckBox.TabIndex = 44;
            this.OccurenceCheckBox.Text = "Find all occurences";
            this.OccurenceCheckBox.UseVisualStyleBackColor = true;
            this.OccurenceCheckBox.Click += new System.EventHandler(this.OccurenceCheckBox_CheckedChanged);
            // 
            // FileInput
            // 
            this.FileInput.AnimateReadOnly = false;
            this.FileInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FileInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FileInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileInput.Depth = 0;
            this.FileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileInput.HelperText = "Type file name...";
            this.FileInput.HideSelection = true;
            this.FileInput.Hint = "Type file name...";
            this.FileInput.LeadingIcon = null;
            this.FileInput.Location = new System.Drawing.Point(18, 45);
            this.FileInput.MaxLength = 32767;
            this.FileInput.MouseState = MaterialSkin.MouseState.OUT;
            this.FileInput.Name = "FileInput";
            this.FileInput.PasswordChar = '\0';
            this.FileInput.PrefixSuffixText = null;
            this.FileInput.ReadOnly = false;
            this.FileInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileInput.SelectedText = "";
            this.FileInput.SelectionLength = 0;
            this.FileInput.SelectionStart = 0;
            this.FileInput.ShortcutsEnabled = true;
            this.FileInput.Size = new System.Drawing.Size(292, 48);
            this.FileInput.TabIndex = 43;
            this.FileInput.TabStop = false;
            this.FileInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FileInput.TrailingIcon = null;
            this.FileInput.UseSystemPasswordChar = false;
            this.FileInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileInput_KeyDown);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.SelectedDir);
            this.materialCard1.Controls.Add(this.LabelDirectory);
            this.materialCard1.Controls.Add(this.DirButton);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(327, 148);
            this.materialCard1.TabIndex = 38;
            // 
            // SelectedDir
            // 
            this.SelectedDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedDir.AutoSize = true;
            this.SelectedDir.Depth = 0;
            this.SelectedDir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SelectedDir.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.SelectedDir.Location = new System.Drawing.Point(17, 90);
            this.SelectedDir.MaximumSize = new System.Drawing.Size(300, 0);
            this.SelectedDir.MinimumSize = new System.Drawing.Size(300, 100);
            this.SelectedDir.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectedDir.Name = "SelectedDir";
            this.SelectedDir.Size = new System.Drawing.Size(300, 100);
            this.SelectedDir.TabIndex = 37;
            this.SelectedDir.Text = "Waiting for root folder...";
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.BackColor = System.Drawing.Color.Transparent;
            this.LabelDirectory.Depth = 0;
            this.LabelDirectory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelDirectory.Location = new System.Drawing.Point(17, 14);
            this.LabelDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(181, 19);
            this.LabelDirectory.TabIndex = 35;
            this.LabelDirectory.Text = "Choose Starting Directory";
            // 
            // DirButton
            // 
            this.DirButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DirButton.Depth = 0;
            this.DirButton.HighEmphasis = true;
            this.DirButton.Icon = null;
            this.DirButton.Location = new System.Drawing.Point(17, 46);
            this.DirButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DirButton.Name = "DirButton";
            this.DirButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DirButton.Size = new System.Drawing.Size(137, 36);
            this.DirButton.TabIndex = 34;
            this.DirButton.Text = "CHOOSE FOLDER";
            this.DirButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DirButton.UseAccentColor = false;
            this.DirButton.UseVisualStyleBackColor = true;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialCard6);
            this.tabPage2.ImageKey = "information.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1353, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(21, 24);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(48, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Author";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel4);
            this.materialCard6.Controls.Add(this.materialLabel1);
            this.materialCard6.Controls.Add(this.materialLabel3);
            this.materialCard6.Controls.Add(this.materialLabel2);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(21, 57);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(402, 201);
            this.materialCard6.TabIndex = 0;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(27, 141);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(240, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "13520139 - Fachry Dennis Heraldi";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(27, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Project made with love by:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(27, 111);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(244, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "13520124 - Owen Christian Wijaya";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(162, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "13520103 - Amar Fadil";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialCard7);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.ImageKey = "settings.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1353, 680);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialSwitch1);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(19, 56);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(339, 68);
            this.materialCard7.TabIndex = 38;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(14, 17);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(155, 37);
            this.materialSwitch1.TabIndex = 39;
            this.materialSwitch1.Text = "Dark Mode 🌙";
            this.materialSwitch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.ThemeSwitch_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(19, 23);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Theme";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "information.png");
            this.imageList1.Images.SetKeyName(2, "settings.png");
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1367, 790);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 718);
            this.Name = "MainForm";
            this.Text = "FilEdge";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel RTF;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialButton DirButton;
        private Panel OutputPanel;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel LabelDrawingDelay;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel LabelDirectory;
        private MaterialSkin.Controls.MaterialRadioButton DFSButton;
        private MaterialSkin.Controls.MaterialRadioButton BFSButton;
        private MaterialSkin.Controls.MaterialLabel LabelSearchMethod;
        private MaterialSkin.Controls.MaterialSlider delaySpeed;
        private MaterialSkin.Controls.MaterialCheckbox OccurenceCheckBox;
        private MaterialSkin.Controls.MaterialTextBox2 FileInput;
        private MaterialSkin.Controls.MaterialLabel LabelInputFileName;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel Status;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel SelectedDir;
    }
}