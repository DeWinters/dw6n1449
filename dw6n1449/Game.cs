using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dw6n1449
{
    class Game
    {
        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public Login login = new Login();
        private Boolean playerTurn;

        Deck deck = new Deck();
        Player player1 = new Player();
        Player dealer = new Player();

        private string feedback;

        public string getFeedback() { return feedback; }
        public void setFeedback(string feedback) { this.feedback = feedback; }

        public Boolean getPlayerTurn() { return playerTurn; }
        public void setPlayerTurn(Boolean maybe) { this.playerTurn = maybe; }

        public Deck getDeck() { return deck; }

        public Player getPlayer1() { return player1; }
        public void setPlayer1(Player player1) { this.player1 = player1; }

        public Player getDealer() { return dealer; }
        public void setDealer(Player dealer) { this.dealer = dealer; }

        public void dealerActions()                                 // Proto 
        {
            dealer.setHandScore();
            if (dealer.getHandScore() == 21)
            {
                setFeedback("Hard luck, Dealer has BlackJack"); 
            }
            else if (dealer.getHandScore() > 21)
            {
                setFeedback("Dealer Busts! You Win!");
            }
            else if (dealer.getHandScore() < 17)
            {
                dealer.hit(getDeck().dealCard());
                dealer.setHandScore();               
            }
            else
            {
                compareScores();
            }
            
        }

        public void compareScores()                                 // Proto 
        {
            if (dealer.getHandScore() == 21)
            {
                feedback = "Dealer has Blackjack";
            }
            else if (player1.getHandScore() > dealer.getHandScore())
            {
                feedback = "You Win!";
            }
            else if (dealer.getHandScore() > player1.getHandScore())
            {
                feedback = "Sorry, You Lose.";
            }
            else if (dealer.getHandScore() == player1.getHandScore())
            {
                feedback = "DRAW";
            }
        }

        public Card populateCard(int cardId)                        // Proto 
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

        public void playerActions()                                 // Proto 
        {
            player1.setHandScore();
            if (player1.getHandScore() > 21)                                                  /** hand status **/
            {                                                               // bust actions
                setFeedback("BUST! (you have gone over 21)"); 
                playerTurn = false;
            }
            else if (player1.getHandScore() == 21)
            {                                                               // win actions
                setFeedback("BLACKJACK! Congratulations!");
                playerTurn = false;
            }
            else
            {                                                               // draw? actions
                setFeedback("Would you like to hit or stay?");
                playerTurn = true;
            }
   
        }

        public void callLoginPage()                                 // MISSING
        {
            login.callForm2();
        }





    }
}
