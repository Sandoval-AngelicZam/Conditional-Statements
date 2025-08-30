using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Practice_Set.Conditionals
{
    internal class Practice_5
    {
        private void Main(string[] args)
        {

            Console.Write("Choose Between 'A', 'P', or 'X': ");

            string computation = Console.ReadLine();

            switch (computation)
            {
                case "A":

                    Console.Write("\nEnter given radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double Area = Math.PI * (radius * radius);
                    Console.WriteLine($"Your Area is {Area:f2}");
                    break;

                case "P":
                    Console.Write("\nEnter given radius: ");
                    double CircleRadius = Convert.ToDouble(Console.ReadLine());
                    double Perimeter = 2 * Math.PI * CircleRadius;
                    Console.WriteLine($"Your Perimeter is {Perimeter:f2}");
                    break;

                case "X":

                    Console.WriteLine("\nSystem logging off");
                    break;

                default:
                    Console.WriteLine("\nInvalid input. Make sure it's upper case.");
                    break;
            }
        }
    }
}
