using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19PyzhovDK
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
    public class Sqlcon
    {
        public string conn;
        public string Host;
        public string Port;
        public string User;
        public string Database;
        public string Password;
        public string Initialization()
        {
            Host = "caseum.ru";
            Port = "33333";
            User = "test_user";
            Database = "db_test";
            Password = "test_pass";
            string connecionString;
            connecionString = $"server={Host};port={Port};user={User};database={Database};password={Password};";

            conn = connecionString;
            return conn;
        }
    }
}