using System;
using System.Text;

namespace ExamSystem
{
    internal class Program
    {
        private static string ReadPassword()
        {
            StringBuilder password = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password.Remove(password.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (key.Key != ConsoleKey.Backspace)
                {
                    password.Append(key.KeyChar);
                    Console.Write("*");
                }
            }

            return password.ToString();
        }

        private static void registerSystem(IExamQuestionCreator _account)
        {
            System.Console.WriteLine("\t\t\t\t\t\t\t\t\tREGISTER\n");
            System.Console.Write("\t\t\t\t\t\t\t\tUsername: "); string usernameRegister = Console.ReadLine();
            System.Console.Write("\t\t\t\t\t\t\t\tPassword: "); string passwordRegister = ReadPassword();
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
            System.Console.Write("\t\t\t\t\t\t\t\tPassword: "); string passwordLogin = ReadPassword();
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
            System.Console.WriteLine("\nWhat is the subject of this exam?");
            System.Console.Write("Subject: "); string subject = Console.ReadLine();
            System.Console.WriteLine("Exam subjects will be selected as: " + _account.subjectExam(subject));
            do
            {
                System.Console.Write("\nAll account role: \n");
                System.Console.WriteLine("1. Teacher \t\t\t 2. Subject Leader \t\t 3. SchoolPrincipal");
                System.Console.WriteLine("4. Subject Leader + Teacher \t 5. School Principal + Teacher \t 6. School Principal + Subject Leader");
                System.Console.WriteLine("7. Back \t\t\t 8. Exit program");
                System.Console.Write("Select your account role: "); int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    IExamQuestionCreator teacher1 = new Teacher(_account);
                    teacher1.action();
                }
                else if (choice2 == 2)
                {
                    IExamQuestionCreator subjectLeader1 = new SubjectLeader(_account);
                    subjectLeader1.action();
                }
                else if (choice2 == 3)
                {
                    IExamQuestionCreator schoolPrincipal = new SchoolPrincipal(_account);
                    schoolPrincipal.action();
                }
                else if (choice2 == 4)
                {
                    IExamQuestionCreator teacher2 = new Teacher(_account);
                    IExamQuestionCreator subjectLeaderAndTeacher = new SubjectLeader(teacher2);
                    subjectLeaderAndTeacher.action();
                }
                else if (choice2 == 5)
                {
                    IExamQuestionCreator teacher3 = new Teacher(_account);
                    IExamQuestionCreator schoolPrincipalAndTeacher = new SchoolPrincipal(teacher3);
                    schoolPrincipalAndTeacher.action();
                }
                else if (choice2 == 6)
                {
                    IExamQuestionCreator subjectLeader2 = new SubjectLeader(_account);
                    IExamQuestionCreator schoolPrincipalAndsubjectLeader = new SchoolPrincipal(subjectLeader2);
                    schoolPrincipalAndsubjectLeader.action();
                }
                else if (choice2 == 7)
                {
                    break;
                }
                else if (choice2 == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Console.WriteLine("Invalid choice. Please enter again!");
                }
            } while (true);
        }
    }
}
