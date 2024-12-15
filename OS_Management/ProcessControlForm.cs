using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Management
{
    public partial class ProcessControlForm : Form
    {
        public ProcessControlForm()
        {
            InitializeComponent();
        }

        private void ProcessControlForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenWord_Click(object sender, EventArgs e)
        {
            OpenProcess(@"C:\Program Files (x86)\Microsoft Office\Office15\WINWORD.EXE"); // Microsoft Word
        }

        private void btnOpenNotepad_Click(object sender, EventArgs e)
        {
            OpenProcess("notepad.exe"); // Notepad
        }

        private void btnOpenExcel_Click(object sender, EventArgs e)
        {
            OpenProcess(@"C:\Program Files (x86)\Microsoft Office\Office15\EXCEL.EXE"); // Microsoft Excel
        }

        private void btnOpenAccess_Click(object sender, EventArgs e)
        {
            OpenProcess(@"C:\Program Files (x86)\Microsoft Office\Office15\MSACCESS.EXE"); // Microsoft Access
        }

        private void btnOpenVSCode_Click(object sender, EventArgs e)
        {
            OpenProcess(@"C:\Program Files\Microsoft VS Code\bin\code.exe"); // Visual Studio Code
        }

        private void btnOpenWebBrowser_Click(object sender, EventArgs e)
        {
            OpenProcess("https://www.chrome.com"); // Open a web browser
        }

        private void btnOpenVSCommunity_Click(object sender, EventArgs e)
        {
            OpenProcess(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe"); // Visual Studio Community
        }

        private void OpenProcess(string processName)
        {
            try
            {
                Process.Start(processName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening {processName}: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
