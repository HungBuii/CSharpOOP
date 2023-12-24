using System;

namespace ExamSystem
{
    internal class Program
    {
        private static void registerSystem(IExamQuestionCreator _account)
        {
            System.Console.WriteLine("\t\t\t\t\t\t\t\t\tREGISTER\n");
            System.Console.Write("\t\t\t\t\t\t\t\tUsername: "); string usernameRegister = Console.ReadLine();
            System.Console.Write("\t\t\t\t\t\t\t\tPassword: "); string passwordRegister = Console.ReadLine();
            if (_account.register(usernameRegister, passwordRegister) == false)
            {
                System.Console.WriteLine("\n\t\t\t\t\t\t\t*********************************");
                System.Console.WriteLine("\t\t\t\t\tUsername and password may be incorrect or exist. Please try again!");
                System.Console.WriteLine("\t\t\t\t\t\t\t*********************************");
            }
            else
            {
                System.Console.WriteLine("\n\t\t\t\t\t\t\t*********************************");
                System.Console.WriteLine("\t\t\t\t\t\t\t   Account successfully created!");
                System.Console.WriteLine("\t\t\t\t\t\t\t*********************************");
            }
        }

        private static void loginSystem(IExamQuestionCreator _account)
        {
            System.Console.WriteLine("\t\t\t\t\t\t\t\t\tLOGIN\n");
            System.Console.Write("\t\t\t\t\t\t\t\tUsername: "); string usernameLogin = Console.ReadLine();
            System.Console.Write("\t\t\t\t\t\t\t\tPassword: "); string passwordLogin = Console.ReadLine();
            if (_account.login(usernameLogin, passwordLogin))
            {
                System.Console.WriteLine("\n\t\t\t\t\t\t\t*********************************");
                System.Console.WriteLine("\t\t\t\t\t\t\tYou have successfully accessed the system!");
                System.Console.WriteLine("\t\t\t\t\t\t\t*********************************");
                MenuFunction(_account);
            }
            else
            {
                System.Console.WriteLine("\n\t\t\t\t\t\t\t*********************************");
                System.Console.WriteLine("\t\t\t\t\t\t\t\tCannot access the system!");
                System.Console.WriteLine("\t\t\t\t\t\t\tPlease log back or re-register into the system.");
                System.Console.WriteLine("\t\t\t\t\t\t\t*********************************");
            }
        }

        static void Main(string[] args)
        {
            IExamQuestionCreator account1 = new ExamQuestionCreator();
            do
            {
                System.Console.WriteLine("\n\n\t\t\t\t\t\t\t\tWelcome to Exam System!\n");
                System.Console.WriteLine("\nDo you want to register a new account? (If yes, please log in)");
                System.Console.WriteLine("1. Register \t 2. Login \t 0. Exit program \n");
                System.Console.Write("Your select: "); int choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
                {
                    registerSystem(account1);
                }
                else if (choice1 == 2)
                {
                    loginSystem(account1);
                }
                else if (choice1 == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Console.WriteLine("Invalid choice. Please enter again!");
                }
            } while (true);
        }

        private static void MenuFunction(IExamQuestionCreator _account)
        {
            do
            {
                System.Console.Write("\nAll account role: \n");
                System.Console.WriteLine("1. Teacher \t\t\t 2. Subject Leader \t\t 3. SchoolPrincipal");
                System.Console.WriteLine("4. Subject Leader + Teacher \t 5. School Principal + Teacher \t 6. School Principal + Subject Leader");
                System.Console.Write("Select your account role: "); int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    IExamQuestionCreator t = new Teacher(_account);
                    do
                    {
                        System.Console.WriteLine("Teacher's function: ");
                        System.Console.WriteLine("1. Add student \t 2. Show student list \t 3. Create question");
                        System.Console.WriteLine("4. Remove question \t 5. Update question \t 6. Show question list \t 7. Back");
                        System.Console.Write("Your select: "); int choice3 = int.Parse(Console.ReadLine());
                        if (choice3 == 1)
                        {
                            t.action(1);
                        }
                        else if (choice3 == 2)
                        {
                            t.action(2);
                        }
                        else if (choice3 == 3)
                        {
                            t.action(3);
                        }
                        else if (choice3 == 4)
                        {
                            t.action(4);
                        }
                        else if (choice3 == 5)
                        {
                            t.action(5);
                        }
                        else if (choice3 == 6)
                        {
                            t.action(6);
                        }
                        else if (choice3 == 7)
                        {
                            break;
                        }
                        else if (choice3 == 0)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid choice. Please enter again!");
                        }
                    } while (true);
                }
                else if (choice2 == 2)
                {
                    IExamQuestionCreator sbj = new SubjectLeader(_account);
                    do
                    {
                        System.Console.WriteLine("Subject Leader's function: ");
                        System.Console.WriteLine("1. Add question to exam \t 2. Create question exam");
                        System.Console.WriteLine("3. Remove question exam \t 4. Update question exam \t 5. Show list question in exam \t 6. Back");
                        System.Console.Write("Your select: "); int choice4 = int.Parse(Console.ReadLine());
                        if (choice4 == 1)
                        {
                            sbj.action(1);
                        }
                        else if (choice4 == 2)
                        {
                            sbj.action(2);
                        }
                        else if (choice4 == 3)
                        {
                            sbj.action(3);
                        }
                        else if (choice4 == 4)
                        {
                            sbj.action(4);
                        }
                        else if (choice4 == 5)
                        {
                            sbj.action(5);
                        }
                        else if (choice4 == 6)
                        {
                            break;
                        }
                        else if (choice4 == 0)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid choice. Please enter again!");
                        }
                    } while (true);
                }
                else if (choice2 == 3)
                {
                    IExamQuestionCreator spl = new SchoolPrincipal(_account);
                    do
                    {
                        System.Console.WriteLine("School Principal's function: ");
                        System.Console.WriteLine("1. Confirm exam \t 2. Print question exam");
                        System.Console.Write("Your select: "); int choice5 = int.Parse(Console.ReadLine());
                        if (choice5 == 1)
                        {
                            spl.action(1);
                        }
                        else if (choice5 == 2)
                        {
                            spl.action(2);
                        }
                        else if (choice5 == 3)
                        {
                            break;
                        }
                        else if (choice5 == 0)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid choice. Please enter again!");
                        }
                    } while (true);
                }
            } while (true);
        }
    }
}
