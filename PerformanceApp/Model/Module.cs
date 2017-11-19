using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceApp
{
    public class Module
    {
        private String code;
        private String name;
        private int credits;
        private List<Assessment> assessments;


        public string Level { get; set; }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public List<Assessment> Assessments
        {
            get
            {
                if (assessments == null)
                {
                    assessments = new List<Assessment>();
                }
                return assessments;
            }
            set
            {
                assessments = value;


            }
        }



        public decimal Status
        {
            get
            {
                return Assessments.Sum(x => x.Weight * x.Mark / 100);
            }
        }


    }
}
