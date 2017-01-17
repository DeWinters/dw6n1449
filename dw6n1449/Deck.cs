using System;
using MySql.Data.MySqlClient;

namespace dw6n1449
{
    class Deck
    {
        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);

        Random rand = new Random();
        public int[] deckArray = new int[52];
        private int position;
        private int nextCard = 0;       

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
            int dealt = 0;
            if (nextCard < 52)
            {
                dealt = deckArray[nextCard];
                nextCard++;
            }
            return dealt;
        }
    }
}
