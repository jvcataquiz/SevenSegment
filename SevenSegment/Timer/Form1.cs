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
            TenSec();


        }

        private void SecondElements(object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            btnclick.BackColor = System.Drawing.Color.Red;
           
        }
        private void TenSec()
        {

            if (tenthsec == 0)
            {
                btnTop2.PerformClick();
                btnTop2left.PerformClick();
                btnTop2right.PerformClick();
                btnBot2right.PerformClick();
                btnBot2lleft.PerformClick();
                btnBot2.PerformClick();
            }
            else if (tenthsec == 1)
            {
                btnTop2.UseVisualStyleBackColor = true;
                btnTop2left.UseVisualStyleBackColor = true;
                btnBot2lleft.UseVisualStyleBackColor = true;
                btnBot2.UseVisualStyleBackColor = true;

                btnTop2right.PerformClick();
                btnBot2right.PerformClick();
            }
            else if (tenthsec == 2)
            {
                btnBot2right.UseVisualStyleBackColor = true;

                btnTop2.PerformClick();
                btnTop2right.PerformClick();
                btnMid2.PerformClick();
                btnBot2lleft.PerformClick();
                btnBot2.PerformClick();
            }
            else if (tenthsec == 3)
            {

                btnBot2lleft.UseVisualStyleBackColor = true;

                btnTop2.PerformClick();
                btnTop2right.PerformClick();
                btnMid2.PerformClick();
                btnBot2right.PerformClick();
                btnBot2.PerformClick();
            }
            else if (tenthsec == 4)
            {
                btnTop2.UseVisualStyleBackColor = true;
                btnBot2.UseVisualStyleBackColor = true;

                btnTop2left.PerformClick();
                btnMid2.PerformClick();
                btnTop2right.PerformClick();
                btnBot2right.PerformClick();
            }
            else if (tenthsec == 5)
            {
                btnTop2right.UseVisualStyleBackColor = true;
                btnTop2.UseVisualStyleBackColor = true;

                btnTop2.PerformClick();
                btnTop2left.PerformClick();
                btnMid2.PerformClick();
                btnBot2right.PerformClick();
                btnBot2.PerformClick();

            }

            else
            {
               
                btnMid2.UseVisualStyleBackColor = true;
                btnTop2right.PerformClick();
                btnBot2lleft.PerformClick();
                tenthsec = 0;
            }

        }
    }
}