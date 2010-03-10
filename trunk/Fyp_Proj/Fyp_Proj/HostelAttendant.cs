using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fyp_Proj
{
    public partial class HostelAttendant : Form
    {
        Login log;
        public HostelAttendant(Login log1)
        {
            log = log1;
            InitializeComponent();
        }

        private void HostelAttendant_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                RoomAssign Rassign = new RoomAssign(this);
                this.Hide();
                Rassign.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }
    }
}