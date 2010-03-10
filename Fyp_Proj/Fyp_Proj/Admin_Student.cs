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
    public partial class Admin_Student : Form
    {
        ClAdmStu stu = new ClAdmStu();
        
        private string name;
        private admin ad;

        public Admin_Student()
        {
            InitializeComponent();
        }

        public Admin_Student(string nm,admin adm)
        {
            name = nm;
            ad = adm;
            InitializeComponent();
        }
        
        private void Admin_Student_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(stag.Text!="" && sname.Text!="" && sroll.Text!="" && slog.Text!="" && spass.Text!="")
            {
                 string ret =  stu.InsStudent(stag.Text,sname.Text,sroll.Text,slog.Text,spass.Text,path.Text );
                 MessageBox.Show (this, ret);
        }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //admin ad = new admin();
            ad.Show();
            this.Dispose();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string tag = "", sn = "", sr = "", lo = "", pass = "",file = "";
            bool error = false;
            stu.SeaStudent(stag.Text, ref tag, ref sn, ref sr, ref lo, ref pass,ref file,ref error);
            if (error == false)
            {
                stag.Enabled = false;
                stag.Text = tag;
                sname.Text = sn;
                sroll.Text = sr;
                slog.Text = lo;
                spass.Text = pass;
                path.Text = file;
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(file);
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

        private void slog_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            path.Clear();
            pictureBox1.Image = null;
            stag.Enabled = true;
            stag.Clear();
            sname.Clear();
            sroll.Clear();
            slog.Clear();
            spass.Clear();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string ret = stu.UpdStudent(stag.Text, sname.Text, sroll.Text, slog.Text, spass.Text,path.Text);
            MessageBox.Show(this, ret);

            stag.Enabled = true;


            stag.Clear();
            sname.Clear();
            sroll.Clear();
            slog.Clear();
            spass.Clear();
            path.Clear();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int indicator = 0;
            if (MessageBox.Show(this, "Delete Whole Student Record", "Whole Record", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                if (MessageBox.Show(this, "Delete Student Login info only", "Login Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    indicator = 2;
                }             
            }
            else {
                indicator = 1; 
            }
           // 1 delete whole record 2 delete login info
            string ret = stu.DelStudent(stag.Text, indicator);
            if (ret != null)
            {
                MessageBox.Show(this,ret);
            }
        }

        private void path_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(path.Text);
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
            if(fb.ShowDialog() == DialogResult.OK )
            {
                path.Text = fb.FileName ;
            }   
        }

        private void Admin_Student_activated(object sender, EventArgs e)
        {
        }
    }
}
 