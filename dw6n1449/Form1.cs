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
        Game game = new Game();        

        static string imgResPrefix = "C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\";
        static string helpResPrefix = "C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\help";

        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);

        Deck deck = new Deck();

        Player player1 = new Player();

        Player dealer = new Player();
        
        int helpPage = 0;

        public Form1()
        {
            //game.callLoginPage();
            InitializeComponent();

            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
            //callLogin();
            /**
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Show();
            this.BringToFront();
            **/

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
            if (player1.getHandScore() > 21)                                                  /** hand status **/
            {                                                               // bust actions
                lblCondition.Text = "BUST! (you have gone over 21)";
                btnHit.Visible = false;
                btnStay.Visible = false;
            }
            else if (player1.getHandScore() == 21)
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

            if (dealer.getHandScore() == 21)
            {
                lblCondition.Text = "Hard luck, Dealer has BlackJack";
                populateTable();
            } else if (dealer.getHandScore() > 21)
            {
                lblCondition.Text = "Dealer Busts! You Win!";

            } else if ( dealer.getHandScore() < 17)
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
            if (dealer.getHandScore() == 21)
            {
                lblCondition.Text = "Dealer has Blackjack";
            }
            if (player1.getHandScore() > dealer.getHandScore())
            {
                lblCondition.Text = "You Win!";
            }else if (dealer.getHandScore() > player1.getHandScore())
            {
                lblCondition.Text = "Sorry, You Lose.";
            }else if (dealer.getHandScore() == player1.getHandScore())
            {
                lblCondition.Text = "DRAW";
            }
            populateTable();
        }

        private void populateTable()
        {
            player1.setCard1(populateCard(player1.getPlayerHand(0)));
            lblId1.Text = player1.getPlayerHand(0).ToString();
            lblFace1.Text = player1.getCard1().getFace();
            lblSuit1.Text = player1.getCard1().getSuit();
            lblValue1.Text = player1.getCard1().getVal().ToString();
            pnlPlayerCard1.BackgroundImage = Image.FromFile(imgResPrefix + player1.getCard1().getFace() + 
                                                                    player1.getCard1().getSuit() + ".jpg");

            player1.setCard2(populateCard(player1.getPlayerHand(1)));
            lblId2.Text = player1.getPlayerHand(1).ToString();
            lblFace2.Text = player1.getCard2().getFace();
            lblSuit2.Text = player1.getCard2().getSuit();
            lblValue2.Text = player1.getCard2().getVal().ToString();
            pnlPlayerCard2.BackgroundImage = Image.FromFile(imgResPrefix + player1.getCard2().getFace() + 
                                                                    player1.getCard2().getSuit() + ".jpg");

            player1.setCard3(populateCard(player1.getPlayerHand(2)));
            lblId3.Text = player1.getPlayerHand(2).ToString();
            lblFace3.Text = player1.getCard3().getFace();
            lblSuit3.Text = player1.getCard3().getSuit();
            lblValue3.Text = player1.getCard3().getVal().ToString();          
            if (player1.getCard3().getVal() != 0)
            {
                pnlPlayerCard3.BackgroundImage = Image.FromFile(imgResPrefix + player1.getCard3().getFace() + 
                                                                    player1.getCard3().getSuit() + ".jpg");
                pnlPlayerCard3.Visible = true;
            }

            player1.setCard4(populateCard(player1.getPlayerHand(3)));
            lblId4.Text = player1.getPlayerHand(3).ToString();
            lblFace4.Text = player1.getCard4().getFace();
            lblSuit4.Text = player1.getCard4().getSuit();
            lblValue4.Text = player1.getCard4().getVal().ToString();
            if (player1.getCard4().getVal() != 0)
            {
                pnlPlayerCard4.BackgroundImage = Image.FromFile(imgResPrefix + player1.getCard4().getFace() + 
                                                                    player1.getCard4().getSuit() + ".jpg");
                pnlPlayerCard4.Visible = true;
            }

            player1.setCard5(populateCard(player1.getPlayerHand(4)));
            lblId5.Text = player1.getPlayerHand(4).ToString();
            lblFace5.Text = player1.getCard5().getFace();
            lblSuit5.Text = player1.getCard5().getSuit();
            lblValue5.Text = player1.getCard5().getVal().ToString();
            if (player1.getCard5().getVal() != 0)
            {
                pnlPlayerCard5.BackgroundImage = Image.FromFile(imgResPrefix + player1.getCard5().getFace() + 
                                                                    player1.getCard5().getSuit() + ".jpg");
                pnlPlayerCard5.Visible = true;
            }

            player1.setHandScore();
            lblPlayerScore.Text = player1.getHandScore().ToString();


            dealer.setCard1(populateCard(dealer.getPlayerHand(0)));
            lblDealerCard1id.Text = dealer.getPlayerHand(0).ToString();
            lblDealerCard1face.Text = dealer.getCard1().getFace();
            lblDealerCard1suit.Text = dealer.getCard1().getSuit();
            lblDealerCard1value.Text = dealer.getCard1().getVal().ToString();
           
            if (dealer.getCard1().getVal() != 0)
            {
                pnlDealerCard1.BackgroundImage = Image.FromFile(imgResPrefix + dealer.getCard1().getFace() + dealer.getCard1().getSuit() + ".jpg");
                pnlDealerCard1.Visible = true;
            }

            dealer.setCard2(populateCard(dealer.getPlayerHand(1)));
            lblDealerCard2id.Text = dealer.getPlayerHand(1).ToString();
            lblDealerCard2face.Text = dealer.getCard2().getFace();
            lblDealerCard2suit.Text = dealer.getCard2().getSuit();
            lblDealerCard2value.Text = dealer.getCard2().getVal().ToString();          
            if (dealer.getCard2().getVal() != 0)
            {
                pnlDealerCard2.BackgroundImage = Image.FromFile(imgResPrefix + dealer.getCard2().getFace() + dealer.getCard2().getSuit() + ".jpg");
                pnlDealerCard2.Visible = true;
            }

            dealer.setCard3(populateCard(dealer.getPlayerHand(2)));
            lblDealerCard3id.Text = dealer.getPlayerHand(2).ToString();
            lblDealerCard3face.Text = dealer.getCard3().getFace();
            lblDealerCard3suit.Text = dealer.getCard3().getSuit();
            lblDealerCard3value.Text = dealer.getCard3().getVal().ToString();           
            if (dealer.getCard3().getVal() != 0)
            {
                pnlDealerCard3.BackgroundImage = Image.FromFile(imgResPrefix + dealer.getCard3().getFace() + dealer.getCard3().getSuit() + ".jpg");
                pnlDealerCard3.Visible = true;
            }

            dealer.setCard4(populateCard(dealer.getPlayerHand(3)));
            lblDealerCard4id.Text = dealer.getPlayerHand(3).ToString();
            lblDealerCard4face.Text = dealer.getCard4().getFace();
            lblDealerCard4suit.Text = dealer.getCard4().getSuit();
            lblDealerCard4value.Text = dealer.getCard4().getVal().ToString();          
            if (dealer.getCard4().getVal() != 0)
            {
                pnlDealerCard4.BackgroundImage = Image.FromFile(imgResPrefix + dealer.getCard4().getFace() + dealer.getCard4().getSuit() + ".jpg");
                pnlDealerCard4.Visible = true;
            }

            dealer.setCard5(populateCard(dealer.getPlayerHand(4)));
            lblDealerCard5id.Text = dealer.getPlayerHand(4).ToString();
            lblDealerCard5face.Text = dealer.getCard5().getFace();
            lblDealerCard5suit.Text = dealer.getCard5().getSuit();
            lblDealerCard5value.Text = dealer.getCard5().getVal().ToString();           
            if (dealer.getCard5().getVal() != 0)
            {
                pnlDealerCard5.BackgroundImage = Image.FromFile(imgResPrefix + dealer.getCard5().getFace() + dealer.getCard5().getSuit() + ".jpg");
                pnlDealerCard5.Visible = true;
            }

            dealer.setHandScore();
            lblDealerScore.Text = dealer.getHandScore().ToString();
            if (dealer.getHandScore() > 0)
            {
                lblDealerScore.Visible = true;
            } else
            {
                lblDealerScore.Visible = false;
            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlHelp.Visible = true;
            pnlGame.Visible = false;
            helpPage = 0;
            pnlHelp.BackgroundImage = Image.FromFile(helpResPrefix + helpPage + ".jpg");
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
                pnlHelp.BackgroundImage = Image.FromFile(helpResPrefix + helpPage + ".jpg");
            }else
            {
                btnHelpNext.Visible = false;
            }
        }

        private void callLogin()
        {
            this.Visible = false;
            this.Hide();
            this.SendToBack();
            Form2 form2 = new Form2();
            form2.Show();
            form2.BringToFront();
        }
    }//form
}
