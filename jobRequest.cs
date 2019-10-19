using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJob2019
{
    public class JobRequest
    {
        private string  _date, _time, _specification, _location,_category;private bool _transport; private decimal _cost; int _jobID, _clientID;
        public int JobId{get { return _jobID; }set{value = _jobID;}}
        public int ClientID { get {return _clientID; } set { value=_clientID; } }
        public string  Date { get {return _date; } set {value=_date; } }
        public string Time { get { return _time; } set { value = _time; } }
        public string Speciifaction { get { return _specification; } set { value = _specification; } }
        public string  Location { get { return _location; } set { value = _location; } }
        public string  MyProperty { get; set; }
        public decimal Cost { get { return _cost; } set { value = _cost; } }
        public bool Transport { get { return _transport; } set { value = _transport; } }
        public string Category { get { return _category; } set { value = _category; } }
        public JobRequest(int jobID,int clientID,string date,string time,string category,string specification,string location,bool transport,decimal cost)
        {
            _jobID = jobID;
            _clientID = clientID;
            _date = date;
            _time = time;
            _category = category;
            _specification = specification;
            _location = location;
            _transport = transport;
            _cost = cost;
        }
        
    }
}
