using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipDaCoins
{
    public partial class Form1 : Form
    {
        //array of coins
        Coin[] coins = new Coin[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();

            label1.Text = "";

            for (int i = 0; i < coins.Length ; i++)
            {
                //method for random fliping

                coins[i].flipCoin(r);

                //display the text 

                if (coins[i].isHeads==true)
                {
                    label1.Text += "Heads" +",";
                }
                else
                {
                    label1.Text += "Tails" + ",";
                }
                
            }

            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.coinHeads : Properties.Resources.coinTail;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.coinHeads : Properties.Resources.coinTail;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.coinHeads : Properties.Resources.coinTail;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.coinHeads : Properties.Resources.coinTail;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.coinHeads : Properties.Resources.coinTail;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loading the coins array 

            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(false);
            }
        }
    }
}
