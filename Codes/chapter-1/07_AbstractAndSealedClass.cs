

namespace AbstractAndSealedClass
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    sealed class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double Area()
        {
            return length * width;
        }

        public sealed override double Perimeter()
        {
            return 2 * (length + width);
        }
    }

    public class ShapeAreaPerimeter
    {
        public static void RunProgram()
        {
            Shape circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.Area()}");
            Console.WriteLine($"Circle Perimeter: {circle.Perimeter()}");

            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}");
        }
    }
}