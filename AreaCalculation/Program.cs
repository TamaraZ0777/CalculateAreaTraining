using System;

namespace AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = NumberValidation(ReadValueFromConsole("Please enter the circle radius: "));
            var side = NumberValidation(ReadValueFromConsole("Please enter the square side: "));

            Circle circle = new Circle(radius);
            Square square = new Square(side);

            
            Console.WriteLine($"The circle's area is: {Math.Round(circle.Area, 2)}.");
            Console.WriteLine($"The square's area is: {Math.Round(square.Area, 2)}.");


            static double ReadValueFromConsole(string message)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(message);
                    var input = Console.ReadLine();
                    if (double.TryParse(input, out double value))
                    {
                        Console.WriteLine("Thank you! The value is accepted.");
                        return value;
                    }
                    else
                    {
                        Console.WriteLine(
                        "Sorry, the value is not valid. It should be a positive number with a comma as a decimal separator.");
                    }
                }
                return 0;

            }

            double NumberValidation (double data) 
            {

                if (data <= 0) 
                {
                    Console.WriteLine("Incorrect data entered 3 times. The value is set randomly in the range from 0,5 to 5,0:");

                    Random r = new Random();
                    data = r.NextDouble() * (5.0 - 0.5) + 0.5;

                    Console.WriteLine($"assigned value is {Math.Round(data, 2)}.");
                }

                return data;
            }

        }
        
    }

}
