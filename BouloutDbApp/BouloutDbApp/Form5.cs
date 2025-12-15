using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BouloutDbApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //change dtp format date&time
            dtpReportDate.Format = DateTimePickerFormat.Custom;
            dtpReportDate.CustomFormat = "MMMM dd, yyyy ";
            dtpReportTime.Format = DateTimePickerFormat.Custom;
            dtpReportDate.CustomFormat = "hh:mm ";
        }

        // ----- A D D   R E P O R T  F O R M -----
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            List<string> errors = new List<string>();
            Control firstInvalidControl = null;

            Color errorColor = Color.MistyRose;
            Color okColor = Color.White;

            // ---------- TEXTBOX ----------
            if (string.IsNullOrWhiteSpace(tbReportBody.Text))
            {
                tbReportBody.BackColor = errorColor;
                errors.Add("Report Body is required.");
                if (firstInvalidControl == null) firstInvalidControl = tbReportBody;
            }
            else
            {
                tbReportBody.BackColor = okColor;
            }

            // ---------- COMBOBOXES ----------
            if (cbUrgency.SelectedIndex == -1)
            {
                cbUrgency.BackColor = errorColor;
                errors.Add("Please select an Urgency level.");
                if (firstInvalidControl == null) firstInvalidControl = cbUrgency;
            }
            else cbUrgency.BackColor = okColor;

            if (cbRepName.SelectedIndex == -1)
            {
                cbRepName.BackColor = errorColor;
                errors.Add("Please select a Reporter's Name.");
                if (firstInvalidControl == null) firstInvalidControl = cbRepName;
            }
            else cbRepName.BackColor = okColor;

            if (cbRepCompany.SelectedIndex == -1)
            {
                cbRepCompany.BackColor = errorColor;
                errors.Add("Please select a Reporter's Company.");
                if (firstInvalidControl == null) firstInvalidControl = cbRepCompany;
            }
            else cbRepCompany.BackColor = okColor;

            // ---------- DATE ----------  
            DateTime today = DateTime.Now.Date;

            if (dtpReportDate.Value.Date > today)
            {
                errors.Add("Report Date cannot be in the future.");
                dtpReportDate.CalendarTitleBackColor = Color.LightSalmon;
                if (firstInvalidControl == null) firstInvalidControl = dtpReportDate;
            }

            // reset color for DTP (they don't have BackColor)
            else dtpReportDate.CalendarTitleBackColor = SystemColors.ActiveCaption;

            // ---------- TIME ----------
            DateTime now = DateTime.Now;

            DateTime chosen = dtpReportDate.Value.Date
                              .AddHours(dtpReportTime.Value.Hour)
                              .AddMinutes(dtpReportTime.Value.Minute);

            if (chosen > now)
            {
                errors.Add("Report Time cannot be in the future.");
                dtpReportTime.CalendarTitleBackColor = Color.LightSalmon;
                if (firstInvalidControl == null) firstInvalidControl = dtpReportTime;
            }
            else dtpReportTime.CalendarTitleBackColor = SystemColors.ActiveCaption;

            // ---------- SHOW ERRORS ----------
            if (errors.Count > 0)
            {
                MessageBox.Show(
                    string.Join("\n", errors),
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // auto-focus the first invalid field
                if (firstInvalidControl != null)
                    firstInvalidControl.Focus();

                return;
            }

            // ---------- SUCCESS ----------
            MessageBox.Show("Saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            cbRepCompany.Items.Clear();
            cbRepCompany.Items.AddRange(CompanyStorage.Companies.ToArray());
        }
    }
}

