using System;
using System.Collections.Generic;

class Teacher : ExamQuestionCreatorDecorator
{
    // Constructor
    public Teacher(IExamQuestionCreator _creator) : base(_creator) { }

    // Properties

    public static List<Student> studentList = new List<Student>();

    public static List<Question> questions = new List<Question>();

    // Method 

    /* Add students to the exam class list */
    public void addStudent()
    {
        Student _student = new Student();
        System.Console.Write("* ID of student: "); _student.No = int.Parse(Console.ReadLine());
        System.Console.WriteLine("- Infomation of student " + _student.No + ": ");
        System.Console.Write("+ Name: "); _student.Name = Console.ReadLine();
        studentList.Add(_student);
        sortQuesionByNo();
    }

    /* Show all students in exam class list */
    public static void showStudentList()
    {
        for (int i = 0; i < studentList.Count; i++)
        {
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("Student " + studentList[i].No + ": ");
            System.Console.WriteLine("+ Name: " + studentList[i].Name);
            System.Console.WriteLine("-------------------");
        }
    }

    /* Each question is created to be included in a separate set of questions prepared by teachers. */
    public void createQuestion()
    {
        Question _question = new Question();
        System.Console.WriteLine("*******************");
        System.Console.Write("- Question "); _question.No = int.Parse(Console.ReadLine()); System.Console.WriteLine(": ");
        System.Console.WriteLine("+ Title: "); _question.Title = Console.ReadLine();
        System.Console.WriteLine("+ Answer Choice: "); _question.AnswerChoice = Console.ReadLine();
        System.Console.WriteLine("*******************");
        questions.Add(_question);
    }

    /* Delete question */
    public void removeQuestion(int _number)
    {
        sortQuesionByNo();
        for (int i = 0; i < questions.Count; i++)
        {
            if (_number > 0 && questions[i].No == _number)
            {
                questions.RemoveAt(i);
                break;
            }
        }

    }

    /* Update question */
    public void updateQuestion(int _number)
    {
        sortQuesionByNo();
        for (int i = 0; i < questions.Count; i++)
        {
            if (_number > 0 && questions[i].No == _number)
            {
                System.Console.WriteLine("+ Title: "); questions[i].Title = Console.ReadLine();
                System.Console.WriteLine("+ Answer Choice: "); questions[i].AnswerChoice = Console.ReadLine();
                break;
            }
        }
    }

    /* Sort question by No */
    public void sortQuesionByNo()
    {
        for (int i = 1; i <= questions.Count; i++)
        {
            if (questions[i-1].No == i) continue;
            else
            {
                questions[i-1].No = i;
                continue;
            }
        }
    }

    /* Show all question in a separate set of questions prepared by teachers */
    public void showQuestion()
    {
        sortQuesionByNo();
        for (int i = 0; i < questions.Count; i++)
        {
            System.Console.WriteLine("- Question " + questions[i].No + ": ");
            System.Console.WriteLine("+ Title: " + questions[i].Title);
            System.Console.WriteLine("+ Answer Choice: " + questions[i].AnswerChoice);
        }
    }

    public override void action(int _choice)
    {
        creator.action(_choice);
        addStudent();
        showStudentList();
        createQuestion();
        createQuestion();
        createQuestion();
        createQuestion();
        removeQuestion(2);
        updateQuestion(1);
        sortQuesionByNo();
        showQuestion();

        // System.Console.WriteLine("Your choice: ");
        // int choice = int.Parse(Console.ReadLine());
        // switch(choice)
        // {
        //     case 1:
        //         infoClass();
        //         break;
        //     case 2: 
        //         addStudent();
        //         break;
        //     case 3: 
        //         showStudentList();
        //         break;
        // }

        // do
        // {
        //     Console.WriteLine("1. Info class");
        //     Console.WriteLine("2. Add student");
        //     Console.WriteLine("0. Show student list");
        //     while (Int32.TryParse(Console.ReadLine(), out choice) == false)
        //     {
        //         Console.WriteLine("Invalid option, try again...");
        //     };
        //     switch (choice)
        //     {
        //         case 1:
        //             infoClass();
        //             break;
        //         case 2:
        //             addStudent();
        //             break;
        //         case 3:
        //             showStudentList();
        //             break;
        //     }
        // } while (choice != 0);
    }
}