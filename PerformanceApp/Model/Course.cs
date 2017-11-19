using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceApp
{
    public class Course
    {
        public string CourseName { get; set; }

        private List<Level> levels;

        public List<Level> Levels
        {
            get
            {
                if (levels == null)
                {
                    levels = new List<Level>();
                }
                return levels;
            }
            set
            {
                levels = value;
            }
        }



        public string Standing
        {
            get
            {
                if (Levels.Where(x => x.LevelName == "Level 6").SelectMany(x => x.Modules).Sum(x => x.Credits) < 105)
                {
                    return "Insufficient Data";
                }
                if (Levels.Where(x => x.LevelName == "Level 6" || x.LevelName == "Level 5").SelectMany(x => x.Modules).Sum(x => x.Credits) < 210)
                {
                    return "Insufficient Data";
                }
                int total = 0;
                var value1 = Levels.Where(x => x.LevelName == "Level 6").SelectMany(x => x.Modules).OrderByDescending(x => x.Status).TakeWhile(x =>
                {
                    int val = total;
                    total += x.Credits;
                    return val < 105;
                }).Average(x => x.Status);

                total = 0;
                var value2 = Levels.Where(x => x.LevelName == "Level 6" || x.LevelName == "Level 5").SelectMany(x => x.Modules).OrderByDescending(x => x.Status).TakeWhile(x =>
                {
                    int val = total;
                    total += x.Credits;
                    return val < 210;
                }).Average(x => x.Status);

                if (value1 >= 70 && value2 >= 60)
                {
                    return "First Class";
                }
                else if (value1 >= 60 && value2 >= 50)
                {
                    return "Upper Second";
                }
                else if (value1 >= 50 && value2 >= 40)
                {
                    return "Lower Second";
                }
                else if (value2 >= 40)
                {
                    return "Third";
                }
                return "Failed";
            }
        }



    }
}
