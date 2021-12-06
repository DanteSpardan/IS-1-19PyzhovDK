using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectDB;

namespace IS_1_19PyzhovDK
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB1 ConnDb1 = new ConnectDB1();
            //создаём экзепляр класса MySqlConnection и присваиваем ему значение которое возвращает метод Initialization
            MySqlConnection connDb = new MySqlConnection(ConnDb1.Initialization1());
            string fioStud = textBox1.Text;
            string datetime = textBox2.Text;
            string zapros = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fioStud}','{datetime}');";
            int x = 0;
            try
            {
                connDb.Open();

                MySqlCommand com1 = new MySqlCommand(zapros, connDb);
                x = com1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //здесь я поигрался с исключением, хотелось выводить проблему более подробно
                string message = ex.Message;
                MessageBox.Show(message);
                this.Close();
            }
            finally
            {
                connDb.Close();

                if (x != 0)
                {
                    MessageBox.Show("Успешно!");
                }
            }
        }
    }
}
