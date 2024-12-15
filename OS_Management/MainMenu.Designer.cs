namespace OS_Management
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileManagementToolStripMenuItem = new ToolStripMenuItem();
            processManagementToolStripMenuItem = new ToolStripMenuItem();
            informationManagementToolStripMenuItem = new ToolStripMenuItem();
            communicationManagementToolStripMenuItem = new ToolStripMenuItem();
            deviceManagementToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileManagementToolStripMenuItem, processManagementToolStripMenuItem, informationManagementToolStripMenuItem, communicationManagementToolStripMenuItem, deviceManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileManagementToolStripMenuItem
            // 
            fileManagementToolStripMenuItem.Name = "fileManagementToolStripMenuItem";
            fileManagementToolStripMenuItem.Size = new Size(111, 20);
            fileManagementToolStripMenuItem.Text = "File Management";
            fileManagementToolStripMenuItem.Click += newfileManagementToolStripMenuItem_Click;
            // 
            // processManagementToolStripMenuItem
            // 
            processManagementToolStripMenuItem.Name = "processManagementToolStripMenuItem";
            processManagementToolStripMenuItem.Size = new Size(133, 20);
            processManagementToolStripMenuItem.Text = "Process Management";
            processManagementToolStripMenuItem.Click += processManagementToolStripMenuItem_Click;
            // 
            // informationManagementToolStripMenuItem
            // 
            informationManagementToolStripMenuItem.Name = "informationManagementToolStripMenuItem";
            informationManagementToolStripMenuItem.Size = new Size(156, 20);
            informationManagementToolStripMenuItem.Text = "Information Management";
            informationManagementToolStripMenuItem.Click += informationControlFormToolStripMenuItem_Click;
            // 
            // communicationManagementToolStripMenuItem
            // 
            communicationManagementToolStripMenuItem.Name = "communicationManagementToolStripMenuItem";
            communicationManagementToolStripMenuItem.Size = new Size(180, 20);
            communicationManagementToolStripMenuItem.Text = "Communication Management";
            communicationManagementToolStripMenuItem.Click += communicationControlFormToolStripMenuItem_Click;
            // 
            // deviceManagementToolStripMenuItem
            // 
            deviceManagementToolStripMenuItem.Name = "deviceManagementToolStripMenuItem";
            deviceManagementToolStripMenuItem.Size = new Size(128, 20);
            deviceManagementToolStripMenuItem.Text = "Device Management";
            deviceManagementToolStripMenuItem.Click += deviceManagementToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileManagementToolStripMenuItem;
        private ToolStripMenuItem processManagementToolStripMenuItem;
        private ToolStripMenuItem informationManagementToolStripMenuItem;
        private ToolStripMenuItem communicationManagementToolStripMenuItem;
        private ToolStripMenuItem deviceManagementToolStripMenuItem;
    }
}
