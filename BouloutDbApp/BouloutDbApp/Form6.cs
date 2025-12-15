using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BouloutDbApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // ----- A D D   E M P L O Y E E  F O R M -----

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                tbEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
            }
            else
            {
                tbEmail.BackColor = Color.White;
            }
        }

        private void tbPhoneNumber_Leave(object sender, EventArgs e)
        {
            string phone = tbPhoneNumber.Text;
            string digits = Regex.Replace(phone, @"\D", "");//remove non-digit characters

            if (digits.Length != 10)
            {
                tbPhoneNumber.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPhoneNumber.Focus();
            }
            else
            {
                tbPhoneNumber.BackColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation : Ensure all fields are filleds
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(tbPosition.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.",
                                "Incomplete Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            else
            {

                // Code to save employee information goes here
                MessageBox.Show("Employee information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
        }
    }
}
