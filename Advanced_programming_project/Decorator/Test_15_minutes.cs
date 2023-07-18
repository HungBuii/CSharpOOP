using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_programming_project.Decorator
{
    internal class Test_15_minutes : ITest
    {
        public Test_15_minutes() { }

        public int Time
        {
            get { return 15; }
        }

        public float Score
        {
            get { return 5; }
        }

        public void show_time()
        {
            Console.WriteLine("\nThis test has a duration of " + Time + " minutes!");
        }

        public void show_score()
        {
            Console.WriteLine("The total test score is " + Score + " points.");
        }

        public void questions()
        {
            Console.WriteLine("\n* Part 1: Multiple-choice questions");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. In the top 20 most expensive transfers of all time, how many are Real Madrid involved in (both buying and selling)?");
            Console.WriteLine("A. 5 \t B. 6 \t C. 7 \t D. 8 ");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("2. What is the most expensive player sale Real Madrid has ever made?");
            Console.WriteLine("A. Robinho \t B. Angle Di Maria \t C. Mesult Ozil \t D. Gonzalo Higuain");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("3. Which of the 4 options below is NOT included in the top 20 most expensive player purchases of Real Madrid?");
            Console.WriteLine("A. Ronaldo de Lima \t B. Asier Illarramendi \t C. Mateo Kovacic \t D. Mahamadou Diarra");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("4. How many players has Real Madrid bought during their career with Ballon d'Or?");
            Console.WriteLine("A. 6 \t B. 7 \t C. 8 \t D. 9");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("5. After Luis Figo, who is the most expensive player bought by Real Madrid directly from Barcelona?");
            Console.WriteLine("A. Javier Saviola \t B. Michael Laudrup \t C. Bernd Schuster \t D. Luis Enrique");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }

        public void answers()
        {
            Console.WriteLine("* Part 1: Multiple-choice questions");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("1. In the top 20 most expensive transfers of all time, how many are Real Madrid involved in (both buying and selling)?");
            Console.WriteLine("Correct answer: C. 7");
            Console.WriteLine("7 cases (Gareth Bale, Cristiano Ronaldo, James Rodriguez, Mesut Ozil, Kaka, Zinedine Zidane, Angel Di Maria).");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("2. What is the most expensive player sale Real Madrid has ever made?");
            Console.WriteLine("Correct answer: B. Angle Di Maria");
            Console.WriteLine("Angel Di Maria, who was sold by Real Madrid for 59.7 million euro to Manchester United.");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("3. Which of the 4 options below is NOT included in the top 20 most expensive player purchases of Real Madrid?");
            Console.WriteLine("Correct answer: A. Ronaldo de Lima");
            Console.WriteLine("Ronaldo of Brazil joined Real Madrid from Inter Milan for euro20m in 2002. The man in 20th place is Angel Di Maria (21m euro, from Benfica).");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("4. How many players has Real Madrid bought during their career with Ballon d'Or?");
            Console.WriteLine("Correct answer: D. 9");
            Console.WriteLine("9 players (Alfredo Di Stefano, Raymond Kopa, Ronaldo of Brazil, Zinedine Zidane, Luis Figo, Michael Owen, Fabio Cannavaro, Kaka, Cristiano Ronaldo).");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("5. After Luis Figo, who is the most expensive player bought by Real Madrid directly from Barcelona?");
            Console.WriteLine("Correct answer: B. Michael Laudrup");
            Console.WriteLine("Michael Laudrup joined Real Madrid directly from Barcelona in 1995 for 8.16 million euro.");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

        }
    }
}
