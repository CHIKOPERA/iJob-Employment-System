using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmAssignJob : Form
    {
        public frmAssignJob()
        {
            InitializeComponent();
        }
        string _jobRequestID, _labourerID, _agentID, _driverID, _date, _category;
        // this listy will store all the labourers ids that are selected
        List<string> _selectedLabourersList = new List<string>();
        decimal _cost;
        bool _isTransportProvided;
        int _numOFLab = 0;
        private  void FrmAssignJob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDrivers1.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter1.Fill(this.dsDrivers1.Driver);

            try
            {
                 this.driverTableAdapter1.Fill(this.dsDrivers1.Driver);        
                 this.labourerTableAdapter.Fill(this.dsLabourerr.Labourer);
                string query = "Select * from [JobRequest] where [Job_Request_ID]= " + frmMain._selectedID.ToString();
                Database.connection.Close();
                if (Database.connection.State == ConnectionState.Closed)
                {
                    Database.connection.Open(); 
                }
                SqlCommand command = new SqlCommand(query, Database.connection);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {//Side panel details
                   // lblName.Text = (dataReader["Client_ID"].ToString());
                    lblJobNumber.Text = dataReader["Job_Request_ID"].ToString();
                    _jobRequestID = dataReader["Job_Request_ID"].ToString();
                    lblCategory.Text = dataReader["Category"].ToString();
                    lblSpecification.Text = dataReader["Job_Specification"].ToString();
                    lblDate.Text = dataReader["Date"].ToString();
                    _date = dataReader["Date"].ToString();
                    lblCost.Text = dataReader["Cost"].ToString();
                    _category= dataReader["Category"].ToString();
                    _cost =Convert.ToDecimal(dataReader["Cost"].ToString());
                    _isTransportProvided = Convert.ToBoolean(dataReader["Transport_Status"].ToString());
                    _numOFLab = int.Parse(dataReader["Num_Of_Labourers"].ToString());
                    // location = dataReader["Location"].ToString();
                    
                }
                if (Database.connection.State == ConnectionState.Open)
                {
                    Database.connection.Close();
                }
              
                if (_isTransportProvided==false)
                {
                    lblDriver.Visible = false;comboDriver.Visible = false;
                }
                else
                {
                    lblDriver.Visible = true; comboDriver.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSearchLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSearchFname_TextChanged(object sender, EventArgs e)
        {
            DataView dv;
            dv = txtSearchID.Text != "" ? new DataView(dsLabourerr.Tables[0], $"Labourer_ID LIKE '{txtSearchID.Text}%'", "Labourer_ID Desc", DataViewRowState.CurrentRows)
                                           : new DataView(dsLabourerr.Tables[0]);
            dgvLabourers.DataSource = dv;
        }

        private void btnAssign2_Click(object sender, EventArgs e)
        {
            Job jobInstance = new Job(_jobRequestID, _labourerID, _agentID, _driverID, _category, _date, _cost, _isTransportProvided, false);
            Job.openJobList.Add(jobInstance);//Add the new job to the list of jobs

        }

        private void BtnAddLab_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_selectedLabourersList.Contains(dgvLabourers.SelectedCells[0].Value.ToString()))
                {
                    //Add the labourer to the list
                    _selectedLabourersList.Add(dgvLabourers.SelectedCells[0].Value.ToString());
                    //Add lab to the liist view
                    ListViewItem listViewItem = new ListViewItem(dgvLabourers.SelectedCells[0].Value.ToString());
                    listViewItem.SubItems.Add(dgvLabourers.SelectedCells[1].Value.ToString() + " " + dgvLabourers.SelectedCells[2].Value.ToString());
                    listViewSelectedLabs.Items.Add(listViewItem);
                    //reduce the number of laboueres
                    _numOFLab--;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TimerLab_Tick(object sender, EventArgs e)
        {//Constantly display the remaining labourers
            lblNumOfLab.Text = _numOFLab.ToString();
            if (_numOFLab<1)
            {
                btnAddLab.Enabled = false;
                btnAddLab.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                btnAddLab.Enabled = true;
                btnAddLab.BackColor = Color.FromArgb(3, 191, 3);
               
            }
            if (listViewSelectedLabs.Items.Count > 0)
            {
                btnRemove.Enabled = true;
                btnRemove.BackColor = Color.FromArgb(3, 191, 3);
            }
            else
            {
                btnRemove.Enabled = false;
                btnRemove.BackColor = Color.FromArgb(240, 240, 240);

            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //Remove the selected item
            if ( listViewSelectedLabs.Items.Count>0 && listViewSelectedLabs.SelectedItems.Count>0)
            {
                try
                {
                   _selectedLabourersList.Remove(listViewSelectedLabs.SelectedItems[0].SubItems[0].ToString().Substring(18).Trim(new char[] { '}' }));//18 => ListView.SubSstring is retunred , and has 18 chars thus they must be removed
                    listViewSelectedLabs.Items.Remove(listViewSelectedLabs.SelectedItems[0]);
                    _numOFLab++;
                    listViewSelectedLabs.Refresh();
                }
                catch (Exception ec)
                {

                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void DgvLabourers_SelectionChanged(object sender, EventArgs e)
        {
            //displaying the labourer details
            try
            {
                string query = "Select * from Labourer where [Labourer_ID] = " + dgvLabourers.SelectedCells[0].Value.ToString();
                SqlCommand command = new SqlCommand(query, Database.connection);
                SqlDataReader dataReader;
                if (Database.connection.State!=ConnectionState.Open)
                {
                    Database.connection.Close();
                    Database.connection.Open(); 
                }
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    lblLName.Text = dataReader["Name"].ToString() + " " + dataReader["Surname"].ToString();
                    lblLAge.Text = (DateTime.Now.Year - Convert.ToDateTime(dataReader["Date_Of_Birth"].ToString()).Year).ToString() + " year old";
                    lblLangauge.Text = "Fluent in " + dataReader["Language"].ToString();
                    lblLGender.Text = dataReader["Gender"].ToString();
                    lblLAddInfo.Text = dataReader["Additional_Information"].ToString();
                    lblLRating.Text = "rated " + dataReader["Rating"].ToString() + "%";
                   
                }
                Database.connection.Close();
                //Add the labourer image
                CustomMethods.GetImage(dgvLabourers.SelectedCells[0].Value.ToString(), picLabourer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private  void BtnAddLabourer_Click(object sender, EventArgs e)
        {
            Form frmRegLab = new frmRegLab();
            frmRegLab.ShowDialog();
        }

        
        private async void BtnAssign_Click(object sender, EventArgs e)
        {
            if (_numOFLab==0)
            {
                Placement placement;
                string[] IDs = _selectedLabourersList.ToArray();

                foreach (string ID in _selectedLabourersList)
                {//For each of the laboueres that have been selected , the code should add each of item to the database
                    placement = new Placement();
                                  
                    try
                    {
                        placement.AgentID = LoginSession.ID;                        
                        placement.Completion = false;
                        placement.Date = DateTime.Now.ToString("yyyy/mm/dd");
                        placement.JobRequestID = int.Parse(frmMain._selectedID.ToString());
                        placement.LabourerID = ID;
                        
                        string query;
                        if (comboDriver.Visible == true)
                        {
                            
                            placement.DriverID = comboDriver.SelectedValue.ToString();
                            query = ($"INSERT INTO Placement (Job_Request_ID,Labourer_ID,Agent_ID,Driver_ID,Date,[Completion_Status]) VALUES('{placement.JobRequestID}','{placement.LabourerID}','{placement.AgentID}','{placement.DriverID}','{placement.Date}','false')");
                        }
                        else
                        {
                            placement.DriverID = "0000000000000";
                            query = ($"INSERT INTO Placement (Job_Request_ID,Labourer_ID,Agent_ID,Date,[Completion_Status]) VALUES('{placement.JobRequestID}','{placement.LabourerID}','{placement.AgentID}','{placement.DriverID}','false')");

                        }
                        if (Database.connection.State==ConnectionState.Closed)
                        {
                           await  Database.connection.OpenAsync();
                        }
                        //have another query for when there is no transpirt
                        try
                        {
                            if (Database.connection.State == ConnectionState.Open)
                            {
                                Database.connection.Close();
                            }
                            if (Database.connection.State == ConnectionState.Closed)
                            {
                                await Database.connection.OpenAsync();
                            }
                            SqlCommand insertCommand = new SqlCommand(query, Database.connection);
                            SqlCommand UpdateJobCommand = new SqlCommand("Update [JobRequest] set [Assigned_Status]='True' where [Job_Request_ID]=" + _jobRequestID, Database.connection);
                            _ = await Task.Run(() => insertCommand.ExecuteNonQuery());
                            _ = await Task.Run(() => UpdateJobCommand.ExecuteNonQuery());
                            if (Database.connection.State == ConnectionState.Open)
                            {
                                Database.connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            if (Database.connection.State == ConnectionState.Open)
                            {
                                Database.connection.Close();
                            }
                            MessageBox.Show(ex.Message);
                        }
                     

                    }
                    catch (Exception )
                    {
                        if (Database.connection.State == ConnectionState.Open)
                        {
                             Database.connection.Close();
                        }
                        throw;
                        // MessageBox.Show("Error reading data from the database", "Panel Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Database.connection.State != ConnectionState.Open)
                {
                    Database.connection.Close();
                    Database.connection.Open();

                }
                //Getting the PlacementID
                SqlCommand getPlacementID = new SqlCommand("Select Count(*) From Placement", Database.connection);
                int placementID=((int)getPlacementID.ExecuteScalar())+1;
                SqlCommand insertPayment = new SqlCommand($"Insert Into Payment ([Placement ID],Amount,Date) VALUE ('{placementID}','{_cost}','{_date}')",Database.connection);


                if (Database.connection.State == ConnectionState.Open)
                {
                    Database.connection.Close();
                }
                

                if (DialogResult.OK == MessageBox.Show("The job has been assigned", "Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                      Close();
                }
            }
            else
            {//Remove messagebox
                MessageBox.Show("More Labourers need to be added");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Database.connection.Close();
            Close();        
        }
       
        private string GetCurrentDateString()
        {
            string date = DateTime.Now.ToShortDateString();
            string[] datevalues = date.Split('/');
            StringBuilder outputdate = new StringBuilder($"{datevalues[2].ToString()}");
            if (datevalues[1].ToString().Length > 1)
            {
                outputdate.Append($"{datevalues[1].ToString()}");
            }
            else
            {
                outputdate.Append($"0{datevalues[1].ToString()}");
            }
            if (datevalues[0].ToString().Length>1)
            {
                outputdate.Append($"{datevalues[0].ToString()}");
            }
            else
            {
                outputdate.Append($"0{datevalues[0].ToString()}");
            }
            return outputdate.ToString();
        }

        private void BtnAddLabourer_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToShortDateString()); MessageBox.Show(GetCurrentDateString());
            //Form form = new frmRegLab();
            //form.ShowDialog();
        }
    }
}

#region Previoud PlacemntCode

// try
//                    {











//                        _jobRequestID = frmMain._selectedID.ToString();
//                        //_labourerID = comboLabourer.SelectedValue.ToString();
//                        //_labourerID = dgvLabourers.SelectedCells[0].Value.ToString(); , got replaced by the list of IDS
//                        _agentID = LoginSession.ID;
//                        _driverID = comboDriver.SelectedValue.ToString();
//                        _date = DateTime.Now.ToShortDateString();
//                        //have another query for when there is no transpirt
//                        string query = ($"INSERT INTO Placement (Job_Request_ID,Labourer_ID,Agent_ID,Driver_ID,Date,[Completion]) VALUES('{_jobRequestID}','{ID}','{_agentID}','{_driverID}','{_date}','false')");
//SqlCommand insertCommand = new SqlCommand(query, Database.connection);
//SqlCommand delJobCommand = new SqlCommand("Update [JobRequest] set [Assigned_Status]='True' where [Job_Request_ID]=" + _jobRequestID, Database.connection);
//_ = await Task.Run(() => insertCommand.ExecuteNonQuery());
//_ = await Task.Run(()=>delJobCommand.ExecuteNonQuery());
//                        if (DialogResult.OK == MessageBox.Show("The job has been assigned", "Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information))
//                        {
//                            Close();
//                        }

//                    }
//                    catch (Exception)
//                    {
//                        throw;
//                       // MessageBox.Show("Error reading data from the database", "Panel Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

//                    } 
#endregion




    /////////////////////////////////////////
//    ///                    try
//                    {
//                        string url;
//HttpClient client = new HttpClient();
//                       if (_isTransportProvided==true)
//                        {
//                            url = $"http://ijobapp.azurewebsites.net/api/Placement?jobRequestID={placement.JobRequestID}&LabID={placement.LabourerID}&AgentID={placement.AgentID}&DriverID={placement.DriverID}&Date={placement.Date}&Completion={placement.Completion}";

//                        }
//                        else
//                        {
//                            url = $"http://ijobapp.azurewebsites.net/api/Placement?jobRequestID={placement.JobRequestID}&LabID={placement.LabourerID}&AgentID={placement.AgentID}&Date={placement.Date}&Completion={placement.Completion}";
//                        }
//                        var uri = new Uri(url);
//client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
//                        HttpResponseMessage response;
//var json = JsonConvert.SerializeObject(placement);
//var content = new StringContent(json, Encoding.UTF8, "application/json");
//response = await client.PostAsync(uri, content);
//                        if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
//                        {
                        
                       
//                        }
//                        else
//                        {
//                            MessageBox.Show("Not done, the placement could not be done. Status Code: "+ response.StatusCode.ToString());
//                        }

//                    }
//                    catch (Exception ex)
//                    {

//                        MessageBox.Show(ex.Message);
//                    }
