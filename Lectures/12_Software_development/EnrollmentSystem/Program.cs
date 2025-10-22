public class Student
{
    public string name;
    public int id;
    public Student(string nameValue, int idValue)
    {
        name = nameValue;
        id = idValue;
    }

    public string GetName()
    {
        return name;
    }
}

public class Course
{
    string name;
    Student[] participants;
    int id;
    public Course(string nameValue)
    {
        name = nameValue;
        participants = new Student[10]; // NOTE: This constant is BAD!
    }
    public void Enroll(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == null)
            {
                participants[i] = student;
                return;
            }
        }
    }
    public void Remove(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == student)
            {
                participants[i] = null;
            }
        }
    }
    public Student[] GetParticipants()
    {
        // count number of entries
        int count = 0;
        foreach (Student student in participants)
        {
            if (student != null)
            {
                count++;
            }
        }

        // make a copy
        Student[] result = new Student[count];
        int index = 0;
        foreach (Student student in participants)
        {
            if (student != null)
            {
                result[index++] = student;
            }
        }
        return result;
    }
}
public class EnrollmentSystem
{
    public Student[] students = new Student[1000];
    public Course[] courses = new Course[10];
    public void Enroll(Student student, Course course) {
        course.Enroll(student);
    }
    public void Remove(Student student, Course course) {
        course.Remove(student);
    
    }
    public void ShowParticipants(Course course)
    {
        foreach (Student student in course.GetParticipants()) {
        Console.WriteLine(student.GetName());
        }
    }
    public void GetCourses() {
        Console.WriteLine("void for a getter?");
    }
    public void GetStudents()
    {
        Console.WriteLine("void for a getter?");
    }

    public void AddStudent(Student student)
    {
        for (int i = 0; i < 1000; i++)
        {
            if (students[i] == null)
            {
                students[i] = student;
                break;
            }
        }
    }
    public void RemoveStudent(Student student)
    {
        for (int i = 0; i < 1000; i++)
        {
            if (students[i] == student)
            {
                students[i] = null;
                break;
            }
        }
    }
    public void AddCourse(Course Course)
    {
        for (int i = 0; i < 1000; i++)
        {
            if (courses[i] == null)
            {
                courses[i] = Course;
                break;
            }
        }
    }
    public void RemoveCourse(Course Course){
        for(int i = 0; i < 1000; i++)
        {
            if (courses[i] == Course)
            {
                courses[i] = null;
                break;
            }
        }
    }
}