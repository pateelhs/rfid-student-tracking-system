using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
namespace Fyp_Proj
{
    public class ClStaff
    {
        static protected string connstr = ConfigurationManager.ConnectionStrings["main"].ConnectionString.ToString();
        public int GetStudentInfo(string id, ref string n, ref string roll, ref string pic)
        {
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();
            SqlDataReader dr1 = null;
            con1.ConnectionString = connstr;

            con1.Open();
            try
            {
                string qry = "select * from Student where tagid='" + id + "'";
                SqlCommand cmsel = new SqlCommand(qry, con1);
                dr1 = cmsel.ExecuteReader();

                if (dr1.HasRows)
                {
                    dr1.Read();
                    n = dr1[1].ToString();
                    roll = dr1[2].ToString();
                    pic = dr1[3].ToString();
                    con1.Close();
                    return 1;
                }

                con1.Close();
                return 0;
            }
            catch (Exception e)
            {
                string err = e.Message.ToString();
                return 0;
            }
        }

        public void ViewReport()
        {
        }
    }


    public class ClLibrarian : ClStaff
    {
        public void SearchByName(string name, ref ListBox lb, ref ListBox t1, ref ListBox t2)
        {
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();
            SqlDataReader dr1 = null;
            con1.ConnectionString = connstr;

            con1.Open();

            lb.Items.Clear();
            t1.Items.Clear();
            t2.Items.Clear();

            try
            {
                string qry = "select * from Book where bookname='" + name + "'";
                SqlCommand cmsel = new SqlCommand(qry, con1);
                dr1 = cmsel.ExecuteReader();

                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        t1.Items.Add(dr1[0].ToString());
                        t2.Items.Add(dr1[4].ToString());
                        lb.Items.Add(dr1[1].ToString() + "        " + dr1[2].ToString() + "       " + dr1[3].ToString());
                    }
                }

                con1.Close();
            }
            catch (Exception e)
            {
                string err = e.Message.ToString();
            }
        }


        public void AssignBook(int tagid, int bookid )
        {

        }
    }


    public class ClHostelAttendant : ClStaff
    {


    }

}
