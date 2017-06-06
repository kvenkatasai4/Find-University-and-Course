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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            int result = obj.addCourse(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            MessageBox.Show("New Course Added");
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();            
            DataTable dt = obj.GetUniversity();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }
    }
}
