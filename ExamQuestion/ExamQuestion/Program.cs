QuestionCreatorComponent teacher = new QuestionCreatorConcreteComponent("Math");
System.Console.WriteLine(teacher.subjectExam());

QuestionCreatorComponent tutor = new Tutor(teacher);
tutor.action();
tutor.showQuestion();