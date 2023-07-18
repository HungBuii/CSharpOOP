using System;
using Advanced_programming_project.Decorator;

namespace Advanced_programming_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("\nTime test score: ");
                int t = Convert.ToInt32(Console.ReadLine());
                if (t == 15)
                {
                    Test_15_minutes test_15 = new Test_15_minutes();
                    test_15.show_time();
                    test_15.show_score();
                    test_15.questions();

                    Console.Write("\nDo you want to display the results of this test " + t + "?(0. No | 1. Yes): ");
                    int select = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (select == 1)
                    {
                        test_15.answers();
                    }
                    else continue;
                }
                else if (t == 30)
                {
                    Test_30_minutes test_30 = new Test_30_minutes();
                    test_30.show_time();
                    test_30.show_score();
                    test_30.questions();

                    Console.Write("\nDo you want to display the results of this test " + t + "?(0. No | 1. Yes): ");
                    int select = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (select == 1)
                    {
                        test_30.answers();
                    }
                    else continue;
                }
                else if (t == 45)
                {
                    Test_45_minutes test_45 = new Test_45_minutes();
                    test_45.show_time();
                    test_45.show_score();
                    test_45.questions();

                    Console.Write("\nDo you want to display the results of this test " + t + "?(0. No | 1. Yes): ");
                    int select = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (select == 1)
                    {
                        test_45.answers();
                    }
                    else continue;
                }
                else if (t == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("There is no such test. Try re-entering");
                }
            } while (true);
        }
    }
}
