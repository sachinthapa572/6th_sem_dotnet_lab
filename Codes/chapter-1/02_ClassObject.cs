namespace Practical.Codes
{

    public class ClassDemo
    {
        public string Name { get; set; }
        public int Age { get; set; }
 
        public ClassDemo(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public void Display()
        {
            Console.WriteLine($"Name: {Name} and Age: {Age}");
        }
    }

    public class ObjectDemo
    {
        public static void ClassObject()
        {
            ClassDemo obj = new ClassDemo("Sachin Thapa", 25);
            obj.Display();
        }
    }
}