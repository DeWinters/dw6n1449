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
        public int[] playerHand = new int[5];
        private int totCards = 0;

        public int getPlayerHand(int card) { return playerHand[card]; }
        public void setPlayerHand(int[] playerHand) { this.playerHand = playerHand; }

        public int getTotCards() { return totCards; }
        public void setTotCards(int totCards) { this.totCards = totCards; }

        public void hit(int cardId)
        {
            playerHand[totCards] = cardId;
            totCards++;
        }
    }
}
