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
    public partial class frmEditLab : Form
    {
                string address = "";
        public frmEditLab()
        {
            InitializeComponent();
        }

        private void FrmEditLab_Load(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand($"Select * From Labourer where Labourer_ID={frmManageLabourers.SelectedID }", Database.connection);
                SqlDataReader dataReader;
                Database.connection.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    lblIDDisplay.Text = dataReader["Labourer_ID"].ToString();
                    txtFName.Text = dataReader["Name"].ToString();
                    txtLName.Text = dataReader["Surname"].ToString();
                    txtAddInfo.Text = dataReader["Additional_Information"].ToString();
                    txtSkills.Text = dataReader["Skills"].ToString();
                    txtContact.Text = dataReader["Contact_Number"].ToString();
                   address = dataReader["Street_Address"].ToString();
                }
                Database.connection.Close();
                CustomMethods.GetImage(frmManageLabourers.SelectedID, picLab);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TxtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtState_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void TxtState_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtSkills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtAddInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                try
                {
                    string query = $"UPDATE Labourer  SET [Name] ='{txtFName.Text}' ,[Surname] ='{txtLName.Text}' ,[Birth_Province] ='{txtNationality.Text}' ,[Language] ='{comboLanguae.SelectedText.ToString()}' ,[Contact] ='{txtContact.Text}' ,[Street_Address] = '{address}',[Skills] ='{txtSkills.Text}' ,[Additional_Information] = '{txtAddInfo.Text}' WHERE Labourer_ID={lblIDDisplay.Text}";
                    SqlCommand command = new SqlCommand(query, Database.connection);
                    Database.connection.Open();
                    command.ExecuteNonQuery();
                    Database.connection.Close();
                    CustomMethods.DislayNotification(lblNotification,"Profile has been added successfully" ,"Green");
                }
                catch (Exception)
                {
                    //Display error message
                    CustomMethods.DislayNotification(lblNotification, "Profile has been added successfully", "Red");
                }
            }
        }
        private void InputError(Control cntrl,string msg)
        {
            errorInpput.SetError(cntrl, msg);
        }
        private bool IsValidated()
        {
            bool isValid = false;         
            foreach (Control textbox in Controls)
            {
                if (textbox.Name.StartsWith("txt"))
                {
                    if (textbox.Text != "")
                    {
                        isValid = true;
                    }
                    else
                    {
                        InputError(textbox, "Please fill in the field");
                        return false;
                    } 
                }
            }
            return isValid;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox textbox in Controls)
            {
                if (textbox.Text.StartsWith("txt"))
                {
                    textbox.Text = ""; 
                }
            }
        }
        int counter = 0;
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {//Display the mesgae for the user 
            try
            {
                if (counter > 3)
                {
                    lblNotification.Text = "";
                    timerUpdate.Stop();
                    counter = 0;
                    if (lblNotification.ForeColor == System.Drawing.Color.Green)
                    {
                        Close();
                    }
                }
                counter++;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LblNotification_TextChanged(object sender, EventArgs e)
        {
            timerUpdate.Start();
        }

        private void TxtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
