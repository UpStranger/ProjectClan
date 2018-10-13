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

namespace clanhelp2
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string log = login.Text;
            string password = pass.Text;
            string myConnectionString = "Database=ClanHelper;Data Source=192.168.0.100;User Id= " + log+";Password="+password+";SslMode=none";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            try
            {
                @static.sValue = myConnectionString;
                myConnection.Open(); // Открываем соединение
                                     // --- код запроса и т.п. --- //*/
                meincampf a = new meincampf();
                Hide();
                a.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
