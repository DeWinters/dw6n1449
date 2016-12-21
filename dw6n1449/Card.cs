using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dw6n1449
{
    class Card
    {
        private int id;
        private int val;
        private string face;
        private string suit;
        // blah blah changes and some more again

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public int getVal() { return val; }
        public void setVal(int val) { this.val = val; }

        public string getFace() { return face; }
        public void setFace(string face) { this.face = face; }

        public string getSuit() { return suit; }
        public void setSuit(string suit) { this.suit = suit; }
    }
}
