using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // The variables for the two points.
            int point1X = 2;
            int point1Y = 3;
            int point2X = 5;
            int point2Y = 2;
            // Using the square root method.
            double distance = Math.Sqrt((point2X - point1X) * (point2X - point1X) +
                                        (point2Y - point1Y) * (point2Y - point1Y));

            Console.WriteLine(distance);

            Console.ReadLine();
        }
    }
}