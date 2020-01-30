using System;

namespace AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = ValidateInput(ReadValueFromConsole("Please enter the circle radius: "));
            var side = ValidateInput(ReadValueFromConsole("Please enter the square side: "));

            Circle circle = new Circle(radius);
            Square square = new Square(side);

                       
            Console.WriteLine($"The circle's area is: {Math.Round(circle.Area, 2)}.");
            Console.WriteLine($"The square's area is: {Math.Round(square.Area, 2)}.");

            Console.WriteLine(CompareFigures(circle.Radius, square.Side));


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

            static double ValidateInput (double parsedInput) 
            {

                if (parsedInput <= 0) 
                {
                    Console.WriteLine("Incorrect data entered 3 times. The value is set randomly in the range from 0,5 to 5,0:");

                    Random random = new Random();
                    parsedInput = random.NextDouble() * (5.0 - 0.5) + 0.5;

                    Console.WriteLine($"assigned value is {Math.Round(parsedInput, 2)}.");
                }

                return parsedInput;
            }

            static string CompareFigures(double radius, double side) 
            {
                string comparisonResult;

                
                if (side > (radius * 2))
                {
                    comparisonResult = "The circle fits in the square.";
                }
                    
                else if (side == (radius * 2))
                {
                    comparisonResult = "The circle fits in the square with the borders overlap.";
                }

                else if ((side * Math.Sqrt(2)) < (2 * radius))
                {
                    comparisonResult = "The square fits in the circle.";
                }
                   
                else if ((side * (Math.Sqrt(2))) == (2 * radius))
                {
                    comparisonResult = "The square fits in the circle with the borders overlap.";
                }
                 
                else
                {
                    comparisonResult = "Neither the square fits in the circle, nor the circle fits in the square.";
                }
                   

                return comparisonResult;
            }
        }

    }

}
