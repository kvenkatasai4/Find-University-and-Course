using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    interface Interface1
    {
        int UserRegistration(string name, string phone, string emailid, string password, string qualification, string address);

        int addUniversity(string name, string code, string phone, string emailid, string location, string address);

        DataTable GetUniversity();

        int addCourse(string universityname, string coursename, string fee, string duration, string about);
    }
}
