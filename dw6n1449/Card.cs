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
        // blah blah changes and some more again

        private int getId() { return id; }
        private void setId(int id) { this.id = id; }

        private int getVal() { return val; }
        private void setVal(int val) { this.val = val; }

        private string getFace() { return face; }
        private void setFace(string face) { this.face = face; }
    }
}
