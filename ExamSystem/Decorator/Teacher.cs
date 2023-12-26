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
            if (questions[i - 1].No == i) continue;
            else
            {
                questions[i - 1].No = i;
                continue;
            }
        }
    }

    /* Show all question in a separate set of questions prepared by teachers */
    public void showQuestion()
    {
        sortQuesionByNo();
        if (questions.Count > 0)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                System.Console.WriteLine("- Question " + questions[i].No + ": ");
                System.Console.WriteLine("+ Title: " + questions[i].Title);
                System.Console.WriteLine("+ Answer Choice: " + questions[i].AnswerChoice);
            }
        }
        else
        {
            System.Console.WriteLine("There are no questions currently in here!");
        }
    }

    public override void action()
    {
        creator.action();
        Console.Clear();
        do
        {
            System.Console.WriteLine("\nTeacher's function: ");
            System.Console.WriteLine("1. Add student \t 2. Show student list \t 3. Create question");
            System.Console.WriteLine("4. Remove question \t 5. Update question \t 6. Show question list \t 7. Back");
            System.Console.Write("Your select: "); int choice3 = int.Parse(Console.ReadLine());
            if (choice3 == 1)
            {
                addStudent();
            }
            else if (choice3 == 2)
            {
                showStudentList();
            }
            else if (choice3 == 3)
            {
                createQuestion();
            }
            else if (choice3 == 4)
            {
                System.Console.WriteLine("What question number do you want to delete?");
                System.Console.Write("Your choice: "); int number = int.Parse(Console.ReadLine());
                removeQuestion(number);
            }
            else if (choice3 == 5)
            {
                System.Console.WriteLine("What question number do you want to update?");
                System.Console.Write("Your choice: "); int number = int.Parse(Console.ReadLine());
                updateQuestion(number);
            }
            else if (choice3 == 6)
            {
                showQuestion();
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
                Console.Clear();
                System.Console.WriteLine("Invalid choice. Please enter again!");
            }
        } while (true);
    }
}