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
            components = new System.ComponentModel.Container();
            GroupBox gbExecution;
            btnCancel = new Button();
            progressBar1 = new ProgressBar();
            rtbLogger = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbUniqueFiles = new GroupBox();
            dgUniqueFiles = new DataGridView();
            hashDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            bsUniqueFiles = new BindingSource(components);
            btnShowSinlges = new Button();
            btnShowDuplicates = new Button();
            btnShowAll = new Button();
            btnAutoClean = new Button();
            btnShowFilePaths = new Button();
            gbPhysicalFiles = new GroupBox();
            dgPhysicalFiles = new DataGridView();
            bsPhysicalFiles = new BindingSource(components);
            btnKeepSelected = new Button();
            btnDeleteSelected = new Button();
            btnKeepFirst = new Button();
            gbDirectory = new GroupBox();
            lblUniqueFilesNumber = new Label();
            txbDirectory = new TextBox();
            lblUniqueFiles = new Label();
            lblDirectoryLabel = new Label();
            lblTotalFilesNumber = new Label();
            btnChooseDirectory = new Button();
            lblTotalFiles = new Label();
            btnScanFolderOnly = new Button();
            btnScanFolderAndSubfolders = new Button();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInBytesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            extensionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hashDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Selected = new DataGridViewCheckBoxColumn();
            Navigate = new DataGridViewButtonColumn();
            gbExecution = new GroupBox();
            gbExecution.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbUniqueFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUniqueFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUniqueFiles).BeginInit();
            gbPhysicalFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhysicalFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPhysicalFiles).BeginInit();
            gbDirectory.SuspendLayout();
            SuspendLayout();
            // 
            // gbExecution
            // 
            tableLayoutPanel1.SetColumnSpan(gbExecution, 2);
            gbExecution.Controls.Add(btnCancel);
            gbExecution.Controls.Add(progressBar1);
            gbExecution.Controls.Add(rtbLogger);
            gbExecution.Location = new Point(6, 947);
            gbExecution.Margin = new Padding(6);
            gbExecution.Name = "gbExecution";
            gbExecution.Padding = new Padding(6);
            gbExecution.Size = new Size(1925, 638);
            gbExecution.TabIndex = 4;
            gbExecution.TabStop = false;
            gbExecution.Text = "Execution";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 557);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(1909, 49);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 495);
            progressBar1.Margin = new Padding(6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1909, 49);
            progressBar1.TabIndex = 1;
            // 
            // rtbLogger
            // 
            rtbLogger.Location = new Point(0, 47);
            rtbLogger.Margin = new Padding(6);
            rtbLogger.Name = "rtbLogger";
            rtbLogger.Size = new Size(1911, 431);
            rtbLogger.TabIndex = 0;
            rtbLogger.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3767967F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6232033F));
            tableLayoutPanel1.Controls.Add(gbUniqueFiles, 0, 1);
            tableLayoutPanel1.Controls.Add(gbExecution, 0, 2);
            tableLayoutPanel1.Controls.Add(gbPhysicalFiles, 1, 1);
            tableLayoutPanel1.Controls.Add(gbDirectory, 0, 0);
            tableLayoutPanel1.Location = new Point(22, 26);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0362816F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.96372F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 649F));
            tableLayoutPanel1.Size = new Size(1937, 1591);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // gbUniqueFiles
            // 
            gbUniqueFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbUniqueFiles.Controls.Add(dgUniqueFiles);
            gbUniqueFiles.Controls.Add(btnShowSinlges);
            gbUniqueFiles.Controls.Add(btnShowDuplicates);
            gbUniqueFiles.Controls.Add(btnShowAll);
            gbUniqueFiles.Controls.Add(btnAutoClean);
            gbUniqueFiles.Controls.Add(btnShowFilePaths);
            gbUniqueFiles.Location = new Point(6, 232);
            gbUniqueFiles.Margin = new Padding(6);
            gbUniqueFiles.Name = "gbUniqueFiles";
            gbUniqueFiles.Padding = new Padding(6);
            gbUniqueFiles.Size = new Size(944, 703);
            gbUniqueFiles.TabIndex = 2;
            gbUniqueFiles.TabStop = false;
            gbUniqueFiles.Text = "Unique Items";
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
            dgUniqueFiles.Location = new Point(11, 47);
            dgUniqueFiles.Margin = new Padding(6);
            dgUniqueFiles.Name = "dgUniqueFiles";
            dgUniqueFiles.ReadOnly = true;
            dgUniqueFiles.RowHeadersWidth = 82;
            dgUniqueFiles.Size = new Size(923, 585);
            dgUniqueFiles.TabIndex = 8;
            // 
            // hashDataGridViewTextBoxColumn
            // 
            hashDataGridViewTextBoxColumn.DataPropertyName = "Hash";
            hashDataGridViewTextBoxColumn.HeaderText = "Hash";
            hashDataGridViewTextBoxColumn.MinimumWidth = 10;
            hashDataGridViewTextBoxColumn.Name = "hashDataGridViewTextBoxColumn";
            hashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 10;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Text = "Show Folders";
            Action.UseColumnTextForButtonValue = true;
            // 
            // bsUniqueFiles
            // 
            bsUniqueFiles.DataSource = typeof(Objects.UniqueFile);
            // 
            // btnShowSinlges
            // 
            btnShowSinlges.Location = new Point(11, 646);
            btnShowSinlges.Margin = new Padding(6);
            btnShowSinlges.Name = "btnShowSinlges";
            btnShowSinlges.Size = new Size(284, 49);
            btnShowSinlges.TabIndex = 7;
            btnShowSinlges.Text = "Show Only Sinlge Entries";
            btnShowSinlges.UseVisualStyleBackColor = true;
            // 
            // btnShowDuplicates
            // 
            btnShowDuplicates.Location = new Point(306, 646);
            btnShowDuplicates.Margin = new Padding(6);
            btnShowDuplicates.Name = "btnShowDuplicates";
            btnShowDuplicates.Size = new Size(253, 49);
            btnShowDuplicates.TabIndex = 6;
            btnShowDuplicates.Text = "Show Duplicates";
            btnShowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(306, 326);
            btnShowAll.Margin = new Padding(6);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(163, 49);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnAutoClean
            // 
            btnAutoClean.Location = new Point(754, 644);
            btnAutoClean.Margin = new Padding(6);
            btnAutoClean.Name = "btnAutoClean";
            btnAutoClean.Size = new Size(163, 49);
            btnAutoClean.TabIndex = 4;
            btnAutoClean.Text = "Auto Clean";
            btnAutoClean.UseVisualStyleBackColor = true;
            // 
            // btnShowFilePaths
            // 
            btnShowFilePaths.Location = new Point(570, 646);
            btnShowFilePaths.Margin = new Padding(6);
            btnShowFilePaths.Name = "btnShowFilePaths";
            btnShowFilePaths.Size = new Size(173, 49);
            btnShowFilePaths.TabIndex = 3;
            btnShowFilePaths.Text = "Show Paths";
            btnShowFilePaths.UseVisualStyleBackColor = true;
            btnShowFilePaths.Click += btnShowFilePaths_Click;
            // 
            // gbPhysicalFiles
            // 
            gbPhysicalFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPhysicalFiles.Controls.Add(dgPhysicalFiles);
            gbPhysicalFiles.Controls.Add(btnKeepSelected);
            gbPhysicalFiles.Controls.Add(btnDeleteSelected);
            gbPhysicalFiles.Controls.Add(btnKeepFirst);
            gbPhysicalFiles.Location = new Point(962, 232);
            gbPhysicalFiles.Margin = new Padding(6);
            gbPhysicalFiles.Name = "gbPhysicalFiles";
            gbPhysicalFiles.Padding = new Padding(6);
            gbPhysicalFiles.Size = new Size(969, 703);
            gbPhysicalFiles.TabIndex = 2;
            gbPhysicalFiles.TabStop = false;
            gbPhysicalFiles.Text = "Physical Files";
            // 
            // dgPhysicalFiles
            // 
            dgPhysicalFiles.AllowUserToAddRows = false;
            dgPhysicalFiles.AllowUserToDeleteRows = false;
            dgPhysicalFiles.AutoGenerateColumns = false;
            dgPhysicalFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhysicalFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhysicalFiles.Columns.AddRange(new DataGridViewColumn[] { pathDataGridViewTextBoxColumn, sizeInBytesDataGridViewTextBoxColumn, extensionDataGridViewTextBoxColumn, hashDataGridViewTextBoxColumn1, Selected, Navigate });
            dgPhysicalFiles.DataSource = bsPhysicalFiles;
            dgPhysicalFiles.Location = new Point(11, 45);
            dgPhysicalFiles.Margin = new Padding(6);
            dgPhysicalFiles.Name = "dgPhysicalFiles";
            dgPhysicalFiles.ReadOnly = true;
            dgPhysicalFiles.RowHeadersWidth = 82;
            dgPhysicalFiles.Size = new Size(947, 585);
            dgPhysicalFiles.TabIndex = 9;
            // 
            // bsPhysicalFiles
            // 
            bsPhysicalFiles.DataSource = typeof(Objects.PhysicalFile);
            // 
            // btnKeepSelected
            // 
            btnKeepSelected.Location = new Point(745, 642);
            btnKeepSelected.Margin = new Padding(6);
            btnKeepSelected.Name = "btnKeepSelected";
            btnKeepSelected.Size = new Size(210, 53);
            btnKeepSelected.TabIndex = 7;
            btnKeepSelected.Text = "Keep Selected";
            btnKeepSelected.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(367, 644);
            btnDeleteSelected.Margin = new Padding(6);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(210, 53);
            btnDeleteSelected.TabIndex = 6;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnKeepFirst
            // 
            btnKeepFirst.Location = new Point(11, 644);
            btnKeepFirst.Margin = new Padding(6);
            btnKeepFirst.Name = "btnKeepFirst";
            btnKeepFirst.Size = new Size(171, 53);
            btnKeepFirst.TabIndex = 5;
            btnKeepFirst.Text = "Keep First";
            btnKeepFirst.UseVisualStyleBackColor = true;
            // 
            // gbDirectory
            // 
            gbDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(gbDirectory, 2);
            gbDirectory.Controls.Add(lblUniqueFilesNumber);
            gbDirectory.Controls.Add(txbDirectory);
            gbDirectory.Controls.Add(lblUniqueFiles);
            gbDirectory.Controls.Add(lblDirectoryLabel);
            gbDirectory.Controls.Add(lblTotalFilesNumber);
            gbDirectory.Controls.Add(btnChooseDirectory);
            gbDirectory.Controls.Add(lblTotalFiles);
            gbDirectory.Controls.Add(btnScanFolderOnly);
            gbDirectory.Controls.Add(btnScanFolderAndSubfolders);
            gbDirectory.Location = new Point(6, 6);
            gbDirectory.Margin = new Padding(6);
            gbDirectory.Name = "gbDirectory";
            gbDirectory.Padding = new Padding(6);
            gbDirectory.Size = new Size(1925, 214);
            gbDirectory.TabIndex = 0;
            gbDirectory.TabStop = false;
            gbDirectory.Text = "Directory";
            // 
            // lblUniqueFilesNumber
            // 
            lblUniqueFilesNumber.AutoSize = true;
            lblUniqueFilesNumber.Location = new Point(754, 164);
            lblUniqueFilesNumber.Margin = new Padding(6, 0, 6, 0);
            lblUniqueFilesNumber.Name = "lblUniqueFilesNumber";
            lblUniqueFilesNumber.Size = new Size(70, 32);
            lblUniqueFilesNumber.TabIndex = 5;
            lblUniqueFilesNumber.Text = "NULL";
            // 
            // txbDirectory
            // 
            txbDirectory.Location = new Point(130, 34);
            txbDirectory.Margin = new Padding(6);
            txbDirectory.Name = "txbDirectory";
            txbDirectory.ReadOnly = true;
            txbDirectory.Size = new Size(1785, 39);
            txbDirectory.TabIndex = 3;
            txbDirectory.TextChanged += txbDirectory_TextChanged;
            // 
            // lblUniqueFiles
            // 
            lblUniqueFiles.AutoSize = true;
            lblUniqueFiles.Location = new Point(605, 164);
            lblUniqueFiles.Margin = new Padding(6, 0, 6, 0);
            lblUniqueFiles.Name = "lblUniqueFiles";
            lblUniqueFiles.Size = new Size(150, 32);
            lblUniqueFiles.TabIndex = 4;
            lblUniqueFiles.Text = "Unique Files:";
            // 
            // lblDirectoryLabel
            // 
            lblDirectoryLabel.AutoSize = true;
            lblDirectoryLabel.Location = new Point(11, 41);
            lblDirectoryLabel.Margin = new Padding(6, 0, 6, 0);
            lblDirectoryLabel.Name = "lblDirectoryLabel";
            lblDirectoryLabel.Size = new Size(116, 32);
            lblDirectoryLabel.TabIndex = 1;
            lblDirectoryLabel.Text = "Directory:";
            // 
            // lblTotalFilesNumber
            // 
            lblTotalFilesNumber.AutoSize = true;
            lblTotalFilesNumber.Location = new Point(754, 130);
            lblTotalFilesNumber.Margin = new Padding(6, 0, 6, 0);
            lblTotalFilesNumber.Name = "lblTotalFilesNumber";
            lblTotalFilesNumber.Size = new Size(70, 32);
            lblTotalFilesNumber.TabIndex = 3;
            lblTotalFilesNumber.Text = "NULL";
            // 
            // btnChooseDirectory
            // 
            btnChooseDirectory.Location = new Point(11, 105);
            btnChooseDirectory.Margin = new Padding(6);
            btnChooseDirectory.Name = "btnChooseDirectory";
            btnChooseDirectory.Size = new Size(175, 100);
            btnChooseDirectory.TabIndex = 0;
            btnChooseDirectory.Text = "Choose Directory";
            btnChooseDirectory.UseVisualStyleBackColor = true;
            btnChooseDirectory.Click += btnChooseDirectory_Click;
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.AutoSize = true;
            lblTotalFiles.Location = new Point(605, 130);
            lblTotalFiles.Margin = new Padding(6, 0, 6, 0);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Size = new Size(124, 32);
            lblTotalFiles.TabIndex = 2;
            lblTotalFiles.Text = "Total Files:";
            // 
            // btnScanFolderOnly
            // 
            btnScanFolderOnly.Location = new Point(197, 105);
            btnScanFolderOnly.Margin = new Padding(6);
            btnScanFolderOnly.Name = "btnScanFolderOnly";
            btnScanFolderOnly.Size = new Size(175, 96);
            btnScanFolderOnly.TabIndex = 0;
            btnScanFolderOnly.Text = "Scan Folder Only";
            btnScanFolderOnly.UseVisualStyleBackColor = true;
            btnScanFolderOnly.Click += btnScanFolderOnly_Click;
            // 
            // btnScanFolderAndSubfolders
            // 
            btnScanFolderAndSubfolders.Location = new Point(383, 105);
            btnScanFolderAndSubfolders.Margin = new Padding(6);
            btnScanFolderAndSubfolders.Name = "btnScanFolderAndSubfolders";
            btnScanFolderAndSubfolders.Size = new Size(212, 96);
            btnScanFolderAndSubfolders.TabIndex = 1;
            btnScanFolderAndSubfolders.Text = "Scan Forlder and Subfolders";
            btnScanFolderAndSubfolders.UseVisualStyleBackColor = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.MinimumWidth = 10;
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeInBytesDataGridViewTextBoxColumn
            // 
            sizeInBytesDataGridViewTextBoxColumn.DataPropertyName = "SizeInBytes";
            sizeInBytesDataGridViewTextBoxColumn.HeaderText = "SizeInBytes";
            sizeInBytesDataGridViewTextBoxColumn.MinimumWidth = 10;
            sizeInBytesDataGridViewTextBoxColumn.Name = "sizeInBytesDataGridViewTextBoxColumn";
            sizeInBytesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            extensionDataGridViewTextBoxColumn.MinimumWidth = 10;
            extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            extensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hashDataGridViewTextBoxColumn1
            // 
            hashDataGridViewTextBoxColumn1.DataPropertyName = "Hash";
            hashDataGridViewTextBoxColumn1.HeaderText = "Hash";
            hashDataGridViewTextBoxColumn1.MinimumWidth = 10;
            hashDataGridViewTextBoxColumn1.Name = "hashDataGridViewTextBoxColumn1";
            hashDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Selected
            // 
            Selected.DataPropertyName = "Selected";
            Selected.HeaderText = "Selected";
            Selected.MinimumWidth = 10;
            Selected.Name = "Selected";
            Selected.ReadOnly = true;
            // 
            // Navigate
            // 
            Navigate.DataPropertyName = "Path";
            Navigate.HeaderText = "Navigate";
            Navigate.MinimumWidth = 10;
            Navigate.Name = "Navigate";
            Navigate.ReadOnly = true;
            Navigate.Text = "Show in Folder";
            Navigate.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1982, 1643);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimumSize = new Size(1989, 1515);
            Name = "MainForm";
            Text = "Duplicate File Cleaner";
            gbExecution.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            gbUniqueFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUniqueFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUniqueFiles).EndInit();
            gbPhysicalFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPhysicalFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPhysicalFiles).EndInit();
            gbDirectory.ResumeLayout(false);
            gbDirectory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gbDirectory;
        private TextBox txbDirectory;
        private Label lblDirectoryLabel;
        private Button btnChooseDirectory;
        private Label lblUniqueFilesNumber;
        private Label lblUniqueFiles;
        private Label lblTotalFilesNumber;
        private Label lblTotalFiles;
        private Button btnScanFolderAndSubfolders;
        private Button btnScanFolderOnly;
        private GroupBox gbUniqueFiles;
        private Button btnShowSinlges;
        private Button btnShowDuplicates;
        private Button btnShowAll;
        private Button btnAutoClean;
        private Button btnShowFilePaths;
        private Button btnCancel;
        private ProgressBar progressBar1;
        private RichTextBox rtbLogger;
        private GroupBox gbPhysicalFiles;
        private Button btnKeepSelected;
        private Button btnDeleteSelected;
        private Button btnKeepFirst;
        private DataGridView dgUniqueFiles;
        private BindingSource bsUniqueFiles;
        private DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Action;
        private DataGridView dgPhysicalFiles;
        private BindingSource bsPhysicalFiles;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeInBytesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn Selected;
        private DataGridViewButtonColumn Navigate;
    }
}