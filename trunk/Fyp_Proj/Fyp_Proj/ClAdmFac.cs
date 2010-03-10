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
    class ClAdmFac
    {
        static string connstr = ConfigurationManager.ConnectionStrings["main"].ConnectionString.ToString();
        public string Insfaculty(string id, string name, string un, string pass, string pic)
        {
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Insfaculty", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@un", un);
            cmd1.Parameters.AddWithValue("@pass", pass);
            cmd1.Parameters.AddWithValue("@rights", "Faculty");
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

        public void Seafaculty(string id, ref string id1, ref string fname, ref string flogin, ref string fpass, ref string fpath, ref bool error)
        {
            error = false;
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();
            SqlConnection con2 = new SqlConnection();

            con1.ConnectionString = connstr;
            con2.ConnectionString = connstr;

            con1.Open();
            con2.Open();
            SqlDataReader dr1 = null, dr2 = null;
            SqlCommand cmsel = new SqlCommand("sp_seafaculty", con1);
            cmsel.CommandType = CommandType.StoredProcedure;
            cmsel.Parameters.AddWithValue("@id", id);
            dr1 = cmsel.ExecuteReader();
            SqlCommand cmsel1 = new SqlCommand("sp_seaflog", con2);
            cmsel1.CommandType = CommandType.StoredProcedure;
            cmsel1.Parameters.AddWithValue("@tag", id);
            dr2 = cmsel1.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Read();
                id1 = dr1[0].ToString();
                fname = dr1[1].ToString();
                fpath = dr1[2].ToString();
                if (dr2.HasRows)
                {
                    dr2.Read();
                    flogin = dr2[0].ToString();
                    fpass = dr2[1].ToString();
                }
            }

            else
            {
                error = true;
            }
            con1.Close();
            con2.Close();
        }
        public string Updfaculty(string fid, string fname, string flog, string fpass, string pic)
        {
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Updfaculty", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@tag", fid);
            cmd1.Parameters.AddWithValue("@name", fname);
            cmd1.Parameters.AddWithValue("@un", flog);
            cmd1.Parameters.AddWithValue("@pass", fpass);
            cmd1.Parameters.AddWithValue("@rights", "Faculty");
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
        
        public string Delfaculty(string tag, int indicator)
        {
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            string sp_name, retval;
            if (indicator == 1)
            {
                sp_name = "sp_Delfaculty";
                retval = "Whole faculty record against '" + tag + "' Deleted";
            }
            else if (indicator == 2)
            {
                sp_name = "sp_Delfacultylogin";
                retval = "Login Info against Faculty of '" + tag + "' Deleted";
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
