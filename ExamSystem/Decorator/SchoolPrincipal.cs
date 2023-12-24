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

    public bool confirmExam(string _confirm)
    {
        if (_confirm == "y")
        {
            return true;
        }
        return false;
    }

    public void printExamQuestion(string _confirm)
    {
        if (confirmExam(_confirm))
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
            System.Console.WriteLine("This exam is in the updating stage. Please visit again later!");
        }     
    }

    public override void action(int _choice)
    {
        printExamQuestion("y");
    }

}