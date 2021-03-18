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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Please Enter First Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFirstName.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please Enter Email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please Enter Username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                if (cboUserType.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Choose User Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboUserType.Focus();
                    return;
                }
               
               
               
                UserDetails ud = new UserDetails();
                ud.FirstName = txtFirstName.Text;
                ud.LastName = txtLastName.Text;
                ud.Email = txtEmail.Text;
                ud.Username = txtUsername.Text;
                ud.Password = txtPassword.Text;
                ud.Usertype = cboUserType.Text;
              
                int i = blu.AddNewUser(ud);
                if (i > 0)
                {
                    //LoadGrid();
                    //Clear();
                    MessageBox.Show("New User Registered Successfully", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    e.Cancel = true;
                }
            }
        }
    }
}
