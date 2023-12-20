using System.Collections.Generic;

class Teacher : ExamQuestionCreatorDecorator
{
    // Constructor
    public Teacher(IExamQuestionCreator _creator) : base(_creator) { }

    // Properties
    private string className;
    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }
    
    public static List<Student> studentList = new List<Student>();

    public static List<Question> questions = new List<Question>();

    // Method 
    public void addStudent(Student _student) 
    {
        studentList.Add(_student);
    }

    public void showStudentList() 
    {
        for (int i = 0; i < studentList.Count; i++) {
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("Student " + i + ": ");
            System.Console.WriteLine("+ Name: " + studentList[i].Name);
            if (studentList[i].ClassName == ClassName) {
                System.Console.WriteLine("+ Class: " + studentList[i].ClassName);
            }
            System.Console.WriteLine("-------------------");
        }
    }

    public static void showStudentListPrinted() 
    {
        showStudentListPrinted();
    }

    public override void action()
    {
        
    }
    

}