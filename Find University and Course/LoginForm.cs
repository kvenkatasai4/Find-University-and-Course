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
using System.Data.SqlClient;

namespace Find_University_and_Course
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            if (comboBox1.Text == "--Select--")
                MessageBox.Show("Please Select User Type");

            else if (comboBox1.Text == "Administrator" && textBox1.Text == "1" && textBox2.Text == "1")
            {
                Administrator Administrator = new Administrator();
                this.Hide();
                Administrator.Show();
                Administrator.Activate();                
            }
            else if (comboBox1.Text == "User")
            {
                SqlDataReader sdr = obj.UserLogin(textBox1.Text, textBox2.Text);
                if (sdr.Read())
                {
                    User user = new User();
                    this.Hide();
                    user.Show();
                    user.Activate();                    
                }
                else
                    MessageBox.Show("Please Enter Correct Details");
            }
            else
                MessageBox.Show("Please Enter Correct Details");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Registration_Form obj = new User_Registration_Form();
            this.Hide();
            obj.Show();
        }
    }
}
