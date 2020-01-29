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

            

            Console.WriteLine(Math.Round(circle.Area, 2));
            Console.WriteLine(Math.Round(square.Area, 2));

            Console.WriteLine(FigureComparing(circle.Radius, square.Side));

            static double ReadValueFromConsole(string message)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(message);
                    var input = Console.ReadLine();
                    if (double.TryParse(input, out double value))
                    {
                        Console.WriteLine("Value have been read");
                        return value;
                    }
                    else
                    {
                        Console.WriteLine(
                        "Invalid input. Please enter a valid number");
                    }
                }
                return 0;

            }

            double NumberValidation (double data) 
            {

                if (data <= 0) 
                {
                    Console.WriteLine("Incorrect data entered 3 times. The side of the square and the circle radius will be set randomly");
                    Random r = new Random();
                    data = r.NextDouble() * (5.0 - 0.5) + 0.5;
                    Console.WriteLine("new value is {0}", Math.Round(data, 2));
;                }

                return data;
            }

            string FigureComparing (double CircleRadius, double SquareSide) 
            {
                string resultString;


                return resultString;
            }
        
        }
        
    }




















































}
