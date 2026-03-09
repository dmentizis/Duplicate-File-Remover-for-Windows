using DuplicateRemover.Objects;
using System.ComponentModel;

namespace DuplicateRemover
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        #region Form properties
        private List<UniqueFile> _uniqueFiles = new();
        private List<PhysicalFile> _physicalFiles = new();

        private string _totalFilesNumberText = string.Empty;
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TotalFilesNumberText
        {
            get => _totalFilesNumberText;
            set
            {
                _totalFilesNumberText = value;
                OnPropertyChanged(nameof(TotalFilesNumberText));
            }
        }

        private string _uniqueFilesNumberText = string.Empty;
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UniqueFilesNumberText
        {
            get => _uniqueFilesNumberText;
            set 
            {
                _uniqueFilesNumberText = value;
                OnPropertyChanged(nameof(UniqueFilesNumberText));
            }
        }
        private enum States { NoFolderChosen, ReadyToScan, Scanning, ReadyToClean, Cleaning };

        private string? _scanPath = null;
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? ScanPath
        {
            get => _scanPath;
            set
            {
                _scanPath = value;
                OnPropertyChanged(nameof(ScanPath));
            }
        }

        private bool _includeSubfolders = false;
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IncludeSubfolders
        {
            get => _includeSubfolders;
            set
            {
                _includeSubfolders = value;
                OnPropertyChanged(nameof(IncludeSubfolders));
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            UpdateFormState(States.NoFolderChosen);

            lblTotalFilesNumber.DataBindings.Add("Text", this, "TotalFilesNumberText", false, DataSourceUpdateMode.OnPropertyChanged);
            lblUniqueFilesNumber.DataBindings.Add("Text", this, "UniqueFilesNumberText", false, DataSourceUpdateMode.OnPropertyChanged);

            txbScanPath.DataBindings.Add("Text", this, "ScanPath", false, DataSourceUpdateMode.OnPropertyChanged);
            cbIncludeSubfolders.DataBindings.Add("Checked", this, "IncludeSubfolders", false, DataSourceUpdateMode.OnPropertyChanged);

            bsUniqueFiles.DataSource = _uniqueFiles;
            dgUniqueFiles.Refresh();
            dgUniqueFiles.RefreshEdit();


            bsPhysicalFiles.DataSource = _physicalFiles;
            dgPhysicalFiles.Refresh();
            dgPhysicalFiles.RefreshEdit();
        }

        #region Form Events
        private void btnChooseScanPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ScanPath = folderDlg.SelectedPath;
                bsUniqueFiles.Clear();
                bsPhysicalFiles.Clear();
                UpdateFormState(States.ReadyToScan);
            }
            if (_scanPath != null && txbScanPath.Text != string.Empty)
            {
                cbIncludeSubfolders.Enabled = true;
                btnScan.Enabled = true;
            }
        }

        private void btnShowFilePaths_Click(object sender, EventArgs e)
        {

        }

        private void txbScanPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScanFolderOnly_Click(object sender, EventArgs e)
        {
            bsUniqueFiles.Clear();
            bsPhysicalFiles.Clear();

            UpdateFormState(States.Scanning);

            if (!bwScan.IsBusy)
            {
                bwScan.RunWorkerAsync();
            }

            UpdateFormState(States.ReadyToClean);
        }
        #endregion

        #region Private Methods
        private void UpdateFormState(States state)
        {
            switch (state)
            {
                case States.NoFolderChosen:
                    btnChooseScanPath.Enabled = true;
                    cbIncludeSubfolders.Enabled = false;
                    btnScan.Enabled = false;
                    btnShowFilePaths.Enabled = false;
                    break;
                case States.ReadyToScan:
                    btnChooseScanPath.Enabled = true;
                    cbIncludeSubfolders.Enabled = true;
                    btnScan.Enabled = true;
                    btnShowFilePaths.Enabled = false;
                    break;
                case States.Scanning:
                    btnChooseScanPath.Enabled = false;
                    cbIncludeSubfolders.Enabled = false;
                    btnScan.Enabled = false;
                    btnShowFilePaths.Enabled = false;
                    break;
                case States.ReadyToClean:
                    btnChooseScanPath.Enabled = true;
                    cbIncludeSubfolders.Enabled = true;
                    btnScan.Enabled = true;
                    btnShowFilePaths.Enabled = true;
                    break;
                case States.Cleaning:
                    btnChooseScanPath.Enabled = false;
                    cbIncludeSubfolders.Enabled = false;
                    btnScan.Enabled = false;
                    btnShowFilePaths.Enabled = false;
                    break;
            }
        }

        private void LoadTestingData()
        {
            _uniqueFiles.Add(new UniqueFile() { Hash = "Hash1", Paths = new List<string>() { "Path1", "Path2" } });
            _uniqueFiles.Add(new UniqueFile() { Hash = "Hash2", Paths = new List<string>() { "Path3" } });
            _uniqueFiles.Add(new UniqueFile() { Hash = "Hash3", Paths = new List<string>() { "Path4" } });

            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash1", Path = "Path1" });
            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash1", Path = "Path2" });
            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash2", Path = "Path3" });
            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash3", Path = "Path4" });
        }

        public void AppendTextToLogger(string text, Color? color = null, FontStyle? fontStyle = null, float? fontSize = null)
        {
            if (rtbLogger.InvokeRequired)
            {
                rtbLogger.Invoke(new Action<string, Color?, FontStyle?, float?>(AppendTextToLogger), text, color, fontStyle, fontSize);
            }
            else
            {
                // Set the default color if none is provided
                Color textColor = color ?? rtbLogger.ForeColor;

                // Create a new font based on the provided parameters
                Font currentFont = rtbLogger.Font;
                FontStyle style = fontStyle ?? currentFont.Style;
                float size = fontSize ?? currentFont.Size;
                Font newFont = new Font(currentFont.FontFamily, size, style);

                // Save the current selection start and length
                int selectionStart = rtbLogger.TextLength;
                int selectionLength = text.Length;

                // Append the text
                rtbLogger.AppendText(text + Environment.NewLine);

                // Apply the color and font to the appended text
                rtbLogger.Select(selectionStart, selectionLength);
                rtbLogger.SelectionColor = textColor;
                rtbLogger.SelectionFont = newFont;

                // Deselect the text
                rtbLogger.SelectionLength = 0;

                // Scroll to the caret
                rtbLogger.ScrollToCaret();
            }
        }

        private void ShowMessage(string message, string caption = "Information", MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string, MessageBoxIcon>(ShowMessage), message, caption, icon);
            }
            else
            {
                MessageBox.Show(this, message, caption, MessageBoxButtons.OK, icon);
            }
        }
        #endregion

        #region Background Workers
        private void bwScan_DoWork(object sender, DoWorkEventArgs e)
        {
            AppendTextToLogger("Scanning folder...", null, FontStyle.Bold);

            if (string.IsNullOrWhiteSpace(ScanPath) || !Directory.Exists(ScanPath))
            {
                AppendTextToLogger("Scan path is invalid!", Color.Red, FontStyle.Bold);
                return;
            }
        }
        private void bwScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        private void bwScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AppendTextToLogger("Scan completed!", null, FontStyle.Bold);
            MessageBox.Show("Scan completed!");

            UpdateFormState(States.ReadyToClean);
        }
        #endregion
    }
}
