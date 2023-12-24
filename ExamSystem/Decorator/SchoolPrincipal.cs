using System;
class SchoolPrincipal : ExamQuestionCreatorDecorator
{
    // Constructor
    public SchoolPrincipal(IExamQuestionCreator _creator) : base(_creator) { }

    // Properties
    private string confirm;
    public string Confirm
    {
        get { return confirm; }
        set { confirm = value; }
    }

    // Method 
    public void printExamQuestion()
    {
        System.Console.WriteLine("Do you agree to publish this exam?");
        System.Console.Write("Your choice(y/n): "); string confirm = Console.ReadLine();
        if (confirm == "y")
        {
            if (SubjectLeader.questionsExam.Count > 0)
            {
                for (int i = 0; i < SubjectLeader.questionsExam.Count; i++)
                {
                    System.Console.WriteLine("- Question " + SubjectLeader.questionsExam[i].No + ": ");
                    System.Console.WriteLine("+ Title: " + SubjectLeader.questionsExam[i].Title);
                    System.Console.WriteLine("+ Answer Choice: " + SubjectLeader.questionsExam[i].AnswerChoice);
                }
                System.Console.WriteLine("This exam has been printed successfully!");
            }
            else
            {
                System.Console.WriteLine("There are no questions currently on this exam!");
            }
        }
        else if (confirm == "n")
        {
            System.Console.WriteLine("This exam is in the updating stage. Please visit again later!");
        }
        else
        {
            System.Console.WriteLine("Invalid choice. Please enter again!");
        }
    }

    public override void action(int _choice)
    {
        if (_choice == 1)
        {
            printExamQuestion();
        }
    }

}