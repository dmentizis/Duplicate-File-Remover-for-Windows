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
            txbDirectory.DataBindings.Add("Text", this, "Directory", false, DataSourceUpdateMode.OnPropertyChanged);

            UpdateFormState(States.NoFolderChosen);

            _uniqueFiles.Add(new UniqueFile() { Hash = "Hash1", Paths = new List<string>() { "Path1", "Path2" } });
            _uniqueFiles.Add(new UniqueFile() { Hash = "Hash2", Paths = new List<string>() { "Path3" } });
            
            bsIncludeSubfolders.DataSource = _includeSubfolders;
            cbIncludeSubfolders.DataBindings.Add("Checked", this, "IncludeSubfolders", false, DataSourceUpdateMode.OnPropertyChanged);

            bsUniqueFiles.DataSource = _uniqueFiles;
            dgUniqueFiles.Refresh();
            dgUniqueFiles.RefreshEdit();

            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash1", Path = "Path1" });
            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash1", Path = "Path2" });
            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash2", Path = "Path3" });
            _physicalFiles.Add(new PhysicalFile() { Hash = "Hash3", Path = "Path4" });
            bsPhysicalFiles.DataSource = _physicalFiles;
            dgPhysicalFiles.Refresh();
            dgPhysicalFiles.RefreshEdit();
        }

        #region Form Events
        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //OnPropertyChanged("Directory");
                //_directory = folderDlg.SelectedPath;
                //txbDirectory.Text = _directory;
                //Environment.SpecialFolder root = folderDlg.RootFolder;
                Directory = folderDlg.SelectedPath;
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
        }
        #endregion

        #region Private Methods
        private void UpdateFormState(States state)
        {
            switch(state)
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
        #endregion
    }
}
