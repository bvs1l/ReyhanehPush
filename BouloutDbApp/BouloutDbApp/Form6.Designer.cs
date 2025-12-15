namespace BouloutDbApp
{
    partial class Form6
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
            lblEmployee = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPosition = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbPosition = new TextBox();
            tbPhoneNumber = new TextBox();
            tbEmail = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Calibri", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployee.Location = new Point(718, 61);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(217, 53);
            lblEmployee.TabIndex = 0;
            lblEmployee.Text = "Employees";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(67, 210);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(201, 46);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(67, 363);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(197, 46);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name :";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(67, 525);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(163, 46);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(812, 210);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(260, 46);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(812, 363);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(124, 46);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email :";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(318, 210);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(393, 53);
            tbFirstName.TabIndex = 6;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(318, 363);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(393, 53);
            tbLastName.TabIndex = 7;
            // 
            // tbPosition
            // 
            tbPosition.Location = new Point(318, 518);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(393, 53);
            tbPosition.TabIndex = 8;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(1121, 203);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(393, 53);
            tbPhoneNumber.TabIndex = 9;
            tbPhoneNumber.Leave += tbPhoneNumber_Leave;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(1121, 363);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(393, 53);
            tbEmail.TabIndex = 10;
            tbEmail.Leave += tbEmail_Leave;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(1256, 525);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 65);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1716, 724);
            Controls.Add(btnSave);
            Controls.Add(tbEmail);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbPosition);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblPosition);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblEmployee);
            Font = new Font("Calibri", 14F);
            Margin = new Padding(4);
            Name = "Form6";
            Text = "Add an employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployee;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPosition;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbPosition;
        private TextBox tbPhoneNumber;
        private TextBox tbEmail;
        private Button btnSave;
    }
}