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
    public partial class frmJobs : Form
    {
        public frmJobs()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //Job job = new Job(rand.Next(10000, 99999).ToString(), rand.Next(10000, 99999).ToString(), rand.Next(10000, 99999).ToString(), "6876987", "Plumbing", DateTime.Now.ToShortDateString(), 234, true, true);
            //Job.openJobList.Add(job);
            //dgvJobs.DataSource = null;
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
      
            //DataView dv = new DataView(jobsDataset.Tables[0], "[Transport]='False'", "[Job_ID] Desc", DataViewRowState.CurrentRows);
            //dgvJobs.DataSource = dv;

        }

        private void dgvJobs_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dgvJobs.SelectedCells[2].Value.ToString());
            string queryTransport = "";
            string queryLab = "Select * from Labourer where Labourer_ID = " + dgvJobs.SelectedCells[2].Value.ToString();//Labouere ID
            string queryEmp = "Select * from Agent WHERE [Agent_ID]=" + dgvJobs.SelectedCells[3].Value.ToString();

            if (dgvJobs.SelectedCells[8].ToString() == "False")
            {//if client does not provide transport

                queryTransport = "Select * from Driver where Driver_ID = " + dgvJobs.SelectedCells[4].Value.ToString();
                lblTransportProvider.Text = "iJob";
            }
            else
            {
                queryTransport = "Select * from Client where Client_ID = (Select Client_ID from [Job Request] where Job_Request_ID = " + dgvJobs.SelectedCells[1].Value.ToString() + ")";
                lblTransportProvider.Text = "Client";

            }
            SqlCommand command1 = new SqlCommand(queryLab, Database.connection);
            SqlDataReader dataReader;
            Database.connection.Open();
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                //Displaying the labourer details
                //Add the code to add the picture
                lblName.Text = dataReader["Name"].ToString();
                lblSurname.Text = dataReader["Surname"].ToString();
                lblSkill.Text = dataReader["Skills"].ToString();
            }
            Database.connection.Close();
            ////////////////////////////////////////////////////////////////////////////////////
            Database.connection.Open();
            SqlCommand command2 = new SqlCommand(queryEmp, Database.connection);
            dataReader = command2.ExecuteReader();
            if (dataReader.Read())
            {//Displaying the Agent information
                lblEmpID.Text = dataReader["Name"].ToString();
                lblEmpName.Text = dataReader["Surname"].ToString();
                lblEmpName.Text = dataReader["Name"].ToString();
            }
            Database.connection.Close();
            /////////////////////////////////////////////////////////////////////////////////
            Database.connection.Open();
            SqlCommand command3 = new SqlCommand(queryTransport, Database.connection);
            dataReader = command3.ExecuteReader();
            if (dataReader.Read())
            {//Displaying the transport information 

                lblDriverName.Text = dataReader["Name"].ToString();

            }
            Database.connection.Close();
        }
    }
}
