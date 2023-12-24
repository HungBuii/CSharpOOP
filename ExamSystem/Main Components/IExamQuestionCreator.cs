interface IExamQuestionCreator
{
    string subjectExam();
    void action(int _choice);
    bool login(string _usernameLogin, string _passwordLogin);
    bool register(string _usernameRegister, string _passwordRegister);
}