namespace DuplicateRemover
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GroupBox gbExecution;
            tlpExecution = new TableLayoutPanel();
            rtbLogger = new RichTextBox();
            progressBar1 = new ProgressBar();
            btnCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbScanPath = new GroupBox();
            tlpScanPath = new TableLayoutPanel();
            tlpScanPathTop = new TableLayoutPanel();
            lblScanPathLabel = new Label();
            txbScanPath = new TextBox();
            btnChooseScanPath = new Button();
            tlpScanPathStats = new TableLayoutPanel();
            btnScan = new Button();
            cbIncludeSubfolders = new CheckBox();
            tlpStatsStack = new TableLayoutPanel();
            lblTotalFiles = new Label();
            lblTotalFilesNumber = new Label();
            lblUniqueFiles = new Label();
            lblUniqueFilesNumber = new Label();
            gbUniqueFiles = new GroupBox();
            tlpUniqueFiles = new TableLayoutPanel();
            dgUniqueFiles = new DataGridView();
            hashDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            bsUniqueFiles = new BindingSource(components);
            tlpUniqueButtons = new TableLayoutPanel();
            btnShowSinlges = new Button();
            btnShowDuplicates = new Button();
            btnShowAll = new Button();
            btnShowFilePaths = new Button();
            btnAutoClean = new Button();
            gbPhysicalFiles = new GroupBox();
            tlpPhysicalFiles = new TableLayoutPanel();
            dgPhysicalFiles = new DataGridView();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Selected = new DataGridViewCheckBoxColumn();
            Navigate = new DataGridViewButtonColumn();
            bsPhysicalFiles = new BindingSource(components);
            tlpPhysicalButtons = new TableLayoutPanel();
            btnKeepFirst = new Button();
            btnDeleteSelected = new Button();
            btnKeepSelected = new Button();
            bsIncludeSubfolders = new BindingSource(components);
            bwScan = new System.ComponentModel.BackgroundWorker();
            gbExecution = new GroupBox();
            gbExecution.SuspendLayout();
            tlpExecution.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbScanPath.SuspendLayout();
            tlpScanPath.SuspendLayout();
            tlpScanPathTop.SuspendLayout();
            tlpScanPathStats.SuspendLayout();
            tlpStatsStack.SuspendLayout();
            gbUniqueFiles.SuspendLayout();
            tlpUniqueFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUniqueFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUniqueFiles).BeginInit();
            tlpUniqueButtons.SuspendLayout();
            gbPhysicalFiles.SuspendLayout();
            tlpPhysicalFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhysicalFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPhysicalFiles).BeginInit();
            tlpPhysicalButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsIncludeSubfolders).BeginInit();
            SuspendLayout();
            // 
            // gbExecution
            // 
            tableLayoutPanel1.SetColumnSpan(gbExecution, 2);
            gbExecution.Controls.Add(tlpExecution);
            gbExecution.Dock = DockStyle.Fill;
            gbExecution.Location = new Point(13, 792);
            gbExecution.Margin = new Padding(6, 6, 6, 6);
            gbExecution.Name = "gbExecution";
            gbExecution.Padding = new Padding(7, 9, 7, 9);
            gbExecution.Size = new Size(2301, 671);
            gbExecution.TabIndex = 3;
            gbExecution.TabStop = false;
            gbExecution.Text = "Execution";
            // 
            // tlpExecution
            // 
            tlpExecution.ColumnCount = 1;
            tlpExecution.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpExecution.Controls.Add(rtbLogger, 0, 0);
            tlpExecution.Controls.Add(progressBar1, 0, 1);
            tlpExecution.Controls.Add(btnCancel, 0, 2);
            tlpExecution.Dock = DockStyle.Fill;
            tlpExecution.Location = new Point(7, 41);
            tlpExecution.Margin = new Padding(6, 6, 6, 6);
            tlpExecution.Name = "tlpExecution";
            tlpExecution.RowCount = 3;
            tlpExecution.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpExecution.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpExecution.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpExecution.Size = new Size(2287, 621);
            tlpExecution.TabIndex = 0;
            // 
            // rtbLogger
            // 
            rtbLogger.Dock = DockStyle.Fill;
            rtbLogger.Location = new Point(6, 6);
            rtbLogger.Margin = new Padding(6, 6, 6, 6);
            rtbLogger.Name = "rtbLogger";
            rtbLogger.Size = new Size(2275, 489);
            rtbLogger.TabIndex = 0;
            rtbLogger.Text = "";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(6, 507);
            progressBar1.Margin = new Padding(6, 6, 6, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(2275, 48);
            progressBar1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(6, 567);
            btnCancel.Margin = new Padding(6, 6, 6, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(2275, 48);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(gbScanPath, 0, 0);
            tableLayoutPanel1.Controls.Add(gbUniqueFiles, 0, 1);
            tableLayoutPanel1.Controls.Add(gbPhysicalFiles, 1, 1);
            tableLayoutPanel1.Controls.Add(gbExecution, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6, 6, 6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(7, 9, 7, 9);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 683F));
            tableLayoutPanel1.Size = new Size(2327, 1478);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gbScanPath
            // 
            tableLayoutPanel1.SetColumnSpan(gbScanPath, 2);
            gbScanPath.Controls.Add(tlpScanPath);
            gbScanPath.Dock = DockStyle.Fill;
            gbScanPath.Location = new Point(13, 15);
            gbScanPath.Margin = new Padding(6, 6, 6, 6);
            gbScanPath.Name = "gbScanPath";
            gbScanPath.Padding = new Padding(7, 9, 7, 9);
            gbScanPath.Size = new Size(2301, 244);
            gbScanPath.TabIndex = 0;
            gbScanPath.TabStop = false;
            gbScanPath.Text = "Scan Path";
            // 
            // tlpScanPath
            // 
            tlpScanPath.ColumnCount = 1;
            tlpScanPath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpScanPath.Controls.Add(tlpScanPathTop, 0, 0);
            tlpScanPath.Controls.Add(tlpScanPathStats, 0, 1);
            tlpScanPath.Dock = DockStyle.Fill;
            tlpScanPath.Location = new Point(7, 41);
            tlpScanPath.Margin = new Padding(6, 6, 6, 6);
            tlpScanPath.Name = "tlpScanPath";
            tlpScanPath.RowCount = 2;
            tlpScanPath.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpScanPath.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpScanPath.Size = new Size(2287, 194);
            tlpScanPath.TabIndex = 0;
            // 
            // tlpScanPathTop
            // 
            tlpScanPathTop.ColumnCount = 3;
            tlpScanPathTop.ColumnStyles.Add(new ColumnStyle());
            tlpScanPathTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpScanPathTop.ColumnStyles.Add(new ColumnStyle());
            tlpScanPathTop.Controls.Add(lblScanPathLabel, 0, 0);
            tlpScanPathTop.Controls.Add(txbScanPath, 1, 0);
            tlpScanPathTop.Controls.Add(btnChooseScanPath, 2, 0);
            tlpScanPathTop.Dock = DockStyle.Fill;
            tlpScanPathTop.Location = new Point(6, 6);
            tlpScanPathTop.Margin = new Padding(6, 6, 6, 6);
            tlpScanPathTop.Name = "tlpScanPathTop";
            tlpScanPathTop.RowCount = 1;
            tlpScanPathTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tlpScanPathTop.Size = new Size(2275, 85);
            tlpScanPathTop.TabIndex = 0;
            // 
            // lblScanPathLabel
            // 
            lblScanPathLabel.Anchor = AnchorStyles.None;
            lblScanPathLabel.AutoSize = true;
            lblScanPathLabel.Location = new Point(6, 26);
            lblScanPathLabel.Margin = new Padding(6, 0, 6, 0);
            lblScanPathLabel.Name = "lblScanPathLabel";
            lblScanPathLabel.Size = new Size(122, 32);
            lblScanPathLabel.TabIndex = 0;
            lblScanPathLabel.Text = "Scan Path:";
            lblScanPathLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbScanPath
            // 
            txbScanPath.Dock = DockStyle.Fill;
            txbScanPath.Location = new Point(140, 6);
            txbScanPath.Margin = new Padding(6, 6, 6, 6);
            txbScanPath.Name = "txbScanPath";
            txbScanPath.ReadOnly = true;
            txbScanPath.Size = new Size(1720, 39);
            txbScanPath.TabIndex = 1;
            txbScanPath.TextChanged += txbScanPath_TextChanged;
            // 
            // btnChooseScanPath
            // 
            btnChooseScanPath.AutoSize = true;
            btnChooseScanPath.Dock = DockStyle.Fill;
            btnChooseScanPath.Location = new Point(1872, 6);
            btnChooseScanPath.Margin = new Padding(6, 6, 6, 6);
            btnChooseScanPath.MinimumSize = new Size(241, 0);
            btnChooseScanPath.Name = "btnChooseScanPath";
            btnChooseScanPath.Size = new Size(397, 73);
            btnChooseScanPath.TabIndex = 2;
            btnChooseScanPath.Text = "Choose Scan Path";
            btnChooseScanPath.UseVisualStyleBackColor = true;
            btnChooseScanPath.Click += btnChooseScanPath_Click;
            // 
            // tlpScanPathStats
            // 
            tlpScanPathStats.ColumnCount = 3;
            tlpScanPathStats.ColumnStyles.Add(new ColumnStyle());
            tlpScanPathStats.ColumnStyles.Add(new ColumnStyle());
            tlpScanPathStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpScanPathStats.Controls.Add(btnScan, 0, 0);
            tlpScanPathStats.Controls.Add(cbIncludeSubfolders, 1, 0);
            tlpScanPathStats.Controls.Add(tlpStatsStack, 2, 0);
            tlpScanPathStats.Dock = DockStyle.Fill;
            tlpScanPathStats.Location = new Point(6, 103);
            tlpScanPathStats.Margin = new Padding(6, 6, 6, 6);
            tlpScanPathStats.Name = "tlpScanPathStats";
            tlpScanPathStats.RowCount = 1;
            tlpScanPathStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScanPathStats.Size = new Size(2275, 85);
            tlpScanPathStats.TabIndex = 1;
            // 
            // btnScan
            // 
            btnScan.Dock = DockStyle.Fill;
            btnScan.Location = new Point(6, 6);
            btnScan.Margin = new Padding(6, 6, 6, 6);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(139, 73);
            btnScan.TabIndex = 3;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScanFolderOnly_Click;
            // 
            // cbIncludeSubfolders
            // 
            cbIncludeSubfolders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbIncludeSubfolders.AutoSize = true;
            cbIncludeSubfolders.Location = new Point(157, 6);
            cbIncludeSubfolders.Margin = new Padding(6, 6, 6, 6);
            cbIncludeSubfolders.Name = "cbIncludeSubfolders";
            cbIncludeSubfolders.Size = new Size(245, 73);
            cbIncludeSubfolders.TabIndex = 4;
            cbIncludeSubfolders.Text = "Include Subfolders";
            cbIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // tlpStatsStack
            // 
            tlpStatsStack.ColumnCount = 2;
            tlpStatsStack.ColumnStyles.Add(new ColumnStyle());
            tlpStatsStack.ColumnStyles.Add(new ColumnStyle());
            tlpStatsStack.Controls.Add(lblTotalFiles, 0, 0);
            tlpStatsStack.Controls.Add(lblTotalFilesNumber, 1, 0);
            tlpStatsStack.Controls.Add(lblUniqueFiles, 0, 1);
            tlpStatsStack.Controls.Add(lblUniqueFilesNumber, 1, 1);
            tlpStatsStack.Dock = DockStyle.Fill;
            tlpStatsStack.Location = new Point(414, 6);
            tlpStatsStack.Margin = new Padding(6, 6, 6, 6);
            tlpStatsStack.Name = "tlpStatsStack";
            tlpStatsStack.RowCount = 2;
            tlpStatsStack.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStatsStack.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStatsStack.Size = new Size(1855, 73);
            tlpStatsStack.TabIndex = 5;
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalFiles.AutoSize = true;
            lblTotalFiles.Location = new Point(6, 0);
            lblTotalFiles.Margin = new Padding(6, 0, 6, 0);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Size = new Size(124, 36);
            lblTotalFiles.TabIndex = 5;
            lblTotalFiles.Text = "Total Files:";
            // 
            // lblTotalFilesNumber
            // 
            lblTotalFilesNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalFilesNumber.AutoSize = true;
            lblTotalFilesNumber.Location = new Point(168, 0);
            lblTotalFilesNumber.Margin = new Padding(6, 0, 6, 0);
            lblTotalFilesNumber.Name = "lblTotalFilesNumber";
            lblTotalFilesNumber.Size = new Size(70, 36);
            lblTotalFilesNumber.TabIndex = 6;
            lblTotalFilesNumber.Text = "NULL";
            // 
            // lblUniqueFiles
            // 
            lblUniqueFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblUniqueFiles.AutoSize = true;
            lblUniqueFiles.Location = new Point(6, 36);
            lblUniqueFiles.Margin = new Padding(6, 0, 6, 0);
            lblUniqueFiles.Name = "lblUniqueFiles";
            lblUniqueFiles.Size = new Size(150, 37);
            lblUniqueFiles.TabIndex = 7;
            lblUniqueFiles.Text = "Unique Files:";
            // 
            // lblUniqueFilesNumber
            // 
            lblUniqueFilesNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblUniqueFilesNumber.AutoSize = true;
            lblUniqueFilesNumber.Location = new Point(168, 36);
            lblUniqueFilesNumber.Margin = new Padding(6, 0, 6, 0);
            lblUniqueFilesNumber.Name = "lblUniqueFilesNumber";
            lblUniqueFilesNumber.Size = new Size(70, 37);
            lblUniqueFilesNumber.TabIndex = 8;
            lblUniqueFilesNumber.Text = "NULL";
            // 
            // gbUniqueFiles
            // 
            gbUniqueFiles.Controls.Add(tlpUniqueFiles);
            gbUniqueFiles.Dock = DockStyle.Fill;
            gbUniqueFiles.Location = new Point(13, 271);
            gbUniqueFiles.Margin = new Padding(6, 6, 6, 6);
            gbUniqueFiles.Name = "gbUniqueFiles";
            gbUniqueFiles.Padding = new Padding(7, 9, 7, 9);
            gbUniqueFiles.Size = new Size(1144, 509);
            gbUniqueFiles.TabIndex = 1;
            gbUniqueFiles.TabStop = false;
            gbUniqueFiles.Text = "Unique Items";
            // 
            // tlpUniqueFiles
            // 
            tlpUniqueFiles.ColumnCount = 1;
            tlpUniqueFiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUniqueFiles.Controls.Add(dgUniqueFiles, 0, 0);
            tlpUniqueFiles.Controls.Add(tlpUniqueButtons, 0, 1);
            tlpUniqueFiles.Dock = DockStyle.Fill;
            tlpUniqueFiles.Location = new Point(7, 41);
            tlpUniqueFiles.Margin = new Padding(6, 6, 6, 6);
            tlpUniqueFiles.Name = "tlpUniqueFiles";
            tlpUniqueFiles.RowCount = 2;
            tlpUniqueFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniqueFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tlpUniqueFiles.Size = new Size(1130, 459);
            tlpUniqueFiles.TabIndex = 0;
            // 
            // dgUniqueFiles
            // 
            dgUniqueFiles.AllowUserToAddRows = false;
            dgUniqueFiles.AllowUserToDeleteRows = false;
            dgUniqueFiles.AutoGenerateColumns = false;
            dgUniqueFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUniqueFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUniqueFiles.Columns.AddRange(new DataGridViewColumn[] { hashDataGridViewTextBoxColumn, Action });
            dgUniqueFiles.DataSource = bsUniqueFiles;
            dgUniqueFiles.Dock = DockStyle.Fill;
            dgUniqueFiles.Location = new Point(6, 6);
            dgUniqueFiles.Margin = new Padding(6, 6, 6, 6);
            dgUniqueFiles.Name = "dgUniqueFiles";
            dgUniqueFiles.ReadOnly = true;
            dgUniqueFiles.RowHeadersWidth = 40;
            dgUniqueFiles.Size = new Size(1118, 374);
            dgUniqueFiles.TabIndex = 0;
            // 
            // hashDataGridViewTextBoxColumn
            // 
            hashDataGridViewTextBoxColumn.DataPropertyName = "Hash";
            hashDataGridViewTextBoxColumn.FillWeight = 65F;
            hashDataGridViewTextBoxColumn.HeaderText = "Hash";
            hashDataGridViewTextBoxColumn.MinimumWidth = 80;
            hashDataGridViewTextBoxColumn.Name = "hashDataGridViewTextBoxColumn";
            hashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            Action.FillWeight = 35F;
            Action.HeaderText = "Action";
            Action.MinimumWidth = 70;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Text = "Show Folders";
            Action.UseColumnTextForButtonValue = true;
            // 
            // bsUniqueFiles
            // 
            bsUniqueFiles.DataSource = typeof(Objects.UniqueFile);
            // 
            // tlpUniqueButtons
            // 
            tlpUniqueButtons.ColumnCount = 5;
            tlpUniqueButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpUniqueButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpUniqueButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpUniqueButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpUniqueButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpUniqueButtons.Controls.Add(btnShowSinlges, 0, 0);
            tlpUniqueButtons.Controls.Add(btnShowDuplicates, 1, 0);
            tlpUniqueButtons.Controls.Add(btnShowAll, 2, 0);
            tlpUniqueButtons.Controls.Add(btnShowFilePaths, 3, 0);
            tlpUniqueButtons.Controls.Add(btnAutoClean, 4, 0);
            tlpUniqueButtons.Dock = DockStyle.Fill;
            tlpUniqueButtons.Location = new Point(6, 392);
            tlpUniqueButtons.Margin = new Padding(6, 6, 6, 6);
            tlpUniqueButtons.Name = "tlpUniqueButtons";
            tlpUniqueButtons.RowCount = 1;
            tlpUniqueButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUniqueButtons.Size = new Size(1118, 61);
            tlpUniqueButtons.TabIndex = 1;
            // 
            // btnShowSinlges
            // 
            btnShowSinlges.Dock = DockStyle.Fill;
            btnShowSinlges.Location = new Point(6, 6);
            btnShowSinlges.Margin = new Padding(6, 6, 6, 6);
            btnShowSinlges.Name = "btnShowSinlges";
            btnShowSinlges.Size = new Size(211, 49);
            btnShowSinlges.TabIndex = 1;
            btnShowSinlges.Text = "Singles";
            btnShowSinlges.UseVisualStyleBackColor = true;
            // 
            // btnShowDuplicates
            // 
            btnShowDuplicates.Dock = DockStyle.Fill;
            btnShowDuplicates.Location = new Point(229, 6);
            btnShowDuplicates.Margin = new Padding(6, 6, 6, 6);
            btnShowDuplicates.Name = "btnShowDuplicates";
            btnShowDuplicates.Size = new Size(211, 49);
            btnShowDuplicates.TabIndex = 2;
            btnShowDuplicates.Text = "Duplicates";
            btnShowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Dock = DockStyle.Fill;
            btnShowAll.Location = new Point(452, 6);
            btnShowAll.Margin = new Padding(6, 6, 6, 6);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(211, 49);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnShowFilePaths
            // 
            btnShowFilePaths.Dock = DockStyle.Fill;
            btnShowFilePaths.Location = new Point(675, 6);
            btnShowFilePaths.Margin = new Padding(6, 6, 6, 6);
            btnShowFilePaths.Name = "btnShowFilePaths";
            btnShowFilePaths.Size = new Size(211, 49);
            btnShowFilePaths.TabIndex = 4;
            btnShowFilePaths.Text = "Paths";
            btnShowFilePaths.UseVisualStyleBackColor = true;
            btnShowFilePaths.Click += btnShowFilePaths_Click;
            // 
            // btnAutoClean
            // 
            btnAutoClean.Dock = DockStyle.Fill;
            btnAutoClean.Location = new Point(898, 6);
            btnAutoClean.Margin = new Padding(6, 6, 6, 6);
            btnAutoClean.Name = "btnAutoClean";
            btnAutoClean.Size = new Size(214, 49);
            btnAutoClean.TabIndex = 5;
            btnAutoClean.Text = "Auto Clean";
            btnAutoClean.UseVisualStyleBackColor = true;
            // 
            // gbPhysicalFiles
            // 
            gbPhysicalFiles.Controls.Add(tlpPhysicalFiles);
            gbPhysicalFiles.Dock = DockStyle.Fill;
            gbPhysicalFiles.Location = new Point(1169, 271);
            gbPhysicalFiles.Margin = new Padding(6, 6, 6, 6);
            gbPhysicalFiles.Name = "gbPhysicalFiles";
            gbPhysicalFiles.Padding = new Padding(7, 9, 7, 9);
            gbPhysicalFiles.Size = new Size(1145, 509);
            gbPhysicalFiles.TabIndex = 2;
            gbPhysicalFiles.TabStop = false;
            gbPhysicalFiles.Text = "Physical Files";
            // 
            // tlpPhysicalFiles
            // 
            tlpPhysicalFiles.ColumnCount = 1;
            tlpPhysicalFiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPhysicalFiles.Controls.Add(dgPhysicalFiles, 0, 0);
            tlpPhysicalFiles.Controls.Add(tlpPhysicalButtons, 0, 1);
            tlpPhysicalFiles.Dock = DockStyle.Fill;
            tlpPhysicalFiles.Location = new Point(7, 41);
            tlpPhysicalFiles.Margin = new Padding(6, 6, 6, 6);
            tlpPhysicalFiles.Name = "tlpPhysicalFiles";
            tlpPhysicalFiles.RowCount = 2;
            tlpPhysicalFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPhysicalFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tlpPhysicalFiles.Size = new Size(1131, 459);
            tlpPhysicalFiles.TabIndex = 0;
            // 
            // dgPhysicalFiles
            // 
            dgPhysicalFiles.AllowUserToAddRows = false;
            dgPhysicalFiles.AllowUserToDeleteRows = false;
            dgPhysicalFiles.AutoGenerateColumns = false;
            dgPhysicalFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhysicalFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhysicalFiles.Columns.AddRange(new DataGridViewColumn[] { pathDataGridViewTextBoxColumn, Selected, Navigate });
            dgPhysicalFiles.DataSource = bsPhysicalFiles;
            dgPhysicalFiles.Dock = DockStyle.Fill;
            dgPhysicalFiles.Location = new Point(6, 6);
            dgPhysicalFiles.Margin = new Padding(6, 6, 6, 6);
            dgPhysicalFiles.Name = "dgPhysicalFiles";
            dgPhysicalFiles.RowHeadersWidth = 40;
            dgPhysicalFiles.Size = new Size(1119, 374);
            dgPhysicalFiles.TabIndex = 0;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.FillWeight = 65F;
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.MinimumWidth = 80;
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Selected
            // 
            Selected.DataPropertyName = "Selected";
            Selected.FillWeight = 10F;
            Selected.HeaderText = "Sel";
            Selected.MinimumWidth = 30;
            Selected.Name = "Selected";
            // 
            // Navigate
            // 
            Navigate.DataPropertyName = "Path";
            Navigate.FillWeight = 25F;
            Navigate.HeaderText = "Navigate";
            Navigate.MinimumWidth = 70;
            Navigate.Name = "Navigate";
            Navigate.ReadOnly = true;
            Navigate.Text = "Show in Folder";
            Navigate.UseColumnTextForButtonValue = true;
            // 
            // bsPhysicalFiles
            // 
            bsPhysicalFiles.DataSource = typeof(Objects.PhysicalFile);
            // 
            // tlpPhysicalButtons
            // 
            tlpPhysicalButtons.ColumnCount = 3;
            tlpPhysicalButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpPhysicalButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpPhysicalButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpPhysicalButtons.Controls.Add(btnKeepFirst, 0, 0);
            tlpPhysicalButtons.Controls.Add(btnDeleteSelected, 1, 0);
            tlpPhysicalButtons.Controls.Add(btnKeepSelected, 2, 0);
            tlpPhysicalButtons.Dock = DockStyle.Fill;
            tlpPhysicalButtons.Location = new Point(6, 392);
            tlpPhysicalButtons.Margin = new Padding(6, 6, 6, 6);
            tlpPhysicalButtons.Name = "tlpPhysicalButtons";
            tlpPhysicalButtons.RowCount = 1;
            tlpPhysicalButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPhysicalButtons.Size = new Size(1119, 61);
            tlpPhysicalButtons.TabIndex = 1;
            // 
            // btnKeepFirst
            // 
            btnKeepFirst.Dock = DockStyle.Fill;
            btnKeepFirst.Location = new Point(6, 6);
            btnKeepFirst.Margin = new Padding(6, 6, 6, 6);
            btnKeepFirst.Name = "btnKeepFirst";
            btnKeepFirst.Size = new Size(360, 49);
            btnKeepFirst.TabIndex = 1;
            btnKeepFirst.Text = "Keep First";
            btnKeepFirst.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Dock = DockStyle.Fill;
            btnDeleteSelected.Location = new Point(378, 6);
            btnDeleteSelected.Margin = new Padding(6, 6, 6, 6);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(360, 49);
            btnDeleteSelected.TabIndex = 2;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnKeepSelected
            // 
            btnKeepSelected.Dock = DockStyle.Fill;
            btnKeepSelected.Location = new Point(750, 6);
            btnKeepSelected.Margin = new Padding(6, 6, 6, 6);
            btnKeepSelected.Name = "btnKeepSelected";
            btnKeepSelected.Size = new Size(363, 49);
            btnKeepSelected.TabIndex = 3;
            btnKeepSelected.Text = "Keep Selected";
            btnKeepSelected.UseVisualStyleBackColor = true;
            // 
            // bwScan
            // 
            bwScan.WorkerReportsProgress = true;
            bwScan.WorkerSupportsCancellation = true;
            bwScan.DoWork += bwScan_DoWork;
            bwScan.ProgressChanged += bwScan_ProgressChanged;
            bwScan.RunWorkerCompleted += bwScan_RunWorkerCompleted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(2327, 1478);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(869, 602);
            Name = "MainForm";
            Text = "Duplicate File Cleaner";
            gbExecution.ResumeLayout(false);
            tlpExecution.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            gbScanPath.ResumeLayout(false);
            tlpScanPath.ResumeLayout(false);
            tlpScanPathTop.ResumeLayout(false);
            tlpScanPathTop.PerformLayout();
            tlpScanPathStats.ResumeLayout(false);
            tlpScanPathStats.PerformLayout();
            tlpStatsStack.ResumeLayout(false);
            tlpStatsStack.PerformLayout();
            gbUniqueFiles.ResumeLayout(false);
            tlpUniqueFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUniqueFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUniqueFiles).EndInit();
            tlpUniqueButtons.ResumeLayout(false);
            gbPhysicalFiles.ResumeLayout(false);
            tlpPhysicalFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPhysicalFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPhysicalFiles).EndInit();
            tlpPhysicalButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsIncludeSubfolders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;

        // ScanPath
        private GroupBox gbScanPath;
        private TableLayoutPanel tlpScanPath;
        private TableLayoutPanel tlpScanPathTop;
        private TableLayoutPanel tlpScanPathStats;
        private Label lblScanPathLabel;
        private TextBox txbScanPath;
        private Button btnChooseScanPath;
        private Button btnScan;
        private CheckBox cbIncludeSubfolders;
        private TableLayoutPanel tlpStatsStack;
        private Label lblTotalFiles;
        private Label lblTotalFilesNumber;
        private Label lblUniqueFiles;
        private Label lblUniqueFilesNumber;

        // Unique files
        private GroupBox gbUniqueFiles;
        private TableLayoutPanel tlpUniqueFiles;
        private DataGridView dgUniqueFiles;
        private DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Action;
        private BindingSource bsUniqueFiles;
        private TableLayoutPanel tlpUniqueButtons;
        private Button btnShowSinlges;
        private Button btnShowDuplicates;
        private Button btnShowAll;
        private Button btnShowFilePaths;
        private Button btnAutoClean;

        // Physical files
        private GroupBox gbPhysicalFiles;
        private TableLayoutPanel tlpPhysicalFiles;
        private DataGridView dgPhysicalFiles;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Selected;
        private DataGridViewButtonColumn Navigate;
        private BindingSource bsPhysicalFiles;
        private TableLayoutPanel tlpPhysicalButtons;
        private Button btnKeepFirst;
        private Button btnDeleteSelected;
        private Button btnKeepSelected;

        // Execution
        private GroupBox gbExecution;
        private TableLayoutPanel tlpExecution;
        private RichTextBox rtbLogger;
        private ProgressBar progressBar1;
        private Button btnCancel;

        private BindingSource bsIncludeSubfolders;
        private System.ComponentModel.BackgroundWorker bwScan;
    }
}