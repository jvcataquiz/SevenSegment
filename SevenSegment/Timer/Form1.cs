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
        bool Color = true;
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
                btnSecMid.UseVisualStyleBackColor = true;

                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (Tick == 2)
            {
                btnSecBotright.UseVisualStyleBackColor = true;
                btnSecTopRight.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
            }
            else if (Tick == 3)
            {
                btnSecTop.UseVisualStyleBackColor = true;
                btnSecTopRight.UseVisualStyleBackColor = true;
                btnSecMid.UseVisualStyleBackColor = true;
                btnSecBotleft.UseVisualStyleBackColor = true;
                btnBot.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
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