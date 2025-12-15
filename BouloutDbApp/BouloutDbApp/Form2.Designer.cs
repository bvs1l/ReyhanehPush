namespace BouloutDbApp
{
    partial class Form2
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
            lblClient = new Label();
            lblCompanyName = new Label();
            lblContractCompany = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblAddressCompany = new Label();
            lblDirectLastName = new Label();
            lblDirectFirstName = new Label();
            tbCompanyName = new TextBox();
            tbDirectFirstName = new TextBox();
            tbDirectLastName = new TextBox();
            tbCompanyAddress = new TextBox();
            tbPhoneNumber = new TextBox();
            tbEmailCompany = new TextBox();
            cbContractBoulout = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Calibri", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClient.Location = new Point(522, 70);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(344, 53);
            lblClient.TabIndex = 0;
            lblClient.Text = "Company's profile";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(50, 166);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(288, 46);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Company name : ";
            // 
            // lblContractCompany
            // 
            lblContractCompany.AutoSize = true;
            lblContractCompany.Location = new Point(807, 431);
            lblContractCompany.Name = "lblContractCompany";
            lblContractCompany.Size = new Size(380, 46);
            lblContractCompany.TabIndex = 2;
            lblContractCompany.Text = "Contract with Boulout?";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(807, 296);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(124, 46);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(807, 166);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(269, 46);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone number :";
            // 
            // lblAddressCompany
            // 
            lblAddressCompany.AutoSize = true;
            lblAddressCompany.Location = new Point(50, 563);
            lblAddressCompany.Name = "lblAddressCompany";
            lblAddressCompany.Size = new Size(162, 46);
            lblAddressCompany.TabIndex = 5;
            lblAddressCompany.Text = "Address :";
            // 
            // lblDirectLastName
            // 
            lblDirectLastName.AutoSize = true;
            lblDirectLastName.Location = new Point(63, 435);
            lblDirectLastName.Name = "lblDirectLastName";
            lblDirectLastName.Size = new Size(206, 46);
            lblDirectLastName.TabIndex = 6;
            lblDirectLastName.Text = "Last name : ";
            // 
            // lblDirectFirstName
            // 
            lblDirectFirstName.AutoSize = true;
            lblDirectFirstName.Location = new Point(59, 296);
            lblDirectFirstName.Name = "lblDirectFirstName";
            lblDirectFirstName.Size = new Size(210, 46);
            lblDirectFirstName.TabIndex = 7;
            lblDirectFirstName.Text = "First name : ";
            // 
            // tbCompanyName
            // 
            tbCompanyName.Location = new Point(371, 159);
            tbCompanyName.Name = "tbCompanyName";
            tbCompanyName.Size = new Size(387, 53);
            tbCompanyName.TabIndex = 8;
            // 
            // tbDirectFirstName
            // 
            tbDirectFirstName.Location = new Point(371, 296);
            tbDirectFirstName.Name = "tbDirectFirstName";
            tbDirectFirstName.Size = new Size(387, 53);
            tbDirectFirstName.TabIndex = 9;
            // 
            // tbDirectLastName
            // 
            tbDirectLastName.Location = new Point(371, 428);
            tbDirectLastName.Name = "tbDirectLastName";
            tbDirectLastName.Size = new Size(387, 53);
            tbDirectLastName.TabIndex = 10;
            // 
            // tbCompanyAddress
            // 
            tbCompanyAddress.Location = new Point(241, 556);
            tbCompanyAddress.Name = "tbCompanyAddress";
            tbCompanyAddress.Size = new Size(536, 53);
            tbCompanyAddress.TabIndex = 11;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(1186, 166);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(387, 53);
            tbPhoneNumber.TabIndex = 12;
            tbPhoneNumber.Leave += tbPhoneNumber_Leave;
            // 
            // tbEmailCompany
            // 
            tbEmailCompany.Location = new Point(1186, 289);
            tbEmailCompany.Name = "tbEmailCompany";
            tbEmailCompany.Size = new Size(387, 53);
            tbEmailCompany.TabIndex = 13;
            tbEmailCompany.Leave += tbEmailCompany_Leave;
            // 
            // cbContractBoulout
            // 
            cbContractBoulout.FormattingEnabled = true;
            cbContractBoulout.Items.AddRange(new object[] { "Yes", "No" });
            cbContractBoulout.Location = new Point(1193, 435);
            cbContractBoulout.Name = "cbContractBoulout";
            cbContractBoulout.Size = new Size(380, 53);
            cbContractBoulout.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1235, 548);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(275, 61);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1726, 669);
            Controls.Add(btnSave);
            Controls.Add(cbContractBoulout);
            Controls.Add(tbEmailCompany);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbCompanyAddress);
            Controls.Add(tbDirectLastName);
            Controls.Add(tbDirectFirstName);
            Controls.Add(tbCompanyName);
            Controls.Add(lblDirectFirstName);
            Controls.Add(lblDirectLastName);
            Controls.Add(lblAddressCompany);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblContractCompany);
            Controls.Add(lblCompanyName);
            Controls.Add(lblClient);
            Font = new Font("Calibri", 14F);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Add a client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClient;
        private Label lblCompanyName;
        private Label lblContractCompany;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblAddressCompany;
        private Label lblDirectLastName;
        private Label lblDirectFirstName;
        private TextBox tbCompanyName;
        private TextBox tbDirectFirstName;
        private TextBox tbDirectLastName;
        private TextBox tbCompanyAddress;
        private TextBox tbPhoneNumber;
        private TextBox tbEmailCompany;
        private ComboBox cbContractBoulout;
        private Button btnSave;
    }
}