using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Fyp_Proj
{
    public partial class Admin_Faculty : Form
    {
        ClAdmFac fac = new ClAdmFac();
        admin ad;
        public Admin_Faculty()
        {
            InitializeComponent();
        }
        public Admin_Faculty(admin ad1)
        {
            ad = ad1;
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (fid.Text != "" && fname.Text != "" && flog.Text != "" && fpass.Text != "")
            {
                string ret = fac.Insfaculty(fid.Text, fname.Text, flog.Text, fpass.Text, fpath.Text);
                MessageBox.Show(this, ret);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Dispose();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string fid1 = "", fn = "", flo = "", fpass1 = "", file = "";
            bool error = false;
            fac.Seafaculty(fid.Text, ref fid1, ref fn, ref flo, ref fpass1, ref file, ref error);
            if (error == false)
            {
                fid.Enabled = false;
                fid.Text = fid1;
                fname.Text = fn;
                flog.Text = flo;
                fpass.Text = fpass1;
                fpath.Text = file;
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "Record not Found");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            flog.Enabled = true;
            fpath.Clear();
            pictureBox1.Image = null;
            fid.Enabled = true;
            fid.Clear();
            fname.Clear();
            flog.Clear();
            fpass.Clear();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string ret = fac.Updfaculty(fid.Text, fname.Text, flog.Text, fpass.Text, fpath.Text);
            MessageBox.Show(this, ret);

            fid.Enabled = true;

            flog.Enabled = true;
            fid.Clear();
            fname.Clear();
            flog.Clear();
            fpass.Clear();
            fpath.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int indicator = 0;
            if (MessageBox.Show(this, "Delete Whole Faculty Record", "Whole Record", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                if (MessageBox.Show(this, "Delete Faculty Login info only", "Login Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    indicator = 2;
                }
            }
            else
            {
                indicator = 1;
            }
            // 1 delete whole record 2 delete login info
            string ret = fac.Delfaculty(fid.Text, indicator);
            if (ret != null)
            {
                MessageBox.Show(this, ret);
            }
        }

        private void fpath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(fpath.Text);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
                string ret = ex.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                fpath.Text = fb.FileName;
            }   
        }
    }
}