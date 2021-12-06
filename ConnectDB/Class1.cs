using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class ConnectDB1
    {
        public string conn1;
        public string Host;
        public string Port;
        public string User;
        public string Database;
        public string Password;

        public string Initialization1()
        {
            Host = "caseum.ru";
            Port = "33333";
            User = "test_user";
            Database = "db_test";
            Password = "test_pass";
            string connecionString1;
            connecionString1 = $"server={Host};port={Port};user={User};database={Database};password={Password};";

            conn1 = connecionString1;
            return conn1;
        }
    }
}
