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
    class ClAdministrator
    {
        static string connstr = ConfigurationManager.ConnectionStrings["main"].ConnectionString.ToString();
        public string InsAdmin(string un, string pass)
        {
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Insadmin", con1);
            cmd1.CommandType = CommandType.StoredProcedure;            
            cmd1.Parameters.AddWithValue("@un", un);
            cmd1.Parameters.AddWithValue("@pass", pass);
            cmd1.Parameters.AddWithValue("@rights", "Administrator"); 
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

        public void SeaAdmin(string tag,ref string login, ref string pass,ref bool error)
        {
            error = false;
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            con1.Open();
            SqlDataReader dr1 = null;
            SqlCommand cmsel = new SqlCommand("sp_seaadmin", con1);
            cmsel.CommandType = CommandType.StoredProcedure;
            cmsel.Parameters.AddWithValue("@tag", tag);
            dr1 = cmsel.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Read();
                login = dr1[0].ToString();
                pass = dr1[1].ToString();
            }

            else
            {
                error = true;
            }
            con1.Close();

        }

        public string UpdAdmin(string alog, string apass)
        {
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Updadmin", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@un", alog);
            cmd1.Parameters.AddWithValue("@pass", apass);
            try
            {
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "Password Changed";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
        public string DelAdmin(string tag)
        {
            //string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            SqlCommand cmd1 = new SqlCommand("sp_Deladmin", con1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@tag", tag);
            try
            {
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "Record Deleted";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }

}
