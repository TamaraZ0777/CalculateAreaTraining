using System;

namespace AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //double side = 0;
            //double radius = 0;
            string input;

            var radius = ReadValueFromConsole("Please enter the circle radius: ");
            var side = ReadValueFromConsole("Please enter the square side: ");

            Circle circle = new Circle(radius);
            Square square = new Square(side);

            Console.WriteLine("You entered " + radius + " and " + side);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter the circle radius: ");
            //    input = Console.ReadLine();
            //    if (double.TryParse(input, out radius))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(
            //        "Invalid input. Please enter a valid number");
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter the square side: ");
            //    input = Console.ReadLine();
            //    if (double.TryParse(input, out radius))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(
            //        "Invalid input. Please enter a valid number");
            //    }
            if value = 0
                {
                Console.WriteLine("Incorrect data entered 3 times. The side of the square and the circle radius will be set randomly");
                Random r = new Random();
                radius = r.NextDouble() * (5.0 - 0.5);
                side = r.NextDouble() * (5.0 - 0.5);
                }
        }
           // area = Math.PI * radius * radius;
            //Console.WriteLine(
              //  $"The area of the circle is: { area: 0.00}");
            public static double ReadValueFromConsole(string message)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(message);
                    var input = Console.ReadLine();
                    if (double.TryParse(input, out double value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine(
                        "Invalid input. Please enter a valid number");
                    }
                }
                return 0;

            if (value = 0)
                {
                Console.WriteLine("Incorrect data entered 3 times. The side of the square and the circle radius will be set randomly");
                public double RandomNumber(double min, double max);
                {
                    Random random = new Random();
                    return random.Next(0.5, 5.0);
                }
                Random r = new Random();
                radius = r.NextDouble() * (5.0 - 0.5);
                side = r.NextDouble() * (5.0 - 0.5);
            }
        }
        
    }
}
