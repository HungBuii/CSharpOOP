using System;
using System.Collections.Generic;

class ExamQuestionCreator : IExamQuestionCreator
{
    // Constructor
    public ExamQuestionCreator() { }

    // Properties
    private string username;
    public string Username
    {
        get { return username; }
        private set { username = value; }
    }

    private string password;
    public string Password
    {
        get { return password; }
        private set { password = value; }
    }

    private string subject;
    public string Subject
    {
        get { return subject; }
        private set { subject = value; }
    }

    public static List<Question> questionsExam = new List<Question>();

    // Method
    public void action()
    {
        if (login(Username, Password)) 
        {
            System.Console.WriteLine("You have successfully accessed the system!");
        }
        else
        {
            System.Console.WriteLine("Cannot access the system!");
            System.Console.WriteLine("Please re-register into the system.");
            register();
        }
    }

    public string subjectExam()
    {
        System.Console.WriteLine("What is the subject of this exam?");
        Subject = Console.ReadLine();
        return Subject;
    }

    public void register()
    {
        if (Username == "" && Password == "")
        {
            System.Console.Write("Username: "); Username = Console.ReadLine();
            System.Console.WriteLine("Password: "); Password = Console.ReadLine();
        }
        else {
            System.Console.WriteLine("Account already exists!");
        }
    }

    public bool login(string _username, string _password)
    {
        if (Username == _username && Password == _password)
        {
            return true;
        }
        return false;
    }
}