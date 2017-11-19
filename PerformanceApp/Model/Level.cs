using System.Collections.Generic;

namespace PerformanceApp
{
    public class Level
    {
        public string LevelName { get; set; }

        private List<Module> modules;

        public List<Module> Modules
        {
            get
            {
                if (modules == null)
                {
                    modules = new List<Module>();
                }
                return modules;
            }
            set { modules = value; }
        }


    }
}