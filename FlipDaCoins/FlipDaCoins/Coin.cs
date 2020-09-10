using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipDaCoins
{
    class Coin
    {

        //constructor
        public Coin(bool h)
        {
            isHeads = h;
        }
        //prop
        public bool isHeads { get; set; }

        //method
        public void flipCoin( Random r)
        {
            if (r.Next(10) < 5)
            {
                isHeads = true;
            }
            else
            {
                isHeads = false;
            }           
        }
    }
}
