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
    public partial class frmAdministrator : Form
    {
        public frmAdministrator()
        {
            InitializeComponent();
        }
     
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    try
                    {
                        SqlDataReader dataReader;
                        string query = ($"SELECT * FROM [Credential] where Username = '{txtUserName.Text}' AND Password='{txtPassword.Text}'");
                        SqlCommand command = new SqlCommand(query, Database.connection);
                        Database.connection.Open();
                        dataReader = command.ExecuteReader();
                        if (dataReader.Read())
                        {
                            if (dataReader["Rights"].ToString() == "True")
                            {
                                Form frm = new frmAdmin();
                                frm.Show();
                                Close();
                            }
                            else
                            {

                                MessageBox.Show("The User Account does not have adminstrative rights", "Denied Access", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Does not exist", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Database.connection.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                    errorProviderInput.SetError(txtPassword, "Please fill in the Password");
                    txtPassword.Focus();
                }
            }
            else
            {
                errorProviderInput.SetError(txtUserName, "Please fill the Username");
                txtUserName.Focus();
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            frm.Show();
            Close();

        }
    }
}
