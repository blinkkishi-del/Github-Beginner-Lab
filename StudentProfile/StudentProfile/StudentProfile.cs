namespace StudentProfile
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
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
    }
}
