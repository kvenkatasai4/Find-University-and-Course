using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Find_University_and_Course
{
    public partial class View_Users : Form
    {
        public View_Users()
        {
            InitializeComponent();
        }

        private void View_Users_Load(object sender, EventArgs e)
        {
            List<Users> userlist = new List<Users>();
            BusinessClass obj = new BusinessClass();

            DataTable dt = obj.ViewUsers();
            foreach (DataRow dr in dt.Rows)
            {
                userlist.Add(new Users(dr["Id"].ToString(), dr["Name"].ToString(), dr["Phone"].ToString(), dr["EmailID"].ToString(), dr["Qualification"].ToString(), dr["Address"].ToString()));                
            }
            var query = from users in userlist                        
                        select users;

            foreach (Users user in query)
            {
                listBox1.Items.Add(user.ToString());
            }
        }
    }
}
