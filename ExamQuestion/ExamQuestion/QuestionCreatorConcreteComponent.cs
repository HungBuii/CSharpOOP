class QuestionCreatorConcreteComponent : QuestionCreatorComponent
{
    // Properties
    private string subject;
    public string getSubject() {
        return subject;
    }

    public static List<string> questions = new List<string>();

    // Constructors
    public QuestionCreatorConcreteComponent(string _subject) {
        this.subject = _subject;
    }

    // Method
    public void action()
    {
        throw new NotImplementedException();
    }

    public string subjectExam()
    {
        return getSubject();
    }

    public void showQuestion()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            System.Console.WriteLine(questions[i]);
        }
    }
}