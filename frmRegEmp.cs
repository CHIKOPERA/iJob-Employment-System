using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmRegEmp : Form
    {
        public frmRegEmp()
        {
            InitializeComponent();
        } 
        private void FrmRegEmp_Load(object sender, EventArgs e)
        {
            comboEmpType.SelectedIndex = 0;
        }
        Employee employee = new Employee();
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (isValidatedInput())
            {
                try
                {
                    string query = "";
                    if (comboEmpType.SelectedIndex==0)
                    {
                        query = $"Insert Into Agent (Agent_ID,Name,Surname,Date_Of_Birth,Gender,Contact,Email,Street_Address,Province,Postal_Code,City) VALUES ('{employee.ID}','{employee.Name}','{employee.Surname}','{employee.DOB}','{employee.Gender}','{employee.Contact}','{employee.Email}','{employee.Street}','{employee.Province}','{employee.PostalCode}','{employee.City}'); Insert into Credential (Agent_ID,Username,Password,Rights) VALUES ('{employee.ID}','{employee.Email}','{employee.Password}','{employee.Rights}')";
                    }
                    else
                    {
                        query =$"INSERT INTO DRIVER (Driver_ID,Name,Surname,Date_Of_Birth,Gender,Contact,Email,Street_Address,Province,Postal_Code,City) VALUES ('{employee.ID}','{employee.Name}','{employee.Surname}','{employee.DOB}','{employee.Gender}','{employee.Contact}','{employee.Email}','{employee.Street}','{employee.Province}','{employee.PostalCode}','{employee.City}')";

                    }

                    SqlCommand cmd = new SqlCommand(query, Database.connection);
                    Database.connection.Close();
                    Database.connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Database.connection.Close();
                        MessageBox.Show("Employee registered successfully ");
                        Close();
                    }
                    else
                    {
                        Database.connection.Close();
                        MessageBox.Show("Employee Registration failed");
                        Close();
                    }
                    CustomMethods.SaveImage(txtID.Text, picLabImg);
                }
                catch (Exception ex)
                {
                    Database.connection.Close();
                    MessageBox.Show(ex.Message);
                }
              
            }
        }
        private void ComboEmpType_SelectionChangeCommitted(object sender, EventArgs e)
        {//changes the registration option to either Agent or the driver 
            if (comboEmpType.SelectedIndex.ToString()=="0")
            {//For Agent Option
                checkAdminRights.Enabled = true;
                checkAdminRights.Visible = true;           
                gbGender.Location = new Point(13, 332);        
            }
            else
            {// For driver Option
               
                checkAdminRights.Visible = false;
                checkAdminRights.Enabled = false ;            
                gbGender.Location = new Point(15, 381);
         
            }

        }
        private bool isValidatedInput()
        {//form validation method

            bool isValidated = false;
                if (txtFName.Text!="" && txtFName.Text.All(char.IsLetter))
                {
                    if (txtLName.Text!="" && txtFName.Text.All(char.IsLetter))
                    {
                    if (CustomMethods.CalculateAge(datePickerDOB.Value.ToString().Substring(0, 8)) > 19)
                    {
                        if (txtID.Text != "" && !(txtID.Text.Length<13))
                        {
                            
                            if (rbFemale.Checked || rbMale.Checked || rbOther.Checked)
                            {

                                if (txtContact.Text != "" && !(txtContact.Text.Length<10))
                                {
                                    if (txtEmail.Text != "")
                                    {
                                        if (txtStreet.Text != "")
                                        {
                                            if (txtCity.Text!="")
                                            {
                                                if (txtProvince.Text!="")
                                                {
                                                    if (txtPostalCode.Text!="")
                                                    {
                                                        if (txtPassword.Text != "")
                                                        {
                                                            if (txtConfimPass.Text != "")
                                                            {
                                                                if (txtConfimPass.Text == txtPassword.Text)
                                                                {
                                                                    try
                                                                    {
                                                                        MailAddress mail = new MailAddress(txtEmail.Text);
                                                                    }
                                                                    catch (Exception)
                                                                    {
                                                                        Msg("Email not valid");
                                                                        return false;
                                                                    }
                                                                  
                                                                  if (picLabImg.Image != null)
                                                                  {
                                                                      employee.ID = txtID.Text;
                                                                      employee.Name = txtFName.Text;
                                                                      employee.Surname = txtLName.Text;
                                                                      employee.Street = txtStreet.Text;
                                                                      employee.Province = txtProvince.Text;
                                                                      employee.City = txtCity.Text;
                                                                      employee.DOB = datePickerDOB.Value.Date.ToShortDateString();
                                                                      employee.Email = txtEmail.Text;
                                                                      employee.Contact = txtContact.Text;
                                                                      employee.PostalCode = txtPostalCode.Text;
                                                                      if (rbMale.Checked)
                                                                            {
                                                                                employee.Gender = "Male";
                                                                            }
                                                                      else if (rbFemale.Checked)
                                                                            {
                                                                                employee.Gender = "Female";
                                                                            }
                                                                      else
                                                                            {
                                                                                employee.Gender = "Other";
                                                                            }
                                                                      employee.Password = txtPassword.Text;

                                                                      if (checkAdminRights.Checked == true)
                                                                            {
                                                                                employee.Rights = true;
                                                                            }
                                                                      else
                                                                            {
                                                                                employee.Rights = false;
                                                                            }

                                                                      isValidated = true;
                                                                  }
                                                                  else
                                                                        {
                                                                            Msg("Picture");
                                                                        }
                                                                                                                                 
                                                                 
                                                                 
                                                                }
                                                                else { MessageBox.Show("Your password did not match", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
                                                            }
                                                            else { Msg("Confrim Password"); }
                                                        }
                                                        else { Msg("Password"); }
                                                    }
                                                    else
                                                    {
                                                        Msg("Zip Code");
                                                    }
                                                }
                                                else
                                                {
                                                    Msg("Province");
                                                }
                                            }
                                            else { Msg("City"); }

                                        }
                                        else { Msg("Address"); }
                                    }
                                    else { Msg("Email"); }
                                }
                                else { Msg("Contact"); }
                            }
                            else { Msg("Gender"); }
                        }
                        else { Msg("Identity Number"); }
                    }
                    else { MessageBox.Show("Employer should be older that 18 years","Inalid Date",MessageBoxButtons.OK,MessageBoxIcon.Hand);}
                    }
                    else { Msg("Last Name"); }
                }
                else { Msg("First Name"); }
            return isValidated;
        }
        private void Msg(string text) => MessageBox.Show($"The {text} field is Empyt or Invalid, please provide  input before proceding ","Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Hand);
      
        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.Name.StartsWith("txt"))
                {
                    control.Text = "";
                }
            }
        }
        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {//Allows the text box to only accept digits for each key pressed 
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {//Allows the text box to only accept digits for each key pressed            
                if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }           
        }
        private void TxtLicence_KeyPress(object sender, KeyPressEventArgs e)
        {//Allows the text box to only accept digits for each key pressed            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {//Allows the textbox to only accept integers
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)){e.Handled = true;}
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                CameraCapture capture = new CameraCapture(picVideo, comboCameras);
                picVideo.BringToFront();
                btnStart.Visible = false;
                btnCapture.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                picLabImg.Image = (Bitmap)picVideo.Image.Clone();
                picLabImg.BringToFront();
                btnStart.Visible = true;
                btnCapture.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
