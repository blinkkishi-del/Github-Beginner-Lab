using System.Drawing;
using System;

namespace StudentProfile
{
    public partial class StudentProfile : Form
    {
        private const int MaxCharacters = 250;

        public StudentProfile()
        {
            InitializeComponent();
            ConfigurePasswordcriteria();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub Beginner Lab", "Student Profile");


            MessageBox.Show("Contact Number:  09171234567");
        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGPA.Text))
            {
                txtGPA.BackColor = Color.White;
                return;
            }

            // Convert text to number and check limits
            if (decimal.TryParse(txtGPA.Text, out decimal gpa))
            {
                if (gpa >= 1.25m && gpa <= 4.00m)
                {
                    txtGPA.BackColor = Color.LightGreen; // Success!
                }
                else
                {
                    txtGPA.BackColor = Color.LightCoral; // Out of range
                }
            }

        }

        private void txtGPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Prevent typing a second decimal point
            if (e.KeyChar == '.' && txtGPA.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 8)
            {
                errorProvider1.SetError(txtPassword, ""); // Clear error
                lblStatus.Text = "Valid password criteria met!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "Password requires a minimum length of 8 characters.");
                lblStatus.Text = $"Characters: {txtPassword.Text.Length}/8";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }

        }


        private void ConfigurePasswordcriteria()
        {
            txtPassword.PasswordChar = '*';
            errorProvider1.SetError(txtPassword, "Password must be at least 8 characters long");
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            int currentLength = txtFeedback.Text.Length;

   
            lblCharCount.Text = $"{currentLength}/{MaxCharacters} characters";

         
            if (currentLength > MaxCharacters)
            {
                lblCharCount.ForeColor = Color.Red;
                lblCharCount.Text += " (Limit exceeded!)";
            }
            else
            {
                lblCharCount.ForeColor = Color.Black;
            }
        }
    }
}

