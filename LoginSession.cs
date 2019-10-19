using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJob2019
{
    public static class LoginSession
    {//Instance to store the login session 
        public static string ID { get; set; }
        public static string UserName { get; set; }
        public static bool AdminRights { get; set; }//This should remain the same through out the session
        public static bool SessionAdminRights { get; set; }//Used to toggle admin rights

        static LoginSession()
        {
            ID = "No set ID";
            UserName = "No set Username";
            AdminRights = false;
            if (AdminRights)
            {
                SessionAdminRights = true;
            }
            else
            {
                SessionAdminRights = false;
            }
        }
    }
}
