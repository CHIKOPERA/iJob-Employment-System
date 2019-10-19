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
    public partial class frmManageEmployees : Form
    {
        public frmManageEmployees()
        {
            InitializeComponent();
        }
        private static string your_username = "ijob", your_password = "Tanya@dodger";
        public static string selectedAgentID = "";

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void FrmManageEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetAgents.Agent' table. You can move, or remove it, as needed.
            try
            {
                this.agentTableAdapter.Fill(this.datasetAgents.Agent);
            }
            catch (Exception ex)
            {

              DialogResult dialogResult=  MessageBox.Show(ex.Message +" Do you want to try again","Load Delay",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult ==DialogResult.Yes)
                {
                    try
                    {
                        this.agentTableAdapter.Fill(this.datasetAgents.Agent);
                    }
                    catch (Exception exx)
                    {

                        MessageBox.Show(exx.Message);
                    }
                }
            }

        }

        private void DgvEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillPanelDetails();
        }
        DataView dv;
        private void TxtSearchLname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dv = new DataView(datasetAgents.Tables[0], $"Agent_ID LIKE '{txtSearchLname.Text}%'", "Agent_ID Desc", DataViewRowState.CurrentRows);
                dgvEmployees.DataSource = dv;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BtnRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                dv = new DataView(datasetAgents.Tables[0]);
                dgvEmployees.DataSource = dv;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (Form frm = new frmRegEmp())
            {
                frm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            selectedAgentID = dgvEmployees.SelectedCells[0].Value.ToString();
            using (Form frm = new frmEditEmployee())
            {
                frm.ShowDialog();
            }
        }

        private void FillPanelDetails()
        {
            if (dgvEmployees.SelectedRows.Count>0)
            {
                SqlCommand cmd = new SqlCommand($"Select * from Agent where Agent_ID= {dgvEmployees.SelectedCells[0].Value.ToString()}", Database.connection);
                try
                {
                    Database.connection.Open();
                   
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        txtFName.Text = dataReader["Name"].ToString();
                        txtLName.Text = dataReader["Surname"].ToString();
                        txtDOB.Text = dataReader["Date_Of_Birth"].ToString();
                        txtProvince.Text = dataReader["Province"].ToString();
                        txtContact.Text = dataReader["Contact"].ToString();
                        txtAddress.Text = $"{dataReader["Street_Address"].ToString()}, {dataReader["City"].ToString()}, {dataReader["Province"].ToString()},  {dataReader["Postal_Code"].ToString()}";
                    }   
                    Database.connection.Close();
                    CustomMethods.GetImage(dgvEmployees.SelectedCells[0].Value.ToString(), picLabImage);
                }
                catch (Exception ex)
                {
                    Database.connection.Close();
                    MessageBox.Show(ex.Message);
                } 
            }
        }
    }
}
