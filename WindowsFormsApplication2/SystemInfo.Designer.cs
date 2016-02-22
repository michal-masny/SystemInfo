namespace SystemInfo
{
    partial class frmSystemInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemInformation));
            this.cmbComputerNameOrIP = new System.Windows.Forms.ComboBox();
            this.lbComputerNameOrIP = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lbOperatingSystem = new System.Windows.Forms.Label();
            this.tbOperatingSystem = new System.Windows.Forms.TextBox();
            this.lbServicePack = new System.Windows.Forms.Label();
            this.tbServicePack = new System.Windows.Forms.TextBox();
            this.lbArchitecture = new System.Windows.Forms.Label();
            this.tbArchitecture = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lbIntenetExplorerVersion = new System.Windows.Forms.Label();
            this.tbInternetExplorerVersion = new System.Windows.Forms.TextBox();
            this.lbInternetExplorerInfo = new System.Windows.Forms.Label();
            this.lbComputerInfo = new System.Windows.Forms.Label();
            this.lbOperatingSystemInfo = new System.Windows.Forms.Label();
            this.cbOperatingSystemInfo = new System.Windows.Forms.CheckBox();
            this.cbComputerInfo = new System.Windows.Forms.CheckBox();
            this.cbInternetExplorerInfo = new System.Windows.Forms.CheckBox();
            this.cbAdministratorsInfo = new System.Windows.Forms.CheckBox();
            this.lbAdministratorsInfo = new System.Windows.Forms.Label();
            this.lbAdminGroupMembers = new System.Windows.Forms.Label();
            this.tbAdminGroupMembers = new System.Windows.Forms.TextBox();
            this.lbComputerName = new System.Windows.Forms.Label();
            this.tbComputerName = new System.Windows.Forms.TextBox();
            this.lbLine1 = new System.Windows.Forms.Label();
            this.cbSessionsInfo = new System.Windows.Forms.CheckBox();
            this.lbSessionsInfo = new System.Windows.Forms.Label();
            this.lbInteractiveSessions = new System.Windows.Forms.Label();
            this.tbInteractiveSessions = new System.Windows.Forms.TextBox();
            this.lbCachedInteractiveSessions = new System.Windows.Forms.Label();
            this.tbCachedInteractiveSessions = new System.Windows.Forms.TextBox();
            this.lbRemoteInteractiveSessions = new System.Windows.Forms.Label();
            this.tbRemoteInteractiveSessions = new System.Windows.Forms.TextBox();
            this.cbVPNInfo = new System.Windows.Forms.CheckBox();
            this.lbVPNInfo = new System.Windows.Forms.Label();
            this.lbVPNConnected = new System.Windows.Forms.Label();
            this.tbVPNConnected = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbUserProfilesInfo = new System.Windows.Forms.CheckBox();
            this.lbUserProfilesInfo = new System.Windows.Forms.Label();
            this.lbUserProfiles = new System.Windows.Forms.Label();
            this.tbUserProfiles = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnCancelQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPingReplies = new System.Windows.Forms.TextBox();
            this.btnSessionDetails = new System.Windows.Forms.Button();
            this.btnProfileDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbComputerNameOrIP
            // 
            this.cmbComputerNameOrIP.Location = new System.Drawing.Point(140, 15);
            this.cmbComputerNameOrIP.Name = "cmbComputerNameOrIP";
            this.cmbComputerNameOrIP.Size = new System.Drawing.Size(154, 21);
            this.cmbComputerNameOrIP.TabIndex = 0;
            // 
            // lbComputerNameOrIP
            // 
            this.lbComputerNameOrIP.AutoSize = true;
            this.lbComputerNameOrIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerNameOrIP.Location = new System.Drawing.Point(14, 18);
            this.lbComputerNameOrIP.Name = "lbComputerNameOrIP";
            this.lbComputerNameOrIP.Size = new System.Drawing.Size(109, 13);
            this.lbComputerNameOrIP.TabIndex = 1;
            this.lbComputerNameOrIP.Text = "Computer name or IP:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(142, 41);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(73, 22);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lbOperatingSystem
            // 
            this.lbOperatingSystem.AutoSize = true;
            this.lbOperatingSystem.Location = new System.Drawing.Point(14, 151);
            this.lbOperatingSystem.Name = "lbOperatingSystem";
            this.lbOperatingSystem.Size = new System.Drawing.Size(91, 13);
            this.lbOperatingSystem.TabIndex = 6;
            this.lbOperatingSystem.Text = "Operating system:";
            // 
            // tbOperatingSystem
            // 
            this.tbOperatingSystem.Location = new System.Drawing.Point(142, 148);
            this.tbOperatingSystem.Name = "tbOperatingSystem";
            this.tbOperatingSystem.ReadOnly = true;
            this.tbOperatingSystem.Size = new System.Drawing.Size(154, 20);
            this.tbOperatingSystem.TabIndex = 5;
            // 
            // lbServicePack
            // 
            this.lbServicePack.AutoSize = true;
            this.lbServicePack.Location = new System.Drawing.Point(14, 173);
            this.lbServicePack.Name = "lbServicePack";
            this.lbServicePack.Size = new System.Drawing.Size(71, 13);
            this.lbServicePack.TabIndex = 8;
            this.lbServicePack.Text = "ServicePack:";
            // 
            // tbServicePack
            // 
            this.tbServicePack.Location = new System.Drawing.Point(142, 170);
            this.tbServicePack.Name = "tbServicePack";
            this.tbServicePack.ReadOnly = true;
            this.tbServicePack.Size = new System.Drawing.Size(154, 20);
            this.tbServicePack.TabIndex = 7;
            // 
            // lbArchitecture
            // 
            this.lbArchitecture.AutoSize = true;
            this.lbArchitecture.Location = new System.Drawing.Point(14, 195);
            this.lbArchitecture.Name = "lbArchitecture";
            this.lbArchitecture.Size = new System.Drawing.Size(67, 13);
            this.lbArchitecture.TabIndex = 10;
            this.lbArchitecture.Text = "Architecture:";
            // 
            // tbArchitecture
            // 
            this.tbArchitecture.Location = new System.Drawing.Point(142, 192);
            this.tbArchitecture.Name = "tbArchitecture";
            this.tbArchitecture.ReadOnly = true;
            this.tbArchitecture.Size = new System.Drawing.Size(154, 20);
            this.tbArchitecture.TabIndex = 9;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(14, 240);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lbManufacturer.TabIndex = 12;
            this.lbManufacturer.Text = "Manufacturer:";
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(142, 237);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.ReadOnly = true;
            this.tbManufacturer.Size = new System.Drawing.Size(154, 20);
            this.tbManufacturer.TabIndex = 11;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(14, 262);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(39, 13);
            this.lbModel.TabIndex = 14;
            this.lbModel.Text = "Model:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(142, 259);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(154, 20);
            this.tbModel.TabIndex = 13;
            // 
            // lbIntenetExplorerVersion
            // 
            this.lbIntenetExplorerVersion.AutoSize = true;
            this.lbIntenetExplorerVersion.Location = new System.Drawing.Point(14, 307);
            this.lbIntenetExplorerVersion.Name = "lbIntenetExplorerVersion";
            this.lbIntenetExplorerVersion.Size = new System.Drawing.Size(45, 13);
            this.lbIntenetExplorerVersion.TabIndex = 16;
            this.lbIntenetExplorerVersion.Text = "Version:";
            // 
            // tbInternetExplorerVersion
            // 
            this.tbInternetExplorerVersion.Location = new System.Drawing.Point(142, 304);
            this.tbInternetExplorerVersion.Name = "tbInternetExplorerVersion";
            this.tbInternetExplorerVersion.ReadOnly = true;
            this.tbInternetExplorerVersion.Size = new System.Drawing.Size(154, 20);
            this.tbInternetExplorerVersion.TabIndex = 15;
            // 
            // lbInternetExplorerInfo
            // 
            this.lbInternetExplorerInfo.AutoSize = true;
            this.lbInternetExplorerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternetExplorerInfo.Location = new System.Drawing.Point(14, 285);
            this.lbInternetExplorerInfo.Name = "lbInternetExplorerInfo";
            this.lbInternetExplorerInfo.Size = new System.Drawing.Size(84, 13);
            this.lbInternetExplorerInfo.TabIndex = 17;
            this.lbInternetExplorerInfo.Text = "Internet Explorer";
            // 
            // lbComputerInfo
            // 
            this.lbComputerInfo.AutoSize = true;
            this.lbComputerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerInfo.Location = new System.Drawing.Point(15, 218);
            this.lbComputerInfo.Name = "lbComputerInfo";
            this.lbComputerInfo.Size = new System.Drawing.Size(52, 13);
            this.lbComputerInfo.TabIndex = 19;
            this.lbComputerInfo.Text = "Computer";
            // 
            // lbOperatingSystemInfo
            // 
            this.lbOperatingSystemInfo.AutoSize = true;
            this.lbOperatingSystemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperatingSystemInfo.Location = new System.Drawing.Point(14, 128);
            this.lbOperatingSystemInfo.Name = "lbOperatingSystemInfo";
            this.lbOperatingSystemInfo.Size = new System.Drawing.Size(90, 13);
            this.lbOperatingSystemInfo.TabIndex = 21;
            this.lbOperatingSystemInfo.Text = "Operating System";
            // 
            // cbOperatingSystemInfo
            // 
            this.cbOperatingSystemInfo.AutoSize = true;
            this.cbOperatingSystemInfo.Location = new System.Drawing.Point(281, 128);
            this.cbOperatingSystemInfo.Name = "cbOperatingSystemInfo";
            this.cbOperatingSystemInfo.Size = new System.Drawing.Size(15, 14);
            this.cbOperatingSystemInfo.TabIndex = 22;
            this.cbOperatingSystemInfo.UseVisualStyleBackColor = true;
            // 
            // cbComputerInfo
            // 
            this.cbComputerInfo.AutoSize = true;
            this.cbComputerInfo.Location = new System.Drawing.Point(281, 218);
            this.cbComputerInfo.Name = "cbComputerInfo";
            this.cbComputerInfo.Size = new System.Drawing.Size(15, 14);
            this.cbComputerInfo.TabIndex = 23;
            this.cbComputerInfo.UseVisualStyleBackColor = true;
            // 
            // cbInternetExplorerInfo
            // 
            this.cbInternetExplorerInfo.AutoSize = true;
            this.cbInternetExplorerInfo.Location = new System.Drawing.Point(281, 285);
            this.cbInternetExplorerInfo.Name = "cbInternetExplorerInfo";
            this.cbInternetExplorerInfo.Size = new System.Drawing.Size(15, 14);
            this.cbInternetExplorerInfo.TabIndex = 24;
            this.cbInternetExplorerInfo.UseVisualStyleBackColor = true;
            // 
            // cbAdministratorsInfo
            // 
            this.cbAdministratorsInfo.AutoSize = true;
            this.cbAdministratorsInfo.Location = new System.Drawing.Point(281, 329);
            this.cbAdministratorsInfo.Name = "cbAdministratorsInfo";
            this.cbAdministratorsInfo.Size = new System.Drawing.Size(15, 14);
            this.cbAdministratorsInfo.TabIndex = 28;
            this.cbAdministratorsInfo.UseVisualStyleBackColor = true;
            // 
            // lbAdministratorsInfo
            // 
            this.lbAdministratorsInfo.AutoSize = true;
            this.lbAdministratorsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdministratorsInfo.Location = new System.Drawing.Point(14, 329);
            this.lbAdministratorsInfo.Name = "lbAdministratorsInfo";
            this.lbAdministratorsInfo.Size = new System.Drawing.Size(72, 13);
            this.lbAdministratorsInfo.TabIndex = 27;
            this.lbAdministratorsInfo.Text = "Administrators";
            // 
            // lbAdminGroupMembers
            // 
            this.lbAdminGroupMembers.AutoSize = true;
            this.lbAdminGroupMembers.Location = new System.Drawing.Point(14, 351);
            this.lbAdminGroupMembers.Name = "lbAdminGroupMembers";
            this.lbAdminGroupMembers.Size = new System.Drawing.Size(53, 13);
            this.lbAdminGroupMembers.TabIndex = 26;
            this.lbAdminGroupMembers.Text = "Members:";
            // 
            // tbAdminGroupMembers
            // 
            this.tbAdminGroupMembers.Location = new System.Drawing.Point(142, 348);
            this.tbAdminGroupMembers.Multiline = true;
            this.tbAdminGroupMembers.Name = "tbAdminGroupMembers";
            this.tbAdminGroupMembers.ReadOnly = true;
            this.tbAdminGroupMembers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdminGroupMembers.Size = new System.Drawing.Size(154, 42);
            this.tbAdminGroupMembers.TabIndex = 25;
            this.tbAdminGroupMembers.WordWrap = false;
            // 
            // lbComputerName
            // 
            this.lbComputerName.AutoSize = true;
            this.lbComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerName.Location = new System.Drawing.Point(14, 79);
            this.lbComputerName.Name = "lbComputerName";
            this.lbComputerName.Size = new System.Drawing.Size(84, 13);
            this.lbComputerName.TabIndex = 30;
            this.lbComputerName.Text = "Computer name:";
            // 
            // tbComputerName
            // 
            this.tbComputerName.Location = new System.Drawing.Point(141, 76);
            this.tbComputerName.Name = "tbComputerName";
            this.tbComputerName.ReadOnly = true;
            this.tbComputerName.Size = new System.Drawing.Size(154, 20);
            this.tbComputerName.TabIndex = 29;
            // 
            // lbLine1
            // 
            this.lbLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine1.Location = new System.Drawing.Point(17, 112);
            this.lbLine1.Name = "lbLine1";
            this.lbLine1.Size = new System.Drawing.Size(277, 2);
            this.lbLine1.TabIndex = 31;
            // 
            // cbSessionsInfo
            // 
            this.cbSessionsInfo.AutoSize = true;
            this.cbSessionsInfo.Location = new System.Drawing.Point(591, 128);
            this.cbSessionsInfo.Name = "cbSessionsInfo";
            this.cbSessionsInfo.Size = new System.Drawing.Size(15, 14);
            this.cbSessionsInfo.TabIndex = 35;
            this.cbSessionsInfo.UseVisualStyleBackColor = true;
            // 
            // lbSessionsInfo
            // 
            this.lbSessionsInfo.AutoSize = true;
            this.lbSessionsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSessionsInfo.Location = new System.Drawing.Point(326, 128);
            this.lbSessionsInfo.Name = "lbSessionsInfo";
            this.lbSessionsInfo.Size = new System.Drawing.Size(49, 13);
            this.lbSessionsInfo.TabIndex = 34;
            this.lbSessionsInfo.Text = "Sessions";
            // 
            // lbInteractiveSessions
            // 
            this.lbInteractiveSessions.AutoSize = true;
            this.lbInteractiveSessions.Location = new System.Drawing.Point(326, 151);
            this.lbInteractiveSessions.Name = "lbInteractiveSessions";
            this.lbInteractiveSessions.Size = new System.Drawing.Size(60, 13);
            this.lbInteractiveSessions.TabIndex = 33;
            this.lbInteractiveSessions.Text = "Interactive:";
            // 
            // tbInteractiveSessions
            // 
            this.tbInteractiveSessions.Location = new System.Drawing.Point(452, 148);
            this.tbInteractiveSessions.Multiline = true;
            this.tbInteractiveSessions.Name = "tbInteractiveSessions";
            this.tbInteractiveSessions.ReadOnly = true;
            this.tbInteractiveSessions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInteractiveSessions.Size = new System.Drawing.Size(154, 42);
            this.tbInteractiveSessions.TabIndex = 32;
            this.tbInteractiveSessions.WordWrap = false;
            // 
            // lbCachedInteractiveSessions
            // 
            this.lbCachedInteractiveSessions.AutoSize = true;
            this.lbCachedInteractiveSessions.Location = new System.Drawing.Point(326, 195);
            this.lbCachedInteractiveSessions.Name = "lbCachedInteractiveSessions";
            this.lbCachedInteractiveSessions.Size = new System.Drawing.Size(99, 13);
            this.lbCachedInteractiveSessions.TabIndex = 37;
            this.lbCachedInteractiveSessions.Text = "Cached interactive:";
            // 
            // tbCachedInteractiveSessions
            // 
            this.tbCachedInteractiveSessions.Enabled = false;
            this.tbCachedInteractiveSessions.Location = new System.Drawing.Point(452, 192);
            this.tbCachedInteractiveSessions.Multiline = true;
            this.tbCachedInteractiveSessions.Name = "tbCachedInteractiveSessions";
            this.tbCachedInteractiveSessions.ReadOnly = true;
            this.tbCachedInteractiveSessions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCachedInteractiveSessions.Size = new System.Drawing.Size(154, 42);
            this.tbCachedInteractiveSessions.TabIndex = 36;
            this.tbCachedInteractiveSessions.WordWrap = false;
            // 
            // lbRemoteInteractiveSessions
            // 
            this.lbRemoteInteractiveSessions.AutoSize = true;
            this.lbRemoteInteractiveSessions.Location = new System.Drawing.Point(326, 240);
            this.lbRemoteInteractiveSessions.Name = "lbRemoteInteractiveSessions";
            this.lbRemoteInteractiveSessions.Size = new System.Drawing.Size(99, 13);
            this.lbRemoteInteractiveSessions.TabIndex = 39;
            this.lbRemoteInteractiveSessions.Text = "Remote interactive:";
            // 
            // tbRemoteInteractiveSessions
            // 
            this.tbRemoteInteractiveSessions.Location = new System.Drawing.Point(452, 237);
            this.tbRemoteInteractiveSessions.Multiline = true;
            this.tbRemoteInteractiveSessions.Name = "tbRemoteInteractiveSessions";
            this.tbRemoteInteractiveSessions.ReadOnly = true;
            this.tbRemoteInteractiveSessions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemoteInteractiveSessions.Size = new System.Drawing.Size(154, 42);
            this.tbRemoteInteractiveSessions.TabIndex = 38;
            this.tbRemoteInteractiveSessions.WordWrap = false;
            // 
            // cbVPNInfo
            // 
            this.cbVPNInfo.AutoSize = true;
            this.cbVPNInfo.Location = new System.Drawing.Point(591, 351);
            this.cbVPNInfo.Name = "cbVPNInfo";
            this.cbVPNInfo.Size = new System.Drawing.Size(15, 14);
            this.cbVPNInfo.TabIndex = 43;
            this.cbVPNInfo.UseVisualStyleBackColor = true;
            // 
            // lbVPNInfo
            // 
            this.lbVPNInfo.AutoSize = true;
            this.lbVPNInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVPNInfo.Location = new System.Drawing.Point(326, 351);
            this.lbVPNInfo.Name = "lbVPNInfo";
            this.lbVPNInfo.Size = new System.Drawing.Size(29, 13);
            this.lbVPNInfo.TabIndex = 42;
            this.lbVPNInfo.Text = "VPN";
            // 
            // lbVPNConnected
            // 
            this.lbVPNConnected.AutoSize = true;
            this.lbVPNConnected.Location = new System.Drawing.Point(326, 373);
            this.lbVPNConnected.Name = "lbVPNConnected";
            this.lbVPNConnected.Size = new System.Drawing.Size(62, 13);
            this.lbVPNConnected.TabIndex = 41;
            this.lbVPNConnected.Text = "Connected:";
            // 
            // tbVPNConnected
            // 
            this.tbVPNConnected.Location = new System.Drawing.Point(452, 370);
            this.tbVPNConnected.Name = "tbVPNConnected";
            this.tbVPNConnected.ReadOnly = true;
            this.tbVPNConnected.Size = new System.Drawing.Size(154, 20);
            this.tbVPNConnected.TabIndex = 40;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(14, 46);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 44;
            // 
            // cbUserProfilesInfo
            // 
            this.cbUserProfilesInfo.AutoSize = true;
            this.cbUserProfilesInfo.Location = new System.Drawing.Point(591, 285);
            this.cbUserProfilesInfo.Name = "cbUserProfilesInfo";
            this.cbUserProfilesInfo.Size = new System.Drawing.Size(15, 14);
            this.cbUserProfilesInfo.TabIndex = 48;
            this.cbUserProfilesInfo.UseVisualStyleBackColor = true;
            // 
            // lbUserProfilesInfo
            // 
            this.lbUserProfilesInfo.AutoSize = true;
            this.lbUserProfilesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserProfilesInfo.Location = new System.Drawing.Point(326, 285);
            this.lbUserProfilesInfo.Name = "lbUserProfilesInfo";
            this.lbUserProfilesInfo.Size = new System.Drawing.Size(65, 13);
            this.lbUserProfilesInfo.TabIndex = 47;
            this.lbUserProfilesInfo.Text = "User profiles";
            // 
            // lbUserProfiles
            // 
            this.lbUserProfiles.AutoSize = true;
            this.lbUserProfiles.Location = new System.Drawing.Point(326, 307);
            this.lbUserProfiles.Name = "lbUserProfiles";
            this.lbUserProfiles.Size = new System.Drawing.Size(41, 13);
            this.lbUserProfiles.TabIndex = 46;
            this.lbUserProfiles.Text = "Profiles";
            // 
            // tbUserProfiles
            // 
            this.tbUserProfiles.Location = new System.Drawing.Point(452, 304);
            this.tbUserProfiles.Multiline = true;
            this.tbUserProfiles.Name = "tbUserProfiles";
            this.tbUserProfiles.ReadOnly = true;
            this.tbUserProfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUserProfiles.Size = new System.Drawing.Size(154, 42);
            this.tbUserProfiles.TabIndex = 45;
            this.tbUserProfiles.WordWrap = false;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(335, 12);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 49;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnCancelQuery
            // 
            this.btnCancelQuery.Enabled = false;
            this.btnCancelQuery.Location = new System.Drawing.Point(223, 40);
            this.btnCancelQuery.Name = "btnCancelQuery";
            this.btnCancelQuery.Size = new System.Drawing.Size(73, 23);
            this.btnCancelQuery.TabIndex = 50;
            this.btnCancelQuery.Text = "Cancel";
            this.btnCancelQuery.UseVisualStyleBackColor = true;
            this.btnCancelQuery.Click += new System.EventHandler(this.btnCancelQuery_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(329, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 2);
            this.label1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(312, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 100);
            this.label2.TabIndex = 52;
            // 
            // tbPingReplies
            // 
            this.tbPingReplies.Location = new System.Drawing.Point(452, 12);
            this.tbPingReplies.Multiline = true;
            this.tbPingReplies.Name = "tbPingReplies";
            this.tbPingReplies.ReadOnly = true;
            this.tbPingReplies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPingReplies.Size = new System.Drawing.Size(154, 80);
            this.tbPingReplies.TabIndex = 53;
            this.tbPingReplies.WordWrap = false;
            // 
            // btnSessionDetails
            // 
            this.btnSessionDetails.Enabled = false;
            this.btnSessionDetails.Location = new System.Drawing.Point(452, 123);
            this.btnSessionDetails.Name = "btnSessionDetails";
            this.btnSessionDetails.Size = new System.Drawing.Size(75, 23);
            this.btnSessionDetails.TabIndex = 54;
            this.btnSessionDetails.Text = "View details";
            this.btnSessionDetails.UseVisualStyleBackColor = true;
            this.btnSessionDetails.Click += new System.EventHandler(this.btnSessionDetails_Click);
            // 
            // btnProfileDetails
            // 
            this.btnProfileDetails.Enabled = false;
            this.btnProfileDetails.Location = new System.Drawing.Point(452, 280);
            this.btnProfileDetails.Name = "btnProfileDetails";
            this.btnProfileDetails.Size = new System.Drawing.Size(75, 23);
            this.btnProfileDetails.TabIndex = 55;
            this.btnProfileDetails.Text = "View details";
            this.btnProfileDetails.UseVisualStyleBackColor = true;
            this.btnProfileDetails.Click += new System.EventHandler(this.btnProfileDetails_Click);
            // 
            // frmSystemInformation
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 412);
            this.Controls.Add(this.btnProfileDetails);
            this.Controls.Add(this.btnSessionDetails);
            this.Controls.Add(this.tbPingReplies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelQuery);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.cbUserProfilesInfo);
            this.Controls.Add(this.lbUserProfilesInfo);
            this.Controls.Add(this.lbUserProfiles);
            this.Controls.Add(this.tbUserProfiles);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbVPNInfo);
            this.Controls.Add(this.lbVPNInfo);
            this.Controls.Add(this.lbVPNConnected);
            this.Controls.Add(this.tbVPNConnected);
            this.Controls.Add(this.lbRemoteInteractiveSessions);
            this.Controls.Add(this.tbRemoteInteractiveSessions);
            this.Controls.Add(this.lbCachedInteractiveSessions);
            this.Controls.Add(this.tbCachedInteractiveSessions);
            this.Controls.Add(this.cbSessionsInfo);
            this.Controls.Add(this.lbSessionsInfo);
            this.Controls.Add(this.lbInteractiveSessions);
            this.Controls.Add(this.tbInteractiveSessions);
            this.Controls.Add(this.lbLine1);
            this.Controls.Add(this.lbComputerName);
            this.Controls.Add(this.tbComputerName);
            this.Controls.Add(this.cbAdministratorsInfo);
            this.Controls.Add(this.lbAdministratorsInfo);
            this.Controls.Add(this.lbAdminGroupMembers);
            this.Controls.Add(this.tbAdminGroupMembers);
            this.Controls.Add(this.cbInternetExplorerInfo);
            this.Controls.Add(this.cbComputerInfo);
            this.Controls.Add(this.cbOperatingSystemInfo);
            this.Controls.Add(this.lbOperatingSystemInfo);
            this.Controls.Add(this.lbComputerInfo);
            this.Controls.Add(this.lbInternetExplorerInfo);
            this.Controls.Add(this.lbIntenetExplorerVersion);
            this.Controls.Add(this.tbInternetExplorerVersion);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.tbManufacturer);
            this.Controls.Add(this.lbArchitecture);
            this.Controls.Add(this.tbArchitecture);
            this.Controls.Add(this.lbServicePack);
            this.Controls.Add(this.tbServicePack);
            this.Controls.Add(this.lbOperatingSystem);
            this.Controls.Add(this.tbOperatingSystem);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lbComputerNameOrIP);
            this.Controls.Add(this.cmbComputerNameOrIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSystemInformation";
            this.Text = "System Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComputerNameOrIP;
        private System.Windows.Forms.Label lbComputerNameOrIP;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lbOperatingSystem;
        private System.Windows.Forms.TextBox tbOperatingSystem;
        private System.Windows.Forms.Label lbServicePack;
        private System.Windows.Forms.TextBox tbServicePack;
        private System.Windows.Forms.Label lbArchitecture;
        private System.Windows.Forms.TextBox tbArchitecture;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lbIntenetExplorerVersion;
        private System.Windows.Forms.TextBox tbInternetExplorerVersion;
        private System.Windows.Forms.Label lbInternetExplorerInfo;
        private System.Windows.Forms.Label lbComputerInfo;
        private System.Windows.Forms.Label lbOperatingSystemInfo;
        private System.Windows.Forms.CheckBox cbOperatingSystemInfo;
        private System.Windows.Forms.CheckBox cbComputerInfo;
        private System.Windows.Forms.CheckBox cbInternetExplorerInfo;
        private System.Windows.Forms.CheckBox cbAdministratorsInfo;
        private System.Windows.Forms.Label lbAdministratorsInfo;
        private System.Windows.Forms.Label lbAdminGroupMembers;
        private System.Windows.Forms.TextBox tbAdminGroupMembers;
        private System.Windows.Forms.Label lbComputerName;
        private System.Windows.Forms.TextBox tbComputerName;
        private System.Windows.Forms.Label lbLine1;
        private System.Windows.Forms.CheckBox cbSessionsInfo;
        private System.Windows.Forms.Label lbSessionsInfo;
        private System.Windows.Forms.Label lbInteractiveSessions;
        private System.Windows.Forms.TextBox tbInteractiveSessions;
        private System.Windows.Forms.Label lbCachedInteractiveSessions;
        private System.Windows.Forms.TextBox tbCachedInteractiveSessions;
        private System.Windows.Forms.Label lbRemoteInteractiveSessions;
        private System.Windows.Forms.TextBox tbRemoteInteractiveSessions;
        private System.Windows.Forms.CheckBox cbVPNInfo;
        private System.Windows.Forms.Label lbVPNInfo;
        private System.Windows.Forms.Label lbVPNConnected;
        private System.Windows.Forms.TextBox tbVPNConnected;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.CheckBox cbUserProfilesInfo;
        private System.Windows.Forms.Label lbUserProfilesInfo;
        private System.Windows.Forms.Label lbUserProfiles;
        private System.Windows.Forms.TextBox tbUserProfiles;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnCancelQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPingReplies;
        private System.Windows.Forms.Button btnSessionDetails;
        private System.Windows.Forms.Button btnProfileDetails;
    }
}

