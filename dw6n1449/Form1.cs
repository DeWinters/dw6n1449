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

        Deck deck = new Deck();

        Player player1 = new Player();
        Card playerCard1 = new Card();
        Card playerCard2 = new Card();
        Card playerCard3 = new Card();
        Card playerCard4 = new Card();
        Card playerCard5 = new Card();       
        int playerScore;

        Player dealer = new Player();
        Card dealerCard1 = new Card();
        Card dealerCard2 = new Card();
        Card dealerCard3 = new Card();
        Card dealerCard4 = new Card();
        Card dealerCard5 = new Card();
        int dealerScore;

        int helpPage = 0;


        public Form1()
        {
            InitializeComponent();
         
            pnlHelp.Visible = false;
            pnlPlayerCard3.Visible = false;
            pnlPlayerCard4.Visible = false;
            pnlPlayerCard5.Visible = false;
            pnlDealerCard1.Visible = false;
            pnlDealerCard2.Visible = false;
            pnlDealerCard3.Visible = false;
            pnlDealerCard4.Visible = false;
            pnlDealerCard5.Visible = false;
            lblDealerScore.Visible = false;

            btnStay.Visible = false;
            btnHit.Visible = false;

            for(int x=0; x < 52; x++)                   /** test deck output **/
            {
                Console.WriteLine(deck.deckArray[x]);
            }

            player1.hit(deck.dealCard());
            player1.hit(deck.dealCard());
            populateTable();

            playerActions();
        }

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

    

        private void btnHit_Click(object sender, EventArgs e)
        {
            player1.hit(deck.dealCard());
            populateTable();
            playerActions();
        }

        private void playerActions()
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
            populateTable();
        }

        private void dealerActions()
        {
            
            populateTable();

            if (dealerScore == 21)
            {
                lblCondition.Text = "Hard luck, Dealer has BlackJack";
                populateTable();
            } else if (dealerScore > 21)
            {
                lblCondition.Text = "Dealer Busts! You Win!";

            } else if ( dealerScore < 17)
            { 
                dealer.hit(deck.dealCard());
                dealerActions();
                populateTable();                 
            }else
            {
                compareScores();
                populateTable();
            }
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnStay.Visible = false;
            lblCondition.Text = "";
            dealer.hit(deck.dealCard());
            dealer.hit(deck.dealCard());
            dealerActions();
            populateTable();
        }

        private void compareScores()
        {
            if (dealerScore == 21)
            {
                lblCondition.Text = "Dealer has Blackjack";
            }
            if (playerScore > dealerScore)
            {
                lblCondition.Text = "You Win!";
            }else if (dealerScore > playerScore)
            {
                lblCondition.Text = "Sorry, You Lose.";
            }else if (dealerScore == playerScore)
            {
                lblCondition.Text = "DRAW";
            }
            populateTable();
        }

        private void populateTable()
        {

            playerCard1 = populateCard(player1.getPlayerHand(0));
            lblId1.Text = player1.playerHand[0].ToString();
            lblFace1.Text = playerCard1.getFace();
            lblSuit1.Text = playerCard1.getSuit();
            lblValue1.Text = playerCard1.getVal().ToString();
            pnlPlayerCard1.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + playerCard1.getFace() + playerCard1.getSuit() + ".jpg");

            playerCard2 = populateCard(player1.getPlayerHand(1));
            lblId2.Text = player1.playerHand[1].ToString();
            lblFace2.Text = playerCard2.getFace();
            lblSuit2.Text = playerCard2.getSuit();
            lblValue2.Text = playerCard2.getVal().ToString();
            pnlPlayerCard2.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + playerCard2.getFace() + playerCard2.getSuit() + ".jpg");

            playerCard3 = populateCard(player1.getPlayerHand(2));
            lblId3.Text = player1.playerHand[2].ToString();
            lblFace3.Text = playerCard3.getFace();
            lblSuit3.Text = playerCard3.getSuit();
            lblValue3.Text = playerCard3.getVal().ToString();          
            if (playerCard3.getVal() != 0)
            {
                pnlPlayerCard3.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + playerCard3.getFace() + playerCard3.getSuit() + ".jpg");
                pnlPlayerCard3.Visible = true;
            }

            playerCard4 = populateCard(player1.getPlayerHand(3));
            lblId4.Text = player1.playerHand[3].ToString();
            lblFace4.Text = playerCard4.getFace();
            lblSuit4.Text = playerCard4.getSuit();
            lblValue4.Text = playerCard4.getVal().ToString();
            if (playerCard4.getVal() != 0)
            {
                pnlPlayerCard4.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + playerCard4.getFace() + playerCard4.getSuit() + ".jpg");
                pnlPlayerCard4.Visible = true;
            }

            playerCard5 = populateCard(player1.getPlayerHand(4));
            lblId5.Text = player1.playerHand[4].ToString();
            lblFace5.Text = playerCard5.getFace();
            lblSuit5.Text = playerCard5.getSuit();
            lblValue5.Text = playerCard5.getVal().ToString();
            if (playerCard5.getVal() != 0)
            {
                pnlPlayerCard5.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + playerCard5.getFace() + playerCard5.getSuit() + ".jpg");
                pnlPlayerCard5.Visible = true;
            }

            playerScore = playerCard1.getVal() + playerCard2.getVal() + playerCard3.getVal() +
                          playerCard4.getVal() + playerCard5.getVal();

            lblPlayerScore.Text = playerScore.ToString();


            dealerCard1 = populateCard(dealer.getPlayerHand(0));
            lblDealerCard1id.Text = dealer.playerHand[0].ToString();
            lblDealerCard1face.Text = dealerCard1.getFace();
            lblDealerCard1suit.Text = dealerCard1.getSuit();
            lblDealerCard1value.Text = dealerCard1.getVal().ToString();
           
            if (dealerCard1.getVal() != 0)
            {
                pnlDealerCard1.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + dealerCard1.getFace() + dealerCard1.getSuit() + ".jpg");
                pnlDealerCard1.Visible = true;
            }

            dealerCard2 = populateCard(dealer.getPlayerHand(1));
            lblDealerCard2id.Text = dealer.playerHand[1].ToString();
            lblDealerCard2face.Text = dealerCard2.getFace();
            lblDealerCard2suit.Text = dealerCard2.getSuit();
            lblDealerCard2value.Text = dealerCard2.getVal().ToString();          
            if (dealerCard2.getVal() != 0)
            {
                pnlDealerCard2.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + dealerCard2.getFace() + dealerCard2.getSuit() + ".jpg");
                pnlDealerCard2.Visible = true;
            }

            dealerCard3 = populateCard(dealer.getPlayerHand(2));
            lblDealerCard3id.Text = dealer.playerHand[2].ToString();
            lblDealerCard3face.Text = dealerCard3.getFace();
            lblDealerCard3suit.Text = dealerCard3.getSuit();
            lblDealerCard3value.Text = dealerCard3.getVal().ToString();           
            if (dealerCard3.getVal() != 0)
            {
                pnlDealerCard3.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + dealerCard3.getFace() + dealerCard3.getSuit() + ".jpg");
                pnlDealerCard3.Visible = true;
            }

            dealerCard4 = populateCard(dealer.getPlayerHand(3));
            lblDealerCard4id.Text = dealer.playerHand[3].ToString();
            lblDealerCard4face.Text = dealerCard4.getFace();
            lblDealerCard4suit.Text = dealerCard4.getSuit();
            lblDealerCard4value.Text = dealerCard4.getVal().ToString();          
            if (dealerCard4.getVal() != 0)
            {
                pnlDealerCard4.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + dealerCard4.getFace() + dealerCard4.getSuit() + ".jpg");
                pnlDealerCard4.Visible = true;
            }

            dealerCard5 = populateCard(dealer.getPlayerHand(4));
            lblDealerCard5id.Text = dealer.playerHand[4].ToString();
            lblDealerCard5face.Text = dealerCard5.getFace();
            lblDealerCard5suit.Text = dealerCard5.getSuit();
            lblDealerCard5value.Text = dealerCard5.getVal().ToString();           
            if (dealerCard5.getVal() != 0)
            {
                pnlDealerCard5.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\" + dealerCard5.getFace() + dealerCard5.getSuit() + ".jpg");
                pnlDealerCard5.Visible = true;
            }

            dealerScore = dealerCard1.getVal() + dealerCard2.getVal() + dealerCard3.getVal() +
                          dealerCard4.getVal() + dealerCard5.getVal();
           
            lblDealerScore.Text = dealerScore.ToString();
            if (dealerScore > 0) { lblDealerScore.Visible = true;
            } else { lblDealerScore.Visible = false; }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = true;
            pnlGame.Visible = false;
            helpPage = 0;
            pnlHelp.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\help" + helpPage + ".jpg");
        }

        private void btnHelpEnd_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = false;
            helpPage = 0;
            pnlGame.Visible = true;
            btnHelpNext.Visible = true;
        }

        private void btnHelpNext_Click(object sender, EventArgs e)
        {           
            helpPage++; // make some test for remaining help pages
            if (helpPage < 4)
            {
                pnlHelp.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\help" + helpPage + ".jpg");
            }else
            {
                btnHelpNext.Visible = false;
            }
        }
    }//form
}
