namespace BouloutDbApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddEmployee = new Button();
            btnAddReport = new Button();
            btnAddRepProfile = new Button();
            btnAddClient = new Button();
            btnAddTicket = new Button();
            pbLogoBoulout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogoBoulout).BeginInit();
            SuspendLayout();
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = SystemColors.ButtonShadow;
            btnAddEmployee.FlatStyle = FlatStyle.Popup;
            btnAddEmployee.Location = new Point(77, 146);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(333, 69);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Add an employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            btnAddEmployee.MouseEnter += btnAddEmployee_MouseEnter;
            btnAddEmployee.MouseLeave += btnAddEmployee_MouseLeave;
            // 
            // btnAddReport
            // 
            btnAddReport.BackColor = SystemColors.ButtonShadow;
            btnAddReport.FlatStyle = FlatStyle.Popup;
            btnAddReport.Location = new Point(77, 309);
            btnAddReport.Name = "btnAddReport";
            btnAddReport.Size = new Size(333, 69);
            btnAddReport.TabIndex = 1;
            btnAddReport.Text = "Add a report";
            btnAddReport.UseVisualStyleBackColor = false;
            btnAddReport.Click += btnAddReport_Click;
            btnAddReport.MouseEnter += btnAddReport_MouseEnter;
            btnAddReport.MouseLeave += btnAddReport_MouseLeave;
            // 
            // btnAddRepProfile
            // 
            btnAddRepProfile.BackColor = SystemColors.ButtonShadow;
            btnAddRepProfile.FlatStyle = FlatStyle.Popup;
            btnAddRepProfile.Location = new Point(77, 483);
            btnAddRepProfile.Name = "btnAddRepProfile";
            btnAddRepProfile.Size = new Size(416, 69);
            btnAddRepProfile.TabIndex = 2;
            btnAddRepProfile.Text = "Add a reporter's profile";
            btnAddRepProfile.UseVisualStyleBackColor = false;
            btnAddRepProfile.Click += btnAddRepProfile_Click;
            btnAddRepProfile.MouseEnter += btnAddRepProfile_MouseEnter;
            btnAddRepProfile.MouseLeave += btnAddRepProfile_MouseLeave;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = SystemColors.ButtonShadow;
            btnAddClient.FlatStyle = FlatStyle.Popup;
            btnAddClient.Location = new Point(768, 309);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(333, 69);
            btnAddClient.TabIndex = 3;
            btnAddClient.Text = "Add a client";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            btnAddClient.MouseEnter += btnAddClient_MouseEnter;
            btnAddClient.MouseLeave += btnAddClient_MouseLeave;
            // 
            // btnAddTicket
            // 
            btnAddTicket.BackColor = SystemColors.ButtonShadow;
            btnAddTicket.FlatStyle = FlatStyle.Popup;
            btnAddTicket.Location = new Point(768, 483);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(333, 69);
            btnAddTicket.TabIndex = 4;
            btnAddTicket.Text = "Add a Ticket";
            btnAddTicket.UseVisualStyleBackColor = false;
            btnAddTicket.Click += btnAddTicket_Click;
            btnAddTicket.MouseEnter += btnAddTicket_MouseEnter;
            btnAddTicket.MouseLeave += btnAddTicket_MouseLeave;
            // 
            // pbLogoBoulout
            // 
            pbLogoBoulout.BackColor = SystemColors.ButtonHighlight;
            pbLogoBoulout.Image = Properties.Resources.bouloutLogo;
            pbLogoBoulout.Location = new Point(674, 12);
            pbLogoBoulout.Name = "pbLogoBoulout";
            pbLogoBoulout.Size = new Size(446, 183);
            pbLogoBoulout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoBoulout.TabIndex = 5;
            pbLogoBoulout.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1216, 649);
            Controls.Add(pbLogoBoulout);
            Controls.Add(btnAddTicket);
            Controls.Add(btnAddClient);
            Controls.Add(btnAddRepProfile);
            Controls.Add(btnAddReport);
            Controls.Add(btnAddEmployee);
            Font = new Font("Calibri", 14F);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Main Form";
            FormClosed += frmMain_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbLogoBoulout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddEmployee;
        private Button btnAddReport;
        private Button btnAddRepProfile;
        private Button btnAddClient;
        private Button btnAddTicket;
        private PictureBox pbLogoBoulout;
    }
}
