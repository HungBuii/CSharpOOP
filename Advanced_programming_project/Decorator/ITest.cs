using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator
{
    internal interface ITest
    {
        // Properties
        int Time
        {
            get;
        }

        float Score
        {
            get;
        }

        // Method
        public void show_time();

        public void show_score();
        public void questions();
        public void answers();
    }
}
