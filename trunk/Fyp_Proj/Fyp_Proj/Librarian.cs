using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fyp_Proj
{
    public partial class Librarian : Form
    {
        Login log;
        public Librarian()
        {
            InitializeComponent();
        }
        public Librarian(Login log1)
        {
            log = log1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                BookAssign1 bookassign = new BookAssign1(this);
                this.Hide();
                bookassign.Show();
            }
        }

        private void Librarian_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }
    }
}