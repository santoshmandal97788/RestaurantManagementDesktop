using BO;
using DAL;
using RMS.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.PLL
{
    public partial class Testdemo : Form
    {
        public Testdemo()
        {
            InitializeComponent();
        }
        RMSDBEntities _db = new RMSDBEntities();
        private void Testdemo_Load(object sender, EventArgs e)
        {

        }
     

        private void listItem1_pictureBoxClick(object sender, EventArgs e)
        {
            textBox1.Text = "worked";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           // Program.Vat = Convert.ToInt32(textBox1.Text);
        }
    }
}
