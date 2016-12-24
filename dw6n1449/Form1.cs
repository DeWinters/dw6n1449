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

        int score;
        public Form1()
        {
            InitializeComponent();

            btnStay.Visible = false;
            btnHit.Visible = false;

            Deck deck = new Deck();
            

            for(int x=0; x < 52; x++)
            {
                Console.WriteLine(deck.deckArray[x]);
            }

            Player player1 = new Player();
            player1.playerHand[0] = deck.deckArray[0];
            player1.playerHand[1] = deck.deckArray[1];
            lblId1.Text = player1.playerHand[0].ToString();
            lblId2.Text = player1.playerHand[1].ToString();


            lblPlayerScore.Text = score.ToString();

            if(score > 21)                                                  /** hand status **/
            {                                                               // bust actions
                lblCondition.Text = "BUST! (you have gone over 21)";
            }
            else if(score == 21)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
