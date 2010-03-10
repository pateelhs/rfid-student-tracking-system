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
    class ClLogin
    {
        static string connstr = ConfigurationManager.ConnectionStrings["main"].ConnectionString.ToString();
        public string FuncLog(string un, string pass,string tas)
        {
           // string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = connstr;

            con1.Open();
            try
            {
                string qry = "select * from Login where loginid='" + un + "'AND pass='" + pass + "'AND rights='" + tas + "'";
                SqlCommand cmsel = new SqlCommand(qry, con1);
                SqlDataReader dr1 = cmsel.ExecuteReader();
                if (dr1.HasRows && tas != "Staff")
                {
                    con1.Close();
                    return "true";
                }
                else if (dr1.HasRows && tas == "Staff")
                {
                    dr1.Read();
                    string me = dr1[3].ToString();
                    con1.Close();
                    return me;
                }
                else
                {
                    con1.Close();
                    return "false";
                }
            }
            catch (Exception e)
            {
                string me = e.Message.ToString();
                me = "false";
                con1.Close();
                return me;           
            }
        }
    }
}
