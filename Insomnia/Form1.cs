using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Insomnia
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("kernel32.dll")]
        public static extern uint SetThreadExecutionState(uint esFlags);
        public const uint ES_CONTINUOUS = 0x80000000;
        public const uint ES_SYSTEM_REQUIRED = 0x00000001;
        public const uint ES_DISPLAY_REQUIRED = 0x00000002;

        private static string[] WAKE_UP_LIST = { };

        public Form1()
        {
            InitializeComponent();
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string filePath = Path.Combine(Path.GetDirectoryName(assemblyPath), "WAKE_UP_LIST.txt");
            if (System.IO.File.Exists(filePath))
            {
                WAKE_UP_LIST = System.IO.File.ReadLines(filePath).ToArray();
            }
        }
        private void changeState()
        {
            if (!insomnia.Enabled)
            {

                insomnia.Start();
                status.Text = "Enabled";
                status.ForeColor = Color.PaleGreen;
            }
            else
            {
                insomnia.Stop();
                SetThreadExecutionState(ES_CONTINUOUS);
                status.Text = "Disabled";
                status.ForeColor = Color.LightCoral;
            }
        }

        private void title_Click_1(object sender, EventArgs e)
        {
            changeState();
        }

        private void status_Click(object sender, EventArgs e)
        {
            changeState();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            SetThreadExecutionState(ES_CONTINUOUS);
            Application.Exit();
        }

        private void insomnia_Tick(object sender, EventArgs e)
        {
            SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED | ES_DISPLAY_REQUIRED);
            if (WAKE_UP_LIST.Length > 0)
                foreach(string s in WAKE_UP_LIST)
                    foreach (Process p in Process.GetProcessesByName(s))
                    {

                        try
                        {
                            SetForegroundWindow(p.MainWindowHandle);
                            SendKeys.SendWait("{CAPSLOCK}");
                            Thread.Sleep(1000);
                            SendKeys.SendWait("{CAPSLOCK}");
                            SendKeys.SendWait("{TAB}");
                        }
                        catch { }
                    }
        }
    }
}