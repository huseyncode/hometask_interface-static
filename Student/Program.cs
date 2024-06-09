class Program
{
    static void Main(string[] args)
    {
        // Yeni bir student yaradırıq
        Student student = new Student();

        // Yeni bir grade yaradırıq və studentə əlavə edirik
        Grade mathGrade = new Grade("Math", Degree.A);
        student.AddGrade(mathGrade);

        // Bütün grade-ləri alırıq və çap edirik
        List<Grade> grades = student.GetAllGrades();
        foreach (Grade grade in grades)
        {
            Console.WriteLine($"Subject: {grade.Subject}, Degree: {grade.Degree}");
        }
    }
}

public enum Degree
{
    A,
    B,
    C,
    D,
    E
}

public class Grade
{
    public string Subject { get; set; }
    public Degree Degree { get; set; }

    public Grade(string subject, Degree degree)
    {
        Subject = subject;
        Degree = degree;
    }
}

public class Student
{
    private List<Grade> grades;

    public Student()
    {
        grades = new List<Grade>();
    }

    public void AddGrade(Grade grade)
    {
        grades.Add(grade);
    }

    public List<Grade> GetAllGrades()
    {
        return grades;
    }
}
