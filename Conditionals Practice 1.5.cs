
/*Practice 1.5*/


Console.WriteLine("1. Area");
Console.WriteLine("2. Perimeter");
Console.WriteLine("3. Exit");
Console.Write("\nChoose a number to select between the three: ");
int options = Convert.ToInt32(Console.ReadLine());

switch (options)
{
    case 1:
        Console.Write("\nEnter any value for Radius: ");
        double rad = Convert.ToSingle(Console.ReadLine());
        double area = Math.PI * rad;
        Console.WriteLine("Your area is {0:f2}", area);
        break;

    case 2:
        Console.Write("\nEnter any value for Perimeter: ");
        double Circumference = Convert.ToSingle(Console.ReadLine());
        double Perimeter = 2 * Math.PI * Circumference;
        Console.WriteLine("Your area is {0:f2}", Perimeter);
        break;

    case 3:
        Console.WriteLine("\nBye bye!! System is closing.");
        break;

}