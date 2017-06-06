using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class University : Course
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string EmailID { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Value { get; set; }

        public virtual List<University> viewUniversity()
        {
            List<University> obj = new List<University>();
            return obj;
        }
        public University()
        {

        }

        public virtual int addUniversity(string name, string code, string phone, string emailid, string location, string address)
        {
            return 0;
        }
    }
}
