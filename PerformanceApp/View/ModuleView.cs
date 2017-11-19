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
    public partial class ModuleView : Form
    {
        public Module Module { get; set; }

        public ModuleView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCredits.Text) || string.IsNullOrWhiteSpace(txtNoOfAssess.Text))
            {
                MessageBox.Show("Mandatory values missing", "Validation Error");
                return;
            }

            //check whether credits is in number
            int credits = 0;
            if (!int.TryParse(txtCredits.Text, out credits))
            {
                MessageBox.Show("Invalid Credit", "Validation Error");
                return;
            }
            int noOfAssessments = 0;
            if (!int.TryParse(txtNoOfAssess.Text, out noOfAssessments))
            {
                MessageBox.Show("Invalid No Of Assessment", "Validation Error");
                return;
            }

            Module module = new Module()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Credits = credits,
                Assessments = new List<Assessment>()
            };

           

            //List<Assessment> assList = new List<Assessment>();

            for (int i = 0; i < noOfAssessments; i++)
            {
                AssessmentView assessmentView = new AssessmentView();
                if (assessmentView.ShowDialog()==DialogResult.OK)
                {
                    //MessageBox.Show("ok detected!");
                    module.Assessments.Add(assessmentView.getAssessment());
                }
                /*else if (assessmentView.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("cancel detected!");
                }*/

                //assList.Add(assessmentView.getAssessment());
            }
            Module = module;
            this.DialogResult = DialogResult.OK;
            Close();
            //module.Assessments = assList;
        }
    }
}
