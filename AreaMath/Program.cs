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
                int s = int.Parse(Console.ReadLine());
                Console.WriteLine($"Area of this square is { s * s }");
                break;
            }
            case "rectangle":
            {
                Console.WriteLine("Enter length.");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width.");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine($"Area of this rectangle is {l * w}.");
                break;
            }
            case "triangle":
            {
                Console.WriteLine("Please enter you base length.");
                int b = int.Parse((Console.ReadLine()));
                Console.WriteLine("Please enter your height length.");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine($"Area of your triangle is { .5 * b * h}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input or unaccepted polygon.\nList of accepted polygons are:\n" +
                                  "Square\nRectangle\nTriangle");
                break;
            }
        }
    }
}