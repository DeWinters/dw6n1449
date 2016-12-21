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
            int score;
            String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM CARD WHERE id=" + card1;       /** Card1 Instantiation **/
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();

            Card playerCard1 = new Card();                              
            while (rdr.Read())
            {
                playerCard1.setVal(Convert.ToInt32(rdr["val"]));
                playerCard1.setFace(rdr["face"].ToString());
                playerCard1.setSuit(rdr["suit"].ToString());
            }
            conn.Close();

            cmd.CommandText = "SELECT * FROM CARD WHERE id=" + card2;       /** Card2 Instantiation **/
            conn.Open();
            rdr = cmd.ExecuteReader();
            Card playerCard2 = new Card();
            while (rdr.Read())
            {
                playerCard2.setVal(Convert.ToInt32(rdr["val"]));
                playerCard2.setFace(rdr["face"].ToString());
                playerCard2.setSuit(rdr["suit"].ToString());
            }

            score = playerCard1.getVal() + playerCard2.getVal();            /** PlayerScore **/

            lblValue1.Text = playerCard1.getVal().ToString();               /** GUI outputs **/
            lblFace1.Text = playerCard1.getFace();
            lblSuit1.Text = playerCard1.getSuit();

            lblValue2.Text = playerCard2.getVal().ToString();              
            lblFace2.Text = playerCard2.getFace();
            lblSuit2.Text = playerCard2.getSuit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
