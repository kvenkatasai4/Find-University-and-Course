using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DataClass: Interface1
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        //SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Projects\Latest\Sai Kiran\Find University and Course\Data Access Layer\Database1.mdf;Integrated Security=True");
        public int UserRegistration(string name, string phone, string emailid, string password, string qualification, string address)
        {
             
                if (sqlconn.State == ConnectionState.Open)
                    sqlconn.Close();
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "insert into Users values('" + name + "','" + phone + "','" + emailid + "','" + password + "','" + qualification + "','" + address + "')";
                sqlcmd.Connection = sqlconn;
                int resutl = sqlcmd.ExecuteNonQuery();
                return resutl;
        }

        public int addUniversity(string name,string code, string phone, string emailid, string location, string address)
        {
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "insert into University values('" + name + "','" + code + "','" + phone + "','" + emailid + "','" + location + "','" + address + "')";
            sqlcmd.Connection = sqlconn;
            int resutl = sqlcmd.ExecuteNonQuery();
            return resutl;
        }

        public int updateUniversity(string name, string code, string phone, string emailid, string location, string address)
        {
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "update University set Code='" + code + "',Phone='" + phone + "',EmailID='" + emailid + "',Location='" + location + "',Address='" + address + "' where Name='" + name + "'";
            sqlcmd.Connection = sqlconn;
            int resutl = sqlcmd.ExecuteNonQuery();
            return resutl;
        }

        public DataTable GetUniversity()
        {
            DataTable set = new DataTable();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select Name from University";
            sqlcmd.Connection = sqlconn;
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(set);
            return set;
        }

        public DataTable ViewUsers()
        {
            DataTable set = new DataTable();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from Users";
            sqlcmd.Connection = sqlconn;
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(set);
            return set;
        }   

        public int addCourse(string universityname, string coursename, string fee, string duration, string about)
        {
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "insert into Course values('" + universityname + "','" + coursename + "','" + fee + "','" + duration + "','" + about + "')";
            sqlcmd.Connection = sqlconn;
            int resutl = sqlcmd.ExecuteNonQuery();
            return resutl;
        }

        public DataTable viewUniversity()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from University";
            sqlcmd.Connection = sqlconn;
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(dt);
            return dt;
        }


        public DataTable viewCourse()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from Course";
            sqlcmd.Connection = sqlconn;
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(dt);
            return dt;
        }
        public DataTable searchUniversity(string universityname)
        {
            DataTable set = new DataTable();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select Name,Code,Phone,EmailID,Location,Address,CourseName,Fee,Duration,AboutCourse from University inner join Course on University.Name=Course.UniversityName where University.Name='" + universityname + "'";
            sqlcmd.Connection = sqlconn;
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(set);
            return set;
        }

        public DataTable searchCourse(string coursename)
        {
            DataTable set = new DataTable();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select Name,Code,Phone,EmailID,Location,Address,CourseName,Fee,Duration,AboutCourse from University inner join Course on University.Name=Course.UniversityName where Course.CourseName='" + coursename + "'";
            sqlcmd.Connection = sqlconn;
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            sqladapter.Fill(set);
            return set;
        }

        public SqlDataReader UserLogin(string emailid, string password)
        {
            SqlDataReader sdr;
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from Users where EmailID='" + emailid + "' and Password='" + password + "'";
            sqlcmd.Connection = sqlconn;
            sdr = sqlcmd.ExecuteReader();
            return sdr;
        }
    }
}
