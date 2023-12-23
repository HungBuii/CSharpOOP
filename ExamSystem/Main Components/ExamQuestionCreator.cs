using System;
using System.Collections.Generic;

class ExamQuestionCreator : IExamQuestionCreator
{
    // Constructor
    public ExamQuestionCreator() { }

    // Properties
    private List<string> username;
    public List<string> Username
    {
        get { return username; }
    }

    private List<string> password;
    public List<string> Password
    {
        get { return password; }
    }

    private string subject;
    public string Subject
    {
        get { return subject; }
        private set { subject = value; }
    }

    public static List<Question> questionsExam = new List<Question>();

    // Method
    public void action() { }

    public string subjectExam()
    {
        System.Console.WriteLine("What is the subject of this exam?");
        Subject = Console.ReadLine();
        return Subject;
    }

    public void login()
    {
        System.Console.Write("Username: "); string usernameLogin = Console.ReadLine();
        System.Console.WriteLine("Password: "); string passwordLogin = Console.ReadLine();

        if (checkAccount(usernameLogin, "") && checkAccount("", passwordLogin))
        {
            System.Console.WriteLine("You have successfully accessed the system!");
        }
        else
        {
            System.Console.WriteLine("Cannot access the system!");
            System.Console.WriteLine("Please log back or re-register into the system.");
        }
    }

    public void register()
    {
        System.Console.Write("Username: "); string usernameRegister = Console.ReadLine();
        System.Console.WriteLine("Password: "); string passwordRegister = Console.ReadLine();

        if (usernameRegister == "" || passwordRegister == "")
        {
            System.Console.WriteLine("Please re-register back into the system.");
            register();
        }

        // for (int i = 0; i < Username.Count; i++)
        // {
        //     if (Username.Contains(usernameRegister))
        //     {
        //         System.Console.WriteLine("This account name already exists. Please re-register back into the system.");
        //         register();
        //         break;
        //     }
        //     else
        //     {
        //         Username.Add(usernameRegister);
        //         break;
        //     }
        // }


        // for (int i = 0; i < Password.Count; i++)
        // {
        //     if (Password.Contains(passwordRegister))
        //     {
        //         System.Console.WriteLine("This password already exists. Please re-register back into the system.");
        //         register();
        //         break;
        //     }
        //     else
        //     {
        //         Password.Add(passwordRegister);
        //         break;
        //     }
        // }

        if (checkAccount(usernameRegister, "") || checkAccount("", passwordRegister))
        {
            System.Console.WriteLine("This account name already exists. Please re-register back into the system.");
            register();
        }
        else
        {
            Username.Add(usernameRegister);
            Password.Add(passwordRegister);
        }
    }

    public bool checkAccount(string usernameLogin, string passwordLogin)
    {
        for (int i = 0; i < Username.Count; i++)
        {
            if (usernameLogin != "" && Username.Contains(usernameLogin))
            {
                return true;
            }
        }
        for (int i = 0; i < Password.Count; i++)
        {
            if (passwordLogin != "" && Password.Contains(passwordLogin))
            {
                return true;
            }
        }
        return false;
    }
}