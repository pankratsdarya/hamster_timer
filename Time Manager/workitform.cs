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
    public partial class workitform : Form
    {
        public workitform()
        {
            InitializeComponent();
        }

        private void Workitform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            
        }
    }
}
