
namespace Bill
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Pdfbutton = new System.Windows.Forms.Button();
            this.Printbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MprintDocument = new System.Drawing.Printing.PrintDocument();
            this.MprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCreateExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDumpData = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnReadLastRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Exitbutton.Location = new System.Drawing.Point(404, 546);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(101, 44);
            this.Exitbutton.TabIndex = 9;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Pdfbutton
            // 
            this.Pdfbutton.Location = new System.Drawing.Point(284, 546);
            this.Pdfbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pdfbutton.Name = "Pdfbutton";
            this.Pdfbutton.Size = new System.Drawing.Size(101, 44);
            this.Pdfbutton.TabIndex = 8;
            this.Pdfbutton.Text = "PDF";
            this.Pdfbutton.UseVisualStyleBackColor = true;
            this.Pdfbutton.Click += new System.EventHandler(this.Pdfbutton_Click);
            // 
            // Printbutton
            // 
            this.Printbutton.Location = new System.Drawing.Point(164, 546);
            this.Printbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(101, 44);
            this.Printbutton.TabIndex = 7;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(47, 546);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(101, 44);
            this.Addbutton.TabIndex = 6;
            this.Addbutton.Text = "Add New";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Item Code :";
            // 
            // txtSenderName
            // 
            this.txtSenderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenderName.Location = new System.Drawing.Point(193, 278);
            this.txtSenderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(395, 22);
            this.txtSenderName.TabIndex = 1;
            this.txtSenderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sender Name :";
            // 
            // MprintPreviewDialog
            // 
            this.MprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.MprintPreviewDialog.Enabled = true;
            this.MprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("MprintPreviewDialog.Icon")));
            this.MprintPreviewDialog.Name = "MprintPreviewDialog";
            this.MprintPreviewDialog.Visible = false;
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiverName.Location = new System.Drawing.Point(193, 318);
            this.txtReceiverName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(395, 22);
            this.txtReceiverName.TabIndex = 2;
            this.txtReceiverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceiverName.Leave += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Reciever Name :";
            // 
            // btnCreateExcel
            // 
            this.btnCreateExcel.Location = new System.Drawing.Point(595, 546);
            this.btnCreateExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(101, 44);
            this.btnCreateExcel.TabIndex = 10;
            this.btnCreateExcel.Text = "Excel";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.btnCreateExcel_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sr. No. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Item Discription :";
            // 
            // btnDumpData
            // 
            this.btnDumpData.Location = new System.Drawing.Point(386, 638);
            this.btnDumpData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDumpData.Name = "btnDumpData";
            this.btnDumpData.Size = new System.Drawing.Size(101, 44);
            this.btnDumpData.TabIndex = 11;
            this.btnDumpData.Text = "Add Data";
            this.btnDumpData.UseVisualStyleBackColor = true;
            this.btnDumpData.Click += new System.EventHandler(this.btnDumpData_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Location = new System.Drawing.Point(193, 362);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(395, 22);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSrNo
            // 
            this.txtSrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrNo.Location = new System.Drawing.Point(193, 410);
            this.txtSrNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(395, 22);
            this.txtSrNo.TabIndex = 4;
            this.txtSrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemDescription.Location = new System.Drawing.Point(193, 460);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(395, 22);
            this.txtItemDescription.TabIndex = 5;
            this.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(550, 638);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(101, 44);
            this.btnSendEmail.TabIndex = 29;
            this.btnSendEmail.Text = "Mail";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnReadLastRow
            // 
            this.btnReadLastRow.Location = new System.Drawing.Point(213, 623);
            this.btnReadLastRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadLastRow.Name = "btnReadLastRow";
            this.btnReadLastRow.Size = new System.Drawing.Size(101, 44);
            this.btnReadLastRow.TabIndex = 30;
            this.btnReadLastRow.Text = "READ DATA";
            this.btnReadLastRow.UseVisualStyleBackColor = true;
            this.btnReadLastRow.Click += new System.EventHandler(this.btnReadLastRow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 773);
            this.Controls.Add(this.btnReadLastRow);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtSrNo);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.btnDumpData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCreateExcel);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Pdfbutton);
            this.Controls.Add(this.Printbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Pdfbutton;
        private System.Windows.Forms.Button Printbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument MprintDocument;
        private System.Windows.Forms.PrintPreviewDialog MprintPreviewDialog;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCreateExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDumpData;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnReadLastRow;
    }
}

