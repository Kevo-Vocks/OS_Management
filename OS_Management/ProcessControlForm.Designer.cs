namespace OS_Management
{
    partial class ProcessControlForm
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
            btnOpenWord = new Button();
            btnOpenNotepad = new Button();
            btnOpenAccess = new Button();
            btnOpenWebBrowser = new Button();
            VSCommunity = new Button();
            btnOpenVSCode = new Button();
            btnOpenExcel = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnOpenWord
            // 
            btnOpenWord.BackColor = Color.Green;
            btnOpenWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenWord.ForeColor = Color.White;
            btnOpenWord.Location = new Point(56, 106);
            btnOpenWord.Margin = new Padding(4);
            btnOpenWord.Name = "btnOpenWord";
            btnOpenWord.Size = new Size(174, 59);
            btnOpenWord.TabIndex = 0;
            btnOpenWord.Text = "Word";
            btnOpenWord.UseVisualStyleBackColor = false;
            btnOpenWord.Click += btnOpenWord_Click;
            // 
            // btnOpenNotepad
            // 
            btnOpenNotepad.BackColor = Color.Green;
            btnOpenNotepad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenNotepad.ForeColor = Color.White;
            btnOpenNotepad.Location = new Point(320, 105);
            btnOpenNotepad.Margin = new Padding(4);
            btnOpenNotepad.Name = "btnOpenNotepad";
            btnOpenNotepad.Size = new Size(174, 59);
            btnOpenNotepad.TabIndex = 1;
            btnOpenNotepad.Text = "Notepad";
            btnOpenNotepad.UseVisualStyleBackColor = false;
            btnOpenNotepad.Click += btnOpenNotepad_Click;
            // 
            // btnOpenAccess
            // 
            btnOpenAccess.BackColor = Color.Green;
            btnOpenAccess.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenAccess.ForeColor = Color.White;
            btnOpenAccess.Location = new Point(56, 189);
            btnOpenAccess.Margin = new Padding(4);
            btnOpenAccess.Name = "btnOpenAccess";
            btnOpenAccess.Size = new Size(174, 59);
            btnOpenAccess.TabIndex = 2;
            btnOpenAccess.Text = "Access";
            btnOpenAccess.UseVisualStyleBackColor = false;
            btnOpenAccess.Click += btnOpenAccess_Click;
            // 
            // btnOpenWebBrowser
            // 
            btnOpenWebBrowser.BackColor = Color.Green;
            btnOpenWebBrowser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenWebBrowser.ForeColor = Color.White;
            btnOpenWebBrowser.Location = new Point(574, 106);
            btnOpenWebBrowser.Margin = new Padding(4);
            btnOpenWebBrowser.Name = "btnOpenWebBrowser";
            btnOpenWebBrowser.Size = new Size(174, 59);
            btnOpenWebBrowser.TabIndex = 3;
            btnOpenWebBrowser.Text = "Web Browser";
            btnOpenWebBrowser.UseVisualStyleBackColor = false;
            btnOpenWebBrowser.Click += btnOpenWebBrowser_Click;
            // 
            // VSCommunity
            // 
            VSCommunity.BackColor = Color.Green;
            VSCommunity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            VSCommunity.ForeColor = Color.White;
            VSCommunity.Location = new Point(320, 273);
            VSCommunity.Margin = new Padding(4);
            VSCommunity.Name = "VSCommunity";
            VSCommunity.Size = new Size(174, 59);
            VSCommunity.TabIndex = 4;
            VSCommunity.Text = "VS Community";
            VSCommunity.UseVisualStyleBackColor = false;
            VSCommunity.Click += btnOpenVSCommunity_Click;
            // 
            // btnOpenVSCode
            // 
            btnOpenVSCode.BackColor = Color.Green;
            btnOpenVSCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenVSCode.ForeColor = Color.White;
            btnOpenVSCode.Location = new Point(321, 197);
            btnOpenVSCode.Margin = new Padding(4);
            btnOpenVSCode.Name = "btnOpenVSCode";
            btnOpenVSCode.Size = new Size(174, 59);
            btnOpenVSCode.TabIndex = 5;
            btnOpenVSCode.Text = "VS Code";
            btnOpenVSCode.UseVisualStyleBackColor = false;
            btnOpenVSCode.Click += btnOpenVSCode_Click;
            // 
            // btnOpenExcel
            // 
            btnOpenExcel.BackColor = Color.Green;
            btnOpenExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenExcel.ForeColor = Color.White;
            btnOpenExcel.Location = new Point(56, 272);
            btnOpenExcel.Margin = new Padding(4);
            btnOpenExcel.Name = "btnOpenExcel";
            btnOpenExcel.Size = new Size(174, 59);
            btnOpenExcel.TabIndex = 6;
            btnOpenExcel.Text = "Excel";
            btnOpenExcel.UseVisualStyleBackColor = false;
            btnOpenExcel.Click += btnOpenExcel_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Green;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(608, 280);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 52);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.Location = new Point(77, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 24);
            label1.TabIndex = 8;
            label1.Text = "Microsoft Office";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.Location = new Point(337, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 9;
            label2.Text = "Tools";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(574, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 10;
            label3.Text = "Browsers";
            // 
            // ProcessControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1143, 630);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnOpenExcel);
            Controls.Add(btnOpenVSCode);
            Controls.Add(VSCommunity);
            Controls.Add(btnOpenWebBrowser);
            Controls.Add(btnOpenAccess);
            Controls.Add(btnOpenNotepad);
            Controls.Add(btnOpenWord);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcessControlForm";
            Text = "ProcessControlForm";
            WindowState = FormWindowState.Maximized;
            Load += ProcessControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenWord;
        private Button btnOpenNotepad;
        private Button btnOpenAccess;
        private Button btnOpenWebBrowser;
        private Button VSCommunity;
        private Button btnOpenVSCode;
        private Button btnOpenExcel;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}