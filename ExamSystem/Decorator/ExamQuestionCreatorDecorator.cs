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
    public string subjectExam()
    {
        return creator.subjectExam();
    }

    abstract public void action(int _choice);
    
    public bool login(string _usernameLogin, string _passwordLogin) { return true; }

    public bool register(string _usernameRegister, string _passwordRegister) { return true; }
}