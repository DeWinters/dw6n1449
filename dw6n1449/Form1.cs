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

            btnStay.Visible = false;
            btnHit.Visible = false;

            int score;

            Card playerCard1 = new Card();
            playerCard1.getCard(2);                            

            Card playerCard2 = new Card();
            playerCard2.getCard(20);

            score = playerCard1.getVal() + playerCard2.getVal();            /** PlayerScore **/

            lblValue1.Text = playerCard1.getVal().ToString();               /** GUI outputs **/
            lblFace1.Text = playerCard1.getFace();
            lblSuit1.Text = playerCard1.getSuit();

            lblValue2.Text = playerCard2.getVal().ToString();              
            lblFace2.Text = playerCard2.getFace();
            lblSuit2.Text = playerCard2.getSuit();

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
