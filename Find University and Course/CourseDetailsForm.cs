﻿using Business_Logic_Layer;
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
    public partial class CourseDetailsForm : Form
    {
        public CourseDetailsForm()
        {
            InitializeComponent();
        }

        private void CourseDetailsForm_Load(object sender, EventArgs e)
        {
            BusinessClass obj = new BusinessClass();
            dataGridView1.DataSource = obj.viewCourse();
        }
    }
}
