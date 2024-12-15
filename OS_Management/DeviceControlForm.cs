using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace OS_Management
{
    public partial class DeviceControlForm : Form
    { 
    public DeviceControlForm()
        {
            InitializeComponent();
        }

        private void DeviceControlForm_Load(object sender, EventArgs e)
        {
            // Initialize buttons, labels, etc. as needed
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Handle Restart operation
            RestartDevice();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            // Handle Sleep operation
            Application.SetSuspendState(PowerState.Suspend, true, false);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            // Handle Shutdown operation
            ShutdownDevice();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // Handle Sign out operation
            SignOutUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // These are the backend methods that you can implement
        private void RestartDevice()
        {
            try
            {
                // Restart the local device
                System.Diagnostics.Process.Start("shutdown", "/r /t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restarting device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SleepDevice()
        {
            try
            {
                // Put the device to sleep
                System.Diagnostics.Process.Start("shutdown", "/h");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error putting device to sleep: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShutdownDevice()
        {
            try
            {
                // Shutdown the device
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error shutting down device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignOutUser()
        {
            try
            {
                // Sign out the current user
                System.Diagnostics.Process.Start("shutdown", "/l");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error signing out user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
