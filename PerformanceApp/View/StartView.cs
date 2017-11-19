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
    public partial class StartView : Form
    {
        private Course course;
        public Course Course
        {
            get
            {
                course.CourseName = txtCourseName.Text;
                return course;
            }
            set
            {
                course = value;
                if (course != null)
                {
                    txtCourseName.Text = course.CourseName;
                }
            }
        }
        StartViewController startCont;
        Button btnConstructLevel;
        public List<Module> modules = new List<Module>();

        public StartView()
        {
            InitializeComponent();
            startCont = new StartViewController();
            Course = startCont.LoadCourse() ?? new Course();
            GenerateUI(Course);
        }

        private void GenerateUI(Course course)
        {
            foreach (var level in course.Levels)
            {
                TabPage page = new TabPage(level.LevelName);
                FlowLayoutPanel panel = new FlowLayoutPanel();
                //panel.FlowDirection = FlowDirection.BottomUp;
                panel.AutoScroll = true;
                panel.Dock = DockStyle.Fill;
                //panel.BackColor = Color.LightBlue;
                page.Controls.Add(panel);
                page.Name = level.LevelName;
                tabControl.TabPages.Add(page);

                btnConstructLevel = new Button();
                //btnConstructLevel.Location = new Point(20, 10);
                btnConstructLevel.Text = "+";
                panel.Controls.Add(btnConstructLevel);
                btnConstructLevel.Click += new EventHandler(btnConstructLevel_Click);

                foreach (var module in level.Modules)
                {
                    ModuleUC modUc = new ModuleUC(module);

                    //modUc.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    panel.Controls.Add(modUc);
                }
            }

            TabPage tpage = new TabPage("Summary");
            tpage.Controls.Add(new SummaryUC(course));
            tabControl.TabPages.Add(tpage);

            var standign = course.Standing;
        }

        //Tabs created to given Level Count        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please Provide Course Name!");
                return;
            }

            course.CourseName = txtCourseName.Text;

            if (tabControl.TabPages.Count > 1)
            {
                tabControl.SelectedIndex = 4;
            }
        }

        private void btnConstructLevel_Click(object sender, EventArgs e)
        {
            Module mod;
            //MessageBox.Show("hiii");
            ModuleView moduleView = new ModuleView();
            if (moduleView.ShowDialog() == DialogResult.OK)
            {
                mod = moduleView.Module;
                this.Course.Levels.Single(x => x.LevelName == tabControl.SelectedTab.Name).Modules.Add(mod);
                ModuleUC mc = new ModuleUC(mod);
                tabControl.SelectedTab.Controls[0].Controls.Add(mc);
                mod.Level = tabControl.SelectedTab.Name;
                modules.Add(mod);



                //TabPage page=tabControl.TabPages["Level 1"];
                //TabPage page = tabControl.TabPages["Level 4"];               
                //if (page != null)
                //{                    
                //    page.Controls[0].Controls.Add(mc);
                //}


            }


        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage page = (sender as TabControl).SelectedTab;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    {
                        //MessageBox.Show("Ne");
                        //tabControl.SelectedIndex = 1;
                    }
                    break;
                case 1:
                    {
                        //MessageBox.Show("Na");
                        //tabControl.SelectedIndex = 2;
                    }
                    break;
                case 2:
                    {
                        //MessageBox.Show("Nm");
                        //tabControl.SelectedIndex = 3;
                    }
                    break;
                case 3:
                    {
                        //MessageBox.Show("Nm");
                        //tabControl.SelectedIndex = 3;
                    }
                    break;
                case 4:
                    {
                        (page.Controls[0] as SummaryUC).Refresh();
                        //MessageBox.Show("Nm");
                        //tabControl.SelectedIndex = 3;
                    }
                    break;
            }
        }

        private void StartView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Course.CourseName = Course.CourseName;
            startCont.SaveCourse(Course);
        }

    }
}
