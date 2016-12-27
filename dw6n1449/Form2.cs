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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int playerId = 0;
            if (tbxName.Text != null && tbxPassword.Text != null)
            {
                string name = tbxName.Text;
                string password = tbxPassword.Text;

                String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
                MySqlConnection conn = new MySqlConnection(connectionString);

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM PLAYER WHERE name=" + name + " AND password=" + password;
                conn.Open();
               // MySqlDataReader rdr = cmd.ExecuteReader();
              //  if (rdr.HasRows)
             //   {
              //      while (rdr.Read())
              //      {


              //      }
                    this.Close();
             //   }
                
            }         
        }// button

    }
}
