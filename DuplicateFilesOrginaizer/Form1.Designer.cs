namespace DuplicateFilesOrginaizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._logFileWithErrorLabel = new System.Windows.Forms.Label();
            this._logFileDuplicateFilesLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._resetButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._fileExtensionComboBox = new System.Windows.Forms.ComboBox();
            this._updateExtantionButton = new System.Windows.Forms.Button();
            this._fileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._splitByGroupsCheckBox = new System.Windows.Forms.CheckBox();
            this._renameDuplicateFileCheckBox = new System.Windows.Forms.CheckBox();
            this._makeMonthFolderNameCheckBox = new System.Windows.Forms.CheckBox();
            this._makeMonthFolderCheckBox = new System.Windows.Forms.CheckBox();
            this._makeYearFolderCheckBox = new System.Windows.Forms.CheckBox();
            this._useFileDateCheckBox = new System.Windows.Forms.CheckBox();
            this._excludeFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._generalCheckBox = new System.Windows.Forms.CheckBox();
            this._imagesCheckBox = new System.Windows.Forms.CheckBox();
            this._musicCheckBox = new System.Windows.Forms.CheckBox();
            this._videosCheckBox = new System.Windows.Forms.CheckBox();
            this._documentsCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this._mainTabDeleteDuplicateFiles = new System.Windows.Forms.CheckBox();
            this._mainTabDeleteEmptyFolders = new System.Windows.Forms.CheckBox();
            this._mainTabStatusLabel = new System.Windows.Forms.Label();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._mainTabIncludeSubFolderCheckBox = new System.Windows.Forms.CheckBox();
            this._destinationButton = new System.Windows.Forms.Button();
            this._sourceButton = new System.Windows.Forms.Button();
            this._mainTabStatusTextBox = new System.Windows.Forms.TextBox();
            this._destinationTextBox = new System.Windows.Forms.TextBox();
            this._sourceTextBox = new System.Windows.Forms.TextBox();
            this._mainTabInfoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._moveRadioButton = new System.Windows.Forms.RadioButton();
            this._copyRadioButton = new System.Windows.Forms.RadioButton();
            this._testRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._mainTabTotalTabTextBox = new System.Windows.Forms.TextBox();
            this._fileHandeledTextBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this._fileWithErrorTextBox = new System.Windows.Forms.TextBox();
            this._startButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.WorkerReportsProgress = true;
            this._backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(814, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Register";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(814, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extended Loges";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 477);
            this.panel1.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._logFileWithErrorLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._logFileDuplicateFilesLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox3, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(808, 477);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // _logFileWithErrorLabel
            // 
            this._logFileWithErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._logFileWithErrorLabel.AutoSize = true;
            this._logFileWithErrorLabel.Location = new System.Drawing.Point(3, 6);
            this._logFileWithErrorLabel.Name = "_logFileWithErrorLabel";
            this._logFileWithErrorLabel.Size = new System.Drawing.Size(802, 13);
            this._logFileWithErrorLabel.TabIndex = 0;
            this._logFileWithErrorLabel.Text = "File with errors";
            // 
            // _logFileDuplicateFilesLabel
            // 
            this._logFileDuplicateFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._logFileDuplicateFilesLabel.AutoSize = true;
            this._logFileDuplicateFilesLabel.Location = new System.Drawing.Point(3, 244);
            this._logFileDuplicateFilesLabel.Name = "_logFileDuplicateFilesLabel";
            this._logFileDuplicateFilesLabel.Size = new System.Drawing.Size(802, 13);
            this._logFileDuplicateFilesLabel.TabIndex = 1;
            this._logFileDuplicateFilesLabel.Text = "Duplicate files";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 28);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox2.Size = new System.Drawing.Size(802, 207);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox3.Location = new System.Drawing.Point(3, 266);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox3.Size = new System.Drawing.Size(802, 208);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._resetButton);
            this.tabPage2.Controls.Add(this._saveButton);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _resetButton
            // 
            this._resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._resetButton.Location = new System.Drawing.Point(581, 77);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(136, 23);
            this._resetButton.TabIndex = 10;
            this._resetButton.Text = "Reset settings";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this._resetButton_Click);
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.Location = new System.Drawing.Point(581, 38);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(136, 23);
            this._saveButton.TabIndex = 10;
            this._saveButton.Text = "Save settings";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._fileExtensionComboBox);
            this.groupBox3.Controls.Add(this._updateExtantionButton);
            this.groupBox3.Controls.Add(this._fileExtensionTextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 241);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select file types";
            // 
            // _fileExtensionComboBox
            // 
            this._fileExtensionComboBox.FormattingEnabled = true;
            this._fileExtensionComboBox.Items.AddRange(new object[] {
            "Images",
            "Movies",
            "Documents",
            "Music",
            "General"});
            this._fileExtensionComboBox.Location = new System.Drawing.Point(7, 38);
            this._fileExtensionComboBox.Name = "_fileExtensionComboBox";
            this._fileExtensionComboBox.Size = new System.Drawing.Size(197, 21);
            this._fileExtensionComboBox.TabIndex = 2;
            this._fileExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this._fileExtensionComboBoxSelectedIndexChanged);
            // 
            // _updateExtantionButton
            // 
            this._updateExtantionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._updateExtantionButton.Location = new System.Drawing.Point(215, 36);
            this._updateExtantionButton.Name = "_updateExtantionButton";
            this._updateExtantionButton.Size = new System.Drawing.Size(61, 23);
            this._updateExtantionButton.TabIndex = 10;
            this._updateExtantionButton.Text = "Update";
            this._updateExtantionButton.UseVisualStyleBackColor = true;
            this._updateExtantionButton.Click += new System.EventHandler(this._updateExtensionButton_Click);
            // 
            // _fileExtensionTextBox
            // 
            this._fileExtensionTextBox.Location = new System.Drawing.Point(7, 65);
            this._fileExtensionTextBox.Multiline = true;
            this._fileExtensionTextBox.Name = "_fileExtensionTextBox";
            this._fileExtensionTextBox.Size = new System.Drawing.Size(469, 152);
            this._fileExtensionTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._splitByGroupsCheckBox);
            this.groupBox1.Controls.Add(this._renameDuplicateFileCheckBox);
            this.groupBox1.Controls.Add(this._makeMonthFolderNameCheckBox);
            this.groupBox1.Controls.Add(this._makeMonthFolderCheckBox);
            this.groupBox1.Controls.Add(this._makeYearFolderCheckBox);
            this.groupBox1.Controls.Add(this._useFileDateCheckBox);
            this.groupBox1.Controls.Add(this._excludeFolderCheckBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global settings";
            // 
            // _splitByGroupsCheckBox
            // 
            this._splitByGroupsCheckBox.AutoSize = true;
            this._splitByGroupsCheckBox.Location = new System.Drawing.Point(6, 90);
            this._splitByGroupsCheckBox.Name = "_splitByGroupsCheckBox";
            this._splitByGroupsCheckBox.Size = new System.Drawing.Size(92, 17);
            this._splitByGroupsCheckBox.TabIndex = 10;
            this._splitByGroupsCheckBox.Text = "SplitByGroups";
            this._splitByGroupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // _renameDuplicateFileCheckBox
            // 
            this._renameDuplicateFileCheckBox.AutoSize = true;
            this._renameDuplicateFileCheckBox.Location = new System.Drawing.Point(6, 67);
            this._renameDuplicateFileCheckBox.Name = "_renameDuplicateFileCheckBox";
            this._renameDuplicateFileCheckBox.Size = new System.Drawing.Size(270, 17);
            this._renameDuplicateFileCheckBox.TabIndex = 9;
            this._renameDuplicateFileCheckBox.Text = "Rename duplicate files and move to duplicate folder";
            this._renameDuplicateFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // _makeMonthFolderNameCheckBox
            // 
            this._makeMonthFolderNameCheckBox.AutoSize = true;
            this._makeMonthFolderNameCheckBox.Location = new System.Drawing.Point(28, 166);
            this._makeMonthFolderNameCheckBox.Name = "_makeMonthFolderNameCheckBox";
            this._makeMonthFolderNameCheckBox.Size = new System.Drawing.Size(221, 17);
            this._makeMonthFolderNameCheckBox.TabIndex = 6;
            this._makeMonthFolderNameCheckBox.Text = "Include the month name on month folders";
            this._makeMonthFolderNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // _makeMonthFolderCheckBox
            // 
            this._makeMonthFolderCheckBox.AutoSize = true;
            this._makeMonthFolderCheckBox.Location = new System.Drawing.Point(28, 142);
            this._makeMonthFolderCheckBox.Name = "_makeMonthFolderCheckBox";
            this._makeMonthFolderCheckBox.Size = new System.Drawing.Size(119, 17);
            this._makeMonthFolderCheckBox.TabIndex = 6;
            this._makeMonthFolderCheckBox.Text = "Make month folders";
            this._makeMonthFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // _makeYearFolderCheckBox
            // 
            this._makeYearFolderCheckBox.AutoSize = true;
            this._makeYearFolderCheckBox.Location = new System.Drawing.Point(6, 118);
            this._makeYearFolderCheckBox.Name = "_makeYearFolderCheckBox";
            this._makeYearFolderCheckBox.Size = new System.Drawing.Size(110, 17);
            this._makeYearFolderCheckBox.TabIndex = 6;
            this._makeYearFolderCheckBox.Text = "Make year folders";
            this._makeYearFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // _useFileDateCheckBox
            // 
            this._useFileDateCheckBox.AutoSize = true;
            this._useFileDateCheckBox.Location = new System.Drawing.Point(6, 43);
            this._useFileDateCheckBox.Name = "_useFileDateCheckBox";
            this._useFileDateCheckBox.Size = new System.Drawing.Size(93, 17);
            this._useFileDateCheckBox.TabIndex = 6;
            this._useFileDateCheckBox.Text = "use EXIF date";
            this._useFileDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // _excludeFolderCheckBox
            // 
            this._excludeFolderCheckBox.AutoSize = true;
            this._excludeFolderCheckBox.Location = new System.Drawing.Point(6, 19);
            this._excludeFolderCheckBox.Name = "_excludeFolderCheckBox";
            this._excludeFolderCheckBox.Size = new System.Drawing.Size(229, 17);
            this._excludeFolderCheckBox.TabIndex = 6;
            this._excludeFolderCheckBox.Text = "Exclude files from \"Program Files\" Directory";
            this._excludeFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._generalCheckBox);
            this.groupBox2.Controls.Add(this._imagesCheckBox);
            this.groupBox2.Controls.Add(this._musicCheckBox);
            this.groupBox2.Controls.Add(this._videosCheckBox);
            this.groupBox2.Controls.Add(this._documentsCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(296, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select file types";
            // 
            // _generalCheckBox
            // 
            this._generalCheckBox.AutoSize = true;
            this._generalCheckBox.Location = new System.Drawing.Point(18, 111);
            this._generalCheckBox.Name = "_generalCheckBox";
            this._generalCheckBox.Size = new System.Drawing.Size(63, 17);
            this._generalCheckBox.TabIndex = 8;
            this._generalCheckBox.Text = "General";
            this._generalCheckBox.UseVisualStyleBackColor = true;
            // 
            // _imagesCheckBox
            // 
            this._imagesCheckBox.AutoSize = true;
            this._imagesCheckBox.Checked = true;
            this._imagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._imagesCheckBox.Location = new System.Drawing.Point(18, 19);
            this._imagesCheckBox.Name = "_imagesCheckBox";
            this._imagesCheckBox.Size = new System.Drawing.Size(60, 17);
            this._imagesCheckBox.TabIndex = 6;
            this._imagesCheckBox.Text = "Images";
            this._imagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // _musicCheckBox
            // 
            this._musicCheckBox.AutoSize = true;
            this._musicCheckBox.Location = new System.Drawing.Point(18, 88);
            this._musicCheckBox.Name = "_musicCheckBox";
            this._musicCheckBox.Size = new System.Drawing.Size(54, 17);
            this._musicCheckBox.TabIndex = 7;
            this._musicCheckBox.Text = "Music";
            this._musicCheckBox.UseVisualStyleBackColor = true;
            // 
            // _videosCheckBox
            // 
            this._videosCheckBox.AutoSize = true;
            this._videosCheckBox.Location = new System.Drawing.Point(18, 42);
            this._videosCheckBox.Name = "_videosCheckBox";
            this._videosCheckBox.Size = new System.Drawing.Size(53, 17);
            this._videosCheckBox.TabIndex = 5;
            this._videosCheckBox.Text = "Video";
            this._videosCheckBox.UseVisualStyleBackColor = true;
            // 
            // _documentsCheckBox
            // 
            this._documentsCheckBox.AutoSize = true;
            this._documentsCheckBox.Location = new System.Drawing.Point(18, 65);
            this._documentsCheckBox.Name = "_documentsCheckBox";
            this._documentsCheckBox.Size = new System.Drawing.Size(80, 17);
            this._documentsCheckBox.TabIndex = 4;
            this._documentsCheckBox.Text = "Documents";
            this._documentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.83133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.16867F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._mainTabInfoTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 477);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(551, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 271);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._mainTabDeleteDuplicateFiles);
            this.panel3.Controls.Add(this._mainTabDeleteEmptyFolders);
            this.panel3.Controls.Add(this._mainTabStatusLabel);
            this.panel3.Controls.Add(this._progressBar);
            this.panel3.Controls.Add(this._mainTabIncludeSubFolderCheckBox);
            this.panel3.Controls.Add(this._destinationButton);
            this.panel3.Controls.Add(this._sourceButton);
            this.panel3.Controls.Add(this._mainTabStatusTextBox);
            this.panel3.Controls.Add(this._destinationTextBox);
            this.panel3.Controls.Add(this._sourceTextBox);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 121);
            this.panel3.TabIndex = 2;
            // 
            // _mainTabDeleteDuplicateFiles
            // 
            this._mainTabDeleteDuplicateFiles.AutoSize = true;
            this._mainTabDeleteDuplicateFiles.Checked = true;
            this._mainTabDeleteDuplicateFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this._mainTabDeleteDuplicateFiles.Location = new System.Drawing.Point(374, 68);
            this._mainTabDeleteDuplicateFiles.Name = "_mainTabDeleteDuplicateFiles";
            this._mainTabDeleteDuplicateFiles.Size = new System.Drawing.Size(124, 17);
            this._mainTabDeleteDuplicateFiles.TabIndex = 25;
            this._mainTabDeleteDuplicateFiles.Text = "Delete duplicate files";
            this._mainTabDeleteDuplicateFiles.UseVisualStyleBackColor = true;
            // 
            // _mainTabDeleteEmptyFolders
            // 
            this._mainTabDeleteEmptyFolders.AutoSize = true;
            this._mainTabDeleteEmptyFolders.Checked = true;
            this._mainTabDeleteEmptyFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this._mainTabDeleteEmptyFolders.Location = new System.Drawing.Point(374, 40);
            this._mainTabDeleteEmptyFolders.Name = "_mainTabDeleteEmptyFolders";
            this._mainTabDeleteEmptyFolders.Size = new System.Drawing.Size(123, 17);
            this._mainTabDeleteEmptyFolders.TabIndex = 24;
            this._mainTabDeleteEmptyFolders.Text = "Delete Empty folders";
            this._mainTabDeleteEmptyFolders.UseVisualStyleBackColor = true;
            // 
            // _mainTabStatusLabel
            // 
            this._mainTabStatusLabel.AutoSize = true;
            this._mainTabStatusLabel.Location = new System.Drawing.Point(302, 95);
            this._mainTabStatusLabel.Name = "_mainTabStatusLabel";
            this._mainTabStatusLabel.Size = new System.Drawing.Size(37, 13);
            this._mainTabStatusLabel.TabIndex = 23;
            this._mainTabStatusLabel.Text = "Status";
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(13, 90);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(270, 23);
            this._progressBar.Step = 1;
            this._progressBar.TabIndex = 22;
            // 
            // _mainTabIncludeSubFolderCheckBox
            // 
            this._mainTabIncludeSubFolderCheckBox.AutoSize = true;
            this._mainTabIncludeSubFolderCheckBox.Checked = true;
            this._mainTabIncludeSubFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._mainTabIncludeSubFolderCheckBox.Location = new System.Drawing.Point(374, 16);
            this._mainTabIncludeSubFolderCheckBox.Name = "_mainTabIncludeSubFolderCheckBox";
            this._mainTabIncludeSubFolderCheckBox.Size = new System.Drawing.Size(111, 17);
            this._mainTabIncludeSubFolderCheckBox.TabIndex = 21;
            this._mainTabIncludeSubFolderCheckBox.Text = "include subfolders";
            this._mainTabIncludeSubFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // _destinationButton
            // 
            this._destinationButton.Location = new System.Drawing.Point(252, 51);
            this._destinationButton.Name = "_destinationButton";
            this._destinationButton.Size = new System.Drawing.Size(116, 23);
            this._destinationButton.TabIndex = 17;
            this._destinationButton.Text = "Select destination folder";
            this._destinationButton.UseVisualStyleBackColor = true;
            this._destinationButton.Click += new System.EventHandler(this._destinationButton_Click);
            // 
            // _sourceButton
            // 
            this._sourceButton.Location = new System.Drawing.Point(254, 13);
            this._sourceButton.Name = "_sourceButton";
            this._sourceButton.Size = new System.Drawing.Size(114, 23);
            this._sourceButton.TabIndex = 18;
            this._sourceButton.Text = "Select Source folder";
            this._sourceButton.UseVisualStyleBackColor = true;
            this._sourceButton.Click += new System.EventHandler(this._sourceButton_Click);
            // 
            // _mainTabStatusTextBox
            // 
            this._mainTabStatusTextBox.Location = new System.Drawing.Point(360, 91);
            this._mainTabStatusTextBox.Name = "_mainTabStatusTextBox";
            this._mainTabStatusTextBox.Size = new System.Drawing.Size(125, 20);
            this._mainTabStatusTextBox.TabIndex = 19;
            // 
            // _destinationTextBox
            // 
            this._destinationTextBox.Location = new System.Drawing.Point(13, 52);
            this._destinationTextBox.Name = "_destinationTextBox";
            this._destinationTextBox.Size = new System.Drawing.Size(233, 20);
            this._destinationTextBox.TabIndex = 19;
            this._destinationTextBox.Click += new System.EventHandler(this._destinationButton_Click);
            // 
            // _sourceTextBox
            // 
            this._sourceTextBox.Location = new System.Drawing.Point(13, 14);
            this._sourceTextBox.Name = "_sourceTextBox";
            this._sourceTextBox.Size = new System.Drawing.Size(235, 20);
            this._sourceTextBox.TabIndex = 20;
            this._sourceTextBox.Click += new System.EventHandler(this._sourceButton_Click);
            // 
            // _mainTabInfoTextBox
            // 
            this._mainTabInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTabInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._mainTabInfoTextBox.Location = new System.Drawing.Point(3, 203);
            this._mainTabInfoTextBox.Multiline = true;
            this._mainTabInfoTextBox.Name = "_mainTabInfoTextBox";
            this._mainTabInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._mainTabInfoTextBox.Size = new System.Drawing.Size(542, 271);
            this._mainTabInfoTextBox.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this._mainTabTotalTabTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this._fileHandeledTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._fileWithErrorTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this._startButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(551, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 194);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._moveRadioButton);
            this.panel4.Controls.Add(this._copyRadioButton);
            this.panel4.Controls.Add(this._testRadioButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 88);
            this.panel4.TabIndex = 24;
            // 
            // _moveRadioButton
            // 
            this._moveRadioButton.AutoSize = true;
            this._moveRadioButton.Location = new System.Drawing.Point(4, 53);
            this._moveRadioButton.Name = "_moveRadioButton";
            this._moveRadioButton.Size = new System.Drawing.Size(52, 17);
            this._moveRadioButton.TabIndex = 2;
            this._moveRadioButton.TabStop = true;
            this._moveRadioButton.Text = "Move";
            this._moveRadioButton.UseVisualStyleBackColor = true;
            // 
            // _copyRadioButton
            // 
            this._copyRadioButton.AutoSize = true;
            this._copyRadioButton.Location = new System.Drawing.Point(4, 32);
            this._copyRadioButton.Name = "_copyRadioButton";
            this._copyRadioButton.Size = new System.Drawing.Size(49, 17);
            this._copyRadioButton.TabIndex = 1;
            this._copyRadioButton.TabStop = true;
            this._copyRadioButton.Text = "Copy";
            this._copyRadioButton.UseVisualStyleBackColor = true;
            // 
            // _testRadioButton
            // 
            this._testRadioButton.AutoSize = true;
            this._testRadioButton.Checked = true;
            this._testRadioButton.Location = new System.Drawing.Point(4, 12);
            this._testRadioButton.Name = "_testRadioButton";
            this._testRadioButton.Size = new System.Drawing.Size(46, 17);
            this._testRadioButton.TabIndex = 0;
            this._testRadioButton.TabStop = true;
            this._testRadioButton.Text = "Test";
            this._testRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total files:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "files handeled:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "File Excluded:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Files with errors";
            // 
            // _mainTabTotalTabTextBox
            // 
            this._mainTabTotalTabTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._mainTabTotalTabTextBox.Location = new System.Drawing.Point(130, 97);
            this._mainTabTotalTabTextBox.Name = "_mainTabTotalTabTextBox";
            this._mainTabTotalTabTextBox.Size = new System.Drawing.Size(121, 20);
            this._mainTabTotalTabTextBox.TabIndex = 26;
            // 
            // _fileHandeledTextBox
            // 
            this._fileHandeledTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._fileHandeledTextBox.Location = new System.Drawing.Point(130, 122);
            this._fileHandeledTextBox.Name = "_fileHandeledTextBox";
            this._fileHandeledTextBox.Size = new System.Drawing.Size(121, 20);
            this._fileHandeledTextBox.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(130, 147);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 26;
            // 
            // _fileWithErrorTextBox
            // 
            this._fileWithErrorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._fileWithErrorTextBox.Location = new System.Drawing.Point(130, 172);
            this._fileWithErrorTextBox.Name = "_fileWithErrorTextBox";
            this._fileWithErrorTextBox.Size = new System.Drawing.Size(121, 20);
            this._fileWithErrorTextBox.TabIndex = 26;
            // 
            // _startButton
            // 
            this._startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startButton.Location = new System.Drawing.Point(130, 3);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(121, 88);
            this._startButton.TabIndex = 27;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this._startButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 509);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 509);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 754);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Miki Dabush-File Orginaizer(c)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox _fileExtensionComboBox;
        private System.Windows.Forms.TextBox _fileExtensionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _makeMonthFolderNameCheckBox;
        private System.Windows.Forms.CheckBox _makeMonthFolderCheckBox;
        private System.Windows.Forms.CheckBox _makeYearFolderCheckBox;
        private System.Windows.Forms.CheckBox _useFileDateCheckBox;
        private System.Windows.Forms.CheckBox _excludeFolderCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox _generalCheckBox;
        private System.Windows.Forms.CheckBox _imagesCheckBox;
        private System.Windows.Forms.CheckBox _musicCheckBox;
        private System.Windows.Forms.CheckBox _videosCheckBox;
        private System.Windows.Forms.CheckBox _documentsCheckBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label _mainTabStatusLabel;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.CheckBox _mainTabIncludeSubFolderCheckBox;
        private System.Windows.Forms.Button _destinationButton;
        private System.Windows.Forms.Button _sourceButton;
        private System.Windows.Forms.TextBox _mainTabStatusTextBox;
        private System.Windows.Forms.TextBox _destinationTextBox;
        private System.Windows.Forms.TextBox _sourceTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label _logFileWithErrorLabel;
        private System.Windows.Forms.Label _logFileDuplicateFilesLabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.CheckBox _renameDuplicateFileCheckBox;
        private System.Windows.Forms.CheckBox _splitByGroupsCheckBox;
        private System.Windows.Forms.Button _updateExtantionButton;
        private System.Windows.Forms.TextBox _mainTabInfoTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton _moveRadioButton;
        private System.Windows.Forms.RadioButton _copyRadioButton;
        private System.Windows.Forms.RadioButton _testRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _mainTabTotalTabTextBox;
        private System.Windows.Forms.TextBox _fileHandeledTextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox _fileWithErrorTextBox;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.CheckBox _mainTabDeleteDuplicateFiles;
        private System.Windows.Forms.CheckBox _mainTabDeleteEmptyFolders;
        private System.Windows.Forms.Button button1;
    }
}

