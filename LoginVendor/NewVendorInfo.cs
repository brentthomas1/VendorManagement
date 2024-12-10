using System;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginVendor
{
    public partial class NewVendorInfo : Form
    {
        private readonly MySqlConnection mysqlConnection;
        private readonly string connectionString = "server=localhost;user=root;database=vendorDB;port=3306;password=Bshow123!;";

        public NewVendorInfo()
        {
            InitializeComponent();
            mysqlConnection = new MySqlConnection(connectionString);
        }

        private byte[] GetPhoto()
        {
            if (picVendorPhoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picVendorPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlCommandText = @"INSERT INTO vendorinfo 
                             (VendorID, POC_Name, POC_JobTitle, POC_Email, POC_Phone, POC_Company, POC_ComAddress, City, Photo)
                              VALUES (@VendorID, @POC_Name, @POC_JobTitle, @POC_Email, @POC_Phone, @POC_Company, @POC_ComAddress, @City, @Photo)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    long nextId = GetNextId(conn);

                    using (MySqlCommand cmd = new MySqlCommand(sqlCommandText, conn))
                    {
                        cmd.Parameters.AddWithValue("@VendorID", nextId);
                        cmd.Parameters.AddWithValue("@POC_Name", txtPOCName.Text);
                        cmd.Parameters.AddWithValue("@POC_JobTitle", txtPOCJobTitle.Text);
                        cmd.Parameters.AddWithValue("@POC_Email", txtPOCEmail.Text);
                        cmd.Parameters.AddWithValue("@POC_Phone", txtPOCPhone.Text);
                        cmd.Parameters.AddWithValue("@POC_Company", txtPOCCompany.Text);
                        cmd.Parameters.AddWithValue("@POC_ComAddress", txtCompanyAddress.Text);
                        cmd.Parameters.AddWithValue("@City", listBox3.GetItemText(listBox3.SelectedItem));
                        cmd.Parameters.AddWithValue("@Photo", GetPhoto());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New vendor information saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to database: " + ex.Message);
            }
        }

        private long GetNextId(MySqlConnection conn)
        {
            string query = "SELECT COALESCE(MAX(VendorID), 0) + 1 FROM vendorinfo";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picVendorPhoto.Image = Image.FromFile(openFileDialog2.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the photo: " + ex.Message);
                }
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewLog_Click(object sender, EventArgs e)
        {
            var newForm = new NewVendorInfo();
            newForm.Show();
            this.Hide();
        }

        private void picVendorPhoto_Click(object sender, EventArgs e)
        {
        }
    }
}
