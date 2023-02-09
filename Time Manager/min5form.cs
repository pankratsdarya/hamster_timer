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
    public partial class min5form : Form
    {
        int rmin, rsec, rinterval;
        

        private void Timer1s_Tick(object sender, EventArgs e)
        {
            timer1s.Start();           
            countdown();            
        }
              
        public min5form()
        {
            InitializeComponent();
        }
        
        private void Min5form_VisibleChanged(object sender, EventArgs e)
        {            
            if (Visible)
            {
                rinterval = 300 - 1;
                timer1s.Start(); 
                label1.Text = "5:00";
                label1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                timer1s.Stop(); 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Owner.Text = Owner.Text + 'К';
            Owner.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Owner.Text = Owner.Text + 'Ф';
            Owner.Show();
        }

        private void Min5form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();            
        }

        private void min5form_Load(object sender, EventArgs e)
        {
            label1.Text = "5:00";
            timer1s.Start();
            rinterval = 300;
        }

        public void countdown()
        {            
            if (rinterval == 0)
            {
                Hide();
                Owner.Text = Owner.Text + 'I';
                Owner.Show();                                               
            }
            else
            {
                rmin = Math.DivRem(rinterval, 60, out rsec);
                label1.Text = rmin.ToString() + ':' + rsec.ToString();
                if (rinterval < 60)
                    label1.ForeColor = System.Drawing.Color.Red;
                rinterval--;
            }
        }

       
    }
}
