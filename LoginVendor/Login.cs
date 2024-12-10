using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Adding a Sql Connection

namespace LoginVendor
{
    public partial class Login : Form
    {
        //When using VM
        private SqlConnection sqlConnection;
        private String connectionString = @"Data Source=DESKTOP-BPLDLKV\SQLEXPRESS;Initial Catalog=VendorLogin;Integrated Security=True;
                                            TrustServerCertificate=True"; // SQL Connection String
        public Login()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);

            
        }


        private bool ValidateUser(string username, string passwords)
        {
            sqlConnection.Open();
            string query = @"SELECT COUNT(*) AS UserCount FROM VendorCredentials WHERE Username = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue ("@password", passwords);

            //Execute the command
            int userCount = (int)command.ExecuteScalar();

            sqlConnection.Close();

            return userCount > 0;  
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (ValidateUser(txtUsername.Text, txtPassword.Text))
            {
                if (comboBoxType.SelectedItem == null)
                {

                    MessageBox.Show("Please Select a valid user type.");
                    comboBoxType.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Incorrect username or passwords!");
                    txtPassword.Clear();
                    txtUsername.Clear();
                    txtUsername.Focus();
                }

                string userSelectedType = comboBoxType.Text; // Get the selected user type from the ComboBox

                // Fetch user type from the database for the given username
                string userTypeQuery = "SELECT Type FROM VendorCredentials WHERE Username = @Username";
                SqlCommand command = new SqlCommand(userTypeQuery, sqlConnection);
                command.Parameters.AddWithValue("@Username", txtUsername.Text);

                string sqlType = (string)command.ExecuteScalar();

                sqlConnection.Close();

                if (userSelectedType == sqlType)
                {
                    // User type is correct
                    if (userSelectedType == "Admin")
                    {
                        new Admin().Show();
                        this.Hide();
                    }
                    else if (userSelectedType == "Vendor")
                    {
                        new VendorBasicInfo().Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User type is incorrect! Please select the correct user type.");
                }
            }
            
            else
            {
                MessageBox.Show("Incorrect username or passwords!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
