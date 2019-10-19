using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJob2019
{
   public class Database
    {
        public static string serverLoginName="ijob";
        public static string serverLoginPass = "Tanya@dodger12";
        public static string serverName = "ijobsrvr.database.windows.net";
        public static string databaseName = "iJobDatabase";
        static string  your_username = "ijob", your_password = "Tanya@dodger12";
        //theres an already open datat reader ==> MultipleActiveResultSets=True  from MultipleActiveResultSets=False
        public static SqlConnection connection = new SqlConnection($"Server=tcp:ijobsrvr.database.windows.net,1433;Initial Catalog=iJobDatabase;  Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
      public static int selectedJobId = 0;
     
    }
  
}
