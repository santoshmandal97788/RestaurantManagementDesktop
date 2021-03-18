using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RMS.User_Controls
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            txtServiceCharge.Text = Properties.Settings.Default.ServiceCharge.ToString();
            txtVAT.Text = Properties.Settings.Default.VAT.ToString();
            txtCompanyName.Text = Properties.Settings.Default.Name;

            //string base64String = Properties.Settings.Default.Logo;
            //byte[] imageBytes = Convert.FromBase64String(base64String);
            
           // MemoryStream ms = new MemoryStream();

            // Convert byte[] to Image
            //ms.Write(imageBytes, 0, imageBytes.Length);
            //System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);

            //pictureBoxLogo.Image = Image.FromStream(ms);
            //MemoryStream ms = new MemoryStream();

            //pictureBoxLogo.Image.Save(ms, pictureBoxLogo.Image.RawFormat);
            //byte[] img = ms.ToArray();
            // Convert byte[] to Base64 String
        
            // Convert Base64 String to byte[]
          

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (txtServiceCharge.Text == "")
            {
                MessageBox.Show("Please Enter Service Charge", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceCharge.Focus();
                return;
            }
            if (txtVAT.Text == "")
            {
                MessageBox.Show("Please Enter VAT Rate", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVAT.Focus();
                return;
            }
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("Please Enter Company Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceCharge.Focus();
                return;
            }
            if (pictureBoxLogo.ImageLocation == Application.StartupPath + "\\add-user.png")
            {
                MessageBox.Show("Please Upload Company Logo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBoxLogo.Focus();
                return;
            }
            MemoryStream ms = new MemoryStream();
          
            //pictureBoxLogo.Image.Save(ms, pictureBoxLogo.Image.RawFormat);
            //byte[] img = ms.ToArray();
            // Convert byte[] to Base64 String
            //string base64String = Convert.ToBase64String(img);
            Properties.Settings.Default.ServiceCharge = Convert.ToDouble(txtServiceCharge.Text);
            Properties.Settings.Default.VAT = Convert.ToDouble(txtVAT.Text);
            Properties.Settings.Default.Name = txtCompanyName.Text;
            //Properties.Settings.Default.Logo = base64String;
          
            Properties.Settings.Default.Save();
            MessageBox.Show("Saved Settings");
            Application.Restart();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(opf.FileName);
            }
            btnRemoveImage.Visible = true;
            btnUploadImage.Visible = false;
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = Application.StartupPath + "\\add-user.png";
            btnUploadImage.Visible = true;
            btnRemoveImage.Visible = false;
        }

        //private void btnUploadImage_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog opf = new OpenFileDialog();

        //    opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

        //    if (opf.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBoxLogo.Image = Image.FromFile(opf.FileName);
        //    }
        //    btnRemoveImage.Visible = true;
        //    btnUploadImage.Visible = false;
        //}

        //private void btnRemoveImage_Click(object sender, EventArgs e)
        //{
        //    pictureBoxLogo.ImageLocation = Application.StartupPath + "\\add-user.png";
        //    btnUploadImage.Visible = true;
        //    btnRemoveImage.Visible = false;
        //}

        //private void btnSaveSettings_Click(object sender, EventArgs e)
        //{

        //    if (txtServiceCharge.Text=="")
        //    {
        //        MessageBox.Show("Please Enter Service Charge", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtServiceCharge.Focus();
        //        return;
        //    }
        //    if (txtVAT.Text == "")
        //    {
        //        MessageBox.Show("Please Enter VAT Rate", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtVAT.Focus();
        //        return;
        //    }
        //    if (txtCompanyName.Text == "")
        //    {
        //        MessageBox.Show("Please Enter Company Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtServiceCharge.Focus();
        //        return;
        //    }
        //    //if (pictureBoxLogo.ImageLocation == Application.StartupPath + "\\add-user.png")
        //    //{
        //    //    MessageBox.Show("Please Upload Company Logo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    pictureBoxLogo.Focus();
        //    //    return;
        //    //}
        //    MemoryStream ms = new MemoryStream();
        //    pictureBoxLogo.Image.Save(ms, pictureBoxLogo.Image.RawFormat);
        //    byte[] img = ms.ToArray();
        //    Properties.Settings.Default.ServiceCharge = Convert.ToDouble(txtServiceCharge.Text);
        //    Properties.Settings.Default.VAT = Convert.ToDouble(txtVAT.Text);
        //    Properties.Settings.Default.Name = txtCompanyName.Text;
        //    //Properties.Settings.Default.Logo = Convert.ToByte(img);
        //    Properties.Settings.Default.Save();
        //    MessageBox.Show("Saved Settings");
        //    //Application.Restart();
        //}



        //private void SettingsUserControl_Load(object sender, EventArgs e)
        //{
        //    txtServiceCharge.Text = Properties.Settings.Default.ServiceCharge.ToString();
        //    txtVAT.Text = Properties.Settings.Default.VAT.ToString();
        //    txtCompanyName.Text = Properties.Settings.Default.Name;
        //}

        //byte img = (byte)Properties.Settings.Default.Logo;

        //MemoryStream ms = new MemoryStream(img);

        //pictureBoxLogo.Image = Image.FromStream(ms);

    }
}
