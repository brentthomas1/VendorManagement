using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginVendor
{
    public partial class NewVendorInfo : Form
    {
        private SqlConnection sqlConnection;
        private String connectionString = @"Data Source=vendor-mgnt.database.windows.net;Initial Catalog=VendorLogIn;Persist Security Info=True;User ID=Ernesto;Password=Password1!;TrustServerCertificate=True
                                            Integrated Security = True; TrustServerCertificate=True";

        private Excel.Application xlApp;
        private Excel.Workbook xlWorkBook;
        private Excel.Worksheet xlWorkSheet;
        private string excelFilePath = @"C:\Users\erodr\OneDrive\Documents\KSU\Senior\Fall 2024\MIS 555\Excel\ExcelFile2.xlsx";

        public NewVendorInfo()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
        }

        
        private byte[] GetPhoto()
        {
            if (picVendorPhoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    // Save image to stream in PNG format
                    picVendorPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray(); // Converts the image in memory stream to byte array
                }
            }
            return null; // Return null if no image is loaded
        }
        


        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlCommandText = @"INSERT INTO NewVendorsDB 
                             (New_VID, POC_Name, POC_JobTitle, POC_Email, POC_Phone, POC_Company, POC_ComAddress, City, Photo)
                              VALUES (@New_VID, @POC_Name, @POC_JobTitle, @POC_Email, @POC_Phone, @POC_Company, @POC_ComAddress, @City, @Photo)";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    long nextId = GetNextId(sqlConnection);

                    using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@New_VID", nextId);
                        sqlCommand.Parameters.AddWithValue("@POC_Name", txtPOCName.Text);
                        sqlCommand.Parameters.AddWithValue("@POC_JobTitle", txtPOCJobTitle.Text);
                        sqlCommand.Parameters.AddWithValue("@POC_Email", txtPOCEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@POC_Phone", txtPOCPhone.Text);
                        sqlCommand.Parameters.AddWithValue("@POC_Company", txtPOCCompany.Text);
                        sqlCommand.Parameters.AddWithValue("@POC_ComAddress", txtCompanyAddress.Text);
                        sqlCommand.Parameters.AddWithValue("@City", listBox3.GetItemText(listBox3.SelectedItem));


                        //Leave for the photo value
                        sqlCommand.Parameters.AddWithValue("@Photo", GetPhoto());
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("New vendor information saved successfully!");
                    }

                    sqlConnection.Close();
                }

                // Initialize Excel objects
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(excelFilePath);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];

                // Example of writing data to Excel
                int row = 2; // Example row
                while (xlWorkSheet.Cells[row, 1].Value != null)
                {
                    row++;
                }

                xlWorkSheet.Cells[row, 1].Value = txtPOCName.Text;
                xlWorkSheet.Cells[row, 2].Value = txtPOCJobTitle.Text;
                xlWorkSheet.Cells[row, 3].Value = txtPOCEmail.Text;
                xlWorkSheet.Cells[row, 4].Value = txtPOCPhone.Text;
                xlWorkSheet.Cells[row, 5].Value = txtPOCCompany.Text;
                xlWorkSheet.Cells[row, 6].Value = txtCompanyAddress.Text;
                xlWorkSheet.Cells[row, 7].Value = listBox3.GetItemText(listBox3.SelectedItem);

                MessageBox.Show("Data saved to Excel successfully!");

                // Save and clean up
                xlWorkBook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save to Excel or database: " + ex.Message);
            }
            finally
            {
                // Cleanup
                if (xlWorkBook != null)
                {
                    xlWorkBook.Close();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                }
                if (xlApp != null)
                {
                    xlApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                }
            }
        }

        private int GetNextId(SqlConnection sqlConnection)
        {
            string query = "SELECT ISNULL(MAX(New_VID), 0) + 1 FROM NewVendorsDB";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return (int)cmd.ExecuteScalar();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            //Open the file Daialog
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the image into the PictureBox
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
            new NewVendorInfo().Show();
            this.Hide();
        }

        private void picVendorPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
