using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;

namespace OS_Management
{
    public partial class InformationControlForm : Form
    {
        public InformationControlForm()
        {
            InitializeComponent();
        }

        private void InformationControlForm_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string comname = System.Windows.Forms.SystemInformation.ComputerName;
            string username = System.Windows.Forms.SystemInformation.UserName;
            textBox1.Text = comname;
            textBox2.Text = username;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            { textBox3.Text = address.ToString(); }
        }


        private void btnGetCurrentDateTime_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            MessageBox.Show($"Current Date and Time: {currentDateTime}");
        }

        private void btnSetCurrentDateTime_Click(object sender, EventArgs e)
        {
            // Expecting input in "yyyy-MM-dd HH:mm:ss" format
            if (DateTime.TryParse(txtSetDateTime.Text, out DateTime newTime))
            {
                SetSystemDateTime(newTime);
                MessageBox.Show("System time updated.");
            }
            else
            {
                MessageBox.Show("Invalid date/time format. Please use 'yyyy-MM-dd HH:mm:ss'.");
            }
        }

        private void btnGetSystemData_Click(object sender, EventArgs e)
        {
            string osVersion = Environment.OSVersion.ToString();
            string machineName = Environment.MachineName;
            string systemData = $"OS Version: {osVersion}\nMachine Name: {machineName}";

            // Display system data in the text box
            txtSystemData.Text = systemData;
        }

        // P/Invoke to set system time
        [DllImport("kernel32.dll")]
        static extern bool SetSystemTime(ref SYSTEMTIME st);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Milliseconds;
        }

        private void SetSystemDateTime(DateTime newTime)
        {
            SYSTEMTIME st = new SYSTEMTIME
            {
                Year = (ushort)newTime.Year,
                Month = (ushort)newTime.Month,
                Day = (ushort)newTime.Day,
                Hour = (ushort)newTime.Hour,
                Minute = (ushort)newTime.Minute,
                Second = (ushort)newTime.Second,
                Milliseconds = (ushort)newTime.Millisecond
            };

            SetSystemTime(ref st);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
