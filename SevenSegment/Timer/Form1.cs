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
        int seconds;
        int seconds1;
        int tenthsec;
        int onesmin = 0;
        int tenthmin = 0;
        string datesec;
        string datesec1;
        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {
            datesec = DateTime.Now.ToString("ss");
            seconds = Convert.ToInt32(datesec.Substring(datesec.Length - 1));
          
            if (seconds == 0)
            {
                btnSecMid.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
            }
            else if (seconds == 1)
            {
                btnSecTop.UseVisualStyleBackColor = true;
                btnSecTopleft.UseVisualStyleBackColor = true;
                btnSecBotleft.UseVisualStyleBackColor = true;
                btnBot.UseVisualStyleBackColor = true;

                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (seconds == 2)
            {
                btnSecBotright.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
            }
            else if (seconds == 3)
            {

                btnSecBotleft.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
            }
            else if (seconds == 4)
            {
                btnSecTop.UseVisualStyleBackColor = true;
                btnBot.UseVisualStyleBackColor = true;

                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (seconds == 5)
            {
                btnSecTopRight.UseVisualStyleBackColor = true;
                btnSecTop.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();

            }



            else if (seconds == 6)
            {
                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
                btnSecBotleft.PerformClick();
            }

            else if (seconds == 7)
            {
                btnSecTopleft.UseVisualStyleBackColor = true;
                btnSecMid.UseVisualStyleBackColor = true; ;
                btnBot.UseVisualStyleBackColor = true;
                btnSecBotleft.UseVisualStyleBackColor = true;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }

            else if (seconds == 8)
            {
                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
                btnSecMid.PerformClick();
            }
           
            else
            {

                btnSecBotleft.UseVisualStyleBackColor = true;
                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
                btnSecMid.PerformClick();

            }



            TenSec();


        }

       
        private void TenSec()
        {
            datesec1 = DateTime.Now.ToString("ss");
            seconds1 = Convert.ToInt32(datesec1.Substring(0, 1));
            tenthsec = seconds1;


            if (tenthsec == 0)
            {
                btnMid2.UseVisualStyleBackColor = true;

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
               
            }
            minute();

        }
        private void minute()
        {
            string datemin = DateTime.Now.ToString("mm");
            onesmin = Convert.ToInt32(datemin.Substring(datemin.Length - 1));
            if (onesmin == 0)
            {
                btnoneTop.PerformClick();
                btnonetopleft.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
                btnonebotleft.PerformClick();
                btnonebot.PerformClick();
            }
            else if (onesmin == 1)
            {
                btnoneTop.UseVisualStyleBackColor = true;
                btnonetopleft.UseVisualStyleBackColor = true;
                btnonebotleft.UseVisualStyleBackColor = true;
                btnonebot.UseVisualStyleBackColor = true;

                btnoneright.PerformClick();
                btnonebotright.PerformClick();
            }
            else if (onesmin == 2)
            {
                btnonebotright.UseVisualStyleBackColor = true;

                btnoneTop.PerformClick();
                btnoneright.PerformClick();
                btnonemid.PerformClick();
                btnonebotleft.PerformClick();
                btnonebot.PerformClick();
            }
            else if (onesmin == 3)
            {

                btnonebotleft.UseVisualStyleBackColor = true;

                btnoneTop.PerformClick();
                btnoneright.PerformClick();
                btnonemid.PerformClick();
                btnonebotright.PerformClick();
                btnonebot.PerformClick();
            }
            else if (onesmin == 4)
            {
                btnoneTop.UseVisualStyleBackColor = true;
                btnonebot.UseVisualStyleBackColor = true;

                btnonetopleft.PerformClick();
                btnonemid.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
            }
            else if (onesmin == 5)
            {
                btnoneright.UseVisualStyleBackColor = true;
                btnoneTop.UseVisualStyleBackColor = true;

                btnoneTop.PerformClick();
                btnonetopleft.PerformClick();
                btnonemid.PerformClick();
                btnonebotright.PerformClick();
                btnonebot.PerformClick();

            }



            else if (onesmin == 6)
            {
                btnoneTop.PerformClick();
                btnonetopleft.PerformClick();
                btnonemid.PerformClick();
                btnonebotright.PerformClick();
                btnonebot.PerformClick();
                btnonebotleft.PerformClick();
            }

            else if (onesmin == 7)
            {
                btnonetopleft.UseVisualStyleBackColor = true;
                btnonemid.UseVisualStyleBackColor = true; ;
                btnonebot.UseVisualStyleBackColor = true;
                btnonebotleft.UseVisualStyleBackColor = true;

                btnoneTop.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
            }

            else if (onesmin == 8)
            {
                btnoneTop.PerformClick();
                btnonetopleft.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
                btnonebotleft.PerformClick();
                btnonebot.PerformClick();
                btnonemid.PerformClick();
            }
            else if (onesmin == 9)
            {
                btnonebotleft.UseVisualStyleBackColor = true;
                btnoneTop.PerformClick();
                btnonetopleft.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
                btnonebot.PerformClick();
                btnonemid.PerformClick();

            }
            else
            {
                btnonemid.UseVisualStyleBackColor = true;
                btnonebotleft.PerformClick();
                onesmin = 0;
                tenthsec++;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HoursMinSEC(object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            btnclick.BackColor = System.Drawing.Color.Red;
        }
    }
}