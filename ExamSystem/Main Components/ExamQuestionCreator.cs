using System;
using System.Collections.Generic;

class ExamQuestionCreator : IExamQuestionCreator
{
    // Constructor
    public ExamQuestionCreator() 
    {
        username = new List<string>();
        password = new List<string>();
    }

    // Properties
    private List<string> username;
    public List<string> Username
    {
        get { return username; }
        private set { username = value; }
    }

    private List<string> password;
    public List<string> Password
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
    public void action() { }

    public string subjectExam()
    {
        System.Console.WriteLine("What is the subject of this exam?");
        Subject = Console.ReadLine();
        return Subject;
    }

    public bool login(string _usernameLogin, string _passwordLogin)
    {
        if (checkAccount(_usernameLogin, "") && checkAccount("", _passwordLogin))
        { 
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool register(string _usernameRegister, string _passwordRegister)
    {
        if (_usernameRegister == "" || _passwordRegister == "")
        {
            System.Console.WriteLine("Please re-register back into the system.");
            return false;
        }

        if (checkAccount(_usernameRegister, "") || checkAccount("", _passwordRegister))
        {
            return false;
        }
        else
        {
            Username.Add(_usernameRegister);
            Password.Add(_passwordRegister);
            return true;
        }
    }

    public bool checkAccount(string _usernameLogin, string _passwordLogin)
    {
        for (int i = 0; i < Username.Count; i++)
        {
            if (_usernameLogin != "" && Username.Contains(_usernameLogin))
            {
                return true;
            }
        }
        for (int i = 0; i < Password.Count; i++)
        {
            if (_passwordLogin != "" && Password.Contains(_passwordLogin))
            {
                return true;
            }
        }
        return false;
    }
}