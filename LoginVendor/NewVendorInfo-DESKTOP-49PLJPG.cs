using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginVendor
{
    public partial class NewVendorInfo : Form
    {
        private Excel.Application xlApp;

        //If on VM
        private string dbPath = @"C:\\Users\\VirtualM\\Documents\\KSU\\Senior\\Fall 2024\\MIS 555\\Excel\\ExcelFile";
        
        //If on laptop
        //private string dbPath = @"C:\Users\erodr\OneDrive\Documents\KSU\Senior\Fall 2024\MIS 555\Excel\ExcelFile";


        public NewVendorInfo()
        {
            InitializeComponent();
            
            xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook; // Open excel file
            Excel.Worksheet xlWorkSheet;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog2.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the photo: " + ex.Message);
                }
            }
        }

        private void btnNewLog_Click(object sender, EventArgs e)
        {
            new NewVendorInfo().Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var xlWorkBook = xlApp.Workbooks.Open(dbPath);
            var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];

            try
            {
                // Save inputs in Excel
                // Continue
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to write to Excel: " + ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Check if the PictureBox has an image
            if (pictureBox1.Image != null)
            {
                // Convert image in PictureBox to byte array
                var ms = new MemoryStream();//Maybe the actual box?
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Position = 0;  // Reset the stream position to the beginning

                // Save the image to a temporary file -- regardless of the original format users uploaded
                string tempImagePath = Path.GetTempFileName() + ".png";
                File.WriteAllBytes(tempImagePath, ms.ToArray());

                // Get image dimensions
                float left = Convert.ToSingle(xlWorkSheet.Cells[iRow, 8].Left);
                float top = Convert.ToSingle(xlWorkSheet.Cells[iRow, 8].Top);

                // Insert the picture from the saved file path
                xlWorkSheet.Shapes.AddPicture(tempImagePath,
                    Microsoft.Office.Core.MsoTriState.msoFalse,
                    Microsoft.Office.Core.MsoTriState.msoCTrue,
                    left, top, 15, 15);  // Fixed width and height

                ms.Close(); // Close the MemoryStream

                MessageBox.Show("New vendor information saved successfully!");

                // Save and close the workbook
                var xlWorkBook.Save();
                var xlWorkBook.Close(true);
                xlApp.Quit();
            }

        }
    }
}
