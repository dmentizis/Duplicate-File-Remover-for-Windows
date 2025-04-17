using System.ComponentModel;

namespace DuplicateRemover
{
    partial class Form1
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
            GroupBox gbExecution;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            btnCancel = new Button();
            progressBar1 = new ProgressBar();
            rtbLogger = new RichTextBox();
            gbDirectory = new GroupBox();
            txbDirectory = new TextBox();
            lblDirectoryLabel = new Label();
            btnChooseDirectory = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbOptions = new GroupBox();
            lblUniqueFilesNumber = new Label();
            lblUniqueFiles = new Label();
            lblTotalFilesNumber = new Label();
            lblTotalFiles = new Label();
            btnScanFolderAndSubfolders = new Button();
            btnScanFolderOnly = new Button();
            gbUniqueFiles = new GroupBox();
            btnShowSinlges = new Button();
            btnShowDuplicates = new Button();
            btnShowAll = new Button();
            btnAutoClean = new Button();
            btnShowFilePaths = new Button();
            lbUniqueFiles = new ListBox();
            gbPhysicalFiles = new GroupBox();
            btnKeepSelected = new Button();
            btnDeleteSelected = new Button();
            btnKeepFirst = new Button();
            lbPaths = new ListBox();
            backgroundWorker1 = new BackgroundWorker();
            gbExecution = new GroupBox();
            gbExecution.SuspendLayout();
            gbDirectory.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbOptions.SuspendLayout();
            gbUniqueFiles.SuspendLayout();
            gbPhysicalFiles.SuspendLayout();
            SuspendLayout();
            // 
            // gbExecution
            // 
            tableLayoutPanel1.SetColumnSpan(gbExecution, 2);
            gbExecution.Controls.Add(btnCancel);
            gbExecution.Controls.Add(progressBar1);
            gbExecution.Controls.Add(rtbLogger);
            gbExecution.Location = new Point(3, 346);
            gbExecution.Name = "gbExecution";
            gbExecution.Size = new Size(978, 242);
            gbExecution.TabIndex = 4;
            gbExecution.TabStop = false;
            gbExecution.Text = "Execution";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(966, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 174);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(966, 23);
            progressBar1.TabIndex = 1;
            // 
            // rtbLogger
            // 
            rtbLogger.Location = new Point(12, 22);
            rtbLogger.Name = "rtbLogger";
            rtbLogger.Size = new Size(966, 146);
            rtbLogger.TabIndex = 0;
            rtbLogger.Text = "";
            // 
            // gbDirectory
            // 
            gbDirectory.Controls.Add(txbDirectory);
            gbDirectory.Controls.Add(lblDirectoryLabel);
            gbDirectory.Controls.Add(btnChooseDirectory);
            gbDirectory.Location = new Point(3, 3);
            gbDirectory.Name = "gbDirectory";
            gbDirectory.Size = new Size(548, 91);
            gbDirectory.TabIndex = 0;
            gbDirectory.TabStop = false;
            gbDirectory.Text = "Directory";
            // 
            // txbDirectory
            // 
            txbDirectory.Location = new Point(80, 51);
            txbDirectory.Name = "txbDirectory";
            txbDirectory.ReadOnly = true;
            txbDirectory.Size = new Size(462, 23);
            txbDirectory.TabIndex = 3;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.0567F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.9433F));
            tableLayoutPanel1.Controls.Add(gbDirectory, 0, 0);
            tableLayoutPanel1.Controls.Add(gbOptions, 1, 0);
            tableLayoutPanel1.Controls.Add(gbUniqueFiles, 0, 1);
            tableLayoutPanel1.Controls.Add(gbExecution, 0, 2);
            tableLayoutPanel1.Controls.Add(gbPhysicalFiles, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.2080536F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.79195F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 247F));
            tableLayoutPanel1.Size = new Size(990, 591);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // gbOptions
            // 
            gbOptions.Controls.Add(lblUniqueFilesNumber);
            gbOptions.Controls.Add(lblUniqueFiles);
            gbOptions.Controls.Add(lblTotalFilesNumber);
            gbOptions.Controls.Add(lblTotalFiles);
            gbOptions.Controls.Add(btnScanFolderAndSubfolders);
            gbOptions.Controls.Add(btnScanFolderOnly);
            gbOptions.Location = new Point(557, 3);
            gbOptions.Name = "gbOptions";
            gbOptions.Size = new Size(430, 91);
            gbOptions.TabIndex = 3;
            gbOptions.TabStop = false;
            gbOptions.Text = "Options";
            // 
            // lblUniqueFilesNumber
            // 
            lblUniqueFilesNumber.AutoSize = true;
            lblUniqueFilesNumber.Location = new Point(293, 59);
            lblUniqueFilesNumber.Name = "lblUniqueFilesNumber";
            lblUniqueFilesNumber.Size = new Size(36, 15);
            lblUniqueFilesNumber.TabIndex = 5;
            lblUniqueFilesNumber.Text = "NULL";
            // 
            // lblUniqueFiles
            // 
            lblUniqueFiles.AutoSize = true;
            lblUniqueFiles.Location = new Point(158, 59);
            lblUniqueFiles.Name = "lblUniqueFiles";
            lblUniqueFiles.Size = new Size(74, 15);
            lblUniqueFiles.TabIndex = 4;
            lblUniqueFiles.Text = "Unique Files:";
            // 
            // lblTotalFilesNumber
            // 
            lblTotalFilesNumber.AutoSize = true;
            lblTotalFilesNumber.Location = new Point(73, 59);
            lblTotalFilesNumber.Name = "lblTotalFilesNumber";
            lblTotalFilesNumber.Size = new Size(36, 15);
            lblTotalFilesNumber.TabIndex = 3;
            lblTotalFilesNumber.Text = "NULL";
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.AutoSize = true;
            lblTotalFiles.Location = new Point(6, 59);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Size = new Size(62, 15);
            lblTotalFiles.TabIndex = 2;
            lblTotalFiles.Text = "Total Files:";
            // 
            // btnScanFolderAndSubfolders
            // 
            btnScanFolderAndSubfolders.Location = new Point(158, 22);
            btnScanFolderAndSubfolders.Name = "btnScanFolderAndSubfolders";
            btnScanFolderAndSubfolders.Size = new Size(163, 23);
            btnScanFolderAndSubfolders.TabIndex = 1;
            btnScanFolderAndSubfolders.Text = "Scan Forlder and Subfolders";
            btnScanFolderAndSubfolders.UseVisualStyleBackColor = true;
            btnScanFolderAndSubfolders.Click += btnScanFolderAndSubfolders_Click;
            // 
            // btnScanFolderOnly
            // 
            btnScanFolderOnly.Location = new Point(6, 22);
            btnScanFolderOnly.Name = "btnScanFolderOnly";
            btnScanFolderOnly.Size = new Size(114, 23);
            btnScanFolderOnly.TabIndex = 0;
            btnScanFolderOnly.Text = "Scan Folder Only";
            btnScanFolderOnly.UseVisualStyleBackColor = true;
            btnScanFolderOnly.Click += btnScanFolderOnly_Click;
            // 
            // gbUniqueFiles
            // 
            gbUniqueFiles.Controls.Add(btnShowSinlges);
            gbUniqueFiles.Controls.Add(btnShowDuplicates);
            gbUniqueFiles.Controls.Add(btnShowAll);
            gbUniqueFiles.Controls.Add(btnAutoClean);
            gbUniqueFiles.Controls.Add(btnShowFilePaths);
            gbUniqueFiles.Controls.Add(lbUniqueFiles);
            gbUniqueFiles.Location = new Point(3, 110);
            gbUniqueFiles.Name = "gbUniqueFiles";
            gbUniqueFiles.Size = new Size(542, 230);
            gbUniqueFiles.TabIndex = 2;
            gbUniqueFiles.TabStop = false;
            gbUniqueFiles.Text = "Unique Items";
            // 
            // btnShowSinlges
            // 
            btnShowSinlges.Location = new Point(216, 182);
            btnShowSinlges.Name = "btnShowSinlges";
            btnShowSinlges.Size = new Size(153, 23);
            btnShowSinlges.TabIndex = 7;
            btnShowSinlges.Text = "Show Only Sinlge Entries";
            btnShowSinlges.UseVisualStyleBackColor = true;
            btnShowSinlges.Click += btnShowSinlges_Click;
            // 
            // btnShowDuplicates
            // 
            btnShowDuplicates.Location = new Point(87, 182);
            btnShowDuplicates.Name = "btnShowDuplicates";
            btnShowDuplicates.Size = new Size(123, 23);
            btnShowDuplicates.TabIndex = 6;
            btnShowDuplicates.Text = "Show Duplicates";
            btnShowDuplicates.UseVisualStyleBackColor = true;
            btnShowDuplicates.Click += btnShowDuplicates_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(6, 182);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnAutoClean
            // 
            btnAutoClean.Location = new Point(461, 182);
            btnAutoClean.Name = "btnAutoClean";
            btnAutoClean.Size = new Size(75, 23);
            btnAutoClean.TabIndex = 4;
            btnAutoClean.Text = "Auto Clean";
            btnAutoClean.UseVisualStyleBackColor = true;
            // 
            // btnShowFilePaths
            // 
            btnShowFilePaths.Location = new Point(375, 182);
            btnShowFilePaths.Name = "btnShowFilePaths";
            btnShowFilePaths.Size = new Size(80, 23);
            btnShowFilePaths.TabIndex = 3;
            btnShowFilePaths.Text = "Show Paths";
            btnShowFilePaths.UseVisualStyleBackColor = true;
            btnShowFilePaths.Click += btnShowFilePaths_Click;
            // 
            // lbUniqueFiles
            // 
            lbUniqueFiles.FormattingEnabled = true;
            lbUniqueFiles.ItemHeight = 15;
            lbUniqueFiles.Location = new Point(6, 22);
            lbUniqueFiles.Name = "lbUniqueFiles";
            lbUniqueFiles.Size = new Size(530, 154);
            lbUniqueFiles.TabIndex = 2;
            // 
            // gbPhysicalFiles
            // 
            gbPhysicalFiles.Controls.Add(btnKeepSelected);
            gbPhysicalFiles.Controls.Add(btnDeleteSelected);
            gbPhysicalFiles.Controls.Add(btnKeepFirst);
            gbPhysicalFiles.Controls.Add(lbPaths);
            gbPhysicalFiles.Location = new Point(557, 110);
            gbPhysicalFiles.Name = "gbPhysicalFiles";
            gbPhysicalFiles.Size = new Size(430, 230);
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
            lbPaths.Size = new Size(418, 154);
            lbPaths.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 610);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Duplicate File Remover";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            gbExecution.ResumeLayout(false);
            gbDirectory.ResumeLayout(false);
            gbDirectory.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            gbOptions.ResumeLayout(false);
            gbOptions.PerformLayout();
            gbUniqueFiles.ResumeLayout(false);
            gbPhysicalFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDirectory;
        private Button btnChooseDirectory;
        private Label lblDirectoryLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lbUniqueFiles;
        private GroupBox gbOptions;
        private Button btnScanFolderOnly;
        private Button btnScanFolderAndSubfolders;
        private GroupBox gbUniqueFiles;
        private Button btnShowFilePaths;
        private ListBox lbPaths;
        private TextBox txbDirectory;
        private Label lblUniqueFilesNumber;
        private Label lblUniqueFiles;
        private Label lblTotalFilesNumber;
        private Label lblTotalFiles;
        private GroupBox gbPhysicalFiles;
        private Button btnKeepSelected;
        private Button btnDeleteSelected;
        private Button btnKeepFirst;
        private Button btnAutoClean;
        private BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private RichTextBox rtbLogger;
        private Button btnCancel;
        private Button btnShowSinlges;
        private Button btnShowDuplicates;
        private Button btnShowAll;
    }
}
