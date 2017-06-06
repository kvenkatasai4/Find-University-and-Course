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
    public partial class SearchCourseForm : Form
    {
        public SearchCourseForm()
        {
            InitializeComponent();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            dataGridView1.DataSource = obj.searchCourse(textBox1.Text);
        }
    }
}
