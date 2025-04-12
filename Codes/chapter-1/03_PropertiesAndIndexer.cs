class StudentProfile
{
    //Private fields (Access modifiers)
    private string name = String.Empty;
    private int age;
    private readonly string[]? subject;


    // Constructor
    public StudentProfile(string name, int age, string[] subject)
    {
        this.name = name;
        this.age = age;
        this.subject = subject;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 0)
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }
        }
    }

    // Indexer
    public string this[int index]
    {
        get
        {
            if (subject == null || index < 0 || index >= subject.Length)
            {
                return "Index is out of range.";
            }
            return subject[index];
        }
        set
        {

            if (subject != null && index >= 0 && index < subject.Length)
            {
                subject[index] = value;
            }

        }
    }

}

public class PropsAndIndApp
{
    public static void PropertiesAndIndexerDemo()
    {
        // Create an instance of StudentProfile
        string[] subjects = { "Math", "Science", "History" };
        StudentProfile student = new StudentProfile("John Doe", 20, subjects);

        // Access properties
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");

        // Access indexer
        Console.WriteLine($"Subject at index 1: {student[1]}");

        // Modify indexer value
        student[1] = "Biology";
        Console.WriteLine($"Updated Subject at index 1: {student[1]}");


        student[2] = "Geography";
        Console.WriteLine($"Added Subject at index 2: {student[2]}");

        Console.WriteLine($"Subject at index 0: {student[0]}");
        Console.WriteLine($"Subject at index 1: {student[1]}");
    }

}