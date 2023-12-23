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

            IExamQuestionCreator emp1 = new ExamQuestionCreator();
            IExamQuestionCreator t1 = new SubjectLeader(emp1);
            t1.action();
        }
    }
}
