abstract class QuestionCreatorDecorator : QuestionCreatorComponent
{
    // Properties
    protected QuestionCreatorComponent creator;

    // Constructors
    protected QuestionCreatorDecorator(QuestionCreatorComponent _creator) {
        this.creator = _creator;
    }

    // Method
    public abstract void action();

    public abstract void showQuestion();

    public string subjectExam()
    {
        return creator.subjectExam();
    }
}