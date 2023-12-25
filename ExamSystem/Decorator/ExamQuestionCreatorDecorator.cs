abstract class ExamQuestionCreatorDecorator : IExamQuestionCreator
{
    // Constructor
    protected ExamQuestionCreatorDecorator(IExamQuestionCreator _creator)
    {
        this.creator = _creator;
    }
    // Properties
    protected IExamQuestionCreator creator;

    // Method 
    public string subjectExam(string _subject)
    {
        return creator.subjectExam(_subject);
    }

    abstract public void action();
    
    public bool login(string _usernameLogin, string _passwordLogin) { return true; }

    public bool register(string _usernameRegister, string _passwordRegister) { return true; }
}