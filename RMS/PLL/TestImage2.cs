using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using MySql.Data.MySqlClient;

namespace RMS.PLL
{
    public partial class TestImage2 : Form
    {
        RMSDBEntities _db = new RMSDBEntities();

        public TestImage2()
        {
            InitializeComponent();

        }

        private void TestImage2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _db.tbl_fooditems.ToList();
            dataGridView1.DataSource = _db.tbl_fooditems.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.tbl_fooditems.Where(x => x.Id == comboBox1.SelectedIndex).ToList();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.tbl_fooditems.Where(x => x.FoodName.Contains(SearchBox.Text)).ToList();
        }
    }
}
