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
    public partial class AssessmentUC : UserControl
    {
        private Assessment assessment;

        public Assessment Assessment
        {
            get
            {
                assessment.Mark = decimal.Parse(txtMark.Text);
                assessment.Name = (txtName.Text);
                assessment.Weight = decimal.Parse(txtWeight.Text);
                return assessment;
            }
            set
            {
                assessment = value;
                if (value == null)
                {
                    assessment = new Assessment();
                }
                txtName.Text = assessment.Name;
                txtMark.Text = assessment.Mark + "";
                txtWeight.Text = assessment.Weight + "";
            }
        }

        public AssessmentUC(Assessment assessment)
        {
            InitializeComponent();
            this.Assessment = assessment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var value = this.Assessment;
        }
    }
}
