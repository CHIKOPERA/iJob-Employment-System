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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        public int JobId { get; set; }
        public static int _selectedID = 0;//Used to pass the selected index to other forms
        public static string networkErrorMsg = "";
        private void LoadData()
        {
            try
            {
                // TODO: This line of code loads data into the 'dsJobRequestt.JobRequest' table. You can move, or remove it, as needed.

                this.jobRequestTableAdapter.Fill(this.dsJobRequestt.JobRequest);
                DataView dataView = new DataView(dsJobRequestt.Tables[0], "Assigned_Status='false'", "", DataViewRowState.CurrentRows);
                dgvJobRequests.DataSource = dataView;
                CustomMethods.GetImage(LoginSession.ID, picUser);
            }
            catch (Exception ex)
            {
                networkErrorMsg = ex.Message;

                Form frm = new frmNetwork();
                frm.Show();
                this.Close();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData();                 
           lblUserName.Text = LoginSession.UserName;
           
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {         
            _panelDashBoard.BringToFront();
            
        }

        private void BtnMailBox_Click(object sender, EventArgs e)
        {
            _panelMailBox.BringToFront();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnLabourers_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new frmManageLabourers();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnManEmp_Click(object sender, EventArgs e)
        {
           
        }
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = DateTime.Now.ToShortTimeString();
                lblDate.Text = DateTime.Now.ToLongDateString();
                lblOpenJobs.Text = "Available Jobs: " + dgvJobRequests.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void BtnAssignJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJobRequests.SelectedRows.Count > 0)//if a record has been selected 
                {
                    _selectedID = int.Parse(dgvJobRequests.SelectedCells[0].Value.ToString());
                    using (Form frmAssignJob = new frmAssignJob())
                    {
                        frmAssignJob.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record before proceeding", "No selected Job", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            try
            {

                Form frm = new frmLogin();
                Hide();
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PictureAdminRightsOn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void PicAdminRightsOff_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deleting the job will completely remove it from the database. Are you sure you want to continue", "Record Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //make sure u cnt delete 

                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM [JobRequest] WHERE  [Job_Request_ID] =" + dgvJobRequests.SelectedCells[0].Value.ToString(), Database.connection);
                    Database.connection.Open();
                    command.ExecuteNonQuery();
                    Database.connection.Close();
                    dgvJobRequests.Rows.RemoveAt(this.dgvJobRequests.SelectedRows[0].Index);
                    dgvJobRequests.Refresh();
                    MessageBox.Show("The job has been successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ComboSortJobs_SelectionChangeCommitted(object sender, EventArgs e)
        {//Sorting records arcding to selected value
            try
            {
                DataView dv;
                dv = comboSortJobs.SelectedIndex.ToString() != "0" ? new DataView(dsJobRequestt.Tables[0], $"Category='{comboSortJobs.SelectedItem.ToString()}' AND [Assigned_Status]='False'", "Category Desc", DataViewRowState.CurrentRows)
                                                                     : new DataView(dsJobRequestt.Tables[0], "[Assigned_Status]='False'", "[Job_Request_ID] Desc", DataViewRowState.CurrentRows);
                dgvJobRequests.DataSource = dv;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void _panelDashBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnOnlineHelp_Click(object sender, EventArgs e)
        {
            Form frm = new frmOnlineHelp();
            frm.ShowDialog();
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            Form frm = new frmAdministrator();
            frm.Show();
            Close();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobRequestTableAdapter.Fill(this.dsJobRequestt.JobRequest); 
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Form frm = new frmOnlineHelp();
            //frm.ShowDialog();
            _panelOnlineHelp.BringToFront();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();            
        }

        private void DgvJobRequests_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            //try
            //{
            //    MessageBox.Show(dgvJobRequests.SelectedCells[9].Value.ToString());

            //}
            //catch (Exception)
            //{

            //  //  throw;
            //}
        }
    }
}
