using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using PerformanceApp.Common;

namespace PerformanceApp
{
    public class StartViewController
    {
        private string fileName = "Course.xml";

        public Course LoadCourse()
        {
            Course course = null;

            if (File.Exists(fileName))
            {
                string data = null;
                Thread t = new Thread(delegate()
                {
                    data = File.ReadAllText(fileName, Encoding.ASCII);
                    course = XmlUtility.DeserializeFromXml<Course>(data);
                });
                t.Start();
                t.Join();
            }
            else
            {

            }

            return course;
        }

        public void SaveCourse(Course course)
        {
            new Thread(delegate()
            {
                string value = XmlUtility.SerializeToXml(course);
                File.WriteAllText(fileName, value, Encoding.ASCII);
            }).Start();
        }


        public void LoadCourseTest()
        {
            Course course = new Course();

            XDocument doc = XDocument.Load(fileName);
            if (doc.Root != null)
            {
                course.CourseName = doc.Root.Attributes("name").First().Value;
                var levels = doc.Descendants("level");
                foreach (var level in levels)
                {
                    Level mlevel = new Level();
                    mlevel.LevelName = level.Attributes("level").First().Value;

                    course.Levels.Add(mlevel);

                    var modules = level.Descendants("module");
                    foreach (var module in modules)
                    {
                        Module mmodule = new Module();
                        mmodule.Code = module.Attributes("code").First().Value;
                        mmodule.Name = module.Attributes("name").First().Value;
                        mmodule.Credits = int.Parse(module.Attributes("credit").First().Value);

                        mlevel.Modules.Add(mmodule);

                        var assignments = module.Descendants("assessment");
                        foreach (var assignment in assignments)
                        {
                            Assessment ass = new Assessment();
                            ass.Name = assignment.Attributes("name").First().Value;
                            ass.Mark = decimal.Parse(assignment.Attributes("mark").First().Value);
                            ass.Weight = decimal.Parse(assignment.Attributes("weight").First().Value);

                            mmodule.Assessments.Add(ass);
                        }
                    }

                }
            }
        }
    }
}
