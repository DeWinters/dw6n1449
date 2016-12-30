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
        static string imgResPrefix = "C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\";
        static string helpResPrefix = "C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\help";
        public static int playerId;
        Game game = new Game();
        int helpPageIndex = 0;

        Form2 form2 = new Form2();     

        public Form1()
        {

            InitializeComponent();

            callForm2();
            this.SendToBack();
           // this.WindowState = FormWindowState.Minimized;
            /**this.WindowState = FormWindowState.Minimized; this.ShowInTaskbar = false; callLogin(); this.WindowState = FormWindowState.Normal; this.ShowInTaskbar = true;            this.Visible = true;            this.Show();            this.BringToFront(); **/
            //for (int x = 0; x < 52; x++) { Console.WriteLine(game.getDeck().deckArray[x]); } /** test deck output **/
            pnlHelp.Visible = false;           
            playGame();
            populateTable();
        }
         
        private void populateTable()                                            // Needs GUI enhancement 
        {
            game.getPlayer1().setId(playerId);
            game.getPlayer1().setName();
            lblPlayer1Name.Text = game.getPlayer1().getName();

            lblCondition.Text = game.getFeedback();

            if(game.getPlayerTurn() == true)
            {
                btnHit.Visible = true;
                btnStay.Visible = true;
            }else
            {
                btnHit.Visible = false;
                btnStay.Visible = false;
            }

            game.getPlayer1().setCard1(game.populateCard(game.getPlayer1().getPlayerHand(0)));
            lblId1.Text = game.getPlayer1().getPlayerHand(0).ToString();
            lblFace1.Text = game.getPlayer1().getCard1().getFace();
            lblSuit1.Text = game.getPlayer1().getCard1().getSuit();
            lblValue1.Text = game.getPlayer1().getCard1().getVal().ToString();
            pnlPlayerCard1.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard1().getFace() + 
                                                                    game.getPlayer1().getCard1().getSuit() + ".jpg");

            game.getPlayer1().setCard2(game.populateCard(game.getPlayer1().getPlayerHand(1)));
            lblId2.Text = game.getPlayer1().getPlayerHand(1).ToString();
            lblFace2.Text = game.getPlayer1().getCard2().getFace();
            lblSuit2.Text = game.getPlayer1().getCard2().getSuit();
            lblValue2.Text = game.getPlayer1().getCard2().getVal().ToString();
            pnlPlayerCard2.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard2().getFace() +
                                                                    game.getPlayer1().getCard2().getSuit() + ".jpg");

            game.getPlayer1().setCard3(game.populateCard(game.getPlayer1().getPlayerHand(2)));
            lblId3.Text = game.getPlayer1().getPlayerHand(2).ToString();
            lblFace3.Text = game.getPlayer1().getCard3().getFace();
            lblSuit3.Text = game.getPlayer1().getCard3().getSuit();
            lblValue3.Text = game.getPlayer1().getCard3().getVal().ToString();          
            if (game.getPlayer1().getCard3().getVal() != 0)
            {
                pnlPlayerCard3.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard3().getFace() +
                                                                    game.getPlayer1().getCard3().getSuit() + ".jpg");
                pnlPlayerCard3.Visible = true;
            }
            else { pnlPlayerCard3.Visible = false; }

            game.getPlayer1().setCard4(game.populateCard(game.getPlayer1().getPlayerHand(3)));
            lblId4.Text = game.getPlayer1().getPlayerHand(3).ToString();
            lblFace4.Text = game.getPlayer1().getCard4().getFace();
            lblSuit4.Text = game.getPlayer1().getCard4().getSuit();
            lblValue4.Text = game.getPlayer1().getCard4().getVal().ToString();
            if (game.getPlayer1().getCard4().getVal() != 0)
            {
                pnlPlayerCard4.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard4().getFace() +
                                                                    game.getPlayer1().getCard4().getSuit() + ".jpg");
                pnlPlayerCard4.Visible = true;
            }
            else { pnlPlayerCard4.Visible = false; }

            game.getPlayer1().setCard5(game.populateCard(game.getPlayer1().getPlayerHand(4)));
            lblId5.Text = game.getPlayer1().getPlayerHand(4).ToString();
            lblFace5.Text = game.getPlayer1().getCard5().getFace();
            lblSuit5.Text = game.getPlayer1().getCard5().getSuit();
            lblValue5.Text = game.getPlayer1().getCard5().getVal().ToString();
            if (game.getPlayer1().getCard5().getVal() != 0)
            {
                pnlPlayerCard5.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard5().getFace() +
                                                                    game.getPlayer1().getCard5().getSuit() + ".jpg");
                pnlPlayerCard5.Visible = true;
            }
            else { pnlPlayerCard5.Visible = false; }

            game.getPlayer1().setHandScore();
            lblPlayerScore.Text = game.getPlayer1().getHandScore().ToString();


            game.getDealer().setCard1(game.populateCard(game.getDealer().getPlayerHand(0)));
            lblDealerCard1id.Text = game.getDealer().getPlayerHand(0).ToString();
            lblDealerCard1face.Text = game.getDealer().getCard1().getFace();
            lblDealerCard1suit.Text = game.getDealer().getCard1().getSuit();
            lblDealerCard1value.Text = game.getDealer().getCard1().getVal().ToString();
           
            if (game.getDealer().getCard1().getVal() != 0)
            {
                pnlDealerCard1.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard1().getFace() + 
                                                                    game.getDealer().getCard1().getSuit() + ".jpg");
                pnlDealerCard1.Visible = true;
            }
            else { pnlDealerCard1.Visible = false; }

            game.getDealer().setCard2(game.populateCard(game.getDealer().getPlayerHand(1)));
            lblDealerCard2id.Text = game.getDealer().getPlayerHand(1).ToString();
            lblDealerCard2face.Text = game.getDealer().getCard2().getFace();
            lblDealerCard2suit.Text = game.getDealer().getCard2().getSuit();
            lblDealerCard2value.Text = game.getDealer().getCard2().getVal().ToString();          
            if (game.getDealer().getCard2().getVal() != 0)
            {
                pnlDealerCard2.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard2().getFace() + 
                                                                    game.getDealer().getCard2().getSuit() + ".jpg");
                pnlDealerCard2.Visible = true;
            }
            else {
                pnlDealerCard2.BackgroundImage = Image.FromFile(imgResPrefix + "cardback.jpg");
            }


            game.getDealer().setCard3(game.populateCard(game.getDealer().getPlayerHand(2)));
            lblDealerCard3id.Text = game.getDealer().getPlayerHand(2).ToString();
            lblDealerCard3face.Text = game.getDealer().getCard3().getFace();
            lblDealerCard3suit.Text = game.getDealer().getCard3().getSuit();
            lblDealerCard3value.Text = game.getDealer().getCard3().getVal().ToString();           
            if (game.getDealer().getCard3().getVal() != 0)
            {
                pnlDealerCard3.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard3().getFace() + 
                                                                    game.getDealer().getCard3().getSuit() + ".jpg");
                pnlDealerCard3.Visible = true;
            }
            else { pnlDealerCard3.Visible = false; }


            game.getDealer().setCard4(game.populateCard(game.getDealer().getPlayerHand(3)));
            lblDealerCard4id.Text = game.getDealer().getPlayerHand(3).ToString();
            lblDealerCard4face.Text = game.getDealer().getCard4().getFace();
            lblDealerCard4suit.Text = game.getDealer().getCard4().getSuit();
            lblDealerCard4value.Text = game.getDealer().getCard4().getVal().ToString();          
            if (game.getDealer().getCard4().getVal() != 0)
            {
                pnlDealerCard4.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard4().getFace() + 
                                                                    game.getDealer().getCard4().getSuit() + ".jpg");
                pnlDealerCard4.Visible = true;
            }
            else { pnlDealerCard4.Visible = false; }


            game.getDealer().setCard5(game.populateCard(game.getDealer().getPlayerHand(4)));
            lblDealerCard5id.Text = game.getDealer().getPlayerHand(4).ToString();
            lblDealerCard5face.Text = game.getDealer().getCard5().getFace();
            lblDealerCard5suit.Text = game.getDealer().getCard5().getSuit();
            lblDealerCard5value.Text = game.getDealer().getCard5().getVal().ToString();           
            if (game.getDealer().getCard5().getVal() != 0)
            {
                pnlDealerCard5.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard5().getFace() + 
                                                                    game.getDealer().getCard5().getSuit() + ".jpg");
                pnlDealerCard5.Visible = true;
            }
            else { pnlDealerCard5.Visible = false; }

            game.getDealer().setHandScore();
            lblDealerScore.Text = game.getDealer().getHandScore().ToString();
            if (game.getDealer().getHandScore() > 0)
            {
                lblDealerScore.Visible = true;
            } else
            {
                lblDealerScore.Visible = false;
            }

        }

        private void btnHit_Click(object sender, EventArgs e)                   // Proto 
        {
            game.getPlayer1().hit(game.getDeck().dealCard());
            populateTable();
            game.playerActions(); 
            populateTable();
        }

        private void btnStay_Click(object sender, EventArgs e)                  // Proto 
        {
            game.setPlayerTurn(false);

            for(int i=0; i<10; i++)
            {
                game.dealerActions();
                populateTable();
            }
            
            if(game.getDealer().getHandScore() < 21)
            {
                game.compareScores();
            }

            lblCondition.Text = game.getFeedback();
        }

        private void btnHelp_Click(object sender, EventArgs e)                  // Needs enhancement 
        {
            pnlHelp.Visible = true;
            pnlGame.Visible = false;
            helpPageIndex = 0;
            pnlHelp.BackgroundImage = Image.FromFile(helpResPrefix + helpPageIndex + ".jpg");
        }

        private void btnHelpEnd_Click(object sender, EventArgs e)               // Proto 
        {
            pnlHelp.Visible = false;
            helpPageIndex = 0;
            pnlGame.Visible = true;
            btnHelpNext.Visible = true;
        }

        private void btnHelpNext_Click(object sender, EventArgs e)              // Needs Improvement 
        {           
            helpPageIndex++; // make some test for remaining help pages
            if (helpPageIndex < 4)
            {
                pnlHelp.BackgroundImage = Image.FromFile(helpResPrefix + helpPageIndex + ".jpg");
            }else
            {
                btnHelpNext.Visible = false;
            }
        }

        public void playGame()                                                  // Working 1 Cycle 
        {
            game.getPlayer1().hit(game.getDeck().dealCard());
            game.getPlayer1().setCard1(game.populateCard(game.getPlayer1().getPlayerHand(0)));

            game.getDealer().hit(game.getDeck().dealCard());
            game.getDealer().setCard1(game.populateCard(game.getDealer().getPlayerHand(0)));

            game.getPlayer1().hit(game.getDeck().dealCard());
            game.getPlayer1().setCard2(game.populateCard(game.getPlayer1().getPlayerHand(1)));

            pnlDealerCard2.BackgroundImage = Image.FromFile(imgResPrefix + "cardBack.jpg");
            pnlDealerCard2.Visible = true;
            game.playerActions();
            populateTable();              
        }

        public void callForm2()
        {
            //this.Hide();       
            form2.Show();
            form2.BringToFront();
        }

        public void setPlayerId(int id) { playerId = id; }

    }//form
}
