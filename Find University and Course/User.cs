using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_University_and_Course
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void searchUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUniversityForm obj = new SearchUniversityForm();
            obj.Show();
        }

        private void searchCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCourseForm obj = new SearchCourseForm();
            obj.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            this.Hide();
            obj.Show();
        }
    }
}
