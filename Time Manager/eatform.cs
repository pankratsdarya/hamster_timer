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
    public partial class eatform : Form
    {
        int emin, esec, einterval;
        public DateTime dintime = new DateTime(2019, 10, 14, 12, 35, 0);
        public DateTime endtime = new DateTime(2019, 10, 14, 17, 35, 0);
        public DateTime nowtime = new DateTime();
        public eatform()
        {
            InitializeComponent();
        }


        private void Eatform_Load(object sender, EventArgs e)
        {
            einterval = 1800;            
            label1.Text = "30:00";
            timer1s.Start(); 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Timer1s_Tick(object sender, EventArgs e)
        {
            timer1s.Start(); 
            countdown();           
        }

        private void Eatform_VisibleChanged(object sender, EventArgs e)
        {            
            if (Visible)
            {
                einterval = 1800 - 1;
                timer1s.Start(); 
                label1.Text = "30:00";
                label1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                timer1s.Stop(); 
            }
        }

        private void Eatform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();           
           
        }

        public void countdown()
        {
            timecheck();
            if (einterval == 0)
            {
                Hide();
                Owner.Show();
            }
            else
            {
                emin = Math.DivRem(einterval, 60, out esec);
                label1.Text = emin.ToString() + ':' + esec.ToString();
                if (einterval < 180)
                    label1.ForeColor = System.Drawing.Color.Red;
                einterval--;
            }
        }

        public void timecheck()
        {
            nowtime = DateTime.Now;

            if (nowtime.Hour == dintime.Hour)
            {
                if (nowtime.Minute == dintime.Minute)
                {
                    Owner.Show();
                    Hide();

                }
            }

            if (nowtime.Hour == endtime.Hour)
            {
                if (nowtime.Minute == endtime.Minute)
                {
                    Owner.Show();
                    Hide();
                }
            }

        }
    }
}
