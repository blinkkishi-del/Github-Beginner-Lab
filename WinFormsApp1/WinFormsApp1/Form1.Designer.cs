namespace WinFormsApp1
{
    partial class Form1
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
            txtActname = new TextBox();
            txtOrganizer = new TextBox();
            lblActname = new Label();
            lblOrganizer = new Label();
            btnRegister = new Button();
            listResult = new ListBox();
            SuspendLayout();
            // 
            // txtActname
            // 
            txtActname.Location = new Point(44, 104);
            txtActname.Name = "txtActname";
            txtActname.Size = new Size(100, 23);
            txtActname.TabIndex = 0;
            // 
            // txtOrganizer
            // 
            txtOrganizer.Location = new Point(209, 104);
            txtOrganizer.Name = "txtOrganizer";
            txtOrganizer.Size = new Size(100, 23);
            txtOrganizer.TabIndex = 1;
            // 
            // lblActname
            // 
            lblActname.AutoSize = true;
            lblActname.Location = new Point(44, 68);
            lblActname.Name = "lblActname";
            lblActname.Size = new Size(143, 15);
            lblActname.TabIndex = 2;
            lblActname.Text = "Enter Activity Name Here:";
            // 
            // lblOrganizer
            // 
            lblOrganizer.AutoSize = true;
            lblOrganizer.Location = new Point(209, 68);
            lblOrganizer.Name = "lblOrganizer";
            lblOrganizer.Size = new Size(119, 15);
            lblOrganizer.TabIndex = 3;
            lblOrganizer.Text = "Enter Organizer Here:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(142, 149);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // listResult
            // 
            listResult.BackColor = SystemColors.Window;
            listResult.FormattingEnabled = true;
            listResult.Location = new Point(44, 230);
            listResult.Name = "listResult";
            listResult.Size = new Size(301, 199);
            listResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 491);
            Controls.Add(listResult);
            Controls.Add(btnRegister);
            Controls.Add(lblOrganizer);
            Controls.Add(lblActname);
            Controls.Add(txtOrganizer);
            Controls.Add(txtActname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtActname;
        private TextBox txtOrganizer;
        private Label lblActname;
        private Label lblOrganizer;
        private Button btnRegister;
        private ListBox listResult;
    }
}
