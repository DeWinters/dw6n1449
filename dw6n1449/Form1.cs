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
        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);
        // MySqlDataAdapter adptr = new MySqlDataAdapter

        Player player1 = new Player();
        Card playerCard1 = new Card();
        Card playerCard2 = new Card();
        Card playerCard3 = new Card();
        Card playerCard4 = new Card();
        Card playerCard5 = new Card();
        Deck deck = new Deck();
        int playerScore;

        public Form1()
        {
            InitializeComponent();


            pnlCard3.Visible = false;
            pnlCard4.Visible = false;
            pnlCard5.Visible = false;
            btnStay.Visible = false;
            btnHit.Visible = false;

            for(int x=0; x < 52; x++)                   /** test deck output **/
            {
                Console.WriteLine(deck.deckArray[x]);
            }

            player1.hit(deck.dealCard());
            player1.hit(deck.dealCard());

            populateTable();

            testScore();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void junk_Click(object sender, EventArgs e) {}

        private Card populateCard(int cardId)
        {
            Card card = new Card();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM CARD where id=" + cardId;
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                card.setVal(Convert.ToInt32(rdr["val"]));
                card.setFace(rdr["face"].ToString());
                card.setSuit(rdr["suit"].ToString());
            }
            conn.Close();
            return card;
        }

        private void populateTable()
        {
            lblId1.Text = player1.playerHand[0].ToString();
            playerCard1 = populateCard(player1.playerHand[0]);
            lblFace1.Text = playerCard1.getFace();
            lblSuit1.Text = playerCard1.getSuit();
            lblValue1.Text = playerCard1.getVal().ToString();

            lblId2.Text = player1.playerHand[1].ToString();
            playerCard2 = populateCard(player1.playerHand[1]);
            lblFace2.Text = playerCard2.getFace();
            lblSuit2.Text = playerCard2.getSuit();
            lblValue2.Text = playerCard2.getVal().ToString();

            
            lblId3.Text = player1.playerHand[2].ToString();
            playerCard3 = populateCard(player1.playerHand[2]);
            lblFace3.Text = playerCard3.getFace();
            lblFace3.Text = playerCard3.getSuit();
            lblValue3.Text = playerCard3.getVal().ToString();
            if (playerCard3.getVal() != 0) { pnlCard3.Visible = true; }

            lblId4.Text = player1.playerHand[3].ToString();
            playerCard4 = populateCard(player1.playerHand[3]);
            lblFace4.Text = playerCard4.getFace();
            lblFace4.Text = playerCard4.getSuit();
            lblValue4.Text = playerCard4.getVal().ToString();
            if (playerCard4.getVal() != 0) { pnlCard4.Visible = true; }
           
            lblId5.Text = player1.playerHand[4].ToString();
            playerCard5 = populateCard(player1.playerHand[4]);
            lblFace5.Text = playerCard5.getFace();
            lblFace5.Text = playerCard5.getSuit();
            lblValue5.Text = playerCard5.getVal().ToString();
            if (playerCard5.getVal() != 0) { pnlCard5.Visible = true; }

            playerScore = playerCard1.getVal() + playerCard2.getVal() + playerCard3.getVal()
                        + playerCard4.getVal() + playerCard5.getVal();

            lblPlayerScore.Text = playerScore.ToString();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            player1.hit(deck.dealCard());
            populateTable();
            testScore();
        }

        private void testScore()
        {
            if (playerScore > 21)                                                  /** hand status **/
            {                                                               // bust actions
                lblCondition.Text = "BUST! (you have gone over 21)";
                btnHit.Visible = false;
                btnStay.Visible = false;
            }
            else if (playerScore == 21)
            {                                                               // win actions
                lblCondition.Text = "BLACKJACK! Congratulations!";
                btnHit.Visible = false;
                btnStay.Visible = false;
            }
            else
            {                                                               // draw? actions
                lblCondition.Text = "Would you like to hit or stay?";
                btnHit.Visible = true;
                btnStay.Visible = true;
            }
        }
    }//form
}
