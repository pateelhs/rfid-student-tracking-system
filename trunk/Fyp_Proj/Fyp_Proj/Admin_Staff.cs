using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fyp_Proj
{
    public partial class Admin_Staff : Form
    {
        admin ad;
        ClAdmStf stf = new ClAdmStf();
        public Admin_Staff()
        {
            InitializeComponent();
        }
        public Admin_Staff(admin ad1)
        {
            ad = ad1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (stid.Text != "" && stname.Text != "" && sttype.Text != "" && stlog.Text != "" && stpass.Text != "")
            {
                string ret = stf.InsStf(stid.Text, stname.Text, sttype.Text, stlog.Text, stpass.Text, stpath.Text);
                MessageBox.Show(this, ret);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int indicator = 0;
            if (MessageBox.Show(this, "Delete Whole Staff Record", "Whole Record", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                if (MessageBox.Show(this, "Delete Staff Login info only", "Login Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    indicator = 2;
                }
            }
            else
            {
                indicator = 1;
            }
            // 1 delete whole record 2 delete login info
            string ret = stf.Delstaff(stid.Text, indicator);
            if (ret != null)
            {
                MessageBox.Show(this, ret);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string stid1 = "", stn = "", stt = "", lo = "", pass = "",file = "";
            bool error = false;
            stf.SeaStaff(stid.Text, ref stid1, ref stn, ref stt, ref lo, ref pass,ref file,ref error);
            if (error == false)
            {
                stid.Enabled = false;
                stid.Text = stid1;
                stname.Text = stn;
                sttype.Text = stt;
                stlog.Text = lo;
                stpass.Text = pass;
                stpath.Text = file;
                try
                {
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictureBox1.Image = Image.FromFile(file);
                }                
                catch (Exception ex)
                {
                    MessageBox.Show(this,ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "Record not Found");
            }
        }
        
        private void Button5_Click(object sender, EventArgs e)
        {
            string ret = stf.Updstaff(stid.Text, sttype.Text, stname.Text, stlog.Text, stpass.Text, stpath.Text);
            MessageBox.Show(this, ret);

            stid.Enabled = true;

            stlog.Enabled = true;
            stid.Clear();
            stname.Clear();
            stlog.Clear();
            stpass.Clear();
            stpath.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                stpath.Text = fb.FileName;
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            ad.Show();
            this.Dispose();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            stpath.Clear();
            //pictureBox1.Image = null;
            stname.Enabled = true;
            sttype.Text = "";
            stid.Clear();
            stname.Clear();
            stlog.Clear();
            stpass.Clear();
        }

        private void Admin_Staff_Load(object sender, EventArgs e)
        {

        }

        private void stpath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(stpath.Text);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
                string ret = ex.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}