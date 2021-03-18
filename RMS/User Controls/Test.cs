using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.PLL;

namespace RMS.User_Controls
{
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Testdemo frm = new Testdemo();
            frm.textBox1.Text = button1.Text;
        }
    }
}
