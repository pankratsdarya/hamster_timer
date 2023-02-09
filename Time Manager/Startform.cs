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
    public partial class Startform : Form
    {
        private timerform formtime = new timerform();
       
       
        public Startform()
        {
            InitializeComponent();
            AddOwnedForm(formtime);
            
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {                                   
            formtime.Show();
            Hide();          
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }
    }
}
