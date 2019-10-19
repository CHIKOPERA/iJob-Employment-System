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
    public partial class frmManageLabourers : Form
    {
        public frmManageLabourers()
        {
            InitializeComponent();
            
        }

        private void PanelMenuInfo_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string  SelectedID { get; set; }
        private void FrmManageLabourers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLabourer.Labourer' table. You can move, or remove it, as needed.
            try
            {
                this.labourerTableAdapter.Fill(this.dsLabourer.Labourer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
           
        }
        private void DgvLabourers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillSidePanelDetails();          
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SelectedID = dgvLabourers.SelectedCells[0].Value.ToString();
            Form frm = new frmEditLab();
            frm.ShowDialog();
        }
        private void CancelUpdate()
        {
         
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelUpdate();
        }

        private void BtnFinishUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    string query = $"UPDATE Labourer SET [Name] ='{txtFName.Text}' ,[Surname] ='{txtLName.Text}' ,[Birth_Province] = '{txtNationality.Text}',[Contact] ='{txtContact.Text}' ,[Address] ='{txtAddress.Text}'  ,[Additional_Information] ='{txtAdditionalInfo}' WHERE Labourer_ID={dgvLabourers.SelectedCells[0].Value.ToString()}";

                    SqlCommand command = new SqlCommand(query, Database.connection);
                    Database.connection.Open();
                    command.ExecuteNonQuery();
                    Database.connection.Close();
                    // MessageBox.Show("The labourer proile has been succefully updated", "Update Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNotification.Text = "The labourer profile has been succefully updated";
                    dgvLabourers.Refresh();
                    CancelUpdate();
                }
                catch (Exception)
                {

                    // MessageBox.Show("An error occured while trying to update the datebase","Connection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    // lblNotification.Text = "An error occured while trying to update the datebase";
                    throw;


                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleting the Labourer will completely remove the record from the database together with all its references. Are you sure you want to continue", "Record Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    Database.connection.Close();
                    if (Database.connection.State!=ConnectionState.Open)
                    {
                        Database.connection.Open();

                    }
                    string query = ($"DELETE FROM LabourerRating WHERE[Labourer_ID] ={dgvLabourers.SelectedCells[0].Value.ToString()}  DELETE FROM Placement WHERE[Labourer_ID] ={dgvLabourers.SelectedCells[0].Value.ToString()} DELETE FROM Payment WHERE[Labourer_ID] ={dgvLabourers.SelectedCells[0].Value.ToString()} DELETE FROM Labourer WHERE[Labourer_ID] ={dgvLabourers.SelectedCells[0].Value.ToString()}");
                    SqlCommand command = new SqlCommand(query, Database.connection);
                    Database.connection.Open();
                    command.ExecuteNonQuery();
                    dgvLabourers.Rows.RemoveAt(this.dgvLabourers.SelectedRows[0].Index);
                    dgvLabourers.Refresh();
                    CustomMethods.DislayNotification(lblNotification, "Labouer has been succesfully deleted","Green");
                    Database.connection.Close();
                }
                catch (Exception)
                {
                    CustomMethods.DislayNotification(lblNotification, "An error occured while reading the database", "Red");
                }
            }
        }

        private void DgvLabourers_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void FillSidePanelDetails()
        {
            try
            {

            string query = "Select * from Labourer where [Labourer_ID]= " + dgvLabourers.SelectedCells[0].Value.ToString();
            Database.connection.Open();
                SqlCommand command = new SqlCommand(query, Database.connection);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    txtFName.Text = dataReader["Name"].ToString();
                    txtLName.Text = dataReader["Surname"].ToString();
                    txtDOB.Text = dataReader["Date_Of_Birth"].ToString();
                    txtLanguage.Text = dataReader["Language"].ToString();
                    txtAddress.Text = (dataReader["Street_Address"].ToString()+", "+ dataReader["City"].ToString() +", "+ dataReader["Province"].ToString() +", "+dataReader["Postal_Code"].ToString());
                    txtNationality.Text = dataReader["Birth_Province"].ToString();
                    txtAdditionalInfo.Text = dataReader["Additional_Information"].ToString();
                    txtContact.Text = dataReader["Contact_Number"].ToString();
                }
                Database.connection.Close();
                if (dgvLabourers.SelectedCells[5].Value.ToString() == "Male")
                {
                    radioMale.Checked = true;
                }
                else if (dgvLabourers.SelectedCells[5].Value.ToString() == "Female")
                {
                    radioFemale.Checked = true;
                }
                else
                {
                    radioOther.Checked = true;
                }
                CustomMethods.GetImage(dgvLabourers.SelectedCells[0].Value.ToString(), picLabImage);
            }
           catch (Exception)
            {
               
            }
        }
        private bool ValidateInput()
        {
            bool isValid = false;
          
            foreach (Control textbox in panelLabourerInfo.Controls)
            {
                if (textbox.Name.StartsWith("txt") && textbox.Text != "")
                {
                }
                else if (textbox.Name.StartsWith("txt"))
                {                  
                    CustomMethods.DislayNotification(lblNotification, "Please fill in all fields before updating", "Red");
                    return isValid;
                }
            }
            
            if (txtFName.Text.All(char.IsLetter))
                {
                    if (txtLName.Text.All(char.IsLetter))
                    {
                        if (radioFemale.Checked==true||radioMale.Checked==true||radioOther.Checked==true)
                        {
                              if (!(txtContact.Text.Length<10))
                              {
                                  if (txtAdditionalInfo.Text != "" && !txtAdditionalInfo.Text.All(char.IsDigit))
                            {
                                isValid = true;
                            }
                                  else { InvalidInputMsg("Additional Information"); }      
                              }
                              else { InvalidInputMsg("Contact"); }                   

                        }
                        else { InvalidInputMsg("Gender"); }
                    }
                    else
                    {
                        InvalidInputMsg("Last Name");
                    }
                 }
            else
            {
                InvalidInputMsg("First Name");
            }
                       
            return isValid;
            

        }
        private void InvalidInputMsg(string field)
        {
             CustomMethods.DislayNotification(lblNotification, $"Please provide valid input for  {field}", "Red");
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmRegLab();
            frm.ShowDialog();         
        }

        private void DgvLabourers_SelectionChanged(object sender, EventArgs e)
        {
            FillSidePanelDetails();
        }

        int counter = 0;//For controlling the message dispaly in the label 
        private void TimerMessage_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter>3)
            {
                lblNotification.Text = "";
                timerMessage.Stop();
            }

        }

        private void LblNotification_TextChanged(object sender, EventArgs e)
        {
           
            if (lblNotification.Text!="")
            {
                timerMessage.Start();
            }
        }

        private void TxtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        DataView dv;
        private void TimerDgvRefresh_Tick(object sender, EventArgs e)
        {
            dv = new DataView(dsLabourer.Tables[0]);
            dgvLabourers.DataSource = dv;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {//Refresh the datagrid, useful after a record has been added
            try
            {
                this.labourerTableAdapter.Fill(this.dsLabourer.Labourer);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchLname_TextChanged(object sender, EventArgs e)
        {//Search Labouere using ID
            try
            {
                DataView dv;
                dv = txtSearchLname.Text != "" ? new DataView(dsLabourer.Tables[0], $"Labourer_ID LIKE '{txtSearchLname.Text}%'", "Labourer_ID Desc", DataViewRowState.CurrentRows)
                                               : new DataView(dsLabourer.Tables[0]);
                dgvLabourers.DataSource = dv;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LblNotification_Click(object sender, EventArgs e)
        {

        }
    }
}
