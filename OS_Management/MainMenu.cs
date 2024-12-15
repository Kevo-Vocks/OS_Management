namespace OS_Management
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.MdiChildActivate += MainMenu_MdiChildActivate; // Subscribe to MDI child activate event
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Only open the default form if no child form is already open
            if (this.MdiChildren.Length == 0)
            {
                FileControlForm fileControlForm = new FileControlForm();
                fileControlForm.MdiParent = this;
                fileControlForm.Show();
            }
        }

        private void newfileManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileControlForm fileControlForm = new FileControlForm();
            fileControlForm.MdiParent = this;
            fileControlForm.Show();
        }

        private void processManagementToolStripMenuItem_Click(object sender, EventArgs args)
        {
            ProcessControlForm processControlForm = new ProcessControlForm();
            processControlForm.MdiParent = this;
            processControlForm.Show();
        }

        private void deviceManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceControlForm deviceControlForm = new DeviceControlForm();
            deviceControlForm.MdiParent = this;
            deviceControlForm.Show();
        }

        private void iOManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add functionality for this menu if needed
        }

        private void informationControlFormToolStripMenuItem_Click(object sender, EventArgs args)
        {
            InformationControlForm informationControlForm = new InformationControlForm();
            informationControlForm.MdiParent = this;
            informationControlForm.Show();
        }

        private void communicationControlFormToolStripMenuItem_Click(object sender, EventArgs args)
        {
            ComuncationControlForm communicationControlForm = new ComuncationControlForm();
            communicationControlForm.MdiParent = this;
            communicationControlForm.Show();
        }

        // MDI Child Activate Event
        private void MainMenu_MdiChildActivate(object sender, EventArgs e)
        {
            // If there is an active child, set the title and highlight
            if (this.ActiveMdiChild != null)
            {
                // Update the main form title with the active child form's title
                this.Text = "MainMenu - " + this.ActiveMdiChild.Text;
            }
            else
            {
                this.Text = "MainMenu"; // Reset title when no active child form
            }
        }
    }

}
