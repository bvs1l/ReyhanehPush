using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BouloutDbApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            //Chnage dtp format start and end service
            dtpStartServiceDate.Format = DateTimePickerFormat.Custom;
            dtpStartServiceDate.CustomFormat = "MMMM dd, yyyy ";
            dtpEndServiceDate.Format = DateTimePickerFormat.Custom;
            dtpEndServiceDate.CustomFormat = "MMMM dd, yyyy ";

            //change dtp time format start&end
            dtpStartServiceTime.Format = DateTimePickerFormat.Custom;
            dtpStartServiceTime.CustomFormat = "hh:mm ";
            dtpEndServiceTime.Format = DateTimePickerFormat.Custom;
            dtpEndServiceTime.CustomFormat = "hh:mm ";
        }


        // ----- A D D   T I C K E T    F O R M -----

        private bool ValidateForm()
        {
            List<string> errors = new List<string>();

            // ----- RESET COLORS -----
            Color okColor = Color.White;
            Color errorColor = Color.MistyRose;

            // TextBoxes
            TextBox[] textBoxes =
            {
                tbInvoiceNumber, tbDiagnose, tbSolution,
                tbUsedMaterial, tbServiceProvided, tbReportBody
            };

            string[] textBoxNames =
            {
                "Invoice Number", "Diagnose", "Solution",
                "Used Material", "Service Provided", "Report Body"
            };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    textBoxes[i].BackColor = errorColor;
                    errors.Add($"{textBoxNames[i]} is required.");
                }
                else
                {
                    textBoxes[i].BackColor = okColor;
                }
            }

            // ComboBoxes
            ComboBox[] combos = { cbCompanyName, cbReportId, cbTechName };
            string[] comboNames = { "Company Name", "Report ID", "Technician Name" };

            for (int i = 0; i < combos.Length; i++)
            {
                if (combos[i].SelectedIndex == -1)
                {
                    combos[i].BackColor = errorColor;
                    errors.Add($"Please select a {comboNames[i]}.");
                }
                else
                {
                    combos[i].BackColor = okColor;
                }
            }

            // DateTimePickers
            DateTimePicker[] dtps =
            {
                dtpStartServiceDate, dtpStartServiceTime,
                dtpEndServiceDate, dtpEndServiceTime
            };

            string[] dtpNames =
            {
                "Start Service Date", "Start Service Time",
                "End Service Date", "End Service Time"
            };

            for (int i = 0; i < dtps.Length; i++)
            {
                // (DTPs always have a value, so here we only check logic)
                if (dtps[i].Value == DateTimePicker.MinimumDateTime)
                {
                    errors.Add($"{dtpNames[i]} is invalid.");
                }
            }

            // FINAL RESULT
            if (errors.Count > 0)
            {
                MessageBox.Show(
                    string.Join("\n", errors),
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true; // everything OK
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!ValidateForm())
                return;

            // Your save logic here
            MessageBox.Show("Saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmTicket_Load(object sender, EventArgs e)
        { 
            cbCompanyName.Items.Clear();
            cbCompanyName.Items.AddRange(CompanyStorage.Companies.ToArray());
        }
            
    }   
}

