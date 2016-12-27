using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dw6n1449
{
    class Game
    {
        public Login login = new Login();
        Deck deck = new Deck();
        Player player1 = new Player();
        Player dealer = new Player();


        public void callLoginPage()
        {
            login.callForm2();
        }





    }
}
