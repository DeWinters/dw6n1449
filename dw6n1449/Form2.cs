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
        static String connectionString = "Server=localhost;Port=3306;database=blackjack;Uid=root;password=secret";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlDataReader rdr;
        public Form2()
        {
            InitializeComponent();  
            //Pacale was here         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryLogin(tbxName.Text.ToString(), tbxPassword.Text.ToString());
            this.Close();
        }

        public void tryLogin(string name, string pass)
        {
            if (name != null && pass != null)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM PLAYER WHERE name='" + name + "' AND pass='" + pass + "'"; 
                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Form1.playerId = Convert.ToInt32(rdr["id"]);
                    }
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string queryString = "INSERT INTO PLAYER (name, pass) VALUES('" + name + "','" + pass + "')";
                    cmd = new MySqlCommand(queryString, conn);
                    cmd.ExecuteReader();
                    conn.Close();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM PLAYER WHERE name='" + name + "' AND pass='" + pass + "'";
                    conn.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Form1.playerId = Convert.ToInt32(rdr["id"]);
                    }
                }
            }
        }// tryLogin
    }
}
