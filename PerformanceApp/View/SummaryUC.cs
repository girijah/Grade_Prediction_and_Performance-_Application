using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceApp
{
    public partial class SummaryUC : UserControl
    {
        private Course course;

        public Course Course
        {
            get { return course; }
            set
            {
                course = value;
                txtCourse.Text = course.CourseName;
                txtStanding.Text = course.Standing;
            }
        }

        public SummaryUC(Course course)
        {
            InitializeComponent();
            this.Course = course;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Course = Course;
        }

        public void Refresh()
        {
            this.Course = Course;
        }
    }
}
