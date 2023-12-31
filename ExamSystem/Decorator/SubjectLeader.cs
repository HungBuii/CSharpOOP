using System;
using System.Collections.Generic;

class SubjectLeader : ExamQuestionCreatorDecorator
{
    // Constructor
    public SubjectLeader(IExamQuestionCreator _creator) : base(_creator) { }

    // Properties
    public static List<Question> questionsExam = new List<Question>();

    // Method 

    /* Add questions from separate test sets prepared by teachers into the school's main test set */
    public void addQuestionToExam(int _number)
    {
        if (_number >= 0 && _number <= Teacher.questions.Count)
        {
            for (int i = 0; i < Teacher.questions.Count; i++)
            {
                if (Teacher.questions[i].No == _number)
                {
                    questionsExam.Add(Teacher.questions[i]);
                    break;
                }
            }
        }
        else
        {
            System.Console.WriteLine("The question you are looking for does not exist!");
        }
    }

    /* Create additional questions prepared by the subject head into the school's main question set */
    public void createQuestionExam()
    {
        try
        {
            Question _question = new Question();
            System.Console.WriteLine("*******************");
            System.Console.Write("- Question "); _question.No = int.Parse(Console.ReadLine()); System.Console.WriteLine(": ");
            System.Console.WriteLine("+ Title: "); _question.Title = Console.ReadLine();
            System.Console.WriteLine("+ Answer Choice: "); _question.AnswerChoice = Console.ReadLine();
            System.Console.WriteLine("*******************");
            questionsExam.Add(_question);
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    /* Delete questions prepared by the subject head into the school's main question set */
    public void removeQuestionExam(int _number)
    {
        sortQuesionExamByNo();
        for (int i = 0; i < questionsExam.Count; i++)
        {
            if (_number > 0 && questionsExam[i].No == _number)
            {
                questionsExam.RemoveAt(i);
                break;
            }
        }

    }

    /* Update questions prepared by the subject head into the school's main question set */
    public void updateQuestionExam(int _number)
    {
        sortQuesionExamByNo();
        for (int i = 0; i < questionsExam.Count; i++)
        {
            if (_number > 0 && questionsExam[i].No == _number)
            {
                try
                {
                    System.Console.WriteLine("+ Title: "); questionsExam[i].Title = Console.ReadLine();
                    System.Console.WriteLine("+ Answer Choice: "); questionsExam[i].AnswerChoice = Console.ReadLine();
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                break;
            }
        }
    }

    /* Arrange questions in order from 1->n */
    public void sortQuesionExamByNo()
    {
        for (int i = 1; i <= questionsExam.Count; i++)
        {
            if (questionsExam[i - 1].No == i) continue;
            else
            {
                questionsExam[i - 1].No = i;
                continue;
            }
        }
    }

    /* Displays questions that have been prepared in the school's exam set */
    public void showQuestionExam()
    {
        sortQuesionExamByNo();
        if (questionsExam.Count > 0)
        {
            for (int i = 0; i < questionsExam.Count; i++)
            {
                System.Console.WriteLine("- Question " + questionsExam[i].No + ": ");
                System.Console.WriteLine("+ Title: " + questionsExam[i].Title);
                System.Console.WriteLine("+ Answer Choice: " + questionsExam[i].AnswerChoice);
            }
        }
        else
        {
            System.Console.WriteLine("There are no questions currently on this exam!");
        }

    }

    public override void action()
    {
        creator.action();
        Console.Clear();
        do
        {
            try
            {
                System.Console.WriteLine("\nSubject Leader's function: ");
                System.Console.WriteLine("1. Add question to exam \t 2. Create question exam");
                System.Console.WriteLine("3. Remove question exam \t 4. Update question exam \t 5. Show list question in exam \t 6. Back");
                System.Console.Write("Your select: "); int choice4 = int.Parse(Console.ReadLine());
                if (choice4 == 1)
                {
                    System.Console.WriteLine("What question number from the teacher's test set do you want to add to the exam set?");
                    System.Console.Write("Your choice: "); int number = int.Parse(Console.ReadLine());
                    addQuestionToExam(number);
                }
                else if (choice4 == 2)
                {
                    createQuestionExam();
                }
                else if (choice4 == 3)
                {
                    System.Console.WriteLine("What question number do you want to delete from the exam?");
                    System.Console.Write("Your choice: "); int number = int.Parse(Console.ReadLine());
                    removeQuestionExam(number);
                }
                else if (choice4 == 4)
                {
                    System.Console.WriteLine("What question number do you want to update from the exam?");
                    System.Console.Write("Your choice: "); int number = int.Parse(Console.ReadLine());
                    updateQuestionExam(number);
                }
                else if (choice4 == 5)
                {
                    showQuestionExam();
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
                    Console.Clear();
                    System.Console.WriteLine("Invalid choice. Please enter again!");
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        } while (true);
    }
}