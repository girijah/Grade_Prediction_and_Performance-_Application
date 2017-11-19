using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceApp
{
    public partial class AssessmentView : Form
    {
        Assessment ass;

        public AssessmentView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide();
            decimal weightage = 0;
            if (!decimal.TryParse(txtWeightage.Text, out weightage))
            {
                MessageBox.Show("Invalid weightage", "Validation Error");
                return;
            }

            decimal marks = 0;
            if (!decimal.TryParse(txtMarks.Text, out marks))
            {
                MessageBox.Show("Invalid marks", "Validation Error");
                return;
            }

            ass = new Assessment();
            ass.Name = txtAssessType.Text;
            ass.Weight = weightage;
            ass.Mark = marks;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public Assessment getAssessment()
        {
            return ass;
        }
    }
}
