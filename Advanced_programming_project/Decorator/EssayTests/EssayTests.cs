using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.EssayTests
{
    internal class EssayTests : ITest
    {
        // Properties
        public int Time
        {
            get;
        }

        public float Score
        {
            get;
        }

        // Method

        public virtual void show_time()
        {

        }

        public virtual void show_score()
        {

        }

        public virtual void questions()
        {

        }

        public virtual void answers() { }
    }
}
