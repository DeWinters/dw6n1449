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

namespace dw6n1449
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int card = 1;
            String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM CARD WHERE id=" + card;
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblOutput.Text = rdr["val"].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
