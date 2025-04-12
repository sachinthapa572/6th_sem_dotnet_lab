namespace Interface
{
    interface IShape
    {
        void Display();
    }

    interface IColor
    {
        void FillColor();
    }

    class Rectangle : IShape, IColor
    {
        public void Display()
        {
            Console.WriteLine("This is a rectangle.");
        }

        public void FillColor()
        {
            Console.WriteLine("Filling rectangle with color.");
        }
    }


    public class InterfaceExample
    {
        public static void RunProgram()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Display();
            rectangle.FillColor();


        }
    }
}
