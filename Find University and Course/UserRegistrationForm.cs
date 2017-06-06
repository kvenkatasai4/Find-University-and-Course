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
    public partial class User_Registration_Form : Form
    {
        public User_Registration_Form()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();

            int result = obj.UserRegistration(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,comboBox1.Text,richTextBox1.Text);
            MessageBox.Show("User Registered Successfully");
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
