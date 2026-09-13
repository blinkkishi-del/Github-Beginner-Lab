namespace StudentProfile
{
    partial class StudentProfile
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
            components = new System.ComponentModel.Container();
            btnClick = new Button();
            lbl1 = new Label();
            txtGPA = new TextBox();
            txtPassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            lblStatus = new Label();
            label1 = new Label();
            txtFeedback = new TextBox();
            lblCharCount = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Segoe UI", 15F);
            btnClick.Location = new Point(12, 12);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(161, 61);
            btnClick.TabIndex = 0;
            btnClick.Text = "Click Here";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 109);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(89, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Enter Your GPA:";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(31, 127);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 2;
            txtGPA.TextChanged += txtGPA_TextChanged;
            txtGPA.KeyPress += txtGPA_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(31, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(31, 235);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 191);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter Password Here:";
            // 
            // txtFeedback
            // 
            txtFeedback.Location = new Point(237, 144);
            txtFeedback.Multiline = true;
            txtFeedback.Name = "txtFeedback";
            txtFeedback.ScrollBars = ScrollBars.Vertical;
            txtFeedback.Size = new Size(329, 65);
            txtFeedback.TabIndex = 6;
            txtFeedback.TextChanged += txtFeedback_TextChanged;
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.Location = new Point(438, 217);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(118, 15);
            lblCharCount.TabIndex = 7;
            lblCharCount.Text = "Enter Password Here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 109);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 8;
            label2.Text = "Ennter your Feedback Here:";
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 458);
            Controls.Add(label2);
            Controls.Add(lblCharCount);
            Controls.Add(txtFeedback);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(txtPassword);
            Controls.Add(txtGPA);
            Controls.Add(lbl1);
            Controls.Add(btnClick);
            Name = "StudentProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label lbl1;
        private TextBox txtGPA;
        private TextBox txtPassword;
        private ErrorProvider errorProvider1;
        private Label lblStatus;
        private Label label1;
        private TextBox txtFeedback;
        private Label lblCharCount;
        private Label label2;
    }
}
