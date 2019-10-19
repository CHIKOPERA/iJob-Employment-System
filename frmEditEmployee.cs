using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmEditEmployee : Form
    {
        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"Select * from Agent where Agent_ID={frmManageEmployees.selectedAgentID}", Database.connection);
                Database.connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                  
                    txtLName.Text = dataReader["Surname"].ToString();
                    txtContact.Text = dataReader["Contact"].ToString();
                    txtStreet.Text = dataReader["Street_Address"].ToString();
                    txtCity.Text = dataReader["City"].ToString();
                    txtState.Text = dataReader["Province"].ToString();
                    txtPostalCode.Text = dataReader["Postal_Code"].ToString();
                   
                }
                Database.connection.Close();
                CustomMethods.GetImage(frmManageEmployees.selectedAgentID, picLab);
            }
            catch (Exception ex)
            {
                Database.connection.Close();
                MessageBox.Show(ex.Message);
            }

        }
        private void SwithOffLabels()
        {
            lblErCity.Visible = false;
         
            lblErLastName.Visible = false;
            lblErProAndZip.Visible = false;
        }
        private void DisplayError(Label label,string msg)
        {
            label.Text = msg;
            label.Visible = true;
        }

        private bool isValidated()
        {
           
                if (!String.IsNullOrWhiteSpace(txtLName.Text))
                {
                    if (!String.IsNullOrWhiteSpace(txtContact.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(txtStreet.Text))
                        {
                            if (!String.IsNullOrWhiteSpace(txtCity.Text))
                            {
                                if (!String.IsNullOrWhiteSpace(txtState.Text))
                                {
                                    if (!String.IsNullOrWhiteSpace(txtPostalCode.Text))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        DisplayError(lblErProAndZip, "Please fill in the Zip Code");
                                        return false;
                                    }
                                }
                                else
                                {
                                    DisplayError(lblErProAndZip, "Please fill in the Province");
                                    return false;
                                }
                            }
                            else
                            {
                                DisplayError(lblErCity, "Plase fill in the City");
                                return false;
                            }
                        }
                        else
                        {
                            DisplayError(lblErStrtAddress, "Plase fill in the Street address");
                            return false;
                        }
                    }
                    else
                    {
                        DisplayError(lblErCell, "Please fill in the contact");
                        return false;
                    }
                }
                else
                {
                    DisplayError(lblErLastName, "Please fill in the Last name");
                    return false;
                }
            
         
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                SwithOffLabels();
                try
                {
                    string query = $"Update Agent set  Surname={txtLName.Text},Contact={txtContact.Text},Street_Address={txtStreet.Text},City={txtCity.Text},Province={txtState.Text},Postal_Code={txtPostalCode.Text} where Agent_ID={ frmManageEmployees.selectedAgentID} ";
                    SqlCommand cmd = new SqlCommand(query, Database.connection);
                    Database.connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Employee Successfuly update", "Update Complete");
                    }
                    else
                    {
                        MessageBox.Show("Employee  update has failed", "Update Fail");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
