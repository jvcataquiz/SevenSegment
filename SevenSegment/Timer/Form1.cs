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
                btnSecMid.BackColor = System.Drawing.Color.Black;

                btnSecTop.PerformClick();
                btnSecTopleft.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
            }
            else if (seconds == 1)
            {
                btnSecTop.BackColor = System.Drawing.Color.Black;
                btnSecTopleft.BackColor = System.Drawing.Color.Black;
                btnSecBotleft.BackColor = System.Drawing.Color.Black;
                btnBot.BackColor = System.Drawing.Color.Black;

                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (seconds == 2)
            {
                btnSecBotright.BackColor = System.Drawing.Color.Black;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotleft.PerformClick();
                btnBot.PerformClick();
            }
            else if (seconds == 3)
            {

                btnSecBotleft.BackColor = System.Drawing.Color.Black;

                btnSecTop.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecMid.PerformClick();
                btnSecBotright.PerformClick();
                btnBot.PerformClick();
            }
            else if (seconds == 4)
            {
                btnSecTop.BackColor = System.Drawing.Color.Black;
                btnBot.BackColor = System.Drawing.Color.Black;

                btnSecTopleft.PerformClick();
                btnSecMid.PerformClick();
                btnSecTopRight.PerformClick();
                btnSecBotright.PerformClick();
            }
            else if (seconds == 5)
            {
                btnSecTopRight.BackColor = System.Drawing.Color.Black;
                btnSecTop.BackColor = System.Drawing.Color.Black;

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
                btnSecTopleft.BackColor = System.Drawing.Color.Black;
                btnSecMid.BackColor = System.Drawing.Color.Black; ;
                btnBot.BackColor = System.Drawing.Color.Black;
                btnSecBotleft.BackColor = System.Drawing.Color.Black;

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

                btnSecBotleft.BackColor = System.Drawing.Color.Black;
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
                btnMid2.BackColor = System.Drawing.Color.Black;

                btnTop2.PerformClick();
                btnTop2left.PerformClick();
                btnTop2right.PerformClick();
                btnBot2right.PerformClick();
                btnBot2lleft.PerformClick();
                btnBot2.PerformClick();
            }
            else if (tenthsec == 1)
            {
                btnTop2.BackColor = System.Drawing.Color.Black;
                btnTop2left.BackColor = System.Drawing.Color.Black;
                btnBot2lleft.BackColor = System.Drawing.Color.Black;
                btnBot2.BackColor = System.Drawing.Color.Black;

                btnTop2right.PerformClick();
                btnBot2right.PerformClick();
            }
            else if (tenthsec == 2)
            {
                btnBot2right.BackColor = System.Drawing.Color.Black;

                btnTop2.PerformClick();
                btnTop2right.PerformClick();
                btnMid2.PerformClick();
                btnBot2lleft.PerformClick();
                btnBot2.PerformClick();
            }
            else if (tenthsec == 3)
            {

                btnBot2lleft.BackColor = System.Drawing.Color.Black;

                btnTop2.PerformClick();
                btnTop2right.PerformClick();
                btnMid2.PerformClick();
                btnBot2right.PerformClick();
                btnBot2.PerformClick();
            }
            else if (tenthsec == 4)
            {
                btnTop2.BackColor = System.Drawing.Color.Black;
                btnBot2.BackColor = System.Drawing.Color.Black;

                btnTop2left.PerformClick();
                btnMid2.PerformClick();
                btnTop2right.PerformClick();
                btnBot2right.PerformClick();
            }
            else if (tenthsec == 5)
            {
                btnTop2right.BackColor = System.Drawing.Color.Black;
                btnTop2.BackColor = System.Drawing.Color.Black;

                btnTop2.PerformClick();
                btnTop2left.PerformClick();
                btnMid2.PerformClick();
                btnBot2right.PerformClick();
                btnBot2.PerformClick();

            }

            else
            {
                btnMid2.BackColor = System.Drawing.Color.Black;
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
                btnoneTop.BackColor = System.Drawing.Color.Black;
                btnonetopleft.BackColor = System.Drawing.Color.Black;
                btnonebotleft.BackColor = System.Drawing.Color.Black;
                btnonebot.BackColor = System.Drawing.Color.Black;

                btnoneright.PerformClick();
                btnonebotright.PerformClick();
            }
            else if (onesmin == 2)
            {
                btnonebotright.BackColor = System.Drawing.Color.Black;

                btnoneTop.PerformClick();
                btnoneright.PerformClick();
                btnonemid.PerformClick();
                btnonebotleft.PerformClick();
                btnonebot.PerformClick();
            }
            else if (onesmin == 3)
            {

                btnonebotleft.BackColor = System.Drawing.Color.Black;

                btnoneTop.PerformClick();
                btnoneright.PerformClick();
                btnonemid.PerformClick();
                btnonebotright.PerformClick();
                btnonebot.PerformClick();
            }
            else if (onesmin == 4)
            {
                btnoneTop.BackColor = System.Drawing.Color.Black;
                btnonebot.BackColor = System.Drawing.Color.Black;

                btnonetopleft.PerformClick();
                btnonemid.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
            }
            else if (onesmin == 5)
            {
                btnoneright.BackColor = System.Drawing.Color.Black;
                btnoneTop.BackColor = System.Drawing.Color.Black;

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
                btnonetopleft.BackColor = System.Drawing.Color.Black;
                btnonemid.BackColor = System.Drawing.Color.Black; ;
                btnonebot.BackColor = System.Drawing.Color.Black;
                btnonebotleft.BackColor = System.Drawing.Color.Black;

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
                btnonebotleft.BackColor = System.Drawing.Color.Black;
                btnoneTop.PerformClick();
                btnonetopleft.PerformClick();
                btnoneright.PerformClick();
                btnonebotright.PerformClick();
                btnonebot.PerformClick();
                btnonemid.PerformClick();

            }
            else
            {
                btnonemid.BackColor = System.Drawing.Color.Black;
                btnonebotleft.PerformClick();
                
            }
            tensmin();
        }
        private void tensmin()
        {
            string datemin1 = DateTime.Now.ToString("mm");
            tenthmin = Convert.ToInt32(datemin1.Substring(0, 1));

            if (tenthmin == 0)
            {
                btntenminmid.BackColor = System.Drawing.Color.Black;

                btntenmintop.PerformClick();
                btntenmintopleft.PerformClick();
                btntenmintopright.PerformClick();
                btntenminbotright.PerformClick();
                btntenminbotleft.PerformClick();
                btntenminbot.PerformClick();
            }
            else if (tenthmin == 1)
            {
                btntenmintop.BackColor = System.Drawing.Color.Black;
                btntenmintopleft.BackColor = System.Drawing.Color.Black;
                btntenminbotleft.BackColor = System.Drawing.Color.Black;
                btntenminbot.BackColor = System.Drawing.Color.Black;

                btntenmintopright.PerformClick();
                btntenminbotright.PerformClick();
            }
            else if (tenthmin == 2)
            {
                btntenminbotright.BackColor = System.Drawing.Color.Black;

                btntenmintop.PerformClick();
                btntenmintopright.PerformClick();
                btntenminmid.PerformClick();
                btntenminbotleft.PerformClick();
                btntenminbot.PerformClick();
            }
            else if (tenthmin == 3)
            {

                btntenminbotleft.BackColor = System.Drawing.Color.Black;

                btntenmintop.PerformClick();
                btntenmintopright.PerformClick();
                btntenminmid.PerformClick();
                btntenminbotright.PerformClick();
                btntenminbot.PerformClick();
            }
            else if (tenthmin == 4)
            {
                btntenmintop.BackColor = System.Drawing.Color.Black;
                btntenminbot.BackColor = System.Drawing.Color.Black;

                btntenmintopleft.PerformClick();
                btntenminmid.PerformClick();
                btntenmintopright.PerformClick();
                btntenminbotright.PerformClick();
            }
            else if (tenthmin == 5)
            {
                btntenmintopright.BackColor = System.Drawing.Color.Black;
                btntenmintop.BackColor = System.Drawing.Color.Black;

                btntenmintop.PerformClick();
                btntenmintopleft.PerformClick();
                btntenminmid.PerformClick();
                btntenminbotright.PerformClick();
                btntenminbot.PerformClick();

            }

            else
            {
                btntenminmid.BackColor = System.Drawing.Color.Black;
                btntenmintopright.PerformClick();
                btntenminbotleft.PerformClick();

            }

        }
        private void HoursMinSEC(object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            btnclick.BackColor = System.Drawing.Color.White;
        }
    }
}