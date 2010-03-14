using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
namespace WindowsApplication1
{
    class Attendance
    {       

     public void  Attendance_apply(string line)
     {
         string str2 = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID";
         string[] data = line.Split(',');
         SqlConnection conn = new SqlConnection(str2);
         string str1 = "SELECT * from Student where tagid = '" + data[1] + "'" ;
         SqlCommand query = new SqlCommand(str1 , conn);
         conn.Open();
         SqlDataReader redata = query.ExecuteReader();         
         while (redata.Read())
         {
             string st = redata[2].ToString();
            // Console.WriteLine(st);
         }
         conn.Close();
     }

    }
}
