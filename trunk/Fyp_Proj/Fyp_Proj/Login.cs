using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Fyp_Proj
{
    public partial class Login : Form
    {
        private TextBox un;
        public Login()
        {
            InitializeComponent();
        }

        private void un_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            ClLogin log1 = new ClLogin();
            string ret = log1.FuncLog(un.Text, pass.Text, cb1.Text);
            if (ret == "false")
            {
                MessageBox.Show (this,"Login Unsuccessful");
            }else if(ret == "true")
            {
                if (cb1.Text == "Administrator")
                {
                    this.Hide();
                    admin a = new admin(un.Text,this);
                    a.Show();
                }
                    if(cb1.Text == "Student")
                    {
                        MessageBox.Show(this, "0");
                //        this.Hide();
                //        student.Show();
                    }
                    if (cb1.Text == "Faculty")
                    {
                        MessageBox.Show (this,"1");
                //        this.Hide();
                //        faculty.Show();
                    }
            }else
            {
                    if (ret == "Librarian")
                    {
                        this.Hide();
                        Librarian Librar = new Librarian(this);
                        Librar.Show();
                    }
                    else
                    if (ret == "HostelAttendant")
                    {
                            this.Hide();
                            HostelAttendant ha = new HostelAttendant(this);
                            ha.Show();
                    }
            }
            log1 = null;
        }
           
       
       
        private void Login_Load(object sender, EventArgs e)
        {
            un.Clear();
            pass.Clear();
            cb1.Text = "";
        }
        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Login_Activated_1(object sender, EventArgs e)
        {
            this.Opacity = 1;
            un.Clear();
            pass.Clear();
            cb1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Map mObj = new Map();
            mObj.Show();
        }

       

    }
}