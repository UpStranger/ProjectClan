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
    public partial class meincampf : Form
    {
        public meincampf()
        {
            InitializeComponent();
            MySqlConnection myConnection = new MySqlConnection(@static.sValue);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            members m = new members();
            m.Show();
            Hide();
        }
    }
}
