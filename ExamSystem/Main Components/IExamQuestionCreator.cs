interface IExamQuestionCreator
{
    string subjectExam();
    void action();
    bool login(string _usernameLogin, string _passwordLogin);
    bool register(string _usernameRegister, string _passwordRegister);
}