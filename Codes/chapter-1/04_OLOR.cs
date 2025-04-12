// 4.Write a program that reflects the overloading and overriding of constructor and function.


namespace _04OLOR
{


    class Shape
    {
        public virtual void Display()
        {
            Console.WriteLine("This is a shape Class .");
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(double sideLength)
        {
            length = sideLength;
            width = sideLength;
        }

        public override void Display()
        {
            Console.WriteLine($"This is a rectangle with length {length} and width {width}.");
        }
    }

    public class ShapeDisplayApp
    {
        public static void RunProgram()
        {
            Shape shape = new Shape();
            shape.Display();

            Rectangle rectangle1 = new Rectangle(7, 8);
            rectangle1.Display();

            Rectangle rectangle2 = new Rectangle(4);
            rectangle2.Display();


        }
    }

}