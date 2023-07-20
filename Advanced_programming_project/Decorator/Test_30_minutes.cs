using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator
{
    internal class Test_30_minutes : Test_15_minutes
    {
        public Test_30_minutes() { }

        public new int Time
        {
            get { return 30; }
        }

        public new float Score
        {
            get { return 8; }
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

            Console.WriteLine("* Part 2: Essay questions");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. Who is the fastest hat-trick player in Premier League history?");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("2. What year was the first English Premier League season since the name change from First Division?");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("3. Which team won the English Premier League first?");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

        public override void answers()
        {
            base.answers();

            Console.WriteLine("* Part 2: Essay questions");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. Who is the fastest hat-trick player in Premier League history?");
            Console.WriteLine("Answer: Sadio Mane (2 minutes 56 seconds in the match between Southampton and Aston Villa in 2015)");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("2. What year was the first English Premier League season since the name change from First Division?");
            Console.WriteLine("Answer: 1992-1993");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("3. Which team won the English Premier League first?");
            Console.WriteLine("Answer: Manchester United");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
