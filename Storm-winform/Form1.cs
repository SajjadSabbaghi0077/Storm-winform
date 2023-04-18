using System.Net;

namespace Storm_winform
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();

            buttonNext1.Tag = new Func<bool>(ValidateInstalledPath);
            buttonNext2.Tag = new Func<bool>(ValidateBackup);
            buttonNext3.Tag = new Func<bool>(ValidateSourcePackage);


        }

        private bool ValidateSourcePackage()
        {
            if (radioButtonDownloadPackage.Checked && !UrlIsValid(comboBoxPackageUrl.Text))
            {
                errorProvider1.SetError(comboBoxPackageUrl, "Backup path not found.");
                return false;
            }
            else if (radioButtonLocalPackage.Checked && !File.Exists(comboBoxPackageLocalPath.Text))
            {
                errorProvider1.SetError(comboBoxPackageLocalPath, "Package file not found.");
                return false;
            }

            return true;
        }
        private bool ValidateBackup()
        {

            if ((checkBoxBackupTinyBlobData.Checked ||
                checkBoxBackupDatabase.Checked ||
                checkBoxBackupExecutables.Checked ||
                checkBoxBackupConfigs.Checked) &&
                !Directory.Exists(comboBoxBackupPath.Text))
            {
                errorProvider1.SetError(comboBoxBackupPath, "Backup path not found.");
                return false;
            }

            return true;
        }
        private void buttonBack2_Click(object sender, EventArgs e)
        {
            wizardPages1.SelectedIndex -= 1;
        }

        private bool ValidateInstalledPath()
        {
            if (!Directory.Exists(comboBoxInstalledPath.Text))
            {
                errorProvider1.SetError(comboBoxInstalledPath, "Storm services path not found.");
                return false;
            }

            return true;
        }

        private void buttonScanInstalledPath_Click_1(object sender, EventArgs e)
        {
            var paths = new string[]
            {
                @"c:\storm-apps",
                @"c:\storm-apps*",
                @"c:\hesabdari",
                @"c:\hesabdari*",
                @"c:\he+",
                @"c:\he"
            };

            List<string> result = Services.ScanDirectoriesForPattern(paths);

            comboBoxInstalledPath.Items.Clear();

            comboBoxInstalledPath.Items.AddRange(result.ToArray());

            if (comboBoxInstalledPath.Items.Count > 0)
                comboBoxInstalledPath.SelectedIndex = 0;

        }

        private void buttonBrowseInstalledPath_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.AutoUpgradeEnabled = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBoxInstalledPath.Text = dialog.SelectedPath;
            }
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            var button = ((Button)sender);

            if (button.Tag is Func<bool>)
            {
                if ((button.Tag as Func<bool>).Invoke())
                    wizardPages1.SelectedIndex += 1;
            }
            else
            {
                wizardPages1.SelectedIndex += 1;
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            var paths = new string[]
           {
                @"c:\storm-apps\backup",
                @"c:\backup",
                @"c:\backups",
                @"c:\storm-apps*\backup"
           };


            List<string> result = Services.ScanDirectoriesForPattern(paths);

            comboBoxBackupPath.Items.Clear();

            comboBoxBackupPath.Items.AddRange(result.ToArray());

            if (comboBoxBackupPath.Items.Count > 0)
                comboBoxBackupPath.SelectedIndex = 0;
        }

        private void buttonBrowseBackupPath_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.AutoUpgradeEnabled = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBoxBackupPath.Text = dialog.SelectedPath;
            }
        }

        private async void buttonCheckOnlinePackage_Click(object sender, EventArgs e)
        {
            var url = "http://sandbox.storm-online.ir:3000/releases/";

            var http = new HttpClient();

            http.BaseAddress = new Uri(url);
            var html = await http.GetStringAsync(string.Empty);

            var document = new HtmlAgilityPack.HtmlDocument();

            document.LoadHtml(html);

            var links = document.DocumentNode.SelectNodes("//a[@href]")
                .Where(a => a.GetAttributeValue("href", "/") != "/")
                .Select(a => "http://sandbox.storm-online.ir:3000" + a.GetAttributeValue("href", ""))
                .ToArray();

            comboBoxPackageUrl.Items.Clear();
            comboBoxPackageUrl.Items.AddRange(links);
        }

        private void buttonBrowseLocalPackage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.AutoUpgradeEnabled = true;
            dialog.Filter = "*.zip;*.tar;*.rar|*.zip;*.tar;*.rar";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buttonBrowseLocalPackage.Text = dialog.FileName;
            }
        }
        private bool UrlIsValid(string url)
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                request.Timeout = 5000; //set the timeout to 5 seconds to keep the user from waiting too long for the page to load
                request.Method = "HEAD"; //Get only the header information -- no need to download any content

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        return true;
                    }
                    else if (statusCode >= 500 && statusCode <= 510) //Server Errors
                    {
                        //log.Warn(String.Format("The remote server has thrown an internal error. Url is not valid: {0}", url));
                        //Debug.WriteLine(String.Format("The remote server has thrown an internal error. Url is not valid: {0}", url));
                        return false;
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError) //400 errors
                {
                    return false;
                }
                else
                {
                    //log.Warn(String.Format("Unhandled status [{0}] returned for url: {1}", ex.Status, url), ex);
                }
            }
            catch (Exception ex)
            {
                //log.Error(String.Format("Could not test url {0}.", url), ex);
            }
            return false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var job = new UpdateJob();
            string InstalledPath = "";
            string BackupPath = "";
            bool BackupDatabase = true;
            bool BackupTinyApiBlobData = true;
            bool BackupExecutablesFiles = true;
            bool BackupConfigFiles = true;
            string PackageLocalPath = "";
            string PackageUrl = "";




            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { InstalledPath = comboBoxInstalledPath.Text; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { BackupPath = comboBoxBackupPath.Text; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { BackupDatabase = checkBoxBackupConfigs.Checked; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { BackupTinyApiBlobData = checkBoxBackupTinyBlobData.Checked; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { BackupExecutablesFiles = checkBoxBackupExecutables.Checked; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { BackupConfigFiles = checkBoxBackupConfigs.Checked; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { PackageLocalPath = comboBoxPackageLocalPath.Text; }));
            comboBoxBackupPath.Invoke(new MethodInvoker(delegate { PackageUrl = comboBoxPackageUrl.Text; }));


            job.InstalledPath = InstalledPath;
            job.BackupPath = BackupPath;
            job.BackupDatabase = BackupDatabase;
            job.BackupTinyApiBlobData = BackupTinyApiBlobData;
            job.BackupExecutablesFiles = BackupExecutablesFiles;
            job.BackupConfigFiles = BackupConfigFiles;
            job.PackageLocalPath = PackageLocalPath;
            job.PackageUrl = PackageUrl;

            job.Log += Job_Log;

            job.Start();
        }
        private void Job_Log(string message)
        {
            Invoke(new Action(() =>
            {
                richTextBoxLog.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} - {message}\r\n");
            }));
        }
    }
}