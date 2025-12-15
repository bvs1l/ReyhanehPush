namespace BouloutDbApp
{
    partial class Form3
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
            lblRepProfile = new Label();
            lblCompanyName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblRepPosition = new Label();
            lblRepLastName = new Label();
            lblRepFirstName = new Label();
            tbRepFirstName = new TextBox();
            tbRepLastName = new TextBox();
            tbRepPosition = new TextBox();
            tbPhoneNumber = new TextBox();
            tbEmail = new TextBox();
            cbCompanyName = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblRepProfile
            // 
            lblRepProfile.AutoSize = true;
            lblRepProfile.Font = new Font("Calibri", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepProfile.Location = new Point(496, 52);
            lblRepProfile.Name = "lblRepProfile";
            lblRepProfile.Size = new Size(334, 53);
            lblRepProfile.TabIndex = 0;
            lblRepProfile.Text = "Reporter's profile";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(68, 187);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(279, 46);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Company name :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(835, 459);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(124, 46);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(835, 330);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(269, 46);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone number :";
            // 
            // lblRepPosition
            // 
            lblRepPosition.AutoSize = true;
            lblRepPosition.Location = new Point(823, 187);
            lblRepPosition.Name = "lblRepPosition";
            lblRepPosition.Size = new Size(333, 46);
            lblRepPosition.TabIndex = 4;
            lblRepPosition.Text = "Reporter's position :";
            // 
            // lblRepLastName
            // 
            lblRepLastName.AutoSize = true;
            lblRepLastName.Location = new Point(68, 468);
            lblRepLastName.Name = "lblRepLastName";
            lblRepLastName.Size = new Size(359, 46);
            lblRepLastName.TabIndex = 5;
            lblRepLastName.Text = "Reporter's last name :";
            // 
            // lblRepFirstName
            // 
            lblRepFirstName.AutoSize = true;
            lblRepFirstName.Location = new Point(68, 330);
            lblRepFirstName.Name = "lblRepFirstName";
            lblRepFirstName.Size = new Size(364, 46);
            lblRepFirstName.TabIndex = 6;
            lblRepFirstName.Text = "Reporter's first name :";
            // 
            // tbRepFirstName
            // 
            tbRepFirstName.Location = new Point(470, 323);
            tbRepFirstName.Name = "tbRepFirstName";
            tbRepFirstName.Size = new Size(339, 53);
            tbRepFirstName.TabIndex = 7;
            // 
            // tbRepLastName
            // 
            tbRepLastName.Location = new Point(470, 461);
            tbRepLastName.Name = "tbRepLastName";
            tbRepLastName.Size = new Size(339, 53);
            tbRepLastName.TabIndex = 8;
            // 
            // tbRepPosition
            // 
            tbRepPosition.Location = new Point(1162, 187);
            tbRepPosition.Name = "tbRepPosition";
            tbRepPosition.Size = new Size(339, 53);
            tbRepPosition.TabIndex = 9;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(1157, 330);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(339, 53);
            tbPhoneNumber.TabIndex = 10;
            tbPhoneNumber.Leave += tbPhoneNumber_Leave;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(1157, 452);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(339, 53);
            tbEmail.TabIndex = 11;
            tbEmail.TextChanged += tbEmail_TextChanged;
            tbEmail.Leave += tbEmail_Leave;
            // 
            // cbCompanyName
            // 
            cbCompanyName.FormattingEnabled = true;
            cbCompanyName.Location = new Point(470, 204);
            cbCompanyName.Name = "cbCompanyName";
            cbCompanyName.Size = new Size(339, 53);
            cbCompanyName.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(954, 561);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(222, 59);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1689, 650);
            Controls.Add(btnSave);
            Controls.Add(cbCompanyName);
            Controls.Add(tbEmail);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbRepPosition);
            Controls.Add(tbRepLastName);
            Controls.Add(tbRepFirstName);
            Controls.Add(lblRepFirstName);
            Controls.Add(lblRepLastName);
            Controls.Add(lblRepPosition);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblCompanyName);
            Controls.Add(lblRepProfile);
            Font = new Font("Calibri", 14F);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Add a reporters profile";
            Load += FrmRepProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRepProfile;
        private Label lblCompanyName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblRepPosition;
        private Label lblRepLastName;
        private Label lblRepFirstName;
        private TextBox tbRepFirstName;
        private TextBox tbRepLastName;
        private TextBox tbRepPosition;
        private TextBox tbPhoneNumber;
        private TextBox tbEmail;
        private ComboBox cbCompanyName;
        private Button btnSave;
    }
}