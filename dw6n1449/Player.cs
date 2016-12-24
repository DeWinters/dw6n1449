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
        public int totCards = 0;

        public void hit(int cardId)
        {
            playerHand[totCards] = cardId;
            totCards++;
        }
    }
}
