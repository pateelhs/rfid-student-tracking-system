using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fyp_Proj
{
    public partial class Admin_Admin : Form
    {
        ClAdministrator adm = new ClAdministrator();
        admin ad;
        public Admin_Admin()
        {
            InitializeComponent();
        }
        public Admin_Admin(admin ad1)
        {
            ad = ad1;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (alog.Text != "" && apass.Text != "")
            {
                string ret = adm.InsAdmin (alog.Text, apass.Text);
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
            string lo = "", pass = "";
            bool error = false;
            adm.SeaAdmin (alog.Text, ref lo, ref pass, ref error);
            if (error == false)
            {
                alog.Enabled = false;
                alog.Text = lo;           
                apass.Text = pass;                          
            }
            else
            {
                MessageBox.Show(this, "Record not Found");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            alog.Enabled = true;
            alog.Clear();
            apass.Clear();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string ret = adm.UpdAdmin(alog.Text, apass.Text);
            MessageBox.Show(this, ret);

            alog.Enabled = true;


            alog.Clear();
            apass.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you Sure you want to Delete Administrator Record '" + alog.Text + "'", "Admin Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ret = adm.DelAdmin (alog.Text);
                if (ret != null)
                {
                    MessageBox.Show(this, ret);
                }
                alog.Clear();
                alog.Enabled = true;
                apass.Clear();

            }           
        }
    }
}