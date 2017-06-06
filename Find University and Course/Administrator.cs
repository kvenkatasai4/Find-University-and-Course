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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void addUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniversityForm obj = new AddUniversityForm();
            obj.Show();
        }

        private void viewUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversityDetailsForm obj = new UniversityDetailsForm();
            obj.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm obj = new AddCourseForm();
            obj.Show();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseDetailsForm obj = new CourseDetailsForm();
            obj.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            this.Hide();
            obj.Show();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Users obj = new View_Users();
            obj.Show();
        }

        private void updateUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUniversity obj = new UpdateUniversity();
            obj.Show();
        }
    }
}
