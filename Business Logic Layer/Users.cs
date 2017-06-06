using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class Users
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EmailID { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }

        public Users(string id, string name, string phone, string email, string qualification, string add)
        {
            Id = id;
            Name = name;
            Phone = phone;
            EmailID = email;
            Qualification = qualification;
            Address = add;
        }
        public Users()
        {

        }        
        public override string ToString()
        {
            return "UserId: " + Id + "   Name: " + Name + "   Phone Number: " + Phone + "   EmailID: " + EmailID + "   Qualification: " + Qualification + "   Address: " + Address;
        }
    }
}
