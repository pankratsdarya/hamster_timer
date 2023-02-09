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
    public partial class gohomeform : Form
    {
        public gohomeform()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Owner.Text = Owner.Text + 'З';
            Owner.Show();
        }

        private void Gohomeform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
           
        }
    }
}
