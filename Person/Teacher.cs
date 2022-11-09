public class Teacher : Person
{
    int myCourses = 0;
    List<string> courses;
    string course;
    public Teacher(string name, string address) : base(name, address)
    {
        courses = new List<string> { };
    }
    public override string ToString()
    {
        return this.address;
    }
    public bool AddCourse(string course)
    {
        int cnt = 0;
        foreach (var item in courses)
        {
            if (item != course || courses.Count()==0) { cnt++; courses.Add(course);}
            // else { return false; }
        }
        if (cnt == 0) {return true;}
        else {return false;}
    }
    public bool RemoveCourse(string course)
    {
        int m=0;
        foreach (var item in courses)
        {
            if (item == course) {m++; courses.Remove(course);}}
        if (m>0) {return true;}
        else {return false;}
    }
}