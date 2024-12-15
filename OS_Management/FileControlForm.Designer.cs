namespace OS_Management
{
    partial class FileControlForm
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
            btnOpen = new Button();
            button2 = new Button();
            button3 = new Button();
            btnDelete = new Button();
            txtOutput = new TextBox();
            btnClose = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.AutoEllipsis = true;
            btnOpen.BackColor = Color.Green;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(10, 68);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(120, 50);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 132);
            button2.Name = "button2";
            button2.Size = new Size(120, 48);
            button2.TabIndex = 1;
            button2.Text = "Save File";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSave_Click;
            // 
            // button3
            // 
            button3.Location = new Point(173, 195);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoEllipsis = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(10, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 45);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.ButtonFace;
            txtOutput.Location = new Point(150, 10);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(361, 230);
            txtOutput.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = Color.Green;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(380, 257);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 45);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.AutoEllipsis = true;
            btnCreate.BackColor = Color.Green;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(10, 10);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 44);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create File";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FileControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCreate);
            Controls.Add(btnClose);
            Controls.Add(txtOutput);
            Controls.Add(btnDelete);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnOpen);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FileControlForm";
            Text = "FileControlForm";
            WindowState = FormWindowState.Maximized;
            Load += FileControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button button2;
        private Button button3;
        private Button btnDelete;
        private TextBox txtOutput;
        private Button btnClose;
        private Button btnCreate;
    }
}