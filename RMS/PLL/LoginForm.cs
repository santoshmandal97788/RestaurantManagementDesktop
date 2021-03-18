
using RMS.PLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Threading;
using BLL;

namespace RMS
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(1500);
            trd.Abort();
           
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();
        private void formRun()
        {
            Application.Run(new SplashScreen());
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter UserName", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            var rd = blu.CheckUserLogin(txtUserName.Text, txtPassword.Text);

            if (txtUserName.Text == rd.Username)
            {
                if (txtPassword.Text == rd.Password)
                {
                    FinalDashboard fdf = new FinalDashboard();
                    fdf.Show();
                    Program.username = txtUserName.Text;

                }
            }
            else
            {
                MessageBox.Show("Error Login");
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Activate();
        }
    }
}


