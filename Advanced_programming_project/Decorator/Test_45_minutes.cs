using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator
{
    internal class Test_45_minutes : Test_30_minutes
    {
        public Test_45_minutes() { }

        public new int Time
        {
            get { return 45; }
        }

        public new float Score
        {
            get { return 11; }
        }

        public override void show_time()
        {
            Console.WriteLine("This test has a duration of " + Time + " minutes!");
        }

        public override void show_score()
        {
            Console.WriteLine("The total test score is " + Score + " points.");
        }

        public override void questions()
        {
            base.questions();

            Console.WriteLine("4. How many clubs competed in the first English Premier League season?");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("5. Which three players share the Golden Shoe award in 2018/19?");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("6. The fastest goal in Premier League history was scored at 7.69 seconds. Who made it?");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

        public override void answers()
        {
            base.answers();

            Console.WriteLine("4. How many clubs competed in the first English Premier League season?");
            Console.WriteLine("Answer: 22");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("5. Which three players share the Golden Shoe award in 2018/19?");
            Console.WriteLine("Answer: Pierre-Emerick Aubameyang, Mohamed Salah and Sadio Mane");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("6. The fastest goal in Premier League history was scored at 7.69 seconds. Who made it?");
            Console.WriteLine("Answer: Shane Long (in Southampton vs Watford season 2018/19)");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
