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
         DateTime date = DateTime.Parse(data[4]);
         string format = "HH:mm";
         string str3 = "SELECT * from CourseTrans where tid = '" + data[0] + "' AND (day1 = '" + System.DateTime.Now.DayOfWeek + "' OR day2 = '" + System.DateTime.Now.DayOfWeek + "') AND starttime <= '" + date.ToString(format) + "' AND endtime > '" + date.ToString(format) + "'";         
         SqlConnection conn1 = new SqlConnection(str2);
         SqlCommand query1 = new SqlCommand(str3, conn1);         
         conn.Open();
         SqlDataReader redata = query.ExecuteReader();

         string rollno = "";
         while (redata.Read())
         {
             rollno = redata[2].ToString();
            // Console.WriteLine(st);
         }
         conn.Close();


         string courseid = "" ;
         DateTime starttime = new DateTime();         
         int limit = 0;
         conn1.Open();
         SqlDataReader rexdata = query1.ExecuteReader();


         while (rexdata.Read())
         {
             courseid = rexdata[0].ToString();
             starttime = Convert.ToDateTime(rexdata[2].ToString());             
             limit = Convert.ToInt32(rexdata[4].ToString());
         }
         conn1.Close();


         DateTime st1 = new DateTime();
         st1 = starttime.AddMinutes(limit);
         DateTime now = DateTime.Now;
         


         string str4 = "SELECT * from stdcourse where tagid = '" + data[1] + "' AND cid = '" + courseid + "'";
         string status;
         if (now < st1 && now >= starttime)         
         status = "P";
         else
         status = "A";
         SqlConnection conn5 = new SqlConnection(str2);
         SqlCommand queryx = new SqlCommand(str4, conn5);
         conn5.Open();
         SqlDataReader redata1 = queryx.ExecuteReader();
         if (redata1.HasRows && status == "P")
         {
             SqlConnection conn3 = new SqlConnection(str2);
             SqlCommand queryx1 = new SqlCommand("sp_attendance", conn3);
             queryx1.CommandType = CommandType.StoredProcedure;
             queryx1.Parameters.AddWithValue("@tagid", data[1]);
             queryx1.Parameters.AddWithValue("@date1", now.Date);
             queryx1.Parameters.AddWithValue("@roll", rollno);
             queryx1.Parameters.AddWithValue("@courseid", courseid);
             conn3.Open();
             queryx1.ExecuteNonQuery();             
             conn3.Close();
         }
         conn5.Close();


     }
         
    }
}
