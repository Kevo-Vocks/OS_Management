namespace OS_Management
{
    partial class ComuncationControlForm
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
            txtReceivedMessages = new RichTextBox();
            txtSendMessage = new TextBox();
            btnSend = new Button();
            btnStartStop = new Button();
            lblSendStatus = new Label();
            lblMonitorStatus = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtReceivedMessages
            // 
            txtReceivedMessages.Location = new Point(348, 146);
            txtReceivedMessages.Margin = new Padding(4);
            txtReceivedMessages.Name = "txtReceivedMessages";
            txtReceivedMessages.Size = new Size(257, 144);
            txtReceivedMessages.TabIndex = 0;
            txtReceivedMessages.Text = "";
            // 
            // txtSendMessage
            // 
            txtSendMessage.Location = new Point(87, 59);
            txtSendMessage.Margin = new Padding(4);
            txtSendMessage.Name = "txtSendMessage";
            txtSendMessage.Size = new Size(223, 29);
            txtSendMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Green;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(348, 36);
            btnSend.Margin = new Padding(4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(157, 52);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.Green;
            btnStartStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Location = new Point(176, 161);
            btnStartStop.Margin = new Padding(4);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(134, 66);
            btnStartStop.TabIndex = 3;
            btnStartStop.Text = "Start/Stop";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // lblSendStatus
            // 
            lblSendStatus.AutoSize = true;
            lblSendStatus.Location = new Point(146, 333);
            lblSendStatus.Margin = new Padding(4, 0, 4, 0);
            lblSendStatus.Name = "lblSendStatus";
            lblSendStatus.Size = new Size(0, 21);
            lblSendStatus.TabIndex = 4;
            // 
            // lblMonitorStatus
            // 
            lblMonitorStatus.AutoSize = true;
            lblMonitorStatus.Location = new Point(329, 333);
            lblMonitorStatus.Margin = new Padding(4, 0, 4, 0);
            lblMonitorStatus.Name = "lblMonitorStatus";
            lblMonitorStatus.Size = new Size(0, 21);
            lblMonitorStatus.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(485, 344);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(120, 56);
            button3.TabIndex = 6;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnClose_Click;
            // 
            // ComuncationControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1143, 630);
            Controls.Add(button3);
            Controls.Add(lblMonitorStatus);
            Controls.Add(lblSendStatus);
            Controls.Add(btnStartStop);
            Controls.Add(btnSend);
            Controls.Add(txtSendMessage);
            Controls.Add(txtReceivedMessages);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ComuncationControlForm";
            Text = "CommunicationControlForm";
            WindowState = FormWindowState.Maximized;
            Load += ComuncationControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtReceivedMessages;
        private TextBox txtSendMessage;
        private Button btnSend;
        private Button btnStartStop;
        private Label lblSendStatus;
        private Label lblMonitorStatus;
        private Button button3;
    }
}