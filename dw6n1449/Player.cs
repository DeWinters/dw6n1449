using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dw6n1449
{
    class Player
    {
        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);

        private int[] playerHand = new int[6];
        private int totCards = 0;
        private int handScore;

        private Card card1 = new Card();
        private Card card2 = new Card();
        private Card card3 = new Card();
        private Card card4 = new Card();
        private Card card5 = new Card();

        public int getPlayerHand(int card) { return playerHand[card]; }
        public void setPlayerHand(int[] playerHand) { this.playerHand = playerHand; }

        public int getTotCards() { return totCards; }
        public void incrTotCards() { this.totCards++; }

        public int getHandScore() { return handScore; }
        public void setHandScore() { this.handScore = card1.getVal() + card2.getVal() + card3.getVal() + card4.getVal() + card5.getVal(); }

        public Card getCard1() { return card1; }
        public void setCard1(Card card1) { this.card1 = card1; }

        public Card getCard2() { return card2; }
        public void setCard2(Card card2) { this.card2 = card2; }

        public Card getCard3() { return card3; }
        public void setCard3(Card card3) { this.card3 = card3; }

        public Card getCard4() { return card4; }
        public void setCard4(Card card4) { this.card4 = card4; }

        public Card getCard5() { return card5; }
        public void setCard5(Card card5) { this.card5 = card5; }

        public Card populateCard(int cardId)
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

        public void hit(int cardId)
        {
            if(playerHand[4] == 0)
            {
                playerHand[getTotCards()] = cardId;
                incrTotCards();
            }
            setHandScore();
        }
    }
}
