namespace BouloutDbApp
{
    partial class Form4
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
            lblProvidedItService = new Label();
            lblCompanyName = new Label();
            lblReportId = new Label();
            lblTechName = new Label();
            lblStartServiceDate = new Label();
            lblStartServiceTime = new Label();
            lblEndServiceDate = new Label();
            lblEndServiceTime = new Label();
            lblServiceInvoice = new Label();
            lblDiagnose = new Label();
            lblSolution = new Label();
            lblReportBody = new Label();
            lblServiceProvided = new Label();
            lblUsedMaterial = new Label();
            cbCompanyName = new ComboBox();
            cbReportId = new ComboBox();
            cbTechName = new ComboBox();
            dtpStartServiceDate = new DateTimePicker();
            dtpEndServiceDate = new DateTimePicker();
            dtpStartServiceTime = new DateTimePicker();
            dtpEndServiceTime = new DateTimePicker();
            tbInvoiceNumber = new TextBox();
            tbReportBody = new TextBox();
            tbServiceProvided = new TextBox();
            tbUsedMaterial = new TextBox();
            tbDiagnose = new TextBox();
            tbSolution = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblProvidedItService
            // 
            lblProvidedItService.AutoSize = true;
            lblProvidedItService.Font = new Font("Calibri", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProvidedItService.Location = new Point(589, 59);
            lblProvidedItService.Name = "lblProvidedItService";
            lblProvidedItService.Size = new Size(379, 53);
            lblProvidedItService.TabIndex = 0;
            lblProvidedItService.Text = "Provided IT Services";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(58, 139);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(288, 46);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Company name : ";
            // 
            // lblReportId
            // 
            lblReportId.AutoSize = true;
            lblReportId.Location = new Point(58, 262);
            lblReportId.Name = "lblReportId";
            lblReportId.Size = new Size(195, 46);
            lblReportId.TabIndex = 2;
            lblReportId.Text = "Report ID : ";
            // 
            // lblTechName
            // 
            lblTechName.AutoSize = true;
            lblTechName.Location = new Point(58, 388);
            lblTechName.Name = "lblTechName";
            lblTechName.Size = new Size(298, 46);
            lblTechName.TabIndex = 3;
            lblTechName.Text = "Technician name: ";
            // 
            // lblStartServiceDate
            // 
            lblStartServiceDate.AutoSize = true;
            lblStartServiceDate.Location = new Point(58, 518);
            lblStartServiceDate.Name = "lblStartServiceDate";
            lblStartServiceDate.Size = new Size(380, 46);
            lblStartServiceDate.TabIndex = 4;
            lblStartServiceDate.Text = "Start of services(date) :";
            // 
            // lblStartServiceTime
            // 
            lblStartServiceTime.AutoSize = true;
            lblStartServiceTime.Location = new Point(58, 651);
            lblStartServiceTime.Name = "lblStartServiceTime";
            lblStartServiceTime.Size = new Size(380, 46);
            lblStartServiceTime.TabIndex = 5;
            lblStartServiceTime.Text = "Start of services(time) :";
            // 
            // lblEndServiceDate
            // 
            lblEndServiceDate.AutoSize = true;
            lblEndServiceDate.Location = new Point(58, 784);
            lblEndServiceDate.Name = "lblEndServiceDate";
            lblEndServiceDate.Size = new Size(365, 46);
            lblEndServiceDate.TabIndex = 6;
            lblEndServiceDate.Text = "End of services(date) :";
            // 
            // lblEndServiceTime
            // 
            lblEndServiceTime.AutoSize = true;
            lblEndServiceTime.Location = new Point(58, 910);
            lblEndServiceTime.Name = "lblEndServiceTime";
            lblEndServiceTime.Size = new Size(365, 46);
            lblEndServiceTime.TabIndex = 7;
            lblEndServiceTime.Text = "End of services(time) :";
            // 
            // lblServiceInvoice
            // 
            lblServiceInvoice.AutoSize = true;
            lblServiceInvoice.Location = new Point(58, 1054);
            lblServiceInvoice.Name = "lblServiceInvoice";
            lblServiceInvoice.Size = new Size(499, 46);
            lblServiceInvoice.TabIndex = 8;
            lblServiceInvoice.Text = "Invoice number of the service :";
            // 
            // lblDiagnose
            // 
            lblDiagnose.AutoSize = true;
            lblDiagnose.Location = new Point(58, 1171);
            lblDiagnose.Name = "lblDiagnose";
            lblDiagnose.Size = new Size(370, 46);
            lblDiagnose.TabIndex = 9;
            lblDiagnose.Text = "Diagnose explanation :";
            // 
            // lblSolution
            // 
            lblSolution.AutoSize = true;
            lblSolution.Location = new Point(1097, 1171);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(355, 46);
            lblSolution.TabIndex = 10;
            lblSolution.Text = "Solution explanation :";
            // 
            // lblReportBody
            // 
            lblReportBody.AutoSize = true;
            lblReportBody.Location = new Point(1097, 139);
            lblReportBody.Name = "lblReportBody";
            lblReportBody.Size = new Size(230, 46);
            lblReportBody.TabIndex = 11;
            lblReportBody.Text = "Report body :";
            // 
            // lblServiceProvided
            // 
            lblServiceProvided.AutoSize = true;
            lblServiceProvided.Location = new Point(1097, 477);
            lblServiceProvided.Name = "lblServiceProvided";
            lblServiceProvided.Size = new Size(295, 46);
            lblServiceProvided.TabIndex = 12;
            lblServiceProvided.Text = "Service provided :";
            // 
            // lblUsedMaterial
            // 
            lblUsedMaterial.AutoSize = true;
            lblUsedMaterial.Location = new Point(1097, 795);
            lblUsedMaterial.Name = "lblUsedMaterial";
            lblUsedMaterial.Size = new Size(270, 46);
            lblUsedMaterial.TabIndex = 13;
            lblUsedMaterial.Text = "Used materials :";
            // 
            // cbCompanyName
            // 
            cbCompanyName.FormattingEnabled = true;
            cbCompanyName.Location = new Point(600, 139);
            cbCompanyName.Name = "cbCompanyName";
            cbCompanyName.Size = new Size(382, 53);
            cbCompanyName.TabIndex = 14;
            // 
            // cbReportId
            // 
            cbReportId.FormattingEnabled = true;
            cbReportId.Location = new Point(600, 259);
            cbReportId.Name = "cbReportId";
            cbReportId.Size = new Size(382, 53);
            cbReportId.TabIndex = 15;
            // 
            // cbTechName
            // 
            cbTechName.FormattingEnabled = true;
            cbTechName.Location = new Point(600, 381);
            cbTechName.Name = "cbTechName";
            cbTechName.Size = new Size(382, 53);
            cbTechName.TabIndex = 16;
            // 
            // dtpStartServiceDate
            // 
            dtpStartServiceDate.Location = new Point(600, 518);
            dtpStartServiceDate.Name = "dtpStartServiceDate";
            dtpStartServiceDate.Size = new Size(400, 53);
            dtpStartServiceDate.TabIndex = 17;
            // 
            // dtpEndServiceDate
            // 
            dtpEndServiceDate.Location = new Point(600, 778);
            dtpEndServiceDate.Name = "dtpEndServiceDate";
            dtpEndServiceDate.Size = new Size(400, 53);
            dtpEndServiceDate.TabIndex = 18;
            // 
            // dtpStartServiceTime
            // 
            dtpStartServiceTime.Location = new Point(600, 651);
            dtpStartServiceTime.Name = "dtpStartServiceTime";
            dtpStartServiceTime.Size = new Size(400, 53);
            dtpStartServiceTime.TabIndex = 19;
            // 
            // dtpEndServiceTime
            // 
            dtpEndServiceTime.Location = new Point(600, 903);
            dtpEndServiceTime.Name = "dtpEndServiceTime";
            dtpEndServiceTime.Size = new Size(400, 53);
            dtpEndServiceTime.TabIndex = 20;
            // 
            // tbInvoiceNumber
            // 
            tbInvoiceNumber.Location = new Point(600, 1056);
            tbInvoiceNumber.Name = "tbInvoiceNumber";
            tbInvoiceNumber.Size = new Size(400, 53);
            tbInvoiceNumber.TabIndex = 21;
            // 
            // tbReportBody
            // 
            tbReportBody.Location = new Point(1097, 200);
            tbReportBody.Multiline = true;
            tbReportBody.Name = "tbReportBody";
            tbReportBody.Size = new Size(881, 251);
            tbReportBody.TabIndex = 22;
            // 
            // tbServiceProvided
            // 
            tbServiceProvided.Location = new Point(1097, 526);
            tbServiceProvided.Multiline = true;
            tbServiceProvided.Name = "tbServiceProvided";
            tbServiceProvided.Size = new Size(881, 251);
            tbServiceProvided.TabIndex = 23;
            // 
            // tbUsedMaterial
            // 
            tbUsedMaterial.Location = new Point(1097, 873);
            tbUsedMaterial.Multiline = true;
            tbUsedMaterial.Name = "tbUsedMaterial";
            tbUsedMaterial.Size = new Size(881, 251);
            tbUsedMaterial.TabIndex = 24;
            // 
            // tbDiagnose
            // 
            tbDiagnose.Location = new Point(58, 1263);
            tbDiagnose.Multiline = true;
            tbDiagnose.Name = "tbDiagnose";
            tbDiagnose.Size = new Size(881, 251);
            tbDiagnose.TabIndex = 25;
            // 
            // tbSolution
            // 
            tbSolution.Location = new Point(1097, 1272);
            tbSolution.Multiline = true;
            tbSolution.Name = "tbSolution";
            tbSolution.Size = new Size(881, 251);
            tbSolution.TabIndex = 26;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(1753, 1171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(225, 63);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(2262, 1582);
            Controls.Add(btnSave);
            Controls.Add(tbSolution);
            Controls.Add(tbDiagnose);
            Controls.Add(tbUsedMaterial);
            Controls.Add(tbServiceProvided);
            Controls.Add(tbReportBody);
            Controls.Add(tbInvoiceNumber);
            Controls.Add(dtpEndServiceTime);
            Controls.Add(dtpStartServiceTime);
            Controls.Add(dtpEndServiceDate);
            Controls.Add(dtpStartServiceDate);
            Controls.Add(cbTechName);
            Controls.Add(cbReportId);
            Controls.Add(cbCompanyName);
            Controls.Add(lblUsedMaterial);
            Controls.Add(lblServiceProvided);
            Controls.Add(lblReportBody);
            Controls.Add(lblSolution);
            Controls.Add(lblDiagnose);
            Controls.Add(lblServiceInvoice);
            Controls.Add(lblEndServiceTime);
            Controls.Add(lblEndServiceDate);
            Controls.Add(lblStartServiceTime);
            Controls.Add(lblStartServiceDate);
            Controls.Add(lblTechName);
            Controls.Add(lblReportId);
            Controls.Add(lblCompanyName);
            Controls.Add(lblProvidedItService);
            Font = new Font("Calibri", 14F);
            Margin = new Padding(4);
            Name = "Form4";
            Text = "Add a ticket";
            Load += FrmTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProvidedItService;
        private Label lblCompanyName;
        private Label lblReportId;
        private Label lblTechName;
        private Label lblStartServiceDate;
        private Label lblStartServiceTime;
        private Label lblEndServiceDate;
        private Label lblEndServiceTime;
        private Label lblServiceInvoice;
        private Label lblDiagnose;
        private Label lblSolution;
        private Label lblReportBody;
        private Label lblServiceProvided;
        private Label lblUsedMaterial;
        private ComboBox cbCompanyName;
        private ComboBox cbReportId;
        private ComboBox cbTechName;
        private DateTimePicker dtpStartServiceDate;
        private DateTimePicker dtpEndServiceDate;
        private DateTimePicker dtpStartServiceTime;
        private DateTimePicker dtpEndServiceTime;
        private TextBox tbInvoiceNumber;
        private TextBox tbReportBody;
        private TextBox tbServiceProvided;
        private TextBox tbUsedMaterial;
        private TextBox tbDiagnose;
        private TextBox tbSolution;
        private Button btnSave;
    }
}