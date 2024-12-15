namespace OS_Management
{
    partial class InformationControlForm
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
            btnGetCurrentDateTime = new Button();
            btnGetSystemData = new Button();
            txtSystemData = new TextBox();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnGetCurrentDateTime
            // 
            btnGetCurrentDateTime.BackColor = Color.Green;
            btnGetCurrentDateTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGetCurrentDateTime.ForeColor = Color.White;
            btnGetCurrentDateTime.Location = new Point(530, 25);
            btnGetCurrentDateTime.Name = "btnGetCurrentDateTime";
            btnGetCurrentDateTime.Size = new Size(206, 43);
            btnGetCurrentDateTime.TabIndex = 0;
            btnGetCurrentDateTime.Text = "Get Current Date/Time";
            btnGetCurrentDateTime.UseVisualStyleBackColor = false;
            btnGetCurrentDateTime.Click += btnGetCurrentDateTime_Click;
            // 
            // btnGetSystemData
            // 
            btnGetSystemData.BackColor = Color.Green;
            btnGetSystemData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGetSystemData.ForeColor = Color.White;
            btnGetSystemData.Location = new Point(530, 89);
            btnGetSystemData.Name = "btnGetSystemData";
            btnGetSystemData.Size = new Size(206, 40);
            btnGetSystemData.TabIndex = 3;
            btnGetSystemData.Text = "Get system Data";
            btnGetSystemData.UseVisualStyleBackColor = false;
            btnGetSystemData.Click += btnGetSystemData_Click;
            // 
            // txtSystemData
            // 
            txtSystemData.BackColor = SystemColors.ControlLight;
            txtSystemData.Location = new Point(530, 169);
            txtSystemData.Multiline = true;
            txtSystemData.Name = "txtSystemData";
            txtSystemData.ReadOnly = true;
            txtSystemData.Size = new Size(206, 23);
            txtSystemData.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Green;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(568, 227);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 53);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 37);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 6;
            label1.Text = "Computer Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 185);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 8;
            label3.Text = "Ip Address";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Location = new Point(205, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Location = new Point(205, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.Location = new Point(205, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(275, 128);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 14;
            button1.Text = "GetInfo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGetInfo_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(275, 222);
            button2.Name = "button2";
            button2.Size = new Size(96, 33);
            button2.TabIndex = 15;
            button2.Text = "Get";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnGet_Click;
            // 
            // InformationControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(txtSystemData);
            Controls.Add(btnGetSystemData);
            Controls.Add(btnGetCurrentDateTime);
            Name = "InformationControlForm";
            Text = "InformationControlForm";
            WindowState = FormWindowState.Maximized;
            Load += InformationControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetCurrentDateTime;
        private TextBox txtSetDateTime;
        private Button btnGetSystemData;
        private TextBox txtSystemData;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}