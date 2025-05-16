using System.IO.Compression;

namespace SAVE_GAMES
{
    public partial class MainForm : Form
    {
        private List<(string, string)> mFolders = new();
        private int mSelectedFolderIndex = -1;

        private void RegisterFolders()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string localLowPath = Path.Combine(userProfile, "AppData", "LocalLow");
            string folderMoon = Path.Combine(localLowPath, "Moon Studios");

            mFolders.Add(new(folderMoon, "MoonStudios"));

            string folderExperimental = @"c:\urgentdev_v2\resources\views\pages\experimental\";
            mFolders.Add(new(folderExperimental, "experimental"));

            mSelectedFolderIndex = 0;
        }

        public MainForm()
        {
            InitializeComponent();

            RegisterFolders();

            this.CenterToParent();
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
                throw new DirectoryNotFoundException("Source directory does not exist: " + sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destDirName);

            foreach (FileInfo file in dir.GetFiles())
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void btnSaveMoon_Click(object sender, EventArgs e)
        {
            string folder = mFolders[mSelectedFolderIndex].Item1;
            string archiveName = mFolders[mSelectedFolderIndex].Item2;

            if (!Directory.Exists(folder))
            {
                MessageBox.Show($"The folder \"{folder}\" was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                saveDialog.Filter = "ZIP archive (*.zip)|*.zip";

                saveDialog.Title = "{archiveName} Archive";
                saveDialog.FileName = $"{archiveName}_{timestamp}.zip";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationZipPath = saveDialog.FileName;

                    try
                    {
                        if (Directory.Exists(folder))
                        {
                            string tempRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                            string tempFolder = Path.Combine(tempRoot, "Moon Studios");

                            btnArchiveFolder.Enabled = false;

                            DirectoryCopy(folder, tempFolder, true);
                            ZipFile.CreateFromDirectory(tempRoot, destinationZipPath);
                            Directory.Delete(tempRoot, true);

                            btnArchiveFolder.Enabled = true;
                            MessageBox.Show("Archive saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show($"The folder \"{folder}\" was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error archiving folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoadMoon_Click(object sender, EventArgs e)
        {
            mSelectedFolderIndex = 0;
            txtFolder.Text = mFolders[mSelectedFolderIndex].Item1;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnExperimental_Click(object sender, EventArgs e)
        {
            mSelectedFolderIndex = 1;
            txtFolder.Text = mFolders[mSelectedFolderIndex].Item1;
        }
    }
}
