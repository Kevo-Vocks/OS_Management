namespace OS_Management
{
    partial class DeviceControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(451, 85);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(139, 56);
            button1.TabIndex = 0;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRestart_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(174, 85);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(139, 56);
            button2.TabIndex = 1;
            button2.Text = "Sleep";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSleep_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(451, 211);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(139, 56);
            button3.TabIndex = 2;
            button3.Text = "ShutDown";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnShutdown_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(174, 225);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(139, 56);
            button4.TabIndex = 3;
            button4.Text = "Signout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnSignOut_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(451, 337);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(139, 56);
            button5.TabIndex = 4;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnClose_Click;
            // 
            // DeviceControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1144, 630);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "DeviceControlForm";
            Text = "DeviceControlForm";
            WindowState = FormWindowState.Maximized;
            Load += DeviceControlForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}