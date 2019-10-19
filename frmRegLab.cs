using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmRegLab : Form
    {
        public frmRegLab()
        {
            InitializeComponent();
            
        }
        string _ID, _name, _surname, _DOB, _language, _skill, _contact, _street, _addtionInfo, _gender, _birthprovince, _city, _province, _postalcode;
      
        private void FrmRegLab_Load(object sender, EventArgs e)
        {

        }

        #region KeyPressEventHandlers
        private void TxtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void TxtSkills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {//Allows the textbox to only allow integers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {//Allows the textbox to only allow integers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {//Allows the textbox to only allow integers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region OtherEventHndlers
        int counter = 0;
        private void TimerNotification_Tick(object sender, EventArgs e)
        {//time for the notifcation
            if (counter > 20)
            {
                lblNotification.Text = "";
                timerNotification.Stop();
            }
            counter++;
        }

        private void LblNotification_TextChanged(object sender, EventArgs e)
        {
            if (lblNotification.Text != "")
            {
                timerNotification.Start();
            }
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            if (!(txtContact.Text.StartsWith("0")))
            {
                inputErrorProvider.SetError(txtContact, "The Cell number must start with a 0");
                txtContact.Text = "";
                txtContact.Focus();
            }
        }

        private void DatePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            txtID.Text = "";
            string[] date = Convert.ToDateTime(datePickerDOB.Text).ToShortDateString().Split('/');
            if (date[0].Length == 1)
            {
                date[0] = ("0" + date[0]);
            }
            if (date[1].Length == 1)
            {
                date[1] = ("0" + date[1]);
            }
            txtID.Text += date[2].Substring(2, 2);
            txtID.Text += date[0];
            txtID.Text += date[1];
        }

        private void TxtAddInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboCameras_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        private void Check_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkNationality.Checked)
            {
                lblID.Text = "Passport Number";
                lblNationality.Visible = true;
                txtNationality.Visible = true;
                txtPassportNum.Visible = true;
                txtID.Visible = false;
                //make it addaptive thn rigid
                panel1.Location = new Point(12, 277);

            }
            else if (!checkNationality.Checked)

            {
                lblID.Text = "ID";
                lblNationality.Visible = false;
                txtNationality.Visible = false;
                txtPassportNum.Visible = false;
                txtID.Visible = true;
                panel1.Location = new Point(12, 244);
            }
        }
        #endregion
        #region ButtonEvenHandlers

        private void BtnCancel_Click(object sender, EventArgs e)
        {//Remeber to ask the user to cancel the operation 
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
             ClearFields();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (isValided())
            {
                try
                {
                    string query = ($"INSERT INTO Labourer([Labourer_ID],[Name],[Surname],[Date_Of_Birth],[Birth_Province],[Language],[Gender],[Contact_Number],[Street_Address],[Skills],[Additional_Information],[City],[Province],[Postal_Code])VALUES('{_ID}','{_name}','{_surname}','{_DOB}','{_birthprovince}','{_language}','{_gender}','{_contact}','{_street}','{_skill}','{_addtionInfo}','{_city}','{_province}','{_postalcode}')");
                    SqlCommand command = new SqlCommand(query, Database.connection);
                    Database.connection.Open();
                    command.ExecuteNonQuery();
                    Database.connection.Close();
                    CustomMethods.SaveImage(_ID,picLabImg);
                    ClearFields();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                 CustomMethods.DislayNotification(lblNotification, "Connection with database can not be established", "Red");
                }

            }

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {//Declaration of a camera capture instance
            CameraCapture capture = new CameraCapture(picVideo, comboCameras);

            try
            {
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
        #endregion
        #region CustomMethods

        private void ClearFields()
        {
            foreach (Control cntrl in Controls)
            {
                if (cntrl.Name.StartsWith("txt"))
                {
                    cntrl.Text = "";

                }
            }
            txtID.Clear();
            txtContact.Clear();
            txtPassportNum.Clear();
            picLabImg.Image = null;
        }
       
        private bool isValided()
        {// this method validates user input, give values to the global variable
            string IdentityNum = "";
            string Nationality = "South Africa";
            bool clear = false;
            bool isValidated = false;



            if (txtFName.Text != "" && txtFName.Text.All(char.IsLetter))
            {
                if (txtLName.Text != "" && txtLName.Text.All(char.IsLetter))
                {
                    if (CustomMethods.CalculateAge(datePickerDOB.Value.ToString().Substring(0, 9)) > 17)
                    {
                        if (checkNationality.Checked)
                        {
                            if (txtNationality.Text != "" && (txtNationality.Text.All(char.IsLetter) || txtNationality.Text.All(char.IsWhiteSpace)))
                            {

                                Nationality = txtNationality.Text;
                                if (txtPassportNum.Text != "")
                                {
                                    
                                    IdentityNum = txtPassportNum.Text;
                                    clear = true;//First name to ID fields clear of errors
                                }
                                else { InputError(txtPassportNum, "Passport Number"); }
                            }
                            else { InputError(txtNationality, "Nationality/Country of origin"); }

                        }
                        else
                        {
                            if (txtID.Text != "" && !(txtID.Text.Length < 13))
                            {
                                IdentityNum = txtID.Text;
                                clear = true;
                            }
                            else { InputError(txtID, "ID"); }
                        }
                        if (clear)
                        {
                            if (rbMale.Checked || rbFemale.Checked || rbOther.Checked)
                            {
                                if (comboLanguae.SelectedIndex > -1)
                                {
                                    if (txtBirthProvince.Text!="" )
                                    {
                                        if (txtContact.Text != "" && !(txtContact.Text.Length < 10))
                                        {
                                            if (txtStreet.Text != "")
                                            {
                                                if (txtCity.Text != "")
                                                {
                                                    if (txtProvince.Text != "")
                                                    {
                                                        if (txtPostalCode.Text != "")
                                                        {
                                                            if (txtSkills.Text != "")
                                                            {
                                                                if (txtAddInfo.Text != "")//=================================
                                                                {
                                                                    if (!(picLabImg.Image == null))
                                                                    {
                                                                        isValidated = true;
                                                                        //Assigning the values
                                                                        _name = txtFName.Text;
                                                                        _surname = txtLName.Text;
                                                                        _language = comboLanguae.SelectedItem.ToString();
                                                                        _skill = txtSkills.Text;
                                                                        _street = txtStreet.Text;
                                                                        _city = txtCity.Text;
                                                                        _province = txtProvince.Text;
                                                                        _postalcode = txtPostalCode.Text;
                                                                        _addtionInfo = txtAddInfo.Text;
                                                                        _DOB = Convert.ToDateTime(datePickerDOB.Text).ToShortDateString();
                                                                        _contact = txtContact.Text;
                                                                        _ID = IdentityNum;
                                                                        _birthprovince = txtBirthProvince.Text;
                                                                        if (rbOther.Checked)
                                                                        {
                                                                            _gender = "Other";
                                                                        }
                                                                        else if (rbMale.Checked)
                                                                        {
                                                                            _gender = "Male";
                                                                        }
                                                                        else
                                                                        {
                                                                            _gender = "Female";
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        InputError(picLabImg, "Labourer picture");
                                                                    }
                                                                }
                                                                else { InputError(txtAddInfo, "Additional Information"); }
                                                            }
                                                            else { InputError(txtSkills, "Skills"); }
                                                        }
                                                        else { InputError(txtPostalCode, "Postal Code"); }
                                                    }
                                                    else { InputError(txtProvince, "State"); }
                                                }
                                                else { InputError(txtCity, "City"); }
                                            }
                                            else { InputError(txtStreet, "Street"); }
                                        }
                                        else { InputError(txtContact, "Contact"); }
                                    }
                                    else { InputError(txtBirthProvince, "Birth Province"); }
                                }
                                else { InputError(comboLanguae, "Language"); }
                            }
                            else { InputError(gbGender, "Gender"); }
                        }
                    }
                    else { inputErrorProvider.SetError(datePickerDOB, "Labourer should be above the age of 18"); }
                }
                else { InputError(txtLName, "Last Name"); }
            }//this part checks the Name,Last name,and the nationality fields....because of the two opetion, one if statement flow had to be introduced
            else { InputError(txtFName, "First Name"); }


            return isValidated;
        }
        private void InputError(Control control, string name) => inputErrorProvider.SetError(control, $"Please provide valid input for the {name} field");

        #endregion

    }
}
