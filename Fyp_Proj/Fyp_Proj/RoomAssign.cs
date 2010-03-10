using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fyp_Proj
{
    public partial class RoomAssign : Form
    {

        HostelAttendant HA;

        public RoomAssign(HostelAttendant h)
        {
            HA = h;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RoomAssign_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check;
            string n="", roll="", pic="";
            ClHostelAttendant HostAtt = new ClHostelAttendant();

            check = HostAtt.GetStudentInfo(textBox1.Text, ref n, ref roll, ref pic);

            if (check == 1)
            {
                label4.Text = n;
                label6.Text = roll;

            }
            else
            {
                MessageBox.Show(this,"Student Not Found!");
               
            }   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HA.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}