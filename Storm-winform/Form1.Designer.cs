namespace Storm_winform
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wizardPages1 = new Storm_winform.WizardPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonScanInstalledPath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.buttonBrowseInstalledPath = new System.Windows.Forms.Button();
            this.comboBoxInstalledPath = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonBrowseBackupPath = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.comboBoxBackupPath = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxBackupExecutables = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupConfigs = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupTinyBlobData = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupDatabase = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNext3 = new System.Windows.Forms.Button();
            this.buttonBrowseLocalPackage = new System.Windows.Forms.Button();
            this.buttonCheckOnlinePackage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPackageLocalPath = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxPackageUrl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonLocalPackage = new System.Windows.Forms.RadioButton();
            this.radioButtonDownloadPackage = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.wizardPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // wizardPages1
            // 
            this.wizardPages1.Controls.Add(this.tabPage1);
            this.wizardPages1.Controls.Add(this.tabPage2);
            this.wizardPages1.Controls.Add(this.tabPage3);
            this.wizardPages1.Controls.Add(this.tabPage4);
            this.wizardPages1.Location = new System.Drawing.Point(2, 1);
            this.wizardPages1.Name = "wizardPages1";
            this.wizardPages1.SelectedIndex = 0;
            this.wizardPages1.Size = new System.Drawing.Size(786, 437);
            this.wizardPages1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonScanInstalledPath);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.buttonBrowseInstalledPath);
            this.tabPage1.Controls.Add(this.comboBoxInstalledPath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(580, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Please enter path of installed storm services, then click Next button.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.label5.Size = new System.Drawing.Size(235, 66);
            this.label5.TabIndex = 11;
            this.label5.Text = "Storm services path";
            // 
            // buttonScanInstalledPath
            // 
            this.buttonScanInstalledPath.Location = new System.Drawing.Point(605, 216);
            this.buttonScanInstalledPath.Name = "buttonScanInstalledPath";
            this.buttonScanInstalledPath.Size = new System.Drawing.Size(66, 23);
            this.buttonScanInstalledPath.TabIndex = 7;
            this.buttonScanInstalledPath.Text = "Scan";
            this.buttonScanInstalledPath.UseVisualStyleBackColor = true;
            this.buttonScanInstalledPath.Click += new System.EventHandler(this.buttonScanInstalledPath_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buttonNext1);
            this.panel1.Location = new System.Drawing.Point(24, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 33);
            this.panel1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(500, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(581, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "< Back";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonNext1
            // 
            this.buttonNext1.Location = new System.Drawing.Point(662, 3);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(75, 23);
            this.buttonNext1.TabIndex = 7;
            this.buttonNext1.Text = "Next >";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // buttonBrowseInstalledPath
            // 
            this.buttonBrowseInstalledPath.Location = new System.Drawing.Point(677, 216);
            this.buttonBrowseInstalledPath.Name = "buttonBrowseInstalledPath";
            this.buttonBrowseInstalledPath.Size = new System.Drawing.Size(32, 23);
            this.buttonBrowseInstalledPath.TabIndex = 5;
            this.buttonBrowseInstalledPath.Text = "...";
            this.buttonBrowseInstalledPath.UseVisualStyleBackColor = true;
            this.buttonBrowseInstalledPath.Click += new System.EventHandler(this.buttonBrowseInstalledPath_Click);
            // 
            // comboBoxInstalledPath
            // 
            this.comboBoxInstalledPath.FormattingEnabled = true;
            this.comboBoxInstalledPath.Location = new System.Drawing.Point(53, 216);
            this.comboBoxInstalledPath.Name = "comboBoxInstalledPath";
            this.comboBoxInstalledPath.Size = new System.Drawing.Size(549, 23);
            this.comboBoxInstalledPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Installed path:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.buttonBrowseBackupPath);
            this.tabPage2.Controls.Add(this.buttonScan);
            this.tabPage2.Controls.Add(this.comboBoxBackupPath);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkBoxBackupExecutables);
            this.tabPage2.Controls.Add(this.checkBoxBackupConfigs);
            this.tabPage2.Controls.Add(this.checkBoxBackupTinyBlobData);
            this.tabPage2.Controls.Add(this.checkBoxBackupDatabase);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 69);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(580, 22);
            this.label13.TabIndex = 39;
            this.label13.Text = "Please enter path of installed storm services, then click Next button.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.label14.Size = new System.Drawing.Size(126, 66);
            this.label14.TabIndex = 38;
            this.label14.Text = "Backup";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonBack2);
            this.panel2.Controls.Add(this.buttonNext2);
            this.panel2.Location = new System.Drawing.Point(32, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 29);
            this.panel2.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonBack2
            // 
            this.buttonBack2.Location = new System.Drawing.Point(581, 3);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(75, 23);
            this.buttonBack2.TabIndex = 7;
            this.buttonBack2.Text = "< Back";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(662, 3);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(75, 23);
            this.buttonNext2.TabIndex = 7;
            this.buttonNext2.Text = "Next >";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // buttonBrowseBackupPath
            // 
            this.buttonBrowseBackupPath.Location = new System.Drawing.Point(582, 248);
            this.buttonBrowseBackupPath.Name = "buttonBrowseBackupPath";
            this.buttonBrowseBackupPath.Size = new System.Drawing.Size(24, 23);
            this.buttonBrowseBackupPath.TabIndex = 36;
            this.buttonBrowseBackupPath.Text = "...";
            this.buttonBrowseBackupPath.UseVisualStyleBackColor = true;
            this.buttonBrowseBackupPath.Click += new System.EventHandler(this.buttonBrowseBackupPath_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(501, 249);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 35;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // comboBoxBackupPath
            // 
            this.comboBoxBackupPath.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBoxBackupPath, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.comboBoxBackupPath.Location = new System.Drawing.Point(72, 249);
            this.comboBoxBackupPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBackupPath.Name = "comboBoxBackupPath";
            this.comboBoxBackupPath.Size = new System.Drawing.Size(423, 23);
            this.comboBoxBackupPath.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(72, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Backup path:";
            // 
            // checkBoxBackupExecutables
            // 
            this.checkBoxBackupExecutables.AutoSize = true;
            this.checkBoxBackupExecutables.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBackupExecutables.Location = new System.Drawing.Point(72, 192);
            this.checkBoxBackupExecutables.Name = "checkBoxBackupExecutables";
            this.checkBoxBackupExecutables.Size = new System.Drawing.Size(189, 23);
            this.checkBoxBackupExecutables.TabIndex = 30;
            this.checkBoxBackupExecutables.Text = "Backup executable files";
            this.checkBoxBackupExecutables.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackupConfigs
            // 
            this.checkBoxBackupConfigs.AutoSize = true;
            this.checkBoxBackupConfigs.Checked = true;
            this.checkBoxBackupConfigs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackupConfigs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBackupConfigs.Location = new System.Drawing.Point(72, 167);
            this.checkBoxBackupConfigs.Name = "checkBoxBackupConfigs";
            this.checkBoxBackupConfigs.Size = new System.Drawing.Size(157, 23);
            this.checkBoxBackupConfigs.TabIndex = 29;
            this.checkBoxBackupConfigs.Text = "Backup config files";
            this.checkBoxBackupConfigs.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackupTinyBlobData
            // 
            this.checkBoxBackupTinyBlobData.AutoSize = true;
            this.checkBoxBackupTinyBlobData.Checked = true;
            this.checkBoxBackupTinyBlobData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackupTinyBlobData.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBackupTinyBlobData.Location = new System.Drawing.Point(72, 142);
            this.checkBoxBackupTinyBlobData.Name = "checkBoxBackupTinyBlobData";
            this.checkBoxBackupTinyBlobData.Size = new System.Drawing.Size(174, 23);
            this.checkBoxBackupTinyBlobData.TabIndex = 28;
            this.checkBoxBackupTinyBlobData.Text = "Backup tiny-api-data ";
            this.checkBoxBackupTinyBlobData.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackupDatabase
            // 
            this.checkBoxBackupDatabase.AutoSize = true;
            this.checkBoxBackupDatabase.Checked = true;
            this.checkBoxBackupDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackupDatabase.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBackupDatabase.Location = new System.Drawing.Point(72, 118);
            this.checkBoxBackupDatabase.Name = "checkBoxBackupDatabase";
            this.checkBoxBackupDatabase.Size = new System.Drawing.Size(145, 23);
            this.checkBoxBackupDatabase.TabIndex = 27;
            this.checkBoxBackupDatabase.Text = "Backup database";
            this.checkBoxBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.buttonBrowseLocalPackage);
            this.tabPage3.Controls.Add(this.buttonCheckOnlinePackage);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.comboBoxPackageLocalPath);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.comboBoxPackageUrl);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.radioButtonLocalPackage);
            this.tabPage3.Controls.Add(this.radioButtonDownloadPackage);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.buttonNext3);
            this.panel3.Location = new System.Drawing.Point(32, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 29);
            this.panel3.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "< Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonNext3
            // 
            this.buttonNext3.Location = new System.Drawing.Point(662, 3);
            this.buttonNext3.Name = "buttonNext3";
            this.buttonNext3.Size = new System.Drawing.Size(75, 23);
            this.buttonNext3.TabIndex = 7;
            this.buttonNext3.Text = "Next >";
            this.buttonNext3.UseVisualStyleBackColor = true;
            this.buttonNext3.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // buttonBrowseLocalPackage
            // 
            this.buttonBrowseLocalPackage.Location = new System.Drawing.Point(508, 264);
            this.buttonBrowseLocalPackage.Name = "buttonBrowseLocalPackage";
            this.buttonBrowseLocalPackage.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseLocalPackage.TabIndex = 41;
            this.buttonBrowseLocalPackage.Text = "Browse";
            this.buttonBrowseLocalPackage.UseVisualStyleBackColor = true;
            this.buttonBrowseLocalPackage.Click += new System.EventHandler(this.buttonBrowseLocalPackage_Click);
            // 
            // buttonCheckOnlinePackage
            // 
            this.buttonCheckOnlinePackage.Location = new System.Drawing.Point(508, 170);
            this.buttonCheckOnlinePackage.Name = "buttonCheckOnlinePackage";
            this.buttonCheckOnlinePackage.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckOnlinePackage.TabIndex = 40;
            this.buttonCheckOnlinePackage.Text = "Check";
            this.buttonCheckOnlinePackage.UseVisualStyleBackColor = true;
            this.buttonCheckOnlinePackage.Click += new System.EventHandler(this.buttonCheckOnlinePackage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 69);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(580, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Please enter path of installed storm services, then click Next button.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.label10.Size = new System.Drawing.Size(199, 66);
            this.label10.TabIndex = 38;
            this.label10.Text = "Update package";
            // 
            // comboBoxPackageLocalPath
            // 
            this.comboBoxPackageLocalPath.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBoxPackageLocalPath, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.comboBoxPackageLocalPath.Location = new System.Drawing.Point(82, 265);
            this.comboBoxPackageLocalPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPackageLocalPath.Name = "comboBoxPackageLocalPath";
            this.comboBoxPackageLocalPath.Size = new System.Drawing.Size(420, 23);
            this.comboBoxPackageLocalPath.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(82, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Path : ";
            // 
            // comboBoxPackageUrl
            // 
            this.comboBoxPackageUrl.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBoxPackageUrl, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.comboBoxPackageUrl.Location = new System.Drawing.Point(82, 170);
            this.comboBoxPackageUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPackageUrl.Name = "comboBoxPackageUrl";
            this.comboBoxPackageUrl.Size = new System.Drawing.Size(420, 23);
            this.comboBoxPackageUrl.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(82, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "URL :";
            // 
            // radioButtonLocalPackage
            // 
            this.radioButtonLocalPackage.AutoSize = true;
            this.radioButtonLocalPackage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLocalPackage.Location = new System.Drawing.Point(66, 215);
            this.radioButtonLocalPackage.Name = "radioButtonLocalPackage";
            this.radioButtonLocalPackage.Size = new System.Drawing.Size(119, 23);
            this.radioButtonLocalPackage.TabIndex = 31;
            this.radioButtonLocalPackage.Text = "Local package :";
            this.radioButtonLocalPackage.UseVisualStyleBackColor = true;
            // 
            // radioButtonDownloadPackage
            // 
            this.radioButtonDownloadPackage.AutoSize = true;
            this.radioButtonDownloadPackage.Checked = true;
            this.radioButtonDownloadPackage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDownloadPackage.Location = new System.Drawing.Point(66, 120);
            this.radioButtonDownloadPackage.Name = "radioButtonDownloadPackage";
            this.radioButtonDownloadPackage.Size = new System.Drawing.Size(129, 23);
            this.radioButtonDownloadPackage.TabIndex = 30;
            this.radioButtonDownloadPackage.TabStop = true;
            this.radioButtonDownloadPackage.Text = "Download from :";
            this.radioButtonDownloadPackage.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.richTextBoxLog);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(778, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Location = new System.Drawing.Point(32, 374);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 29);
            this.panel4.TabIndex = 43;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(500, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(581, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "< Back";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(662, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Start";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.Location = new System.Drawing.Point(6, 107);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(767, 243);
            this.richTextBoxLog.TabIndex = 35;
            this.richTextBoxLog.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 69);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(344, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Click start button to upgrade services.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            this.label12.Size = new System.Drawing.Size(152, 66);
            this.label12.TabIndex = 33;
            this.label12.Text = "Upgrade ...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 442);
            this.Controls.Add(this.wizardPages1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.wizardPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WizardPages wizardPages1;
        private TabPage tabPage1;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button buttonNext1;
        private Button buttonBrowseInstalledPath;
        private ComboBox comboBoxInstalledPath;
        private Label label3;
        private TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ErrorProvider errorProvider1;
        private Button buttonScanInstalledPath;
        private ComboBox comboBoxBackupPath;
        private Label label6;
        private CheckBox checkBoxBackupExecutables;
        private CheckBox checkBoxBackupConfigs;
        private CheckBox checkBoxBackupTinyBlobData;
        private CheckBox checkBoxBackupDatabase;
        private Button buttonScan;
        private Button buttonBrowseBackupPath;
        private Panel panel2;
        private Button button1;
        private Button buttonBack2;
        private Button buttonNext2;
        private TabPage tabPage3;
        private Button buttonBrowseLocalPackage;
        private Button buttonCheckOnlinePackage;
        private Label label8;
        private Label label10;
        private ComboBox comboBoxPackageLocalPath;
        private Label label9;
        private ComboBox comboBoxPackageUrl;
        private Label label7;
        private RadioButton radioButtonLocalPackage;
        private RadioButton radioButtonDownloadPackage;
        private Panel panel3;
        private Button button2;
        private Button button3;
        private Button buttonNext3;
        private TabPage tabPage4;
        private Label label4;
        private Label label5;
        private Label label13;
        private Label label14;
        private Panel panel4;
        private Button button6;
        private Button button7;
        private Button button8;
        private RichTextBox richTextBoxLog;
        private Label label11;
        private Label label12;
    }
}