using System;
using System.Collections.Generic;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // Get a polygon from the method.
            Polygon poly = CreatePolygon();
            Console.WriteLine("The area of this polygon is " + poly.Area + ".");

            double distance = poly.Vertices[0].calculateEuclideanDistanceTo(poly.Vertices[2]);
            Console.WriteLine("The distance between the first and the third point is " + distance + ".");

            Circle circle = CreateCircle();
            Console.WriteLine("The area of this circle is " + circle.Area + ".");

            Console.ReadLine();
        }

        public static Polygon CreatePolygon()
        {
            int vertexCount = 0;
            // Only continue if the right input was taken.
            bool inputFinished = false;
            while(!inputFinished)
            {
                // Read the number of vertices of the polygon.
                Console.WriteLine("How many vertices:");
                string vertexCountString = Console.ReadLine();
                // Try if the parsing works.
                try
                {
                    vertexCount = int.Parse(vertexCountString);
                }
                catch(Exception)
                {
                    Console.WriteLine("Your input wasn't a number.");
                    continue;
                }
                // Look if the count is to low.
                if(vertexCount < 3)
                    Console.WriteLine("The vertex count is too low (need to be greater than 2).");
                else
                    inputFinished = true;
            }

            // The list of the points.
            List<Point2D> vertices = new List<Point2D>();
            Console.WriteLine("Your vertex input:");

            char[] splitChar = { '-' };
            for(int c = 0; c < vertexCount; c++)
            {
                // Get the new input and look if it is a correct input.
                string inputString = Console.ReadLine();
                // Split the string in x and y value and convert them.
                string[] inputValues = inputString.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Point2D newPoint =  new Point2D(int.Parse(inputValues[0]), int.Parse(inputValues[1]));
                    vertices.Add(newPoint);
                }
                catch(Exception)
                {
                    Console.WriteLine("Your input wasn't correct. Please re-enter:");
                    c--;
                }
            }
            return new Polygon(vertices, new Point2D());
        }

        public static Circle CreateCircle()
        {
            int radius = 0;
            // Only continue if the right input was taken.
            bool inputFinished = false;
            while(!inputFinished)
            {
                // Read the radius.
                Console.WriteLine("What is the radius of the circle:");
                string circleRadius = Console.ReadLine();
                // Try if the parsing works.
                try
                {
                    radius = int.Parse(circleRadius);
                }
                catch(Exception)
                {
                    Console.WriteLine("Your input wasn't a number.");
                    continue;
                }
                // Look if the radius is correct.
                if(radius <= 0)
                    Console.WriteLine("The radius isn't allowed to be less or equal 0.");
                else
                    inputFinished = true;
            }
            return new Circle(radius, new Point2D());
        }
    }
}
