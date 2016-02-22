using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;

namespace SystemInfo
{
    public partial class frmSystemInformation : Form
    {
        public SessionDetails SessionDetailsForm;
        public ProfileDetails ProfileDetailsForm;
        public QueryErrors QueryErrorsForm;
        public List<ProfileListItem> ProfilesList;
        public List<SessionListItem> SessionsList;

        public frmSystemInformation()
        {
            InitializeComponent();
            LoadQueryHistory();
            ProfilesList = new List<ProfileListItem>();
            SessionsList = new List<SessionListItem>();
        }

        CancellationTokenSource cts = new CancellationTokenSource();

        private async void btnQuery_Click(object sender, EventArgs e)
        {
            //Perform string cleanup on user input
            string computernameorip = PrepareComputerNameOrIP(cmbComputerNameOrIP.Text);

            //Prepare form for new search
            lbStatus.Text = "Clearing old information";
            StartTasks();

            //Create temporary string variables
            string computername = "";
            string operatingsystem = "";
            string servicepack = "";
            string architecture = "";
            string manufacturer = "";
            string model = "";
            string internetexplorerversion = "";
            string admingroupmembers = "";
            string interactivesessions = "";
            string remoteinteractivesessions = "";
            string cachedinteractivesessions = "";
            string userprofiles = "";
            string vpnconnected = "";
            string queryerrors = "";

            lbStatus.Text = "Retrieving information...";

            //Clean up user input
            computernameorip = PrepareComputerNameOrIP(cmbComputerNameOrIP.Text);

            //Create remote WMI scope and connect       
            ManagementScope scope = new ManagementScope();
            //scope.Options.Timeout = TimeSpan.FromSeconds(21);
            try
            {
                scope = new ManagementScope("\\\\" + computernameorip + "\\root\\cimv2");
                scope.Connect();
            }
            catch (COMException ex)
            {
                if ((uint)ex.HResult == 0x800706BA)
                {
                    MessageBox.Show("Unable to connect to \"" + computernameorip + "\".");
                    EndTasks();
                    return;
                }

                if ((uint)ex.HResult == 0x80080004)
                {
                    MessageBox.Show("Bad path to object: the path is most likely too long.");
                    EndTasks();
                    return;
                }
                else
                {
                    MessageBox.Show("COM exception thrown while connecting to the host: " + ex.Message);
                    EndTasks();
                    return;
                }
            }
            catch (ManagementException ex)
            {
                if ((uint)ex.HResult == 0x80131501)
                {
                    MessageBox.Show("Invalid computer name or IP.");
                    EndTasks();
                    return;
                }
                else { MessageBox.Show("WMI exception thrown while connecting to the host: " + ex.Message); return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown while connecting to the host: " + ex.Message);
                EndTasks();
                return;
            }

            //Run queries
            try
            {
                await Task.Run(() =>
                {
                    //Query system for computer name
                    try
                    {
                        computername = GetComputerName(scope);
                    }
                    catch(Exception ex)
                    {
                        queryerrors = queryerrors + 
                        "Unable to get the computer name.\r\nThe system error message was: " + ex.Message + 
                        "\r\nError code: " + ex.HResult + "\r\n";
                        computername = "";
                    }
                    cts.Token.ThrowIfCancellationRequested();

                    //Query system for Operating System information
                    if (cbOperatingSystemInfo.Checked)
                    {
                        try
                        {
                            var operatingsysteminfo = GetOperatingSystemInfo(scope);
                            operatingsystem = operatingsysteminfo.Item1;
                            servicepack = operatingsysteminfo.Item2;
                            architecture = operatingsysteminfo.Item3;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the operating system information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                            operatingsystem = "";
                            servicepack = "";
                            architecture = "";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }
                    //Query system for Computer System Product information
                    if (cbComputerInfo.Checked)
                    {
                        try
                        {
                            var computerinfo = GetComputerInfo(scope);
                            manufacturer = computerinfo.Item1;
                            model = computerinfo.Item2;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the computer information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                            manufacturer = "";
                            model = "";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }

                    // Query remote registry for Internet Explorer Version
                    if (cbInternetExplorerInfo.Checked)
                    {
                        string target = computername;
                        if (String.IsNullOrEmpty(target))
                            target = computernameorip;
                        try
                        {
                            var internetexplorerinfo = GetInternetExplorerInfo(target);
                            internetexplorerversion = internetexplorerinfo.Item1;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the Internet Explorer information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                            internetexplorerversion = "";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }

                    //Query system for admin users information
                    if (cbAdministratorsInfo.Checked)
                    {
                        try
                        {
                            var administratorsinfo = GetAdministratorsInfo(scope, computername);
                            admingroupmembers = administratorsinfo.Item1;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the administrator group information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }

                    //Query system for open sessions
                    if (cbSessionsInfo.Checked)
                    {
                        try
                        {
                            var sessionsinfo = GetSessionsInfo(scope);
                            interactivesessions = sessionsinfo.Item1;
                            cachedinteractivesessions = sessionsinfo.Item2;
                            remoteinteractivesessions = sessionsinfo.Item3;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the session information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                            interactivesessions = "";
                            cachedinteractivesessions = "";
                            remoteinteractivesessions = "";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }

                    //Query system for user profiles
                    if (cbUserProfilesInfo.Checked)
                    {
                        string target = computername;
                        if (String.IsNullOrEmpty(target))
                            target = computernameorip;
                        try
                        {
                            var userprofilesinfo = GetUserProfilesInfo(scope, target);
                            userprofiles = userprofilesinfo.Item1;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the profiles information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                            userprofiles = "";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }

                    //Ask system if VPN is connected
                    if (cbVPNInfo.Checked)
                    {
                        try
                        {
                            var VPNInfo = GetVPNInfo(scope);
                            vpnconnected = VPNInfo.Item1;
                        }
                        catch (Exception ex)
                        {
                            queryerrors = queryerrors + 
                            "Unable to get the operating system information.\r\nThe system error message was: " + ex.Message + 
                            "\r\nError code: " + ex.HResult + "\r\n";
                            vpnconnected = "";
                        }
                        cts.Token.ThrowIfCancellationRequested();
                    }
                }, cts.Token);
            }
            catch (OperationCanceledException ex)
            {
                EndTasks();
                return;
            }

            //fill text fields with information
            tbComputerName.Text = computername;
            tbOperatingSystem.Text = operatingsystem;
            tbServicePack.Text = servicepack;
            tbArchitecture.Text = architecture;
            tbManufacturer.Text = manufacturer;
            tbModel.Text = model;
            tbInternetExplorerVersion.Text = internetexplorerversion;
            tbAdminGroupMembers.Text = admingroupmembers;
            tbInteractiveSessions.Text = interactivesessions;
            tbCachedInteractiveSessions.Text = cachedinteractivesessions;
            tbRemoteInteractiveSessions.Text = remoteinteractivesessions;
            tbVPNConnected.Text = vpnconnected;
            tbUserProfiles.Text = userprofiles;

            //run end tasks
            EndTasks(computernameorip, queryerrors);
        }

        private string PrepareComputerNameOrIP(string computernameorip)
        {
            computernameorip = computernameorip.TrimStart('\\', '/', '\n', '\r', ' ').TrimEnd('\r', '\n', ' ');
            if (String.IsNullOrEmpty(computernameorip))
                computernameorip = "localhost";
            return computernameorip;
        }

        private string GetComputerName(ManagementScope scope)
        {
            ObjectQuery queryOS = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcherOS = new ManagementObjectSearcher(scope, queryOS);
            ManagementObjectCollection queryCollectionOS = searcherOS.Get();
            string computername = "";
            foreach (ManagementObject m in queryCollectionOS)
            {
                computername = m["CSName"].ToString();
            }
            return computername;
        }

        private Tuple<string, string, string> GetOperatingSystemInfo(ManagementScope scope)
        {
            //Query system for Operating System information
            ObjectQuery queryOS = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcherOS = new ManagementObjectSearcher(scope, queryOS);
            ManagementObjectCollection queryCollectionOS = searcherOS.Get();
            string operatingsystem = "";
            string servicepack = "";
            string architecture = "";
            foreach (ManagementObject m in queryCollectionOS)
            {
                operatingsystem = m["Caption"].ToString();
                servicepack = m["ServicePackMajorVersion"].ToString();
                architecture = m["OSArchitecture"].ToString();
            }
            return Tuple.Create(operatingsystem, servicepack, architecture);
        }

        private Tuple<string, string> GetComputerInfo(ManagementScope scope)
        {
            ObjectQuery queryComputerSystemProduct = new ObjectQuery("SELECT * FROM Win32_ComputerSystemProduct");
            ManagementObjectSearcher searcherComputerSystemProduct = new ManagementObjectSearcher(scope, queryComputerSystemProduct);
            ManagementObjectCollection queryCollectionComputerSystemProduct = searcherComputerSystemProduct.Get();
            string manufacturer = "";
            string model = "";
            foreach (ManagementObject m in queryCollectionComputerSystemProduct)
            {
                manufacturer = m["Vendor"].ToString();
                model = m["Version"].ToString();
            }
            return Tuple.Create(manufacturer, model);
        }

        private Tuple<string> GetInternetExplorerInfo(string target)
        {
            RegistryKey rkey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, target);
            RegistryKey rkeySoftware = rkey.OpenSubKey("Software");
            RegistryKey rkeyMicrosoft = rkeySoftware.OpenSubKey("Microsoft");
            RegistryKey rkeyInternetExplorer = rkeyMicrosoft.OpenSubKey("Internet Explorer");
            string internetexplorerversion = "";
            if (rkeyInternetExplorer.GetValue("svcVersion") != null)
                internetexplorerversion = rkeyInternetExplorer.GetValue("svcVersion").ToString();
            else
                internetexplorerversion = rkeyInternetExplorer.GetValue("Version").ToString();
            return Tuple.Create(internetexplorerversion);
        }

        private Tuple<string> GetAdministratorsInfo(ManagementScope scope, string computername)
        {
            ObjectQuery queryGroupUser = new ObjectQuery("SELECT PartComponent FROM Win32_GroupUser where GroupComponent = 'Win32_Group.Domain=\"" + computername + "\",Name=\"Administrators\"'");
            ManagementObjectSearcher searcherGroupUser = new ManagementObjectSearcher(scope, queryGroupUser);
            ManagementObjectCollection queryCollectionGroupUser = searcherGroupUser.Get();
            int index = 0;
            string line = "";
            string admingroupmembers = "";
            foreach (ManagementObject m in queryCollectionGroupUser)
            {
                line = m["PartComponent"].ToString();
                index = line.IndexOf("Name");
                line = line.Substring(index).Remove(0, 6).TrimEnd('\"');
                admingroupmembers = admingroupmembers + "\r\n" + line;
            }
            if (!String.IsNullOrEmpty(admingroupmembers))
                admingroupmembers = admingroupmembers.Remove(0, 2);
            return Tuple.Create(admingroupmembers);
        }

        private Tuple<string, string, string> GetSessionsInfo(ManagementScope scope)
        {
            ObjectQuery queryLogonSession = new ObjectQuery("SELECT * FROM Win32_LogonSession");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, queryLogonSession);
            string interactivesessions = "";
            string cachedinteractivesessions = "";
            string remoteinteractivesessions = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string id = queryObj["__RELPATH"].ToString().Replace("\"", "'");
                //ObjectQuery queryInteractiveSessions = new ObjectQuery("ASSOCIATORS OF {" + id + "} WHERE ResultClass = Win32_Account");
                ObjectQuery queryLoggedOnUser = new ObjectQuery("REFERENCES OF {" + id + "} WHERE ResultClass = Win32_LoggedOnUser");
                ManagementObjectSearcher s = new ManagementObjectSearcher(scope, queryLoggedOnUser);
                string interactiveline = "";
                string cachedinteractiveline = "";
                string remoteinteractiveline = "";
                string antecedent = "";
                int index = 0;
                foreach (ManagementObject q in s.Get())
                {
                    antecedent = q["Antecedent"].ToString();
                    index = antecedent.IndexOf("Name");
                    antecedent = antecedent.Substring(index).Remove(0, 6).TrimEnd('\"');
                    switch (queryObj["LogonType"].ToString())
                    {
                        case "2":
                            interactiveline = antecedent;
                            interactivesessions = interactivesessions + "\r\n" + interactiveline;
                            break;
                        case "10":
                            remoteinteractiveline = antecedent;
                            remoteinteractivesessions = remoteinteractivesessions + "\r\n" + remoteinteractiveline;
                            break;
                        case "11":
                            cachedinteractiveline = antecedent;
                            cachedinteractivesessions = cachedinteractivesessions + "\r\n" + cachedinteractiveline;
                            break;
                        default:
                            break;
                    }
                    SessionListItem sessionlistitem = new SessionListItem
                    (
                        antecedent,
                        queryObj["LogonType"].ToString(),
                        queryObj["LogonId"].ToString(),
                        ManagementDateTimeConverter.ToDateTime(queryObj["StartTime"].ToString()).ToString()
                    );
                    SessionsList.Add(sessionlistitem);
                }
            }
            if (!String.IsNullOrEmpty(interactivesessions))
                interactivesessions = interactivesessions.Remove(0, 2);
            if (!String.IsNullOrEmpty(cachedinteractivesessions))
                cachedinteractivesessions = cachedinteractivesessions.Remove(0, 2);
            if (!String.IsNullOrEmpty(remoteinteractivesessions))
                remoteinteractivesessions = remoteinteractivesessions.Remove(0, 2);
            return Tuple.Create(interactivesessions, cachedinteractivesessions, remoteinteractivesessions);
        }

        private Tuple<string> GetUserProfilesInfo(ManagementScope scope, string target)
        {
            ObjectQuery queryUserProfile = new ObjectQuery("SELECT * FROM Win32_UserProfile");
            ManagementObjectSearcher searcherUserProfile = new ManagementObjectSearcher(scope, queryUserProfile);
            ManagementObjectCollection queryCollectionUserProfile = searcherUserProfile.Get();
            string userprofiles = "";
            string line = "";
            foreach (ManagementObject m in queryCollectionUserProfile)
            {
                SecurityIdentifier sid = new SecurityIdentifier(m["SID"].ToString());
                //using WinApi's LookupAccountSid to look up domain account name
                byte[] sidBytes = new byte[sid.BinaryLength]; //need to pass SID to LookupAccountSid as byte array
                sid.GetBinaryForm(sidBytes, 0);
                StringBuilder profileName = new StringBuilder();
                SID_NAME_USE use;
                uint cchName = (uint)profileName.Capacity;
                StringBuilder referencedDomainName = new StringBuilder();
                uint cchReferencedDomainName = (uint)referencedDomainName.Capacity;
                NativeMethods.LookupAccountSid(target, sidBytes, profileName, ref cchName, referencedDomainName, ref cchReferencedDomainName, out use).ToString();
                line = profileName.ToString();
                if (String.IsNullOrEmpty(line)) //if domain LookupAccountSid fails
                {
                    if (m["Special"].ToString() == "False")
                    {
                        Regex rgx = new Regex(@"(.*\\)*");
                        line = rgx.Replace(m["LocalPath"].ToString(), ""); //get the username from local folder path
                        if (!String.IsNullOrEmpty(line))
                            line = line + " (account not found)";
                        else
                            line = m["Sid"].ToString();
                    }
                    else
                    {
                        line = m["Sid"].ToString();
                    }
                }
                userprofiles = userprofiles + "\r\n" + line;
                ProfileListItem profilelistitem = new ProfileListItem
                (
                    line,
                    m["SID"].ToString(),
                    ManagementDateTimeConverter.ToDateTime(m["LastUseTime"].ToString()).ToString()
                );
                ProfilesList.Add(profilelistitem);
            }
            userprofiles = userprofiles.Remove(0, 2);
            return Tuple.Create(userprofiles);
        }

        private Tuple<string> GetVPNInfo(ManagementScope scope)
        {
            ObjectQuery queryNetworkAdapter = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher searcherNetworkAdapter = new ManagementObjectSearcher(scope, queryNetworkAdapter);
            ManagementObjectCollection queryCollectionNetworkAdapter = searcherNetworkAdapter.Get();
            string vpnconnected = "NO";
            foreach (ManagementObject m in queryCollectionNetworkAdapter)
            {
                if (m["ServiceName"] != null && m["NetConnectionStatus"] != null)
                {
                    if (m["ServiceName"].ToString() == "vpnva" && m["NetConnectionStatus"].ToString() == "2")
                        vpnconnected = "YES";
                }
            }
            return Tuple.Create(vpnconnected);
        }

        private void LoadQueryHistory()
        {
            //Load query history
            try
            {
                SafeFileHandle safeADSHandle = NativeMethods.CreateFile(Program.QueryCacheName,
                FileAccess.Read,
                FileShare.ReadWrite,
                IntPtr.Zero,
                FileMode.Open,
                0,
                IntPtr.Zero);
                if (safeADSHandle.IsInvalid)
                {
                    Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                }
                var stream = new FileStream(safeADSHandle, FileAccess.Read);
                var reader = new StreamReader(stream);
                List<string> queryhistory = new List<string>();
                while (!reader.EndOfStream)
                {
                    queryhistory.Add(reader.ReadLine());
                }
                stream.Close();
                cmbComputerNameOrIP.DataSource = queryhistory;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the query history file. \r\nThe system error message was: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToQueryHistory(string computernameorip)
        {
            //create list of current combobox items
            int n = cmbComputerNameOrIP.Items.Count;
            List<String> queryhistory = new List<string>();

            for (int i = 0; i < n; i++)
            {
                try { queryhistory.Add(cmbComputerNameOrIP.Items[i].ToString()); }
                catch (Exception ex) { MessageBox.Show(ex.Message + " Error code: " + ex.HResult.ToString()); }
            }
            //remove duplicates of new query from list and check for cache size limit
            queryhistory.RemoveAll(x => x.Equals(computernameorip));
            if (queryhistory.Count() >= 20)
            {
                queryhistory.RemoveAt(19);
            }
            //add new query to list and make list new combobox datasource
            queryhistory.Insert(0, computernameorip);
            cmbComputerNameOrIP.DataSource = queryhistory;
            //overwrite query history file with new list
            try
            {
                SafeFileHandle ADS = NativeMethods.CreateFile(Program.QueryCacheName,
                FileAccess.Write,
                FileShare.Read,
                IntPtr.Zero,
                FileMode.Create,
                0,
                IntPtr.Zero);
                if (ADS.IsInvalid)
                {
                    Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                }
                var dataStream = new FileStream(ADS, FileAccess.ReadWrite);
                using (StreamWriter writer = new StreamWriter(dataStream))
                {
                    for (int i = 0; i < queryhistory.Count; i++)
                        writer.WriteLine(queryhistory[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not write to the query history file. \r\nThe system error message was: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void StartTasks()
        {
            //Clear fields
            ClearFields();
            //Disable form elements while query is running
            btnQuery.Enabled = false;
            cbOperatingSystemInfo.Enabled = false;
            cbComputerInfo.Enabled = false;
            cbInternetExplorerInfo.Enabled = false;
            cbAdministratorsInfo.Enabled = false;
            cbSessionsInfo.Enabled = false;
            cbUserProfilesInfo.Enabled = false;
            cbVPNInfo.Enabled = false;
            //Enable Cancel button
            btnCancelQuery.Enabled = true;
            //Disable View Details buttons
            btnProfileDetails.Enabled = false;
            btnSessionDetails.Enabled = false;
            //Create SessionsList and ProfilesList
            SessionsList = new List<SessionListItem>();
            ProfilesList = new List<ProfileListItem>();
            return;
        }

        private void ClearFields()
        {
            tbComputerName.Text = "";
            tbOperatingSystem.Text = "";
            tbServicePack.Text = "";
            tbArchitecture.Text = "";
            tbManufacturer.Text = "";
            tbModel.Text = "";
            tbInternetExplorerVersion.Text = "";
            tbAdminGroupMembers.Text = "";
            tbInteractiveSessions.Text = "";
            tbCachedInteractiveSessions.Text = "";
            tbRemoteInteractiveSessions.Text = "";
            tbUserProfiles.Text = "";
            tbVPNConnected.Text = "";
        }

        //overload for cancelled/unsuccessful queries
        private void EndTasks()
        {
            //Load query history
            LoadQueryHistory();
            //Re-enable form elements after query has finished running
            btnQuery.Enabled = true;
            cbOperatingSystemInfo.Enabled = true;
            cbComputerInfo.Enabled = true;
            cbInternetExplorerInfo.Enabled = true;
            cbAdministratorsInfo.Enabled = true;
            cbSessionsInfo.Enabled = true;
            cbUserProfilesInfo.Enabled = true;
            cbVPNInfo.Enabled = true;
            //Re-disable Cancel button
            btnCancelQuery.Enabled = false;
            //Re-Disable View Details buttons
            btnSessionDetails.Enabled = false;
            btnProfileDetails.Enabled = false;
            //Clear status
            lbStatus.Text = "";
            //Re-create cancellation token source
            cts.Dispose();
            cts = new CancellationTokenSource();
            return;
        }

        //overload for successful queries
        private void EndTasks(string computernameorip, string queryerrors)
        {
            //Add query to history
            AddToQueryHistory(computernameorip);
            //Load query history
            //LoadQueryHistory();
            //Re-enable form elements after query has finished running
            btnQuery.Enabled = true;
            cbOperatingSystemInfo.Enabled = true;
            cbComputerInfo.Enabled = true;
            cbInternetExplorerInfo.Enabled = true;
            cbAdministratorsInfo.Enabled = true;
            cbSessionsInfo.Enabled = true;
            cbUserProfilesInfo.Enabled = true;
            cbVPNInfo.Enabled = true;
            if (SessionsList.Count > 0)
                btnSessionDetails.Enabled = true;
            else
                btnSessionDetails.Enabled = false;
            if (ProfilesList.Count > 0)
                btnProfileDetails.Enabled = true;
            else
                btnSessionDetails.Enabled = false;
            //Re-disable Cancel button
            btnCancelQuery.Enabled = false;
            //Clear status
            lbStatus.Text = "";
            //Re-create cancellation token source
            cts.Dispose();
            cts = new CancellationTokenSource();
            //check for errors and show in separate window if there have been any 
            if (!String.IsNullOrEmpty(queryerrors))
            {
                QueryErrorsForm = new QueryErrors(queryerrors);
                QueryErrorsForm.Show();
            }
            return;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelQuery_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Cancelling...";
            cts.Cancel();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string computernameorip = PrepareComputerNameOrIP(cmbComputerNameOrIP.Text);
            Ping pingSender = new Ping();
            string pingreplies = "";
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    PingReply reply = pingSender.Send(computernameorip);
                    if (reply.Status == IPStatus.Success)
                        pingreplies = pingreplies + "\r\n" + reply.Status.ToString() + " (" + reply.RoundtripTime.ToString() + " ms)";
                    else
                        pingreplies = pingreplies + "\r\n" + reply.Status.ToString();
                }
            }
            catch (PingException ex)
            {
                tbPingReplies.Text = ex.Message;
                return;
            }
            //});
            tbPingReplies.Text = pingreplies.Remove(0, 2);
        }

        private void btnSessionDetails_Click(object sender, EventArgs e)
        {
            SessionDetailsForm = new SessionDetails();
            SessionDetailsForm.SessionDetailsList = SessionsList;
            SessionDetailsForm.Show();
        }

        private void btnProfileDetails_Click(object sender, EventArgs e)
        {
            ProfileDetailsForm = new ProfileDetails();
            ProfileDetailsForm.ProfileDetailsList = ProfilesList;
            ProfileDetailsForm.Show();
        }
    }

    public class SessionListItem
    {
        public string UserName { get; set; }
        public string LogonType { get; set; }
        public string LogonId { get; set; }
        public string StartTime { get; set; }
            
        public SessionListItem (string userName, string logonType, string logonId, string startTime)
        {
            UserName = userName;
            LogonType = logonType;
            LogonId = logonId;
            StartTime = startTime;
        } 
    }

    public class ProfileListItem
    {
        public string UserName { get; set; }
        public string SID { get; set; }
        public string LastUsed { get; set; }

        public ProfileListItem(string userName, string sID, string lastUsed)
        {
            UserName = userName;
            SID = sID;
            LastUsed = lastUsed;
        }
    }

    public enum SID_NAME_USE
    {
        SidTypeUser = 1,
        SidTypeGroup,
        SidTypeDomain,
        SidTypeAlias,
        SidTypeWellKnownGroup,
        SidTypeDeletedAccount,
        SidTypeInvalid,
        SidTypeUnknown,
        SidTypeComputer
    }
    public class NativeMethods
    {
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LookupAccountSid(
        string lpSystemName,
        [MarshalAs(UnmanagedType.LPArray)] byte[] Sid,
        StringBuilder lpName,
        ref uint cchName,
        StringBuilder ReferencedDomainName,
        ref uint cchReferencedDomainName,
        out SID_NAME_USE peUse);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern SafeFileHandle CreateFile(
        [MarshalAs(UnmanagedType.LPTStr)] string filename,
        [MarshalAs(UnmanagedType.U4)] FileAccess access,
        [MarshalAs(UnmanagedType.U4)] FileShare share,
        IntPtr securityAttributes,
        [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
        [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
        IntPtr templateFile);

        [DllImport("shlwapi.dll", EntryPoint = "PathFileExistsW", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PathFileExists([MarshalAs(UnmanagedType.LPTStr)]string pszPath);


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileW([MarshalAs(UnmanagedType.LPWStr)]string lpFileName);
    }
}
