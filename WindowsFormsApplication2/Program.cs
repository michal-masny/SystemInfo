using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace SystemInfo
{
    static class Program
    {
        public static string ProgramPath;
        public static string ProgramName;
        public static string QueryCacheName;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            ProgramPath = appPath.Substring(8).Replace(@"/", @"\");
            ProgramName = Path.GetFileName(appPath);
            QueryCacheName = ProgramName + ":" + "searches.txt";
            if (!NativeMethods.PathFileExists(QueryCacheName))
            {
                try
                {
                    SafeFileHandle safeADSHandle = NativeMethods.CreateFile(Program.QueryCacheName,
                    FileAccess.Read,
                    FileShare.ReadWrite,
                    IntPtr.Zero,
                    FileMode.CreateNew,
                    0,
                    IntPtr.Zero);
                    if (safeADSHandle.IsInvalid)
                    {
                        Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not create a query history file. Your queries will not be saved.\r\nThe system error message was: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Application.Run(new frmSystemInformation());
        }
    }
}
