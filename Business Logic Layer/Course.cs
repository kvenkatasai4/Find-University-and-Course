using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class Course
    {
        public int Id { get; set; }
        public string university { get; set; }
        public string CourseName { get; set; }
        public string Fee { get; set; }
        public string Duration { get; set; }
        public string Aboutcourse { get; set; }

        public Course()
        {
        }
        public virtual List<Course> viewCourse()
        {
            List<Course> obj = new List<Course>();
            return obj;
        }
        
    }
}
