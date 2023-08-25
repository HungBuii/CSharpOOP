using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.EssayTests
{
    internal class Test_15_minutes_e : EssayTests
    {
        // Properties
        public new int Time
        {
            get { return 15; }
        }

        public new float Score
        {
            get { return 1; }
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
            string user_answer = "";
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. Who is the fastest hat-trick player in Premier League history?");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

        }

        public override void answers()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. Who is the fastest hat-trick player in Premier League history?");
            Console.WriteLine("Answer: Sadio Mane (2 minutes 56 seconds in the match between Southampton and Aston Villa in 2015)");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

        }
    }
}
