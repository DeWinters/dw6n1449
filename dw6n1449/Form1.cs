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

            int card1 = 5;
            int card2 = 2;
            String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM CARD WHERE id=" + card1;
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblValue1.Text = rdr["val"].ToString();
                lblFace1.Text = rdr["face"].ToString();
                lblSuit1.Text = rdr["suit"].ToString();
            }
            conn.Close();


            cmd.CommandText = "SELECT * FROM CARD WHERE id=" + card2;
            conn.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblValue2.Text = rdr["val"].ToString();
                lblFace2.Text = rdr["face"].ToString();
                lblSuit2.Text = rdr["suit"].ToString();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
