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
        private int[] playerHand = new int[5];
        private int totCards;
        private int handScore = 0;

        Card card1 = new Card();
        Card card2 = new Card();
        Card card3 = new Card();
        Card card4 = new Card();
        Card card5 = new Card();

        public int getPlayerHand(int card) { return playerHand[card]; }
        public void setPlayerHand(int[] playerHand) { this.playerHand = playerHand; }

        public int getTotCards() { return totCards; }
        public void setTotCards(int totCards) { this.totCards = totCards; }

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

        public void hit(int cardId)
        {
            playerHand[totCards] = cardId;
            totCards++;
        }
    }
}
