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
            btnClick = new Button();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Segoe UI", 15F);
            btnClick.Location = new Point(94, 88);
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
            lbl1.Location = new Point(325, 223);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "label1";
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Controls.Add(btnClick);
            Name = "StudentProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label lbl1;
    }
}
