using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace OS_Management
{
    public partial class ComuncationControlForm : Form
    {
        private bool isMonitoring = false;
        private Thread monitorThread;
        private CancellationTokenSource cancellationTokenSource;
        private string filePath = "communication.txt";

        public ComuncationControlForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtSendMessage.Text;

            if (!string.IsNullOrWhiteSpace(message))
            {
                try
                {
                    // Append the message to the file
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(message);
                    }

                    lblSendStatus.Text = "Message sent successfully!";
                    txtSendMessage.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a message to send.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!isMonitoring)
            {
                isMonitoring = true;
                lblMonitorStatus.Text = "Monitoring started...";
                btnStartStop.Text = "Stop Monitoring";

                cancellationTokenSource = new CancellationTokenSource();
                CancellationToken token = cancellationTokenSource.Token;

                // Start monitoring in a new thread
                monitorThread = new Thread(() => MonitorFile(token));
                monitorThread.IsBackground = true;
                monitorThread.Start();
            }
            else
            {
                isMonitoring = false;
                lblMonitorStatus.Text = "Monitoring stopped.";
                btnStartStop.Text = "Start Monitoring";

                // Signal cancellation
                cancellationTokenSource?.Cancel();
            }
        }

        private void MonitorFile(CancellationToken token)
        {
            long lastPosition = 0;

            while (!token.IsCancellationRequested)
            {
                if (File.Exists(filePath))
                {
                    using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        stream.Seek(lastPosition, SeekOrigin.Begin);

                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string newMessage = reader.ReadToEnd();

                            if (!string.IsNullOrWhiteSpace(newMessage))
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    txtReceivedMessages.AppendText(newMessage + Environment.NewLine);
                                });

                                lastPosition = stream.Position;
                            }
                        }
                    }
                }

                Thread.Sleep(1000); // Poll every second
            }
        }

        private void CommunicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isMonitoring = false;
            cancellationTokenSource?.Cancel();

            // Wait for the thread to finish if it's still running
            if (monitorThread?.IsAlive == true)
            {
                monitorThread.Join();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComuncationControlForm_Load(object sender, EventArgs e)
        {
        }
    }
}
