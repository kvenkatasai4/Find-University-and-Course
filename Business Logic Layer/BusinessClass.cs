using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace Business_Logic_Layer
{
    public class BusinessClass : University
    {
        public int UserRegistration(string name, string phone, string emailid, string password, string qualification, string address)
        {
            DataClass obj = new DataClass();
            
            return obj.UserRegistration(name, phone, emailid, password, qualification, address);
        }        
        
        public override int addUniversity(string name, string code, string phone, string emailid, string location, string address)
        {
            DataClass obj = new DataClass();

            return obj.addUniversity(name, code, phone, emailid, location, address);
        }

        public  int updateUniversity(string name, string code, string phone, string emailid, string location, string address)
        {
            DataClass obj = new DataClass();

            return obj.updateUniversity(name, code, phone, emailid, location, address);
        }

        public DataTable GetUniversity()
        {
            DataClass obj = new DataClass();
            DataTable set = new DataTable();
            set = obj.GetUniversity();
            return set;
        }

        public DataTable ViewUsers()
        {
            DataClass obj = new DataClass();
            DataTable set = new DataTable();
            set = obj.ViewUsers();
            return set;
        }

        public int addCourse(string universityname, string coursename, string fee, string duration, string about)
        {
            DataClass obj = new DataClass();

            return obj.addCourse(universityname, coursename, fee, duration, about);
        }

        public override List<University> viewUniversity()
        {
            DataClass obj = new DataClass();
            DataTable dt = new DataTable();
            List<University> listuni = new List<University>();
            dt = obj.viewUniversity();
            foreach (DataRow dr in dt.Rows)
            {
                University uni = new University();
                uni.Id = Convert.ToInt32(dr["Id"].ToString());
                uni.Name = dr["Name"].ToString();
                uni.Code = dr["Code"].ToString();
                uni.Phone = dr["Phone"].ToString();
                uni.EmailID = dr["EmailID"].ToString();
                uni.Location = dr["Location"].ToString();
                uni.Address = dr["Address"].ToString();
                listuni.Add(uni);
            }                      
            return listuni;
        }

        public override List<Course> viewCourse()
        {
            DataClass obj = new DataClass();
            DataTable dt = new DataTable();
            
            List<Course> listcourse = new List<Course>();
            dt = obj.viewCourse();
            foreach (DataRow dr in dt.Rows)
            {
                Course course = new Course();
                course.Id = Convert.ToInt32(dr["Id"].ToString());
                course.university = dr["UniversityName"].ToString();
                course.CourseName = dr["CourseName"].ToString();
                course.Fee = dr["Fee"].ToString();
                course.Duration = dr["Duration"].ToString();
                course.Aboutcourse = dr["AboutCourse"].ToString();
                listcourse.Add(course);
            }
            return listcourse;
        }

        public DataTable searchUniversity(string universityname)
        {            
            DataClass obj = new DataClass();
            DataTable set = new DataTable();
            set = obj.searchUniversity(universityname);
            return set;
        }

        public DataTable searchCourse(string coursename)
        {
            DataClass obj = new DataClass();
            DataTable set = new DataTable();
            set = obj.searchCourse(coursename);
            return set;
        }

        public SqlDataReader UserLogin(string emailid, string password)
        {
            DataClass obj = new DataClass();
            SqlDataReader sdr;
            sdr = obj.UserLogin(emailid, password);
            return sdr;           
        }
    }
}