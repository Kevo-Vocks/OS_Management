using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Management
{
    public partial class FileControlForm : Form
    {
        public FileControlForm()
        {
            InitializeComponent();
        }

        private void FileControlForm_Load(object sender, EventArgs e)
        {

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.Create(saveFileDialog.FileName).Close();
                        txtOutput.AppendText($"File created: {saveFileDialog.FileName}\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    txtOutput.Text = content;
                    txtOutput.AppendText($"File opened: {openFileDialog.FileName}\n");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtOutput.Text);
                    txtOutput.AppendText($"File saved: {saveFileDialog.FileName}\n");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Delete(openFileDialog.FileName);
                    txtOutput.AppendText($"File deleted: {openFileDialog.FileName}\n");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the FileControlForm
        }
    }
}
