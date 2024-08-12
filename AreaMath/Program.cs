namespace AreaMath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What polygon would you like to calculate?");//circles are polygons with infinite sides, okay
        string polygon = Console.ReadLine();
        switch (polygon)
        {
            case "square":
            {
                Console.WriteLine("Enter side length.");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of this square is { SquareArea(side) }");
                break;
            }
            case "rectangle":
            {
                Console.WriteLine("Enter length.");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width.");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of this rectangle is {RectangleArea(length, width)}.");
                break;
            }
            case "triangle":
            {
                Console.WriteLine("Enter you base length.");
                double baseLength = double.Parse((Console.ReadLine()));
                Console.WriteLine("Enter your height length.");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of your triangle is { TriangleArea(baseLength, height)}");
                break;
            }
            case "trapezoid": //to whoever is grading this, you can just ignore this. I made it before I knew this was
                //an assignment, and I'm too proud to delete this code but too lazy to change it.
            {
                Console.WriteLine("Enter the length of your first base.");
                double l1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of your second base.");
                double l2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height.");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of your trapezoid is { (l1 + l2) * h / 2}");
                break;
            }
            case "circle":
            {
                Console.WriteLine("Enter the area of your circle.");
                double radius = int.Parse(Console.ReadLine());
                Console.WriteLine($"The area of your circle is {CircleArea(radius)}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input or unaccepted polygon.\nList of accepted polygons are:\n" +
                                  "Circle\nSquare\nRectangle\nTriangle\nTrapezoid");
                break;
            }
            
        }
        
    }
    public static double CircleArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }

    public static double SquareArea(double side)
    {
        return side * side;
    }

    public static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double TriangleArea(double baseLength, double height)
    {
        return .5 * baseLength * height;
    }
}