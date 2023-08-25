using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.EssayTests
{
    internal class Test_45_minutes_e : Test_30_minutes_e
    {
        // Properties
        public new int Time
        {
            get { return 45; }
        }

        public new float Score
        {
            get { return 3; }
        }

        // Method
        public override void show_time()
        {
            Console.WriteLine("\nThis essay test has a duration of " + Time + " minutes!");
        }

        public override void show_score()
        {
            Console.WriteLine("The total test score is " + Score + " points.");
        }

        public override void questions()
        {
            base.questions();
            string user_answer = "";

            Console.WriteLine("3. The fastest goal in Premier League history was scored at 7.69 seconds. Who made it?");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

        public override void answers()
        {
            base.answers();

            Console.WriteLine("3. The fastest goal in Premier League history was scored at 7.69 seconds. Who made it?");
            Console.WriteLine("Answer: Shane Long (in Southampton vs Watford season 2018/19)");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
