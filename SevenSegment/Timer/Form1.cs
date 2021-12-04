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
        int Tick = 0;
        bool Color = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {

            Button newbot = new Button();

         
            if (Tick == 0)
            {
                 btnSecTop.PerformClick();
                 btnSecTopleft.PerformClick();
                 btnSecTopRight.PerformClick();
                 btnSecBotright.PerformClick();
                 btnSecBotleft.PerformClick();
                 btnBot.PerformClick();
            }
            else
            {
                btnSecTop.UseVisualStyleBackColor = true;
                btnSecTopleft.UseVisualStyleBackColor = true;
                btnSecTopRight.UseVisualStyleBackColor = true;
                btnSecBotright.UseVisualStyleBackColor = true;
                btnSecBotleft.UseVisualStyleBackColor = true;
                btnBot.UseVisualStyleBackColor = true;
               
            }
            Tick++;
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