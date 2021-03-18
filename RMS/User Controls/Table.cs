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
using BO;
using BLL;

namespace RMS.User_Controls
{
    public partial class Table : UserControl
    {

        public Table()
        {
            InitializeComponent();
        }
        BLLTable blt = new BLLTable();
        private void btnNew_Click(object sender, EventArgs e)
        {
            AddTable tbl = new AddTable();
            if (tbl.ShowDialog() == DialogResult.OK)
            {
                LoadGrid();
            }
        }
        private void LoadGrid()
        {
            List<TableDetails> lsttable = blt.GetAllTables();
            grdTable.DataSource = lsttable;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            List<TableDetails> lsttd = blt.GetAllTables().Where(s => s.TableNumber.StartsWith(bunifuMetroTextbox1.Text)).ToList();
            grdTable.DataSource = lsttd;
        }
        public int tableId = 0;
        private void grdTable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tableId = Convert.ToInt32(grdTable.CurrentRow.Cells[0].Value.ToString());

            //this.Hide();
            var table = blt.GetAllTables().Where(s => s.Id == tableId).FirstOrDefault();
            TableUpdateDelete frm = new TableUpdateDelete();
            frm.Show();
            frm.txtTableNumber.Text = table.TableNumber;
            frm.txtId.Text = tableId.ToString();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            AddTable frm = new AddTable();
            frm.Show();
        }
    }
}
