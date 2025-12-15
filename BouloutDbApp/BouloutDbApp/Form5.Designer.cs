namespace BouloutDbApp
{
    partial class Form5
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
            lblReport = new Label();
            lblRepCompany = new Label();
            lblRepName = new Label();
            lblReportDate = new Label();
            lblReportTime = new Label();
            lblUrgency = new Label();
            lblReportBody = new Label();
            cbRepCompany = new ComboBox();
            cbRepName = new ComboBox();
            cbUrgency = new ComboBox();
            dtpReportDate = new DateTimePicker();
            dtpReportTime = new DateTimePicker();
            tbReportBody = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Calibri", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReport.Location = new Point(812, 79);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(144, 53);
            lblReport.TabIndex = 0;
            lblReport.Text = "Report";
            // 
            // lblRepCompany
            // 
            lblRepCompany.AutoSize = true;
            lblRepCompany.Location = new Point(64, 194);
            lblRepCompany.Name = "lblRepCompany";
            lblRepCompany.Size = new Size(348, 46);
            lblRepCompany.TabIndex = 1;
            lblRepCompany.Text = "Reporter's company :";
            // 
            // lblRepName
            // 
            lblRepName.AutoSize = true;
            lblRepName.Location = new Point(64, 318);
            lblRepName.Name = "lblRepName";
            lblRepName.Size = new Size(295, 46);
            lblRepName.TabIndex = 2;
            lblRepName.Text = "Reporter's name :";
            // 
            // lblReportDate
            // 
            lblReportDate.AutoSize = true;
            lblReportDate.Location = new Point(69, 462);
            lblReportDate.Name = "lblReportDate";
            lblReportDate.Size = new Size(259, 46);
            lblReportDate.TabIndex = 3;
            lblReportDate.Text = "Date of report :";
            // 
            // lblReportTime
            // 
            lblReportTime.AutoSize = true;
            lblReportTime.Location = new Point(69, 610);
            lblReportTime.Name = "lblReportTime";
            lblReportTime.Size = new Size(263, 46);
            lblReportTime.TabIndex = 4;
            lblReportTime.Text = "Time of report :";
            // 
            // lblUrgency
            // 
            lblUrgency.AutoSize = true;
            lblUrgency.Location = new Point(69, 754);
            lblUrgency.Name = "lblUrgency";
            lblUrgency.Size = new Size(290, 46);
            lblUrgency.TabIndex = 5;
            lblUrgency.Text = "Matters urgency :";
            // 
            // lblReportBody
            // 
            lblReportBody.AutoSize = true;
            lblReportBody.Location = new Point(949, 187);
            lblReportBody.Name = "lblReportBody";
            lblReportBody.Size = new Size(253, 46);
            lblReportBody.TabIndex = 6;
            lblReportBody.Text = "Report's body :";
            // 
            // cbRepCompany
            // 
            cbRepCompany.FormattingEnabled = true;
            cbRepCompany.Location = new Point(450, 187);
            cbRepCompany.Name = "cbRepCompany";
            cbRepCompany.Size = new Size(443, 53);
            cbRepCompany.TabIndex = 7;
            // 
            // cbRepName
            // 
            cbRepName.FormattingEnabled = true;
            cbRepName.Location = new Point(450, 311);
            cbRepName.Name = "cbRepName";
            cbRepName.Size = new Size(443, 53);
            cbRepName.TabIndex = 8;
            // 
            // cbUrgency
            // 
            cbUrgency.FormattingEnabled = true;
            cbUrgency.Items.AddRange(new object[] { "Urgent", "Not Urgent" });
            cbUrgency.Location = new Point(450, 754);
            cbUrgency.Name = "cbUrgency";
            cbUrgency.Size = new Size(443, 53);
            cbUrgency.TabIndex = 9;
            // 
            // dtpReportDate
            // 
            dtpReportDate.Location = new Point(450, 455);
            dtpReportDate.Name = "dtpReportDate";
            dtpReportDate.Size = new Size(443, 53);
            dtpReportDate.TabIndex = 10;
            // 
            // dtpReportTime
            // 
            dtpReportTime.Location = new Point(450, 603);
            dtpReportTime.Name = "dtpReportTime";
            dtpReportTime.Size = new Size(443, 53);
            dtpReportTime.TabIndex = 11;
            // 
            // tbReportBody
            // 
            tbReportBody.Location = new Point(949, 268);
            tbReportBody.Multiline = true;
            tbReportBody.Name = "tbReportBody";
            tbReportBody.Size = new Size(781, 481);
            tbReportBody.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(1451, 794);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(207, 59);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1779, 890);
            Controls.Add(btnSave);
            Controls.Add(tbReportBody);
            Controls.Add(dtpReportTime);
            Controls.Add(dtpReportDate);
            Controls.Add(cbUrgency);
            Controls.Add(cbRepName);
            Controls.Add(cbRepCompany);
            Controls.Add(lblReportBody);
            Controls.Add(lblUrgency);
            Controls.Add(lblReportTime);
            Controls.Add(lblReportDate);
            Controls.Add(lblRepName);
            Controls.Add(lblRepCompany);
            Controls.Add(lblReport);
            Font = new Font("Calibri", 14F);
            Margin = new Padding(4);
            Name = "Form5";
            Text = "Add a Report";
            Load += frmReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReport;
        private Label lblRepCompany;
        private Label lblRepName;
        private Label lblReportDate;
        private Label lblReportTime;
        private Label lblUrgency;
        private Label lblReportBody;
        private ComboBox cbRepCompany;
        private ComboBox cbRepName;
        private ComboBox cbUrgency;
        private DateTimePicker dtpReportDate;
        private DateTimePicker dtpReportTime;
        private TextBox tbReportBody;
        private Button btnSave;
    }
}