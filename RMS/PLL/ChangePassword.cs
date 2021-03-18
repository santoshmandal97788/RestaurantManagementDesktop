using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.PLL
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // var dt = blu.CheckUserLogin(Program.username, txtOldPassword.Text);
            //UserDetails ud = new UserDetails();
            //ud.id = dt.id;
            //ud.FirstName = dt.FirstName;
            //ud.LastName = dt.LastName;
            //ud.Email = dt.Email;
            //ud.Username = dt.Username;
            //ud.Password = txtConfirmPassword.Text;
            //ud.Usertype = dt.Usertype;

            var dt = blu.CheckUserLogin(Program.username, txtOldPassword.Text);
            if (dt!= null)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    int i = blu.UpdatePassword(Program.username, txtConfirmPassword.Text);
                    if (i > 0)
                    {
                        MessageBox.Show("Password Changed Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Password Mismatch");
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = string.Empty;
                    txtConfirmPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password");
                txtOldPassword.Text = "";
                txtOldPassword.Focus();
            }
        }
    }
}
