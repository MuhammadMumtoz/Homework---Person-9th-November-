public class Student : Person
{
    int numOfCourses = 0;
    List<string> courses;
    List<int> grades;
    public Student(string name, string address) : base(name, address)
    {
        courses = new List<string> { };
        grades = new List<int> { };
    }
    public override string ToString()
    {
        return this.address;
    }
    public void addCourseGrade(string course, int grade)
    {
        courses.Add(course);
        grades.Add(grade);
    }
    public void PrintGrades()
    {
        foreach (var grade in grades)
        {
            System.Console.WriteLine(grade);
        }
    }
    public double GetAverageGrade()
    {
        return grades.Sum() / grades.Count();
    }
}