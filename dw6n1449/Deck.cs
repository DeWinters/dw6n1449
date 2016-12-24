using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dw6n1449
{
    class Deck
    {

        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);
        // MySqlDataAdapter adptr = new MySqlDataAdapter();
        Random rand = new Random();

        public int[] deckArray = new int[52];
        int position;
        int nextCard = 0;       

        public Deck()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM CARD";
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Boolean flag = false;
                do
                {
                    position = rand.Next(52);
                    if (deckArray[position] == 0)
                    {
                        deckArray[position] = Convert.ToInt32(rdr["id"]);
                        flag = false;
                    } else { flag = true; }
                } while (flag == true);                
            }
            conn.Close();
        }

        public int dealCard()
        {
            int dealt = deckArray[nextCard];
            nextCard++;
            return dealt;
        }



    }
}
