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
    public partial class UpdateUniversity : Form
    {
        public UpdateUniversity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            DataTable dt;            
            dt = obj.searchUniversity(comboBox1.Text);
            if (dt.Rows.Count != 0)
            {
                textBox1.Text = dt.Rows[0]["Name"].ToString();
                textBox2.Text = dt.Rows[0]["Code"].ToString();
                textBox3.Text = dt.Rows[0]["Phone"].ToString();
                textBox4.Text = dt.Rows[0]["EmailID"].ToString();
                textBox5.Text = dt.Rows[0]["Location"].ToString();
                richTextBox1.Text = dt.Rows[0]["Address"].ToString();
            }            
        }

        private void UpdateUniversity_Load(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            DataTable dt = obj.GetUniversity();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            int result = obj.updateUniversity(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, richTextBox1.Text);
            MessageBox.Show("University Details Updated");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
        }
    }
}
