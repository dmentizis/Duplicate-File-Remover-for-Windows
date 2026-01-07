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
            GroupBox gbExecution;
            btnCancel = new Button();
            progressBar1 = new ProgressBar();
            rtbLogger = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbUniqueFiles = new GroupBox();
            btnShowSinlges = new Button();
            btnShowDuplicates = new Button();
            btnShowAll = new Button();
            btnAutoClean = new Button();
            btnShowFilePaths = new Button();
            gbPhysicalFiles = new GroupBox();
            btnKeepSelected = new Button();
            btnDeleteSelected = new Button();
            btnKeepFirst = new Button();
            lbPaths = new ListBox();
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
            gbPhysicalFiles.SuspendLayout();
            gbDirectory.SuspendLayout();
            SuspendLayout();
            // 
            // gbExecution
            // 
            tableLayoutPanel1.SetColumnSpan(gbExecution, 2);
            gbExecution.Controls.Add(btnCancel);
            gbExecution.Controls.Add(progressBar1);
            gbExecution.Controls.Add(rtbLogger);
            gbExecution.Location = new Point(3, 680);
            gbExecution.Name = "gbExecution";
            gbExecution.Size = new Size(1048, 114);
            gbExecution.TabIndex = 4;
            gbExecution.TabStop = false;
            gbExecution.Text = "Execution";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(966, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 336);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(966, 23);
            progressBar1.TabIndex = 1;
            // 
            // rtbLogger
            // 
            rtbLogger.Location = new Point(6, 18);
            rtbLogger.Name = "rtbLogger";
            rtbLogger.Size = new Size(966, 204);
            rtbLogger.TabIndex = 0;
            rtbLogger.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.45283F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.54717F));
            tableLayoutPanel1.Controls.Add(gbUniqueFiles, 0, 1);
            tableLayoutPanel1.Controls.Add(gbExecution, 0, 2);
            tableLayoutPanel1.Controls.Add(gbPhysicalFiles, 1, 1);
            tableLayoutPanel1.Controls.Add(gbDirectory, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4401779F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.55982F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.Size = new Size(1060, 797);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // gbUniqueFiles
            // 
            gbUniqueFiles.Controls.Add(btnShowSinlges);
            gbUniqueFiles.Controls.Add(btnShowDuplicates);
            gbUniqueFiles.Controls.Add(btnShowAll);
            gbUniqueFiles.Controls.Add(btnAutoClean);
            gbUniqueFiles.Controls.Add(btnShowFilePaths);
            gbUniqueFiles.Location = new Point(3, 182);
            gbUniqueFiles.Name = "gbUniqueFiles";
            gbUniqueFiles.Size = new Size(542, 277);
            gbUniqueFiles.TabIndex = 2;
            gbUniqueFiles.TabStop = false;
            gbUniqueFiles.Text = "Unique Items";
            // 
            // btnShowSinlges
            // 
            btnShowSinlges.Location = new Point(12, 153);
            btnShowSinlges.Name = "btnShowSinlges";
            btnShowSinlges.Size = new Size(153, 23);
            btnShowSinlges.TabIndex = 7;
            btnShowSinlges.Text = "Show Only Sinlge Entries";
            btnShowSinlges.UseVisualStyleBackColor = true;
            // 
            // btnShowDuplicates
            // 
            btnShowDuplicates.Location = new Point(252, 153);
            btnShowDuplicates.Name = "btnShowDuplicates";
            btnShowDuplicates.Size = new Size(123, 23);
            btnShowDuplicates.TabIndex = 6;
            btnShowDuplicates.Text = "Show Duplicates";
            btnShowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(171, 153);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnAutoClean
            // 
            btnAutoClean.Location = new Point(467, 144);
            btnAutoClean.Name = "btnAutoClean";
            btnAutoClean.Size = new Size(75, 23);
            btnAutoClean.TabIndex = 4;
            btnAutoClean.Text = "Auto Clean";
            btnAutoClean.UseVisualStyleBackColor = true;
            // 
            // btnShowFilePaths
            // 
            btnShowFilePaths.Location = new Point(381, 153);
            btnShowFilePaths.Name = "btnShowFilePaths";
            btnShowFilePaths.Size = new Size(80, 23);
            btnShowFilePaths.TabIndex = 3;
            btnShowFilePaths.Text = "Show Paths";
            btnShowFilePaths.UseVisualStyleBackColor = true;
            btnShowFilePaths.Click += btnShowFilePaths_Click;
            // 
            // gbPhysicalFiles
            // 
            gbPhysicalFiles.Controls.Add(btnKeepSelected);
            gbPhysicalFiles.Controls.Add(btnDeleteSelected);
            gbPhysicalFiles.Controls.Add(btnKeepFirst);
            gbPhysicalFiles.Controls.Add(lbPaths);
            gbPhysicalFiles.Location = new Point(559, 182);
            gbPhysicalFiles.Name = "gbPhysicalFiles";
            gbPhysicalFiles.Size = new Size(492, 277);
            gbPhysicalFiles.TabIndex = 2;
            gbPhysicalFiles.TabStop = false;
            gbPhysicalFiles.Text = "Physical Files";
            // 
            // btnKeepSelected
            // 
            btnKeepSelected.Location = new Point(324, 186);
            btnKeepSelected.Name = "btnKeepSelected";
            btnKeepSelected.Size = new Size(100, 25);
            btnKeepSelected.TabIndex = 7;
            btnKeepSelected.Text = "Keep Selected";
            btnKeepSelected.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(169, 189);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(100, 25);
            btnDeleteSelected.TabIndex = 6;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // btnKeepFirst
            // 
            btnKeepFirst.Location = new Point(6, 186);
            btnKeepFirst.Name = "btnKeepFirst";
            btnKeepFirst.Size = new Size(79, 25);
            btnKeepFirst.TabIndex = 5;
            btnKeepFirst.Text = "Keep First";
            btnKeepFirst.UseVisualStyleBackColor = true;
            // 
            // lbPaths
            // 
            lbPaths.FormattingEnabled = true;
            lbPaths.ItemHeight = 15;
            lbPaths.Location = new Point(6, 22);
            lbPaths.Name = "lbPaths";
            lbPaths.Size = new Size(480, 154);
            lbPaths.TabIndex = 4;
            // 
            // gbDirectory
            // 
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
            gbDirectory.Size = new Size(1048, 173);
            gbDirectory.TabIndex = 0;
            gbDirectory.TabStop = false;
            gbDirectory.Text = "Directory";
            // 
            // lblUniqueFilesNumber
            // 
            lblUniqueFilesNumber.AutoSize = true;
            lblUniqueFilesNumber.Location = new Point(92, 147);
            lblUniqueFilesNumber.Name = "lblUniqueFilesNumber";
            lblUniqueFilesNumber.Size = new Size(36, 15);
            lblUniqueFilesNumber.TabIndex = 5;
            lblUniqueFilesNumber.Text = "NULL";
            // 
            // txbDirectory
            // 
            txbDirectory.Location = new Point(80, 51);
            txbDirectory.Name = "txbDirectory";
            txbDirectory.ReadOnly = true;
            txbDirectory.Size = new Size(962, 23);
            txbDirectory.TabIndex = 3;
            txbDirectory.TextChanged += txbDirectory_TextChanged;
            // 
            // lblUniqueFiles
            // 
            lblUniqueFiles.AutoSize = true;
            lblUniqueFiles.Location = new Point(12, 147);
            lblUniqueFiles.Name = "lblUniqueFiles";
            lblUniqueFiles.Size = new Size(74, 15);
            lblUniqueFiles.TabIndex = 4;
            lblUniqueFiles.Text = "Unique Files:";
            // 
            // lblDirectoryLabel
            // 
            lblDirectoryLabel.AutoSize = true;
            lblDirectoryLabel.Location = new Point(6, 59);
            lblDirectoryLabel.Name = "lblDirectoryLabel";
            lblDirectoryLabel.Size = new Size(58, 15);
            lblDirectoryLabel.TabIndex = 1;
            lblDirectoryLabel.Text = "Directory:";
            // 
            // lblTotalFilesNumber
            // 
            lblTotalFilesNumber.AutoSize = true;
            lblTotalFilesNumber.Location = new Point(80, 132);
            lblTotalFilesNumber.Name = "lblTotalFilesNumber";
            lblTotalFilesNumber.Size = new Size(36, 15);
            lblTotalFilesNumber.TabIndex = 3;
            lblTotalFilesNumber.Text = "NULL";
            // 
            // btnChooseDirectory
            // 
            btnChooseDirectory.Location = new Point(6, 22);
            btnChooseDirectory.Name = "btnChooseDirectory";
            btnChooseDirectory.Size = new Size(75, 23);
            btnChooseDirectory.TabIndex = 0;
            btnChooseDirectory.Text = "Choose Directory";
            btnChooseDirectory.UseVisualStyleBackColor = true;
            btnChooseDirectory.Click += btnChooseDirectory_Click;
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.AutoSize = true;
            lblTotalFiles.Location = new Point(12, 132);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Size = new Size(62, 15);
            lblTotalFiles.TabIndex = 2;
            lblTotalFiles.Text = "Total Files:";
            // 
            // btnScanFolderOnly
            // 
            btnScanFolderOnly.Location = new Point(6, 80);
            btnScanFolderOnly.Name = "btnScanFolderOnly";
            btnScanFolderOnly.Size = new Size(194, 49);
            btnScanFolderOnly.TabIndex = 0;
            btnScanFolderOnly.Text = "Scan Folder Only";
            btnScanFolderOnly.UseVisualStyleBackColor = true;
            btnScanFolderOnly.Click += btnScanFolderOnly_Click;
            // 
            // btnScanFolderAndSubfolders
            // 
            btnScanFolderAndSubfolders.Location = new Point(206, 80);
            btnScanFolderAndSubfolders.Name = "btnScanFolderAndSubfolders";
            btnScanFolderAndSubfolders.Size = new Size(194, 49);
            btnScanFolderAndSubfolders.TabIndex = 1;
            btnScanFolderAndSubfolders.Text = "Scan Forlder and Subfolders";
            btnScanFolderAndSubfolders.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 821);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            gbExecution.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            gbUniqueFiles.ResumeLayout(false);
            gbPhysicalFiles.ResumeLayout(false);
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
        private ListBox lbPaths;
    }
}