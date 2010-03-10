using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Fyp_Proj
{
    public partial class admin : Form
    {
        //private Login log = new Login();
        Login log = null;
        private string name;
        public admin()
        {

            InitializeComponent();
        }
        public admin(string val,Login loged)
        {
            log = loged;
            name = val;
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Dispose();
            this.Close();
        }

        private void tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            tx.Text = name;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin_Student astu = new Admin_Student(name,this);
            astu.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Admin_Faculty afac = new Admin_Faculty(this);
            afac.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Admin_Admin admin = new Admin_Admin(this);
            admin.Show();
            this.Hide();
        }

        private void admin_Activated(object sender, EventArgs e)
        {
            tx.Text = name;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Admin_Staff asta = new Admin_Staff(this);
            asta.Show();
            this.Hide();
        }
    }
}