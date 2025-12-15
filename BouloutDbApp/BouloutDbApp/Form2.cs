using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BouloutDbApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblDirectFirstName.Text= "Direct first name:";
            lblDirectLastName.Text= "Direct last name:";
        }

        // ----- A D D   C O M P A N Y    P R O F I L E    F O R M -----

        private void tbEmailCompany_Leave(object sender, EventArgs e)
        {
            string email = tbEmailCompany.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                tbEmailCompany.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmailCompany.Focus();
            }
            else
            {
                tbEmailCompany.BackColor = Color.White;
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
            string company = tbCompanyName.Text.Trim();//user input --> variables for the cb in other forms
            
            // Avoid duplicates
            if (!CompanyStorage.Companies.Contains(company))
            {
                CompanyStorage.Companies.Add(company);
            }

            //Validation : Ensure all fields are filleds
            if (string.IsNullOrWhiteSpace(tbDirectFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbDirectLastName.Text) ||
                string.IsNullOrWhiteSpace(tbEmailCompany.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(tbCompanyName.Text) ||
                string.IsNullOrWhiteSpace(cbContractBoulout.SelectedItem?.ToString()) ||
                string.IsNullOrWhiteSpace(tbCompanyAddress.Text))
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
                MessageBox.Show("Company information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.GetConnectionString))
            {
                conn.Open();

                // Prevent duplicates
                string checkSql = "SELECT COUNT(*) FROM Companies WHERE CompanyName = ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("?", company);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("Company already exists.");
                        return;
                    }
                }

                string insertSql = "INSERT INTO Companies (CompanyName) VALUES (?)";
                using (OleDbCommand cmd = new OleDbCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("?", company);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
