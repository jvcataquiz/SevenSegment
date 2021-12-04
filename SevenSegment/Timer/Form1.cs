using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int Tick = -1;
        int tenthsec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {
            Tick++;

            if (Tick == 0)
            {
                 btnSecTop.PerformClick();
                 btnSecTopleft.PerformClick();
                 btnSecTopRight.PerformClick();
                 btnSecBotright.PerformClick();
                 btnSecBotleft.PerformClick();
                 btnBot.PerformClick();
            }
            else if (Tick == 1)
            {
                btnSecTop.UseVisualStyleBackColor = true;
                btnSecTopleft.UseVisualStyleBackColor = true;
                btnSecBotleft.UseVisualStyleBackColor = true;
                btnBot.UseVisualStyleBackColor = true;
               
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (Tick == 2)
            {
                btnSecBotright.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
            }
            else if (Tick == 3)
            {
               
                btnSecBotleft.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
            }
            else if (Tick ==4)
            {
                btnSecTop.UseVisualStyleBackColor = true;
                btnBot.UseVisualStyleBackColor = true;

                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (Tick == 5)
            {
                btnSecTopRight.UseVisualStyleBackColor = true;
                btnSecTop.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();

            }



            else if (Tick == 6)
            {
                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
                btnSecBotleft.PerformClick();
            }

            else if (Tick == 7)
            {
                btnSecTopleft.UseVisualStyleBackColor = true;
                btnSecMid.UseVisualStyleBackColor = true; ;
                btnBot.UseVisualStyleBackColor = true;
                btnSecBotleft.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }

            else if (Tick == 8)
            {
                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
                btnSecMid.PerformClick();
            }
            else if(Tick == 9)
            {
                btnSecBotleft.UseVisualStyleBackColor = true;
                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
                btnSecMid.PerformClick();

            }
            else
            {
                btnSecMid.UseVisualStyleBackColor = true;
                btnSecBotleft.PerformClick();
                Tick = 0;
                tenthsec++;
            }
       
  
        }

        private void SecondElements(object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            btnclick.BackColor = System.Drawing.Color.Red;
           
        }
        private void changer()
        {
          
        }
    }
}