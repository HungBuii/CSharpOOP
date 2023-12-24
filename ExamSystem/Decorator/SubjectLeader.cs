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
                if (Teacher.questions[i].No == _number)// && !questionsExam[j].Equals(Teacher.questions[i])
                {
                    questionsExam.Add(Teacher.questions[i]);
                    break;
                }
                // for (int j = 0; j < questionsExam.Count; j++)
                // {
                //     if (Teacher.questions[i].No == _number)// && !questionsExam[j].Equals(Teacher.questions[i])
                //     {
                //         questionsExam.Add(Teacher.questions[i]);
                //         break;
                //     }
                // }

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
        Question _question = new Question();
        System.Console.WriteLine("*******************");
        System.Console.Write("- Question "); _question.No = int.Parse(Console.ReadLine()); System.Console.WriteLine(": ");
        System.Console.WriteLine("+ Title: "); _question.Title = Console.ReadLine();
        System.Console.WriteLine("+ Answer Choice: "); _question.AnswerChoice = Console.ReadLine();
        System.Console.WriteLine("*******************");
        questionsExam.Add(_question);
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
                System.Console.WriteLine("+ Title: "); questionsExam[i].Title = Console.ReadLine();
                System.Console.WriteLine("+ Answer Choice: "); questionsExam[i].AnswerChoice = Console.ReadLine();
                break;
            }
        }
    }

    /* Arrange questions in order from 1->n */
    public void sortQuesionExamByNo()
    {
        for (int i = 1; i <= questionsExam.Count; i++)
        {
            if (questionsExam[i-1].No == i) continue;
            else
            {
                questionsExam[i-1].No = i;
                continue;
            }
        }
    }

    /* Displays questions that have been prepared in the school's exam set */
    public void showQuestionExam()
    {
        sortQuesionExamByNo();
        System.Console.WriteLine(questionsExam.Count);
        for (int i = 0; i < questionsExam.Count; i++)
        {
            System.Console.WriteLine("- Question " + questionsExam[i].No + ": ");
            System.Console.WriteLine("+ Title: " + questionsExam[i].Title);
            System.Console.WriteLine("+ Answer Choice: " + questionsExam[i].AnswerChoice);
        }
    }

    public override void action(int _choice)
    {
        addQuestionToExam(1);
        addQuestionToExam(2);
        addQuestionToExam(3);
        createQuestionExam();
        // removeQuestionExam(2);
        // updateQuestionExam(1);
        showQuestionExam();
    }
}