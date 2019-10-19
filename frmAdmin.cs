using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
           
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            //    // TODO: This line of code loads data into the 'datasetJobRequests.Job_Request' table. You can move, or remove it, as needed.
            try
            {
                this.Job_RequestTableAdapter.Fill(this.datasetJobRequests.Job_Request);
                this.job_RequestTableAdapter1.Fill(this.iJobDataSetD.Job_Request);
                using (iJobEntitiesModel db = new iJobEntitiesModel())
                {
                    iJobEntitiesModelBindingSource.DataSource = db.Job_Requests.ToList();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //Determine the time period used bythe charts at Form Load 0-Today,1-weekly,2-Monthly
            cmbRqstPrd.SelectedIndex = 2;
            cmbCtgrsPrd.SelectedIndex = 2;

            try
            {


                if (Database.connection.State != ConnectionState.Open)
                {
                    Database.connection.Close();
                    Database.connection.Open();
                }


                //////Chart 3==>Job requets statistics 
                ///Update the month based on the month
                lblChrtRX_axis.Text = $"{DateTime.Now.ToString("MMM")} Days";
                DataSet datasetStats = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select DAY(Date)  Date ,Count(*) [JobRequest]  From JobRequest Group By DAY(Date)", Database.connection);
                dataAdapter.Fill(datasetStats);
                chartWeeklyRequests.DataSource = datasetStats;
                chartWeeklyRequests.Series["Request"].XValueMember = "Date";
                chartWeeklyRequests.Series["Request"].YValueMembers = "JobRequest";

                ///////

                ///////

                Database.connection.Close();

            }
            catch (Exception ex)
            {
                Database.connection.Close();
                MessageBox.Show(ex.Message);
                LoadCharts();
            }
            //  LoadCharts();
            _panelReports.BringToFront();
             panelWelcome.BringToFront();
          //  this.reportViewer1.RefreshReport();
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            frm.Show();
            this.Dispose();

        }

        private void BtnSwitvh_Click(object sender, EventArgs e)
        {           
            Form frm = new frmMain();
            frm.Show();
            this.Dispose();
        }
     
        private string GetRequestQuery(string table)
        {//Method to generate SQL queris depending on the chosen selected time frame
            try
            {
                string query = "";
                switch (cmbRqstPrd.SelectedIndex)
                {
                    case 0:
                        query = $"Select count(*) From {table} Where Date = {DateTime.Today.ToString()}";

                        break;
                    case 1:
                        query = $"SELECT  COUNT(*) FROM {table} WHERE DATEPART(wk,Date) = '{DateTime.Now.DayOfYear / 7}' ";

                        break;
                    case 2:
                        query = $"SELECT  COUNT(*) FROM {table} WHERE DATEPART(m,Date) = '{DateTime.Now.Month.ToString()}'";
                        break;
                    default:
                        break;
                }
                return query;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return "";
            }
        }
        private string GetCategoryQuery(string category)
        {//Method to generate SQL queris depending on the chosen selected time frame
            string query = "";
            if (cmbCtgrsPrd.SelectedIndex==0)
            {
                switch (category)
                {
                    case "Plumbing":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE Date='{DateTime.Now}' AND CONVERT(VARCHAR, Category)='Plumbing'";
                        break;
                    case "Carpentry":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE Date='{DateTime.Now}' AND CONVERT(VARCHAR, Category)='Carpentry'";
                        break;
                    case "Welding":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE Date='{DateTime.Now}' AND CONVERT(VARCHAR, Category)='Welding'";
                        break;
                    case "Domestic":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE Date='{DateTime.Now}' AND CONVERT(VARCHAR, Category)='Domestic'";
                        break;
                    case "Painting":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE Date='{DateTime.Now}' AND CONVERT(VARCHAR, Category)='Painting'";
                        break;

                    default:
                        break;
                }
               
            }
            else if (cmbCtgrsPrd.SelectedIndex == 1)
            {
                switch (category)
                {
                    case "Plumbing":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(wk,Date) = '{DateTime.Now.DayOfYear / 7}' AND CONVERT(VARCHAR, Category)='Plumbing' GROUP BY  DATEPART(wk,Date)";
                        break;
                    case "Carpentry":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(wk,Date) = '{DateTime.Now.DayOfYear / 7}' AND CONVERT(VARCHAR, Category)='Carpentry' GROUP BY  DATEPART(wk,Date)";
                        break;
                    case "Welding":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(wk,Date) = '{DateTime.Now.DayOfYear / 7}' AND CONVERT(VARCHAR, Category)='Welding' GROUP BY  DATEPART(wk,Date)";
                        break;
                    case "Domestic":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(wk,Date) = '{DateTime.Now.DayOfYear / 7}' AND CONVERT(VARCHAR, Category)='Domestic' GROUP BY  DATEPART(wk,Date)";
                        break;
                    case "Painting":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(wk,Date) = '{DateTime.Now.DayOfYear / 7}' AND CONVERT(VARCHAR, Category)='Painting' GROUP BY  DATEPART(wk,Date)";
                        break;

                    default:
                        break;
                }
            }
            else if (cmbCtgrsPrd.SelectedIndex == 2)
            {
                switch (category)
                {
                    case "Plumbing":
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(m,Date) = '{DateTime.Now.Month - 1}' AND CONVERT(VARCHAR, Category)='Plumbing' GROUP BY  DATEPART(wk,Date)";
                        break;                                                                               
                    case "Carpentry":                                                                        
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(m,Date) = '{DateTime.Now.Month - 1}' AND CONVERT(VARCHAR, Category)='Carpentry' GROUP BY  DATEPART(wk,Date)";
                        break;                                                                               
                    case "Welding":                                                                          
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(m,Date) = '{DateTime.Now.Month - 1}' AND CONVERT(VARCHAR, Category)='Welding' GROUP BY  DATEPART(wk,Date)";
                        break;                                                                                
                    case "Domestic":                                                                          
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(m,Date) = '{DateTime.Now.Month - 1}' AND CONVERT(VARCHAR, Category)='Domestic' GROUP BY  DATEPART(wk,Date)";
                        break;                                                                                
                    case "Painting":                                                                          
                        query = $"SELECT  COUNT(*) FROM JobRequest WHERE DATEPART(m,Date) = '{DateTime.Now.Month-1}' AND CONVERT(VARCHAR, Category)='Painting' GROUP BY  DATEPART(wk,Date)";
                        break;

                    default:
                        break;
                }
            }
               
            
            return query;
        }

        private void LoadRequestChart()
        {
            if (Database.connection.State != ConnectionState.Open)
            {
                try
                {
                    Database.connection.Close();
                    Database.connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                
                }
            }
            SqlCommand cmdLab = new SqlCommand("Select count(*) From Labourer", Database.connection);
            SqlCommand cmdClient = new SqlCommand("Select count(*) From Client", Database.connection);
            SqlCommand cmdAgent = new SqlCommand("Select count(*) From Agent", Database.connection);
            SqlCommand cmdDriver = new SqlCommand("Select count(*) From Driver", Database.connection);
            SqlCommand cmdJ = new SqlCommand("Select count(*) FROM JobRequest", Database.connection);
            SqlCommand cmdJRAs = new SqlCommand($"{GetRequestQuery("JobRequest")} AND Assigned_Status='true'", Database.connection);
            SqlCommand cmdJRUa = new SqlCommand($"{GetRequestQuery("JobRequest")} AND  Assigned_Status='false'", Database.connection);
            int counter = 0;
            int counterLabs = 0;
            int counterClients = 0;
            int counterEmps = 0;
            int jobsUnassigned = 0;
            try
            {
                if (Database.connection.State != ConnectionState.Open)
                {
                    try
                    {
                        Database.connection.Close();
                        Database.connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }

                counter = (int)(cmdJ.ExecuteScalar());
                counterLabs = (int)cmdLab.ExecuteScalar();
                counterClients = (int)cmdClient.ExecuteScalar();
                counterEmps = (int)cmdAgent.ExecuteScalar() + (int)cmdDriver.ExecuteScalar();
                jobsUnassigned = (int)cmdJRUa.ExecuteScalar();
                ///////

                Database.connection.Close();
                lblNumofEmp.Text = counterEmps.ToString();
                lblNumofRequest.Text = counter.ToString();
                lbllNumofLabourers.Text = counterLabs.ToString();
                lblNumofClients.Text = counterClients.ToString();

                //Adding chart1 values

                double unassignedjobs = ((double)(jobsUnassigned) / (double)counter) * 100;
                double assignedjobs = ((double)(counter - jobsUnassigned) / (double)counter) * 100;
                // double deletedjobs = ((double)(counter - (jobsUnassigned + (counter - jobsUnassigned))) / (double)counter) * 100;
                double deletedjobs = 3;
                 //    chartRequests.Titles.Add("Job Request");


                 //  chartRequests.Series.Clear();
                 //chartRequests.ChartAreas.Clear();
                 //   chartRequests.Series.Add("Requests");
                 chartRequests.Series[0].Points.Clear();
                chartRequests.Series["Requests"].Points.AddXY("Assigned Jobs", assignedjobs);
                chartRequests.Series["Requests"].Points.AddXY("Pending Jobs", unassignedjobs);
                chartRequests.Series["Requests"].Points.AddXY("Cancelled Jobs", deletedjobs);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                LoadRequestChart();
                
            }
        }
        private void LoadCategoriesChart()
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            SqlCommand cmdPlumbing = new SqlCommand(GetCategoryQuery("Plumbing"), Database.connection);
            SqlCommand cmdCarpentry = new SqlCommand(GetCategoryQuery("Carpentry"), Database.connection);
            SqlCommand cmdDomestic = new SqlCommand(GetCategoryQuery("Domestic"), Database.connection);
            SqlCommand cmdWelding = new SqlCommand(GetCategoryQuery("Welding"), Database.connection);
            SqlCommand cmdPainting = new SqlCommand(GetCategoryQuery("Painting"), Database.connection);
            int plumbing = 0;
            int carpentry = 0;
            int domestic = 0;
            int welding = 0;
            int painting = 0;


            if (cmdPlumbing.ExecuteScalar()!=null)
            {
                int.TryParse(cmdPlumbing.ExecuteScalar().ToString(), out plumbing);
            }
            if (cmdCarpentry.ExecuteScalar() != null)
            {
                int.TryParse(cmdCarpentry.ExecuteScalar().ToString(), out carpentry);
            }
            if (cmdDomestic.ExecuteScalar() != null)
            {
                int.TryParse(cmdDomestic.ExecuteScalar().ToString(), out domestic);
            }
            if (cmdWelding.ExecuteScalar() != null)
            {
                int.TryParse(cmdWelding.ExecuteScalar().ToString(), out welding);
                if (welding==0)
                {
                    welding = 3;
                }
            }
            if (cmdPainting.ExecuteScalar() != null)
            {
                int.TryParse(cmdPainting.ExecuteScalar().ToString(), out painting);
            }







            // chartCategories.Titles.Add("Requests by Categories");
            // chartCategories.Series.Clear();
            //    chartCategories.Series.Add("Categories");
            chartCategories.Series[0].Points.Clear();
            chartCategories.Series["Categories"].Points.AddXY("Plumbing", plumbing);
            chartCategories.Series["Categories"].Points.AddXY("Carpentry", carpentry);
            chartCategories.Series["Categories"].Points.AddXY("Domestic", domestic);
            chartCategories.Series["Categories"].Points.AddXY("Welding", welding);
            chartCategories.Series["Categories"].Points.AddXY("Painting", painting);

        }
        private void LoadStats()
        {
            try
            {
                

                if (Database.connection.State == ConnectionState.Closed)
                {
                    Database.connection.Open();
                }


                //////Chart 3==>Job requets statistics 
                ///Update the month based on the month
                lblChrtRX_axis.Text = $"{DateTime.Now.ToString("MMM")} Days";
                DataSet dataset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select DAY(Date)  Date ,Count(*) [JobRequest]  From JobRequest Group By DAY(Date)", Database.connection);
                dataAdapter.Fill(dataset);
                chartWeeklyRequests.DataSource = dataset;
                chartWeeklyRequests.Series["Request"].XValueMember = "Date";
                chartWeeklyRequests.Series["Request"].YValueMembers = "JobRequest";

                ///////

                ///////

                Database.connection.Close();

            }
            catch (Exception ex)
            {
                Database.connection.Close();
                MessageBox.Show(ex.Message);
                LoadCharts();
            }
        }
        private void LoadCharts()
        {
         //   LoadStats();
            LoadRequestChart();
            LoadCategoriesChart();            
           
            //CLosing the connection because the methods above open the connection but do not close it;
            //this has been done to avoid opening and closing the database connection ...
            Database.connection.Close();
        }
        private void LoadPrintableReports()
        {//EMthod to add data to the request table,it also avoids the database loginig in prompt
            try
            {
                ReportsRequest reportJobRequests = new ReportsRequest();
                ProfitableClientsReport profitableClientsReport = new ProfitableClientsReport();
                PlacementByLabourer placementByLabourerReport = new PlacementByLabourer();
                HghlyRqstdCtgryRprt hghlyRqstdCtgryReport = new HghlyRqstdCtgryRprt();

                reportJobRequests.SetDatabaseLogon($"{Database.serverLoginName}", $"{Database.serverLoginPass}", $"{Database.serverName}", $"{Database.databaseName}");
                profitableClientsReport.SetDatabaseLogon($"{Database.serverLoginName}", $"{Database.serverLoginPass}", $"{Database.serverName}", $"{Database.databaseName}");
                placementByLabourerReport.SetDatabaseLogon($"{Database.serverLoginName}", $"{Database.serverLoginPass}", $"{Database.serverName}", $"{Database.databaseName}");
                hghlyRqstdCtgryReport.SetDatabaseLogon($"{Database.serverLoginName}", $"{Database.serverLoginPass}", $"{Database.serverName}", $"{Database.databaseName}");
                // reportJobRequests.Load(@"C:\Users\T4NY4\source\repos\iJob2019\PROJECT BACKUP\iJob2019 08_05_2019\ReportJobRequests.rpt");

                reportViewerJobR.ReportSource = reportJobRequests;
                reportViewerJobR.Refresh();

                JobPlacementRprtVwr.ReportSource = placementByLabourerReport;
                JobPlacementRprtVwr.Refresh();

                ProfitabelClientViewer2.ReportSource = profitableClientsReport;
                ProfitabelClientViewer2.Refresh();

                RqstPerLabourersReportViewer.ReportSource = hghlyRqstdCtgryReport;
                RqstPerLabourersReportViewer.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void BtnReports_Click(object sender, EventArgs e)
        {
            
            LoadCharts();
            LoadPrintableReports();
            Form frmLoading = new frmReportsLoading();
            frmLoading.ShowDialog();
            _panelReports.BringToFront();

        }

        private void BtnOnlineHelp_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new frmOnlineHelp();
            frm.Show();

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            using (Form frm = new frmManageEmployees())
            {
                frm.ShowDialog();
            }
        }
        
        private void BtnMailBox_Click(object sender, EventArgs e)
        {
            _panelMailBox.BringToFront();
        }

        private void CmbRqstPrd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadRequestChart();
        }

        private void CmbCtgrsPrd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCategoriesChart();
        }

        private void CmbCtgrsPrd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void PicHomeLogo_Click(object sender, EventArgs e)
        {
            panelWelcome.BringToFront();
        }
    }
}
