using DuplicateRemover.Objects;
using System.ComponentModel;

namespace DuplicateRemover
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        #region Form properties
        private List<UniqueFile> _uniqueFiles = new();
        private List<PhysicalFile> _physicalFiles = new();
        private enum States { NoFolderChosen, ReadyToScan, Scanning, ReadyToClean, Cleaning };

        private string? _directory = null;
        public string? Directory
        {
            get { return _directory; }
            set
            {
                _directory = value;
                OnPropertyChanged("Directory");
            }
        }

        private bool _includeSubfolders = false;
        public bool IncludeSubfolders
        {
            get { return _includeSubfolders; }
            set
            {
                _includeSubfolders = value;
                OnPropertyChanged("IncludeSubfolders");
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

            txbDirectory.DataBindings.Add("Text", this, "Directory", false, DataSourceUpdateMode.OnPropertyChanged);
            cbIncludeSubfolders.DataBindings.Add("Checked", this, "IncludeSubfolders", false, DataSourceUpdateMode.OnPropertyChanged);

            bsUniqueFiles.DataSource = _uniqueFiles;
            dgUniqueFiles.Refresh();
            dgUniqueFiles.RefreshEdit();


            bsPhysicalFiles.DataSource = _physicalFiles;
            dgPhysicalFiles.Refresh();
            dgPhysicalFiles.RefreshEdit();
        }

        #region Form Events
        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Directory = folderDlg.SelectedPath;
                bsUniqueFiles.Clear();
                bsPhysicalFiles.Clear();
                UpdateFormState(States.ReadyToScan);
            }
            if (_directory != null && txbDirectory.Text != string.Empty)
            {
                cbIncludeSubfolders.Enabled = true;
                btnScan.Enabled = true;
            }
        }

        private void btnShowFilePaths_Click(object sender, EventArgs e)
        {

        }

        private void txbDirectory_TextChanged(object sender, EventArgs e)
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
                    btnChooseDirectory.Enabled = true;
                    cbIncludeSubfolders.Enabled = false;
                    btnScan.Enabled = false;
                    btnShowFilePaths.Enabled = false;
                    break;
                case States.ReadyToScan:
                    btnChooseDirectory.Enabled = true;
                    cbIncludeSubfolders.Enabled = true;
                    btnScan.Enabled = true;
                    btnShowFilePaths.Enabled = false;
                    break;
                case States.Scanning:
                    btnChooseDirectory.Enabled = false;
                    cbIncludeSubfolders.Enabled = false;
                    btnScan.Enabled = false;
                    btnShowFilePaths.Enabled = false;
                    break;
                case States.ReadyToClean:
                    btnChooseDirectory.Enabled = true;
                    cbIncludeSubfolders.Enabled = true;
                    btnScan.Enabled = true;
                    btnShowFilePaths.Enabled = true;
                    break;
                case States.Cleaning:
                    btnChooseDirectory.Enabled = false;
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
        #endregion

        #region Background Workers
        private void bwScan_DoWork(object sender, DoWorkEventArgs e)
        {
            AppendTextToLogger("Scanning folder...", null, FontStyle.Bold);
            //ScanFolder();
        }
        private void bwScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        private void bwScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateFormState(States.ReadyToClean);
        }
        #endregion
    }
}
