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
        // MySqlDataAdapter adptr = new MySqlDataAdapter();
        
        public int[] playerHand = new int[5];
        public int totCards = 0;

        public int hit()
        {
            int nextCard = 1;

                return nextCard;
        }





    }
}
