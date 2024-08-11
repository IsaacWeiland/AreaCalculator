namespace AreaMath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What polygon would you like to calculate?");
        string polygon = Console.ReadLine();
        switch (polygon)
        {
            case "square":
            {
                Console.WriteLine("Enter side length.");
                double s = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of this square is { s * s }");
                break;
            }
            case "rectangle":
            {
                Console.WriteLine("Enter length.");
                double l = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width.");
                double w = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of this rectangle is {l * w}.");
                break;
            }
            case "triangle":
            {
                Console.WriteLine("Enter you base length.");
                double b = double.Parse((Console.ReadLine()));
                Console.WriteLine("Enter your height length.");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of your triangle is { .5 * b * h}");
                break;
            }
            case "trapezoid":
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
            default:
            {
                Console.WriteLine("Invalid input or unaccepted polygon.\nList of accepted polygons are:\n" +
                                  "Square\nRectangle\nTriangle\nTrapezoid");
                break;
            }
        }
    }
}