using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dw6n1449
{
    class Card
    {
        private int id;
        private int val;
        private String face;
        private String suit;

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public int getVal() { return val; }
        public void setVal(int val) { this.val = val; }

        public String getFace() { return face; }
        public void setFace(string face) { this.face = face; }

        public String getSuit() { return suit; }
        public void setSuit(string suit) { this.suit = suit; } 
    }
}
