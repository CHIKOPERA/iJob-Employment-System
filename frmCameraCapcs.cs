using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using CrystalDecisions.Shared;

namespace iJob2019
{
    public partial class frmCameraCapcs : Form
    {
        public frmCameraCapcs()
        {
            InitializeComponent();
        }
        //private FilterInfoCollection CaptureDevices;
        //private VideoCaptureDevice videoSource;

        private void FrmCameraCapcs_Load(object sender, EventArgs e)
        {
            //Code to identify all the available web cameras
            //CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo Device in CaptureDevices)
            //{
            //    comboBox1.Items.Add(Device.Name);

            //}
            //comboBox1.SelectedIndex = 0;
            //videoSource = new VideoCaptureDevice();
            //videoSource = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            //videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            //videoSource.Start();

            try
            {
                //load();
                LoadChart();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
              ///  load();

            }

            
            
        }
        private void LoadChart()
        {

            SqlCommand cmdJ;
            cmdJ = new SqlCommand("Select count(*) FROM JobRequest",Database.connection);
            SqlCommand cmdLab = new SqlCommand("Select count(*) From Labourer", Database.connection);
            SqlCommand cmdClient = new SqlCommand("Select count(*) From Client", Database.connection);
            SqlCommand cmdAgent = new SqlCommand("Select count(*) From Agent", Database.connection);
            SqlCommand cmdDriver = new SqlCommand("Select count(*) From Driver", Database.connection);
            SqlCommand cmdJRAs = new SqlCommand("Select count(*) From JobRequest WHERE Assigned_Status='true'", Database.connection);
            SqlCommand cmdJRUa = new SqlCommand("Select count(*) From JobRequest WHERE Assigned_Status='false'", Database.connection);
            int counter = 0;
            int counterLabs = 0;
            int counterClients = 0;
            int counterEmps = 0;

            Database.connection.Open();

          
            counter = (int)(cmdJ.ExecuteScalar());
            counterLabs = (int)cmdLab.ExecuteScalar();
            counterClients = (int)cmdClient.ExecuteScalar();
            counterEmps = (int)cmdAgent.ExecuteScalar() + (int)cmdDriver.ExecuteScalar();
            Database.connection.Close();
            lblNumofEmp.Text = counterEmps.ToString();
            lblNumofRequest.Text = counter.ToString();
            lbllNumofLabourers.Text = counterLabs.ToString();
            lblNumofClients.Text = counterClients.ToString();
            chartRequests.Titles.Add("Job Request");
            chartRequests.Series["Requests"].Points.AddXY("Assigned Jobs","60");
            chartRequests.Series["Requests"].Points.AddXY("Unssigned Jobs", "25");
            chartRequests.Series["Requests"].Points.AddXY("Deleted Jobs", "15");

            if (Database.connection.State==ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            
            //////Chart 2==>Job requets statistics 
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
            ///Chart 3 ==> Payemnt
            lblChrtPayXaxis.Text = lblChrtRX_axis.Text = $"{DateTime.Now.ToString("MMM")} Days";
            DataSet dataset2 = new DataSet();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select DAY(Date) Date, SUM(Amount) Amount From Payment Group By DAY(Date)", Database.connection);
            dataAdapter2.Fill(dataset2);
            chartWeelyPayment.DataSource = dataset2;
            chartWeelyPayment.Series["Payments"].XValueMember = "Date";
            chartWeelyPayment.Series["Payments"].YValueMembers = "Amount";
            ////////
            Database.connection.Close();
        }
        private void loadRequestReport()
        {
            ReportsRequest reportJobRequests = new ReportsRequest();
            reportJobRequests.SetDatabaseLogon("ijob", "Tanya@dodger12","ijobsrvr.database.windows.net","iJobDatabase");
            
           // reportJobRequests.Load(@"C:\Users\T4NY4\source\repos\iJob2019\PROJECT BACKUP\iJob2019 08_05_2019\ReportJobRequests.rpt");
        
            reportViewerJobR.ReportSource = reportJobRequests;
            reportViewerJobR.Refresh();
        }
        private void BtnCapture_Click(object sender, EventArgs e)
        {

            //string text = listView1.SelectedItems[0].SubItems[0].ToString().Substring(18).Trim(new char[] { '}'});
            //textBox3.Text = text;



            //pictureBox1.BringToFront();
            //CameraCapture xx = new CameraCapture(pictureBox1, comboBox1);
            //btnCapture.Visible = false;
            //btnStart.Visible = true;



            // xx.CaptureImage(pictureBox2);

            //if (videoSource.IsRunning==false)
            //{
            //    videoSource.Start();
            //    btnCapture.Text = "Capture";
            //    return;
            //}
            //else
            //{
            //    //pictureBox1.Image = (Bitmap)pictureBox1.Image.Clone();
            //    //btnCapture.Text = "Start";
            //    //videoSource.Stop();
            //}

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //ListViewItem item = new ListViewItem(textBox1.Text);
            //item.SubItems.Add(textBox2.Text);
            //listView1.Items.Add(item);

            //ListViewItem listViewItem = new ListViewItem(new string[] { textBox1.Text, textBox2.Text});
            //listView1.Items.Add(listViewItem);










            //pictureBox2.BringToFront();
            //pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            //btnStart.Visible = false;
            //btnCapture.Visible = true;
            

        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            //Database.connection.Open();
            //SqlCommand cmd = new SqlCommand("Select Image from Labourer Where Labourer_ID ='1106155652235'",Database.connection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlCommandBuilder cbd = new SqlCommandBuilder(da);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //Database.connection.Close();
            //byte[] ap = (byte[])(ds.Tables[0].Rows[0]["Image"]);
            //MemoryStream ms = new MemoryStream(ap);
            //pictureBox2.Image = Image.FromStream(ms);
            //ms.Close();


            //videoSource.Stop();
            //pictureBox1.Image = null;
            //pictureBox1.Invalidate();
            //pictureBox2.Image = null;
            //pictureBox2.Invalidate();

        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            //videoSource.Stop();
        }


        private void BtnStop_Click(object sender, EventArgs e)
        {
            string qeury = "SELECT IMAGE FROM Labourer WHERE Labourer_ID='9507314444444'";
            using (Database.connection)
            {
                Database.connection.Open();
                SqlCommand com = new SqlCommand(qeury, Database.connection);
                SqlDataReader dataReader = com.ExecuteReader();
                if (dataReader.Read())
                {
                }

            }

        }

        private void ChartRequests_Click(object sender, EventArgs e)
        {

        }
    }
}
