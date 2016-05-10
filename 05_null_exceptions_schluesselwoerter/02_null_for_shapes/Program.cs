using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // Get a polygon from the method.
            Polygon poly = Polygon.CreatePolygon();
            Console.WriteLine("The area of this polygon is " + poly.Area + ".");

            double distance = poly.Vertices[0].calculateEuclideanDistanceTo(poly.Vertices[2]);
            Console.WriteLine("The distance between the first and the third point is " + distance + ".");

            Circle circle = Circle.CreateCircle();
            Console.WriteLine("The area of this circle is " + circle.Area + ".");

            Console.ReadLine();
        }
    }
}
