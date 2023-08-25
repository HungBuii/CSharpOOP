using System;
using Advanced_programming_project.Decorator;
using Advanced_programming_project.Decorator.EssayTests;
using Advanced_programming_project.Decorator.MultiChoiceTests;

namespace Advanced_programming_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please select the test category: ");
                Console.WriteLine("1. Multi-choice questions test.");
                Console.WriteLine("2. Essay questions test.");
                Console.WriteLine("3. Multi-choice questions test + Essay questions test.");
                Console.WriteLine("0. Exit program.");
                Console.Write("Your choice: "); int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    Environment.Exit(0);
                }
                while (x == 1)
                {
                    Console.Write("\nTime test score: ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    if (t == 15)
                    {
                        Test_15_minutes_m test_15_m = new Test_15_minutes_m();
                        test_15_m.show_time();
                        test_15_m.show_score();
                        test_15_m.questions();

                        continue;
                    }
                    else if (t == 30)
                    {
                        Test_30_minutes_m test_30_m = new Test_30_minutes_m();
                        test_30_m.show_time();
                        test_30_m.show_score();
                        test_30_m.questions();

                        continue;
                    }
                    else if (t == 45)
                    {
                        Test_45_minutes_m test_45_m = new Test_45_minutes_m();
                        test_45_m.show_time();
                        test_45_m.show_score();
                        test_45_m.questions();

                        continue;
                    }
                    else if (t == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("There is no such test. Try re-entering");
                    }
                }

                while (x == 2)
                {
                    Console.Write("\nTime test score: ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    if (t == 15)
                    {
                        Test_15_minutes_e test_15_e = new Test_15_minutes_e();
                        test_15_e.show_time();
                        test_15_e.show_score();
                        test_15_e.questions();
                        Console.Write("\nDo you want to display the results of this test " + t + "?(0. No | 1. Yes): ");
                        int select = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (select == 1)
                        {
                            test_15_e.answers();
                        }
                        else continue;     
                    }
                    else if (t == 30)
                    {
                        Test_30_minutes_e test_30_e = new Test_30_minutes_e();
                        test_30_e.show_time();
                        test_30_e.show_score();
                        test_30_e.questions();
                        Console.Write("\nDo you want to display the results of this test " + t + "?(0. No | 1. Yes): ");
                        int select = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (select == 1)
                        {
                            test_30_e.answers();
                        }
                        else continue;
                    }
                    else if (t == 45)
                    {
                        Test_45_minutes_e test_45_e = new Test_45_minutes_e();
                        test_45_e.show_time();
                        test_45_e.show_score();
                        test_45_e.questions();
                        Console.Write("\nDo you want to display the results of this test " + t + "?(0. No | 1. Yes): ");
                        int select = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (select == 1)
                        {
                            test_45_e.answers();
                        }
                        else continue;
                    }
                    else if (t == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("There is no such test. Try re-entering");
                    }
                }

                while (x == 3)
                {
                    while (true)
                    {
                        Console.Write("\nTime multi-choice test score (0: next test): ");
                        int t1 = Convert.ToInt32(Console.ReadLine());
                        if (t1 == 0)
                        {
                            break;
                        }
                        else if (t1 == 15)
                        {
                            Test_15_minutes_m test_15_m = new Test_15_minutes_m();
                            test_15_m.show_time();
                            test_15_m.show_score();
                            test_15_m.questions();

                            continue;
                        }
                        else if (t1 == 30)
                        {
                            Test_30_minutes_m test_30_m = new Test_30_minutes_m();
                            test_30_m.show_time();
                            test_30_m.show_score();
                            test_30_m.questions();

                            continue;
                        }
                        else if (t1 == 45)
                        {
                            Test_45_minutes_m test_45_m = new Test_45_minutes_m();
                            test_45_m.show_time();
                            test_45_m.show_score();
                            test_45_m.questions();

                            continue;
                        }
                        else
                        {
                            Console.Write("There is no such test. Try re-entering");
                        }
                    }

                    while (true)
                    {
                        Console.Write("\nTime essay test score (0: exit): ");
                        int t2 = Convert.ToInt32(Console.ReadLine());
                        if (t2 == 0)
                        {
                            break;
                        }
                        else if (t2 == 15)
                        {
                            Test_15_minutes_e test_15_e = new Test_15_minutes_e();
                            test_15_e.show_time();
                            test_15_e.show_score();
                            test_15_e.questions();
                            Console.Write("\nDo you want to display the results of this test " + t2 + "?(0. No | 1. Yes): ");
                            int select = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (select == 1)
                            {
                                test_15_e.answers();
                            }
                            else continue;
                        }
                        else if (t2 == 30)
                        {
                            Test_30_minutes_e test_30_e = new Test_30_minutes_e();
                            test_30_e.show_time();
                            test_30_e.show_score();
                            test_30_e.questions();
                            Console.Write("\nDo you want to display the results of this test " + t2 + "?(0. No | 1. Yes): ");
                            int select = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (select == 1)
                            {
                                test_30_e.answers();
                            }
                            else continue;
                        }
                        else if (t2 == 45)
                        {
                            Test_45_minutes_e test_45_e = new Test_45_minutes_e();
                            test_45_e.show_time();
                            test_45_e.show_score();
                            test_45_e.questions();
                            Console.Write("\nDo you want to display the results of this test " + t2 + "?(0. No | 1. Yes): ");
                            int select = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (select == 1)
                            {
                                test_45_e.answers();
                            }
                            else continue;
                        }
                        else
                        {
                            Console.Write("There is no such test. Try re-entering");
                        }
                    }
                    break;
                }
            } while (true);
        }
    }
}
