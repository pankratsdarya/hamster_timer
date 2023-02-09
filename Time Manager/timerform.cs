using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Manager
{       
    public partial class timerform : Form
    {
        private workitform wif = new workitform();
        private eatform eatf = new eatform();
        private min5form min5 = new min5form();
        private dinerform din = new dinerform();
        private gohomeform ghf = new gohomeform();
        int wmin, wsec, winterval, wifvis = 5;
        bool wifshow = true, staylate = false;
        public DateTime dintime = new DateTime(2019, 10, 14, 12, 35, 0);
        public DateTime endtime = new DateTime(2019, 10, 14, 17, 35, 0);
        public DateTime nowtime = new DateTime();
      

        public timerform()
        {
            InitializeComponent();
            AddOwnedForm(wif);
            AddOwnedForm(eatf);
            AddOwnedForm(min5);
            AddOwnedForm(din);
            AddOwnedForm(ghf);
        }

        private void Timer1s_Tick(object sender, EventArgs e)
        {
            timer1s.Start(); 
            countdown();            
        }
               
               
        private void Timerform_VisibleChanged(object sender, EventArgs e)
        {                       
            if (Visible)
            {
                winterval =  1500 ;
                if (wifshow)
                {
                    wif.Show();
                    wifshow = false;
                }
                if (Text == "Таймер")
                    wif.Show();
                wifvis = 5;
                timer1s.Start(); 
                label1.Text = "25:00";
                label1.ForeColor = System.Drawing.Color.Black;                
            }
            else
            {
                timer1s.Stop(); 
            }
            
        }

        private void Timerform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Text = Text + "I";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string str;
            if (Text.EndsWith("I"))
            {
                str = Text.Remove(Text.Length - 1);
                Text = str;
            }
            else
            {
                winterval = 1500;                
                if (Text == "Таймер")
                    wif.Show();
                wifvis = 5;
                timer1s.Start();
                label1.Text = "25:00";
                label1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            wif.Hide();
            wifshow = true;
            Owner.Show();
            Hide();

        }

        private void Timerform_Load(object sender, EventArgs e)
        {
            wif.Show();
            label1.Text = "25:00";
            timer1s.Start();
            winterval =  1500;            
        }

        
        public void countdown ()
        {            
            if (Text.EndsWith("IIII"))
            {
                wif.Hide();
                Text = "Таймер";
                eatf.Show();
                Hide();
            }
            if (Text.EndsWith("К")|| Text.EndsWith("Ф"))
            {
                wif.Hide();
                Text = "Таймер";
                wifshow = true;
                eatf.Show();
                Hide();
            }
            timecheck();
            if (wifvis > 0)
                wifvis--;
            else if (wifvis == 0)
                wif.Hide();
            if (winterval == 0)
            {
                if (Text.EndsWith("III"))
                    wifshow = false;
                else wifshow = true;
                Hide();
                min5.Show();                                  
            }
            else
            {
                wmin = Math.DivRem(winterval, 60, out wsec);
                label1.Text = wmin.ToString() + ':' + wsec.ToString();
                if (winterval < 180)
                    label1.ForeColor = System.Drawing.Color.Red;
                winterval--;
            }
        }

        public void timecheck ()
        {
            nowtime = DateTime.Now;

            if (Text.EndsWith("З"))
            {
                staylate = true;
            }

            if (nowtime.Hour==dintime.Hour)
            {
                if (nowtime.Minute > (dintime.Minute-1))
                {

                    wif.Hide();
                    Text = "Таймер";
                    wifshow = true;
                    din.Show();
                    Hide();

                }
            }

            if (!staylate)
            {
                if (nowtime.Hour==endtime.Hour)
                {
                    if (nowtime.Minute > (endtime.Minute-1))
                    {
                        wif.Hide();
                        Text = "Таймер";
                        wifshow = true;
                        ghf.Show();
                        Hide();
                    }
                }
            }
        }
    }
}
