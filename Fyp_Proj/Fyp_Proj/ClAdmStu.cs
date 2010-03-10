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
    class ClAdmStu
    {
        static string connstr = ConfigurationManager.ConnectionStrings["main"].ConnectionString.ToString();
        public string InsStudent(string tag,string name,string roll,string un,string pass,string pic)
        {
            //string connstr = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Insstudent", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@tag", tag);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@roll", roll);
            cmd1.Parameters.AddWithValue("@un", un);
            cmd1.Parameters.AddWithValue("@pass", pass);
            cmd1.Parameters.AddWithValue("@rights", "Student");
            cmd1.Parameters.AddWithValue("@pic", pic);
            try
            {
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "Data Inserted";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }




        public void SeaStudent(string tag,ref string tag1,ref string sname,ref string sroll,ref string login,ref string pass,ref string path,ref bool error)
        {
            error = false;
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();
            SqlConnection con2 = new SqlConnection();

            con1.ConnectionString = connstr;
            con2.ConnectionString = connstr;

            con1.Open();
            con2.Open();
            SqlDataReader dr1 = null, dr2 = null;
            SqlCommand cmsel = new SqlCommand("sp_seastudent", con1);
            cmsel.CommandType = CommandType.StoredProcedure;
            cmsel.Parameters.AddWithValue("@tag",tag);
            dr1 = cmsel.ExecuteReader();
            SqlCommand cmsel1 = new SqlCommand("sp_sealog", con2);
            cmsel1.CommandType = CommandType.StoredProcedure;
            cmsel1.Parameters.AddWithValue("@tag", tag);
            dr2 = cmsel1.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Read();
                tag1 = dr1[0].ToString();
                sname = dr1[1].ToString();
                sroll = dr1[2].ToString();
                path = dr1[3].ToString();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    login = dr2[0].ToString();
                    pass = dr2[1].ToString();
                }
            }
           
            else
            {
                error = true;
            }
            con1.Close();
            con2.Close();
          
        }
        public string UpdStudent(string tag,string sname,string sroll,string slog,string spass,string pic)
        {
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();
            
            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Updstudent", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@tag", tag);
            cmd1.Parameters.AddWithValue("@name", sname);
            cmd1.Parameters.AddWithValue("@roll", sroll);
            cmd1.Parameters.AddWithValue("@un", slog);
            cmd1.Parameters.AddWithValue("@pass", spass);
            cmd1.Parameters.AddWithValue("@rights", "Student");
            cmd1.Parameters.AddWithValue("@pic", pic);
            try
            {
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "Data Updated";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
        public string DelStudent(string tag, int indicator)
        {
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            string sp_name, retval ;
            if (indicator == 1)
            {
                sp_name = "sp_Delstudent";
                retval = "Whole student record against '" + tag + "' Deleted";
            }
            else if (indicator == 2)
            {
                sp_name = "sp_Delstudentlogin";
                retval = "Login Info against '" + tag + "' Deleted";
            }
            else
            {
                return null;
            }
            SqlCommand cmd1 = new SqlCommand(sp_name, con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@tag", tag);
            try
            {
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return retval;
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
