using System.Reflection.Metadata;

class Tutor : QuestionCreatorDecorator
{
    // Properties
    public static int Max_Question_Tutor = 5;

    // Field
    int count = 1;

    // Constructor
    public Tutor(QuestionCreatorComponent _creator) : base(_creator)
    {
    }

    // Method
    public void createQuestion()
    {
        if (QuestionCreatorConcreteComponent.questions.Count < Max_Question_Tutor)
        {
            if (count > 5)
            {
                count = 1;
            }
            System.Console.WriteLine("Question " + (count++) + ": ");
            string question = Console.ReadLine();
            QuestionCreatorConcreteComponent.questions.Add(question);
        }
        else
        {
            System.Console.WriteLine("You cannot add more questions!");
        }
    }

    public void removeQuestion()
    {
        System.Console.WriteLine("What question number do you want to delete?");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            return;
        }
        if (number >= 1 && number <= 5)
        {
            QuestionCreatorConcreteComponent.questions.RemoveAt(number - 1);
        }
    }

    public void updateQuestion() {
        System.Console.WriteLine("What question number do you want to update?");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            return;
        }
        if (number >= 1 && number <= 5)
        {
            System.Console.WriteLine("Question " + (number) + ": ");
            string question = Console.ReadLine();
            QuestionCreatorConcreteComponent.questions[number-1] = question;
        }
    } 

    public override void showQuestion()
    {
        while (QuestionCreatorConcreteComponent.questions.Count < Max_Question_Tutor)
        {
            System.Console.WriteLine("Do u want to add more questions? (y/n)");
            string answers = Console.ReadLine();
            if (answers == "y")
            {
                createQuestion();
            }
            else
            {
                return;
            }
        }
        for (int i = 0; i < Max_Question_Tutor; i++)
        {
            System.Console.WriteLine(QuestionCreatorConcreteComponent.questions[i]);
        }
    }
    public override void action()
    {
        {
            createQuestion();
            showQuestion();
        }
        {
            removeQuestion();
            showQuestion();
        }
        {
            updateQuestion();
            showQuestion();
        }
    }
}