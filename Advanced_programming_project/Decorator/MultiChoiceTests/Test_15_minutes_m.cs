using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.MultiChoiceTests
{
    internal class Test_15_minutes_m : MultiChoiceTest
    {
        // Properties
        public new int Time
        {
            get { return 15; }
        }

        public new float Score
        {
            get { return 2; }
        }

        // Method
        public override void show_time()
        {
            Console.WriteLine("\nThis multi-choice test has a duration of " + Time + " minutes!");
        }

        public override void show_score()
        {
            Console.WriteLine("The total test score is " + Score + " points.");
        }

        public override void questions()
        {
            string user_answer = "";
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. In the top 20 most expensive transfers of all time, how many are Real Madrid involved in (both buying and selling)?");
            Console.WriteLine("A. 5 \t B. 6 \t C. 7 \t D. 8 ");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();
            while(user_answer != "C")
            {
                Console.Write("Incorrect. Re-answer: ");
                user_answer = Console.ReadLine();
            }
            if (user_answer == "C")
            {
                Console.WriteLine("Correct answer: C. 7");
                Console.WriteLine("7 cases (Gareth Bale, Cristiano Ronaldo, James Rodriguez, Mesut Ozil, Kaka, Zinedine Zidane, Angel Di Maria).");
            }
            
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("2. What is the most expensive player sale Real Madrid has ever made?");
            Console.WriteLine("A. Robinho \t B. Angle Di Maria \t C. Mesult Ozil \t D. Gonzalo Higuain");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();
            while (user_answer != "B")
            {
                Console.Write("Incorrect. Re-answer: ");
                user_answer = Console.ReadLine();
            }
            if (user_answer == "B")
            {
                Console.WriteLine("Correct answer: B. Angle Di Maria");
                Console.WriteLine("Angel Di Maria, who was sold by Real Madrid for 59.7 million euro to Manchester United.");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

    }
}
