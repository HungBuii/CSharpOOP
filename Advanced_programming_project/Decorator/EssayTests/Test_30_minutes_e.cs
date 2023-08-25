using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.EssayTests
{
    internal class Test_30_minutes_e : Test_15_minutes_e
    {
        // Properties
        public new int Time
        {
            get { return 30; }
        }

        public new float Score
        {
            get { return 2; }
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
            
            Console.WriteLine("2. What year was the first English Premier League season since the name change from First Division?");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            

        }

        public override void answers()
        {
            base.answers();

            Console.WriteLine("2. What year was the first English Premier League season since the name change from First Division?");
            Console.WriteLine("Answer: 1992-1993");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
