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
    public partial class UniversityDetailsForm : Form
    {
        public UniversityDetailsForm()
        {
            InitializeComponent();
        }

        private void UniversityDetailsForm_Load(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            dataGridView1.DataSource = obj.viewUniversity();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }
    }
}
