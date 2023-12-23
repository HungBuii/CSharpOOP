using System;

namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExamQuestionCreator emp = new ExamQuestionCreator();
            IExamQuestionCreator t = new Teacher(emp);
            t.action();
        }
    }
}
