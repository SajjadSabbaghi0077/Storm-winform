using Microsoft.SqlServer.Management.Smo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;

namespace Storm_winform
{
    public class UpdateJob
    {
        WebClient client;
        public event Action<string> Log;
        public UpdateJob()
        {
        }


        protected void OnLog(string message)
        {
            if (Log != null)
                Log(message);
        }
        public string PackageLocalPath { get; set; }
        public string BackupPath { get; set; }
        public bool BackupDatabase { get; set; }
        public bool BackupTinyApiBlobData { get; set; }
        public bool BackupConfigFiles { get; set; }
        public bool BackupExecutablesFiles { get; set; }
        public string PackageUrl { get; set; }
        public string InstalledPath { get; set; }

        public string richTextBoxLog { get; set; }

        public void Validate()
        {
            var errors = new List<ValidationError>();

            var readApiPath = FindDirectory(InstalledPath, "accounting-read-api", "accounting-readapi", "storm-readapi", "accounting-read-api");
            var writeApiPath = FindDirectory(InstalledPath, "accounting-write-api", "accounting-writeapi", "storm-writeapi", "accounting-write-api");
            var tinyApiPath = FindDirectory(InstalledPath, "accounting-tiny-api", "accounting-tinyapi", "storm-tinyapi", "accounting-tiny-api");
            var thirdPartyApiPath = FindDirectory(InstalledPath, "accounting-thirdparty-api", "accounting-thirdpartyapi", "accounting-third-party-api", "storm-thirdpartyapi", "accounting-thirdparty-api");
            var accountingPath = FindDirectory(InstalledPath + "\\web-ui", "accounting");
            var pettycashPath = FindDirectory(InstalledPath + "\\web-ui" + "pettycash");


            var readApiConfigPath = FindFile(readApiPath, "appsettings.json");
            var writeApiConfigPath = FindFile(writeApiPath, "appsettings.json");
            var tinyApiConfigPath = FindFile(tinyApiPath + "\\dist\\shared", "constant.js");
            var thirdPartyApiConfigPath = FindFile(thirdPartyApiPath + "\\dist", "constant.js");
            var accountingConfigPath = FindFile(accountingPath, "constants.js");
            var pettycashConfigPath = FindFile(pettycashPath, "constants.js");



            if (accountingPath is null)
                errors.Add(new ValidationError()
                {
                    Title = "Accounting Dashboard UI not found!",
                    Description = "Searching dirs : web-ui "
                });

            if (pettycashPath is null)
                errors.Add(new ValidationError()
                {
                    Title = "Accounting PettyCash UI not found!",
                    Description = "Searching dirs : web-ui "
                });

            if (readApiPath == null)
                errors.Add(new ValidationError()
                {
                    Title = "Accounting Read Api service not found!",
                    Description = "Searching dirs : accounting-read-api, accounting-readapi,accounting-read-api, storm-readapi."
                });

            if (writeApiPath == null)
                errors.Add(new ValidationError()
                {
                    Title = "Accounting Write Api service not found!",
                    Description = "Searching dirs : accounting-write-api, accounting-writeapi,accounting-write-api, storm-writeapi."
                });

            if (tinyApiPath == null)
                errors.Add(new ValidationError()
                {
                    Title = "Accounting Tiny Api service not found!",
                    Description = "Searching dirs : accounting-tiny-api, accounting-tinyapi, accounting-tiny-api , storm-tinyapi."
                });

            if (thirdPartyApiPath == null)
                errors.Add(new ValidationError()
                {
                    Title = "Accounting Third-party api service not found!",
                    Description = "Searching dirs : accounting-thirdparty-api, accounting-thirdpartyapi, accounting-third-party-api ,accounting-thirdparty-api, storm-thirdpartyapi."
                });

            if (accountingPath is null)
                errors.Add(new ValidationError() { Title = "Accounting constant.js file not found!", Description = $"Searching dirs : {accountingPath}\\constant.js" });

            if (pettycashPath is null)
                errors.Add(new ValidationError() { Title = "Pettycash constant.js file not found!", Description = $"Searching dirs : {accountingPath}\\constant.js" });

            if (readApiConfigPath == null)
                errors.Add(new ValidationError() { Title = "Read api .env file not found!", Description = $"Searching dirs : {readApiPath}\\appsettings.json" });

            if (writeApiConfigPath == null)
                errors.Add(new ValidationError() { Title = "Write api .env file not found!", Description = $"Searching dirs : {writeApiPath}\\appsettings.json" });

            if (tinyApiConfigPath == null)
                errors.Add(new ValidationError() { Title = "Tiny api .env file not found!", Description = $"Searching dirs : {tinyApiPath}\\dist\\shared\\constant.js" });

            if (thirdPartyApiConfigPath == null)
                errors.Add(new ValidationError() { Title = "Third party api .env file not found!", Description = $"Searching dirs : {thirdPartyApiPath}\\dist\\constant.js" });

            if (!Directory.Exists(BackupPath))
                errors.Add(new ValidationError() { Title = "Backup directory not found!", Description = $"Searching dirs : {BackupPath}" });

        }
        public void Start()
        {

            List<String> servicePath = new List<String>();
            //Finding service path
            var readApiPath = FindDirectory(InstalledPath, "accounting-read-api", "accounting-readapi", "storm-readapi", "accounting-read-api");
            var writeApiPath = FindDirectory(InstalledPath, "accounting-write-api", "accounting-writeapi", "storm-writeapi", "accounting-write-api");
            var tinyApiPath = FindDirectory(InstalledPath, "accounting-tiny-api", "accounting-tinyapi", "storm-tinyapi", "accounting-tiny-api");
            var thirdPartyApiPath = FindDirectory(InstalledPath, "accounting-thirdparty-api", "accounting-thirdpartyapi", "accounting-third-party-api", "storm-thirdpartyapi", "accounting-thirdparty-api");
            var accountingPath = FindDirectory(InstalledPath + "\\web-ui", "accounting");
            var pettycashPath = FindDirectory(InstalledPath + "\\web-ui", "pettycash");
            if (accountingPath is null)
                accountingPath = FindDirectory(InstalledPath, "accounting-dashboard");
            if (pettycashPath is null)
                pettycashPath = FindDirectory(InstalledPath, "accounting-pettycash");

            servicePath.Add(readApiPath);
            servicePath.Add(writeApiPath);
            servicePath.Add(tinyApiPath);
            servicePath.Add(thirdPartyApiPath);
            servicePath.Add(accountingPath);
            servicePath.Add(pettycashPath);

            //Finding service config path
            var readApiConfigPath = FindFile(readApiPath, "appsettings.json");
            var readApiConfigPathPg = FindFile(readApiPath, ".env");
            var writeApiConfigPath = FindFile(writeApiPath, "appsettings.json");
            var writeApiConfigPathPg = FindFile(writeApiPath, ".env");
            var tinyApiConfigPath = FindFile(tinyApiPath + "\\dist\\shared", "constant.js");
            var tinyApiConfigPathPg = FindFile(tinyApiPath + ".env");
            var thirdPartyApiConfigPath = FindFile(thirdPartyApiPath + "\\dist", "constant.js");
            var thirdPartyApiConfigPathPg = FindFile(thirdPartyApiPath + ".env");
            var accountingConfigPath = FindFile(accountingPath, "constants.js");
            var pettycashConfigPath = FindFile(pettycashPath, "constants.js");


            var backupDirectoryName = "BackUp_Config";
            var readDirectoryName = BackupPath + "\\" + backupDirectoryName + "\\" + Path.GetFileName(readApiPath);
            var writeDirectoryName = BackupPath + "\\" + backupDirectoryName + "\\" + Path.GetFileName(writeApiPath);
            var tinyDirectoryName = BackupPath + "\\" + backupDirectoryName + "\\" + Path.GetFileName(tinyApiPath);
            var thirdPartyDirectoryName = BackupPath + "\\" + backupDirectoryName + "\\" + Path.GetFileName(thirdPartyApiPath);
            var accountingDirectoryName = BackupPath + "\\" + backupDirectoryName + "\\" + Path.GetFileName(accountingPath);
            var pettycashPathDirectoryName = BackupPath + "\\" + backupDirectoryName + "\\" + Path.GetFileName(pettycashPath);

            Directory.CreateDirectory(BackupPath + "\\" + backupDirectoryName);
            Directory.CreateDirectory(readDirectoryName);
            Directory.CreateDirectory(writeDirectoryName);
            Directory.CreateDirectory(tinyDirectoryName);
            Directory.CreateDirectory(thirdPartyDirectoryName);
            Directory.CreateDirectory(accountingDirectoryName);
            Directory.CreateDirectory(pettycashPathDirectoryName);

            if (readApiConfigPath != null)
                File.Copy(readApiConfigPath, readDirectoryName + "\\" + Path.GetFileName(readApiConfigPath), true);
            if (readApiConfigPathPg != null)
                File.Copy(readApiConfigPathPg, readDirectoryName + "\\" + Path.GetFileName(readApiConfigPathPg), true);
            if (writeApiConfigPath != null)
                File.Copy(writeApiConfigPath, writeDirectoryName + "\\" + Path.GetFileName(writeApiConfigPath), true);
            if (writeApiConfigPathPg != null)
                File.Copy(writeApiConfigPathPg, writeDirectoryName + "\\" + Path.GetFileName(writeApiConfigPathPg), true);
            if (tinyApiConfigPath != null)
                File.Copy(tinyApiConfigPath, tinyDirectoryName + "\\" + Path.GetFileName(tinyApiConfigPath), true);
            if (tinyApiConfigPathPg != null)
                File.Copy(tinyApiConfigPathPg, tinyDirectoryName + "\\" + Path.GetFileName(tinyApiConfigPathPg), true);
            if (thirdPartyApiConfigPath != null)
                File.Copy(thirdPartyApiConfigPath, thirdPartyDirectoryName + "\\" + Path.GetFileName(thirdPartyApiConfigPath), true);
            if (thirdPartyApiConfigPathPg != null)
                File.Copy(thirdPartyApiConfigPathPg, thirdPartyDirectoryName + "\\" + Path.GetFileName(thirdPartyApiConfigPathPg), true);
            File.Copy(accountingConfigPath, accountingDirectoryName + "\\" + Path.GetFileName(accountingConfigPath), true);
            if (pettycashConfigPath != null)
                File.Copy(pettycashConfigPath, pettycashPathDirectoryName + "\\" + Path.GetFileName(pettycashConfigPath), true);

            //var zipFilePath = GetZipFilePath(BackupPath);

            //try
            //{
            //    ZipDirectory(servicePath, zipFilePath, BackupPath);
            //}
            //catch (Exception ex)
            //{

            //}

            var accountingConnectionString = GetValueFromAppsettings(readApiConfigPath);

            if (BackupDatabase)
            {
                try
                {
                    var rootBackupPath = Path.Combine(BackupPath, $"{DateTime.Now:yyyyMMdd-HHmmss}");
                    var dbBackupPath = Path.Combine(rootBackupPath, "Databases");
                    BackupSQLDb(accountingConnectionString, dbBackupPath);
                }
                catch (Exception x)
                {
                    richTextBoxLog += x.ToString();
                }
            }


            var hhasjkfd = "ggwdfhjfgasjhfgasdgf";

















        }

        private string GetZipFilePath(string outputDir)
        {
            var file = Path.Combine(outputDir, $"storm-apps-{DateTime.Now.ToString("yyyyMMdd")}");

            int i = 1;

            while (File.Exists(file))
            {
                file = Path.Combine(outputDir, $"storm-apps-{DateTime.Now.ToString("yyyyMMdd")}-{i++}");
            }

            return file;
        }

        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("منبع پوشه وجود ندارد: " + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
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


        public static void ZipDirectory(List<string> directoryPaths, string directorybackupPath, string backupPath)
        {
            for (int i = 0; i < directoryPaths.Count; i++)
            {
                Directory.CreateDirectory(directorybackupPath);
                var FileName = Path.GetFileName(directoryPaths[i]);
                Directory.CreateDirectory(directorybackupPath + "\\" + FileName);
                DirectoryCopy(directoryPaths[i], directorybackupPath + "\\" + FileName, true);
            }
            var file = Path.Combine(backupPath, $"storm-apps-{DateTime.Now.ToString("yyyyMMdd")}.zip");

            ZipFile.CreateFromDirectory(directorybackupPath, file);

        }
       
        private void UpDating()
        {

        }

        private void Unzip()
        {

        }
        private void Downloading(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadDataAsync(uri, Application.StartupPath + "/" + fileName);
                });
                thread.Start();
            }
        }

        //private void BackupPostgresDb(string pgConnectionString, string pgBackupPath)
        //{
        //	var process = new Process();
        //	var startInfo = new ProcessStartInfo();
        //	startInfo.FileName = Path.Combine("PostgreSQL", "postgresql-backup.bat");
        //	//var host = options.Value.PostgreSQLHost;
        //	//var port = options.Value.PostgreSQLPort;
        //	//var user = options.Value.PostgreSQLUser;
        //	//var database = databaseName;
        //	//var outputPath = localDatabasePath;
        //}

      
        private void BackupSQLDb(string connString, string backupFilePath)
        {
            #region

            Directory.CreateDirectory(backupFilePath);
            // Create a new SQL connection object
            SqlConnection conn = new SqlConnection(connString);
            ServerConnection serverCon = new ServerConnection(conn);
            Server server = new Server(serverCon);
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connString);

            string databaseName = builder.InitialCatalog;
           
            // Open the connection
            conn.Open();

            // Create a new SQL backup object
            Backup sqlBackup = new Backup();

            // Set the backup object properties
            sqlBackup.Action = BackupActionType.Database;
            sqlBackup.BackupSetDescription = "BackUp of:" + databaseName + "on" + DateTime.Now.ToShortDateString();
            sqlBackup.BackupSetName = "Backup : " + databaseName;
            sqlBackup.ContinueAfterError =false;
            BackupDeviceItem destination = new BackupDeviceItem("C:\\BackUp\\20230418-143915\\Databases", DeviceType.File);
            sqlBackup.LogTruncation = BackupTruncateLogType.Truncate;
            sqlBackup.Devices.Add(destination);

            sqlBackup.Database = conn.Database;
            sqlBackup.SqlBackup(server);
           
        

            // Close the connection
            conn.Close();
            #endregion



            #region

            //// Create a new SQL connection object
            //using (SqlConnection connection = new SqlConnection(connString))
            //{
            //    // Open the connection
            //    connection.Open();

            //    // Create a new SQL command object
            //    using (SqlCommand command = new SqlCommand("BACKUP DATABASE New-Accounting TO DISK = @BackupFilePath", connection))
            //    {
            //        // Set the backup file path parameter
            //        command.Parameters.AddWithValue("@BackupFilePath", backupFilePath);

            //        // Execute the command
            //        command.ExecuteNonQuery();
            //    }

            //    // Close the connection
            //    connection.Close();
            //}
            #endregion
        }
        private string GetValueFromAppsettings(string appsettingsPath)
        {
            // Deserialize JSON file
            dynamic jsonData = JsonConvert.DeserializeObject(File.ReadAllText(appsettingsPath));

            string CONNECTION_STRING = jsonData.CONNECTION_STRING;

            return CONNECTION_STRING;
        }
        private string GetValueFromDotEnv(string dotEnvPath, string name)
        {
            var line = File.ReadAllLines(dotEnvPath)
                .Select(l => l.Trim())
                .Where(l => !string.IsNullOrWhiteSpace(l) && l.IndexOf("=") >= 0)
                .FirstOrDefault(l => l.Split("=")[0].Trim() == name);

            if (line == null)
                return null;

            return string.Join("=", line.Split("=").Skip(1));
        }
        public static string GetValueJson(string jsonPath, string path)
        {
            var json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(jsonPath));

            path.Split(".")
                .SkipLast(1)
                .ToList()
                .ForEach(i => json = (JObject)json[i]);

            return json[path.Split(".").Last()].ToString();
        }
        private string FindDirectory(string installedPath, params string[] dirs)
        {
            if (installedPath == null)
                return null;

            foreach (var subdirectory in dirs)
            {
                var p = Path.Combine(installedPath, subdirectory);

                if (Directory.Exists(p))
                    return p;
            }

            return null;
        }
        private string FindFile(string path, params string[] files)
        {
            if (path == null)
                return null;

            foreach (var file in files)
            {
                var p = Path.Combine(path, file);

                if (File.Exists(p))
                    return p;
            }

            return null;
        }
    }
}
