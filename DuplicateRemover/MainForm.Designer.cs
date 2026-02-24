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
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInBytesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            extensionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hashDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Selected = new DataGridViewCheckBoxColumn();
            Navigate = new DataGridViewButtonColumn();
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
            gbExecution.Location = new Point(3, 444);
            gbExecution.Name = "gbExecution";
            gbExecution.Size = new Size(1087, 299);
            gbExecution.TabIndex = 4;
            gbExecution.TabStop = false;
            gbExecution.Text = "Execution";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(3, 261);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(1078, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 232);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1078, 23);
            progressBar1.TabIndex = 1;
            // 
            // rtbLogger
            // 
            rtbLogger.Location = new Point(0, 22);
            rtbLogger.Name = "rtbLogger";
            rtbLogger.Size = new Size(1081, 204);
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
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0362816F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.96372F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 304F));
            tableLayoutPanel1.Size = new Size(1093, 746);
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
            gbUniqueFiles.Location = new Point(3, 109);
            gbUniqueFiles.Name = "gbUniqueFiles";
            gbUniqueFiles.Size = new Size(533, 329);
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
            dgUniqueFiles.Location = new Point(6, 22);
            dgUniqueFiles.Name = "dgUniqueFiles";
            dgUniqueFiles.ReadOnly = true;
            dgUniqueFiles.RowHeadersWidth = 82;
            dgUniqueFiles.Size = new Size(521, 274);
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
            btnShowSinlges.Location = new Point(6, 303);
            btnShowSinlges.Name = "btnShowSinlges";
            btnShowSinlges.Size = new Size(153, 23);
            btnShowSinlges.TabIndex = 7;
            btnShowSinlges.Text = "Show Only Sinlge Entries";
            btnShowSinlges.UseVisualStyleBackColor = true;
            // 
            // btnShowDuplicates
            // 
            btnShowDuplicates.Location = new Point(165, 303);
            btnShowDuplicates.Name = "btnShowDuplicates";
            btnShowDuplicates.Size = new Size(136, 23);
            btnShowDuplicates.TabIndex = 6;
            btnShowDuplicates.Text = "Show Duplicates";
            btnShowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(165, 153);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(88, 23);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnAutoClean
            // 
            btnAutoClean.Location = new Point(406, 302);
            btnAutoClean.Name = "btnAutoClean";
            btnAutoClean.Size = new Size(88, 23);
            btnAutoClean.TabIndex = 4;
            btnAutoClean.Text = "Auto Clean";
            btnAutoClean.UseVisualStyleBackColor = true;
            // 
            // btnShowFilePaths
            // 
            btnShowFilePaths.Location = new Point(307, 303);
            btnShowFilePaths.Name = "btnShowFilePaths";
            btnShowFilePaths.Size = new Size(93, 23);
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
            gbPhysicalFiles.Location = new Point(542, 109);
            gbPhysicalFiles.Name = "gbPhysicalFiles";
            gbPhysicalFiles.Size = new Size(548, 329);
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
            dgPhysicalFiles.Location = new Point(6, 21);
            dgPhysicalFiles.Name = "dgPhysicalFiles";
            dgPhysicalFiles.RowHeadersWidth = 82;
            dgPhysicalFiles.Size = new Size(510, 274);
            dgPhysicalFiles.TabIndex = 9;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.MinimumWidth = 10;
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // sizeInBytesDataGridViewTextBoxColumn
            // 
            sizeInBytesDataGridViewTextBoxColumn.DataPropertyName = "SizeInBytes";
            sizeInBytesDataGridViewTextBoxColumn.HeaderText = "SizeInBytes";
            sizeInBytesDataGridViewTextBoxColumn.MinimumWidth = 10;
            sizeInBytesDataGridViewTextBoxColumn.Name = "sizeInBytesDataGridViewTextBoxColumn";
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            extensionDataGridViewTextBoxColumn.MinimumWidth = 10;
            extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            // 
            // hashDataGridViewTextBoxColumn1
            // 
            hashDataGridViewTextBoxColumn1.DataPropertyName = "Hash";
            hashDataGridViewTextBoxColumn1.HeaderText = "Hash";
            hashDataGridViewTextBoxColumn1.MinimumWidth = 10;
            hashDataGridViewTextBoxColumn1.Name = "hashDataGridViewTextBoxColumn1";
            // 
            // Selected
            // 
            Selected.DataPropertyName = "Selected";
            Selected.HeaderText = "Selected";
            Selected.MinimumWidth = 10;
            Selected.Name = "Selected";
            // 
            // Navigate
            // 
            Navigate.DataPropertyName = "Path";
            Navigate.HeaderText = "Navigate";
            Navigate.MinimumWidth = 10;
            Navigate.Name = "Navigate";
            Navigate.Text = "Show in Folder";
            Navigate.UseColumnTextForButtonValue = true;
            // 
            // bsPhysicalFiles
            // 
            bsPhysicalFiles.DataSource = typeof(Objects.PhysicalFile);
            // 
            // btnKeepSelected
            // 
            btnKeepSelected.Location = new Point(401, 301);
            btnKeepSelected.Name = "btnKeepSelected";
            btnKeepSelected.Size = new Size(113, 25);
            btnKeepSelected.TabIndex = 7;
            btnKeepSelected.Text = "Keep Selected";
            btnKeepSelected.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(198, 302);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(113, 25);
            btnDeleteSelected.TabIndex = 6;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnKeepFirst
            // 
            btnKeepFirst.Location = new Point(6, 302);
            btnKeepFirst.Name = "btnKeepFirst";
            btnKeepFirst.Size = new Size(92, 25);
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
            gbDirectory.Location = new Point(3, 3);
            gbDirectory.Name = "gbDirectory";
            gbDirectory.Size = new Size(1087, 100);
            gbDirectory.TabIndex = 0;
            gbDirectory.TabStop = false;
            gbDirectory.Text = "Directory";
            // 
            // lblUniqueFilesNumber
            // 
            lblUniqueFilesNumber.AutoSize = true;
            lblUniqueFilesNumber.Location = new Point(406, 77);
            lblUniqueFilesNumber.Name = "lblUniqueFilesNumber";
            lblUniqueFilesNumber.Size = new Size(36, 15);
            lblUniqueFilesNumber.TabIndex = 5;
            lblUniqueFilesNumber.Text = "NULL";
            // 
            // txbDirectory
            // 
            txbDirectory.Location = new Point(70, 16);
            txbDirectory.Name = "txbDirectory";
            txbDirectory.ReadOnly = true;
            txbDirectory.Size = new Size(963, 23);
            txbDirectory.TabIndex = 3;
            txbDirectory.TextChanged += txbDirectory_TextChanged;
            // 
            // lblUniqueFiles
            // 
            lblUniqueFiles.AutoSize = true;
            lblUniqueFiles.Location = new Point(326, 77);
            lblUniqueFiles.Name = "lblUniqueFiles";
            lblUniqueFiles.Size = new Size(74, 15);
            lblUniqueFiles.TabIndex = 4;
            lblUniqueFiles.Text = "Unique Files:";
            // 
            // lblDirectoryLabel
            // 
            lblDirectoryLabel.AutoSize = true;
            lblDirectoryLabel.Location = new Point(6, 19);
            lblDirectoryLabel.Name = "lblDirectoryLabel";
            lblDirectoryLabel.Size = new Size(58, 15);
            lblDirectoryLabel.TabIndex = 1;
            lblDirectoryLabel.Text = "Directory:";
            // 
            // lblTotalFilesNumber
            // 
            lblTotalFilesNumber.AutoSize = true;
            lblTotalFilesNumber.Location = new Point(406, 61);
            lblTotalFilesNumber.Name = "lblTotalFilesNumber";
            lblTotalFilesNumber.Size = new Size(36, 15);
            lblTotalFilesNumber.TabIndex = 3;
            lblTotalFilesNumber.Text = "NULL";
            // 
            // btnChooseDirectory
            // 
            btnChooseDirectory.Location = new Point(6, 49);
            btnChooseDirectory.Name = "btnChooseDirectory";
            btnChooseDirectory.Size = new Size(94, 47);
            btnChooseDirectory.TabIndex = 0;
            btnChooseDirectory.Text = "Choose Directory";
            btnChooseDirectory.UseVisualStyleBackColor = true;
            btnChooseDirectory.Click += btnChooseDirectory_Click;
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.AutoSize = true;
            lblTotalFiles.Location = new Point(326, 61);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Size = new Size(62, 15);
            lblTotalFiles.TabIndex = 2;
            lblTotalFiles.Text = "Total Files:";
            // 
            // btnScanFolderOnly
            // 
            btnScanFolderOnly.Location = new Point(106, 49);
            btnScanFolderOnly.Name = "btnScanFolderOnly";
            btnScanFolderOnly.Size = new Size(94, 45);
            btnScanFolderOnly.TabIndex = 0;
            btnScanFolderOnly.Text = "Scan Folder Only";
            btnScanFolderOnly.UseVisualStyleBackColor = true;
            btnScanFolderOnly.Click += btnScanFolderOnly_Click;
            // 
            // btnScanFolderAndSubfolders
            // 
            btnScanFolderAndSubfolders.Location = new Point(206, 49);
            btnScanFolderAndSubfolders.Name = "btnScanFolderAndSubfolders";
            btnScanFolderAndSubfolders.Size = new Size(114, 45);
            btnScanFolderAndSubfolders.TabIndex = 1;
            btnScanFolderAndSubfolders.Text = "Scan Forlder and Subfolders";
            btnScanFolderAndSubfolders.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1134, 540);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimumSize = new Size(1040, 504);
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