using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJob2019
{
    public class Job
    {
        public static List<Job> openJobList = new List<Job>();// a list to store all the open jobs before they are updated to the database
        
        private string  _jobRequestID, _labourerID, _agentID, _driverID,_category;
        private string _date;
        private decimal _cost;
        private bool _transportStatus, _completion;

        public string  JobRequestID { get { return _jobRequestID; } set { _jobRequestID = value; } }
        public string  LabourerID { get { return _labourerID; } set { _labourerID = value; } }
        public string AgentID { get { return _agentID; } set { _agentID = value; } }
        public string DriverID { get { return _driverID; } set { _driverID = value; } }
        public string  Category { get { return _category; } set { _category = value; } }
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
                
        }
        public decimal Cost { get { return _cost; } set { _cost = value; } }
        public bool TransportStatus { get { return _transportStatus; } set { _transportStatus = value; } }
        public bool CompletionStatus { get { return _completion; }set { _completion = value; } }

        public Job( string jobRequestId, string labourerID, string agentID, string driverID, string category, string date, decimal cost,bool transportStatus, bool completionStatus)
        {
            _jobRequestID = jobRequestId;_labourerID = labourerID;_agentID = agentID;_driverID = driverID;_category = category;_date = date;_cost = cost;_transportStatus = transportStatus;_completion = completionStatus;
        }

    }
}
