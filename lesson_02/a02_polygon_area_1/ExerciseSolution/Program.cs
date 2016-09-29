using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // The arrays of the values.
            int[] xValues = { 0, 3, 3, 0 };
            int[] yValues = { 0, 0, 3, 3 };
            // Get the area from the method.
            float solution = calcPolygonArea(xValues, yValues);

            Console.WriteLine("The area of this polygon is " + solution + ".");

            Console.ReadLine();
        }

        private static float calcPolygonArea(int[] xValues, int[] yValues)
        {
            float area = 0;
            int count = 0;
            // Go through all vertices and calculate the area.
            while(count < xValues.Length)
            {
                // Add all point pairs.
                if(count < xValues.Length - 1)
                    area += (xValues[count] - xValues[count + 1]) * (yValues[count] + yValues[count + 1]);
                // Don't forget the last pair (last and first point).
                else
                    area += (xValues[count] - xValues[0]) * (yValues[count] + yValues[0]);

                count++;
            }
            // Take the absolute half value.
            return Math.Abs(area / 2);
        }
    }
}
