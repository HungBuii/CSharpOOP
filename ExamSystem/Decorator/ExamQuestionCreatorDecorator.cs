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

    abstract public void action();

}