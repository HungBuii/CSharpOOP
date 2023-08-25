using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.MultiChoiceTests
{
    internal class Test_45_minutes_m : Test_30_minutes_m
    {
        // Properties
        public new int Time
        {
            get { return 45; }
        }

        public new float Score
        {
            get { return 6; }
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
            base.questions();
            string user_answer = "";

            Console.WriteLine("5. After Luis Figo, who is the most expensive player bought by Real Madrid directly from Barcelona?");
            Console.WriteLine("A. Javier Saviola \t B. Michael Laudrup \t C. Bernd Schuster \t D. Luis Enrique");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();
            while (user_answer != "B")
            {
                Console.Write("Incorrect. Re-answer: ");
                user_answer = Console.ReadLine();
            }
            if (user_answer == "B")
            {
                Console.WriteLine("Correct answer: B. Michael Laudrup");
                Console.WriteLine("Michael Laudrup joined Real Madrid directly from Barcelona in 1995 for 8.16 million euro.");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("6. In the top 10 most expensive player sales of Real Madrid, how many players joined Italian clubs?");
            Console.WriteLine("A. 1 \t B. 2 \t C. 3 \t D. 4");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();
            while (user_answer != "C")
            {
                Console.Write("Incorrect. Re-answer: ");
                user_answer = Console.ReadLine();
            }
            if (user_answer == "C")
            {
                Console.WriteLine("Correct answer: C. 3");
                Console.WriteLine("3 players (Gonzalo Higuain to Napoli - £ 33 million, Clarence Seedorf to Inter Milan - £ 20 million, Alvaro Morata to Juventus - £ 17 million).");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");


        }
    }
}
