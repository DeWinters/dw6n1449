using System;
using System.Drawing;
using System.Windows.Forms;

namespace dw6n1449
{
    public partial class Form1 : Form
    {     
        static string imgResPrefix = "C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\";
        static string helpResPrefix = "C:\\Users\\Administrator\\Source\\Repos\\dw6n1449\\dw6n1449\\Resources\\help";
        public static int playerId;
        Game game = new Game();
        int helpPageIndex = 0;

        public Form1()
        {
            InitializeComponent();           

            pnlGame.Visible = false;
            pnlHelp.Visible = false;
            pnlIntro.Visible = true;
            pnlIntro.BringToFront();
        }
         
        private void populateTable()                                            // Needs GUI enhancement 
        {
            pnlIntro.Visible = false;
            pnlGame.Visible = true;

            game.getPlayer1().setId(playerId);
            game.getPlayer1().setName();
            lblPlayer1Name.Text = game.getPlayer1().getName();

            lblCondition.Text = game.getFeedback();

            if(game.getPlayerTurn() == true)
            {
                btnHit.Visible = true;
                btnStay.Visible = true;
                btnPlay.Visible = false;
            }else
            {
                btnHit.Visible = false;
                btnStay.Visible = false;
                btnPlay.Visible = true;
            }

            game.getPlayer1().setCard1(game.populateCard(game.getPlayer1().getPlayerHand(0)));
            pnlPlayerCard1.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard1().getFace() + 
                                                                    game.getPlayer1().getCard1().getSuit() + ".jpg");

            game.getPlayer1().setCard2(game.populateCard(game.getPlayer1().getPlayerHand(1)));
            pnlPlayerCard2.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard2().getFace() +
                                                                    game.getPlayer1().getCard2().getSuit() + ".jpg");

            game.getPlayer1().setCard3(game.populateCard(game.getPlayer1().getPlayerHand(2)));
            if (game.getPlayer1().getCard3().getVal() != 0)
            {
                pnlPlayerCard3.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard3().getFace() +
                                                                    game.getPlayer1().getCard3().getSuit() + ".jpg");
                pnlPlayerCard3.Visible = true;
            }
            else { pnlPlayerCard3.Visible = false; }

            game.getPlayer1().setCard4(game.populateCard(game.getPlayer1().getPlayerHand(3)));
            if (game.getPlayer1().getCard4().getVal() != 0)
            {
                pnlPlayerCard4.BackgroundImage = Image.FromFile(imgResPrefix + game.getPlayer1().getCard4().getFace() +
                                                                    game.getPlayer1().getCard4().getSuit() + ".jpg");
                pnlPlayerCard4.Visible = true;
            }
            else { pnlPlayerCard4.Visible = false; }

            game.getPlayer1().setCard5(game.populateCard(game.getPlayer1().getPlayerHand(4)));
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
            if (game.getDealer().getCard1().getVal() != 0)
            {
                pnlDealerCard1.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard1().getFace() + 
                                                                    game.getDealer().getCard1().getSuit() + ".jpg");
                pnlDealerCard1.Visible = true;
            }
            else { pnlDealerCard1.Visible = false; }


            game.getDealer().setCard2(game.populateCard(game.getDealer().getPlayerHand(1)));        
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
            if (game.getDealer().getCard3().getVal() != 0)
            {
                pnlDealerCard3.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard3().getFace() + 
                                                                    game.getDealer().getCard3().getSuit() + ".jpg");
                pnlDealerCard3.Visible = true;
            }
            else { pnlDealerCard3.Visible = false; }


            game.getDealer().setCard4(game.populateCard(game.getDealer().getPlayerHand(3)));   
            if (game.getDealer().getCard4().getVal() != 0)
            {
                pnlDealerCard4.BackgroundImage = Image.FromFile(imgResPrefix + game.getDealer().getCard4().getFace() + 
                                                                    game.getDealer().getCard4().getSuit() + ".jpg");
                pnlDealerCard4.Visible = true;
            }
            else { pnlDealerCard4.Visible = false; }


            game.getDealer().setCard5(game.populateCard(game.getDealer().getPlayerHand(4)));        
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

        public void playGame()                                                 
        {
            game.getPlayer1().hit(game.getDeck().dealCard());
            game.getDealer().hit(game.getDeck().dealCard());
            game.getPlayer1().hit(game.getDeck().dealCard());

            pnlDealerCard2.Visible = true;
            game.playerActions();
            populateTable();              
        }

        public void setPlayerId(int id) { playerId = id; }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            if(playerId != 0)
            {
                dealHand();
            }
            else
            {
                lblIntroOutput.Text = "Sorry, we'll need to see your ID before you may enter.";
            }
        }

        private void dealHand()
        {
            game = new Game();
            playGame();
            pnlIntro.SendToBack();
            pnlGame.BringToFront();
            populateTable();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            dealHand();
        }
    }//form
}
