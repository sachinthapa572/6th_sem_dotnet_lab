namespace Collection
{
    using System;
    using System.Collections.Generic;

    public class StudentModel
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Grade { get; set; } = String.Empty;
    }

    public class StudentList
    {
        private List<StudentModel> students = new List<StudentModel>();

        public void AddStudent(StudentModel student)
        {
            students.Add(student);
        }

        public void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");



            }
        }
    }

    public class StudentDisplay
    {
        public static void RunProgram()
        {
            // Step 5: Create a StudentList of Student objects
            StudentList studentList = new StudentList();

            // Step 6: Add some students to the list
            studentList.AddStudent(new StudentModel { Name = "Sachin Thapa", Age = 20, Grade = "A" });
            studentList.AddStudent(new StudentModel { Name = "Ram Bahik", Age = 22, Grade = "B" });
            studentList.AddStudent(new StudentModel { Name = "Sita kandel", Age = 19, Grade = "A" });

            // Step 7: Display all students
            Console.WriteLine("Student List:");
            studentList.DisplayStudents();
        }
    }

}