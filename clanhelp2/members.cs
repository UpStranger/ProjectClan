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
    public partial class members : Form
    {
        public members()
        {
            InitializeComponent();
            
        }

        private void members_Load(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(@static.sValue);
            myConnection.Open();
            string mysql = "select nickname from Members x, Clans y where x.Clan_id=y.Clan_id";

            MySqlCommand com = new MySqlCommand(mysql, myConnection);

            string nick = com.ExecuteScalar().ToString();

            MessageBox.Show(nick, "sad");
        }
    }
}
