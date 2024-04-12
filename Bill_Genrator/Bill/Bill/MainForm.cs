using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;
namespace Bill
{
    public partial class MainForm : Form
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            txtSenderName.Clear();
            txtReceiverName.Clear();
            txtItemDescription.Clear();
            txtItemCode.Clear();
            txtSrNo.Clear();
            txtSenderName.Focus();
        }
    
        private void Pdfbutton_Click(object sender, EventArgs e)
        {
            MprintPreviewDialog.Document = MprintDocument;
            MprintPreviewDialog.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize Excel application
            // Initialize Excel application
            excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Add a new workbook
            workbook = excelApp.Workbooks.Add();
            worksheet = workbook.ActiveSheet;

            // Set the header text for Company Name and the data columns
            string companyName = "Company Name: XYZ Ltd";
            string[] headerRow = { "DateTime", "Sender Name", "Receiver Name", "Item Code", "Sr No.", "Item Description" };

            // Add the headers to the worksheet
            Excel.Range companyHeaderRange = worksheet.Range["A1"];
            companyHeaderRange.Value = companyName;
            companyHeaderRange.Font.Bold = true;

            Excel.Range dataHeaderRange = worksheet.Range["A2:F2"];
            dataHeaderRange.Value = headerRow;
            dataHeaderRange.Font.Bold = true;

            // Auto-fit columns for better visibility
            dataHeaderRange.EntireColumn.AutoFit();
        }

        private void btnDumpData_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                string filePath = @"C:\Users\MaitreykumarP\Desktop\file.xlsx";

                // Create Excel application
                excelApp = new Excel.Application();
                excelApp.Visible = false; // Set to false to hide the Excel application

                // Open workbook
                workbook = excelApp.Workbooks.Open(filePath, ReadOnly: false, Editable: true);

                // Get worksheet
                worksheet = workbook.ActiveSheet;

                // Get data from textboxes and dump to worksheet
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string senderName = txtSenderName.Text;
                string receiverName = txtReceiverName.Text;
                string itemCode = txtItemCode.Text;
                string srNo = txtSrNo.Text;
                string itemDescription = txtItemDescription.Text;

                // Check if any textbox is empty
                if (string.IsNullOrEmpty(dateTime) || string.IsNullOrEmpty(senderName) ||
                    string.IsNullOrEmpty(receiverName) || string.IsNullOrEmpty(itemCode) ||
                    string.IsNullOrEmpty(srNo) || string.IsNullOrEmpty(itemDescription))
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the next available row for data
                Excel.Range lastRow = worksheet.Cells[worksheet.Rows.Count, "A"].End(Excel.XlDirection.xlUp);
                int nextRow = (lastRow != null && lastRow.Row > 1) ? lastRow.Row + 1 : 2;

                // Dump the data to the worksheet
                Excel.Range dataRange = worksheet.Range[$"A{nextRow}:F{nextRow}"];
                dataRange.Value = new object[,] {
            { dateTime, senderName, receiverName, itemCode, srNo, itemDescription }
        };

                // Save and close the workbook
                workbook.Save();
                workbook.Close();

                MessageBox.Show("Data dumped to Excel file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Release COM objects
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
              //  if (workbook != null) workbook.Close(SaveChanges: false);
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close Excel and release resources when the form is closing
            if (workbook != null)
                workbook.Close(false);
            if (excelApp != null)
                excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void btnCreateExcel_Click_1(object sender, EventArgs e)
        {

            string filePath = @"C:\Users\MaitreykumarP\Desktop\file.xlsx";

            // Check if the file already exists
            if (File.Exists(filePath))
            {
                MessageBox.Show("Excel file already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            excelApp = new Excel.Application();
            excelApp.Visible = false;

            // Add a new workbook
            workbook = excelApp.Workbooks.Add();
            worksheet = workbook.ActiveSheet;

            // Set the header text for Company Name and the data columns
            string companyName = "Company Name: XYZ Ltd";
            string[] headerRow = { "DateTime", "Sender Name", "Receiver Name", "Item Code", "Sr No.", "Item Description" };

            // Add the headers to the worksheet
            Excel.Range companyHeaderRange = worksheet.Range["A1"];
            companyHeaderRange.Value = companyName;
            companyHeaderRange.Font.Bold = true;

            Excel.Range dataHeaderRange = worksheet.Range["A2:F2"];
            dataHeaderRange.Value = headerRow;
            dataHeaderRange.Font.Bold = true;

            // Auto-fit columns for better visibility
            dataHeaderRange.EntireColumn.AutoFit();
            workbook.SaveAs(@"C:\Users\MaitreykumarP\Desktop\file.xlsx");

            MessageBox.Show("Excel file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string fromAddress = "maitreypatel293@gmail.com";
            string[] toAddresses = { "m.patel@beckhoff.com"};
            string subject = "Test Email";
            string body = "This is a test email sent from C#.";

            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "maitreypatel293@gmail.com";
            string smtpPassword = "uwia chvt bpij kbos";

            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromAddress);

                foreach (string toAddress in toAddresses)
                {
                    message.To.Add(toAddress);
                }

                message.Subject = subject;
                message.Body = body;

                // Add attachment
                string attachmentPath = @"C:\Users\MaitreykumarP\Desktop\file.TXT"; // Replace with the actual path of your attachment
                Attachment attachment = new Attachment(attachmentPath);
                message.Attachments.Add(attachment);

                client.Send(message);

                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("SMTP Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                client.Dispose();
            }
        }

        private void btnReadLastRow_Click(object sender, EventArgs e)
        {
            ReadLastRow();
        }

        private void ReadLastRow()
        {
            string filePath = @"C:\Users\MaitreykumarP\Desktop\file.xlsx"; // Replace with the actual path of your Excel file

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            int lastRow = worksheet.Cells[worksheet.Rows.Count, "A"].End[Excel.XlDirection.xlUp].Row;

            // Read data from the last row
            string data1 = worksheet.Cells[lastRow, 1].Value?.ToString(); // Assuming data is in column A
            string data2 = worksheet.Cells[lastRow, 2].Value?.ToString(); // Assuming data is in column B
                                                                          // Add more lines as needed for other columns

            workbook.Close(false);
            excelApp.Quit();

            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
            txtSenderName.Text = data2;
            // Use the data read from the last row
            MessageBox.Show($"Data from last row - Column 1: {data1}, Column 2: {data2}", "Last Row Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Exception occurred while releasing object: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
