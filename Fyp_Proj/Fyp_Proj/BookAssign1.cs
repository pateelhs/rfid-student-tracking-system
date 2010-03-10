using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fyp_Proj
{
    public partial class BookAssign1 : Form
    {
        ListBox t1=new ListBox();
        ListBox t2 = new ListBox();
        Librarian lib;

        public BookAssign1(Librarian l)
        {
            lib = l;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookAssign1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check;
            string n="", roll="", pic="";
            ClLibrarian lib = new ClLibrarian();

            check = lib.GetStudentInfo(textBox1.Text, ref n, ref roll, ref pic);

            if (check == 1)
            {
                label4.Text = n;
                label6.Text = roll;

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;

            }
            else
            {
                MessageBox.Show(this,"Student Not Found!");
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            ClLibrarian lib = new ClLibrarian();
            lib.SearchByName(textBox2.Text, ref listBox1, ref t1, ref t2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            if (t2.Items[ind].ToString()=="0")
            {
                label7.Text = "Book is Not Available!";
                button4.Enabled = false;

            }
            else
            {
                label7.Text = "Book is Available!";
                button4.Enabled = true;
           }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            lib.Show();
        }
    }
}