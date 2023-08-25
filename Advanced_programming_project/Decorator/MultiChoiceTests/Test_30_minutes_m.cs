using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator.MultiChoiceTests
{
    internal class Test_30_minutes_m : Test_15_minutes_m
    {
        // Properties
        public new int Time
        {
            get { return 30; }
        }

        public new float Score
        {
            get { return 4; }
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
            Console.WriteLine("3. Which of the 4 options below is NOT included in the top 20 most expensive player purchases of Real Madrid?");
            Console.WriteLine("A. Ronaldo de Lima \t B. Asier Illarramendi \t C. Mateo Kovacic \t D. Mahamadou Diarra");
            Console.Write("Your answer: "); user_answer = Console.ReadLine();
            while (user_answer != "A")
            {
                Console.Write("Incorrect. Re-answer: ");
                user_answer = Console.ReadLine();
            }
            if (user_answer == "A")
            {
                Console.WriteLine("Correct answer: A. Ronaldo de Lima");
                Console.WriteLine("Ronaldo of Brazil joined Real Madrid from Inter Milan for euro20m in 2002. The man in 20th place is Angel Di Maria (21m euro, from Benfica).");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("4. How many players has Real Madrid bought during their career with Ballon d'Or?");
            Console.WriteLine("A. 6 \t B. 7 \t C. 8 \t D. 9");
            while (user_answer != "D")
            {
                Console.Write("Incorrect. Re-answer: ");
                user_answer = Console.ReadLine();
            }
            if (user_answer == "D")
            {
                Console.WriteLine("Correct answer: D. 9");
                Console.WriteLine("9 players (Alfredo Di Stefano, Raymond Kopa, Ronaldo of Brazil, Zinedine Zidane, Luis Figo, Michael Owen, Fabio Cannavaro, Kaka, Cristiano Ronaldo).");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
