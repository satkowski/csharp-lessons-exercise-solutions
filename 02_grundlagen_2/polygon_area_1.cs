using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // The arrays of the values.
            int[] xValues = { 0, 3.5f, 3, 0 };
            int[] yValues = { 0, 0, 3, 3 };
            // Get the area from the method.
            float solution = calcPolygonArea(xValues, yValues);

            Console.WriteLine("The area of this polygon is " + solution + ".");

            Console.ReadLine();
        }

        private static float calcPolygonArea(int[] xValues, int[] yValues)
        {
            float area = 0;
            // Go through all vertices and calculate the area.
            for(int c = 0; c < xValues.Length; c++)
            {
                // Add all point pairs.
                if(c < xValues.Length - 1)
                    area += (xValues[c] - xValues[c + 1]) * (yValues[c] + yValues[c + 1]);
                // Don't forget the last pair (last and first point).
                else
                    area += (xValues[c] - xValues[0]) * (yValues[c] + yValues[0]);
            }
            // Take the absolute half value.
            return Math.Abs(area / 2);
        }
    }
}
