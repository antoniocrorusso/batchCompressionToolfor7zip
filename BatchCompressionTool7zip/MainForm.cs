using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BatchCompressionTool7zip
{
    public partial class MainForm : Form
    {
        string sevenZipPath = @"C:\Program Files\7-Zip\7z.exe";
        string targetFolder = "";

        public MainForm()
        {
            InitializeComponent();
            Detect7Zip();
        }

        private void Detect7Zip()
        {
            if (!File.Exists(sevenZipPath))
            {
                MessageBox.Show("7-Zip not found at default path. Please locate it manually.");
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "7z.exe|7z.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sevenZipPath = ofd.FileName;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                targetFolder = fbd.SelectedPath;
                lblSelectedPath.Text = targetFolder;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(targetFolder))
            {
                MessageBox.Show("No Target folder selected");
                return;
            } 

            string extension = txtExtension.Text.Trim().ToLower();
            bool isFolderMode = rbtnFolders.Checked;

            string[] targets = isFolderMode ?
                Directory.GetDirectories(targetFolder) :
                Directory.GetFiles(targetFolder, $"*{extension}");

            foreach (var item in targets)
            {
                string name = Path.GetFileNameWithoutExtension(item);
                string zipPath = Path.Combine(targetFolder, name + ".zip");

                string args = $"a \"{zipPath}\" \"{item}\""; //Add the files to a sub-folder

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = sevenZipPath,
                    Arguments = args,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process proc = Process.Start(psi);
                proc.WaitForExit();
            }

            MessageBox.Show("Compression Complete!");
        }
    }
}
