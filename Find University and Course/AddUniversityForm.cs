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
    public partial class AddUniversityForm : Form
    {
        public AddUniversityForm()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            int result = obj.addUniversity(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,richTextBox1.Text);
            MessageBox.Show("New University Added");

            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";
            textBox5.Text="";
            richTextBox1.Text = "";
        }
    }
}
