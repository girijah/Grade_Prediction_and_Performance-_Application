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
    public partial class ModuleUC : UserControl
    {
        private Module module;

        public Module Module
        {
            get
            {
                module.Code = txtModCode.Text;
                module.Name = txtModName.Text;
                module.Credits = int.Parse(txtModCredit.Text);
                return module;
            }
            set
            {
                flowLay.Controls.Clear();
                module = value;
                if (value == null)
                {
                    module = new Module();
                }
                txtModCode.Text = module.Code;
                txtModName.Text = module.Name;
                txtModCredit.Text = module.Credits.ToString();
                lblStatus.Text = string.Format("Total = {0}, Standing = {1}", module.Status, (module.Status < 30 ? "Fail" : "Pass"));
                //string.Format("{0} - {1} ({2} Credits)", , , );
                foreach (var assessment in module.Assessments)
                {
                   
                    AssessmentUC assUc = new AssessmentUC(assessment);
                    flowLay.Controls.Add(assUc);
                }
            }
        }


        public ModuleUC(Module module)
        {
            InitializeComponent();
            this.Module = module;
        }

        private void ModuleUC_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Module = this.Module;
        }
    }
}
