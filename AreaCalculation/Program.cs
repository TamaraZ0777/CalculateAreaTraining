using System;

namespace AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = 0;
            double radius = 0;
            string input;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the circle radius: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out radius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(
                    "Invalid input. Please enter a valid number");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the square side: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out radius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(
                    "Invalid input. Please enter a valid number");
                }

                Console.WriteLine("Incorrect data entered 3 times. The side of the square and the circle radius will be set randomly");
                Random r = new Random();
                radius = r.NextDouble() * (5.0 - 0.5);
                side = r.NextDouble() * (5.0 - 0.5);

            }
            area = Math.PI * radius * radius;
            Console.WriteLine(
                $"The area of the circle is: { area: 0.00}");

        }
    }
}
