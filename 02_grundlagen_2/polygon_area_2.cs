using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // Read the number of vertices of the polygon.
            Console.WriteLine("How many vertices:");
            string vertexCountString = Console.ReadLine();
            int vertexCount = int.Parse(vertexCountString);

            // Only continue if there are more than 2 vertices.
            while(vertexCount < 3)
            {
                Console.WriteLine("There are not enough vertex. Please enter a new number:");
                vertexCountString = Console.ReadLine();
                vertexCount = int.Parse(vertexCountString);
            }

            // The arrays of the values.
            int[] xValues = new int[vertexCount];
            int[] yValues = new int[vertexCount];

            Console.WriteLine("Your vertex input:");

            char[] splitChar = { ':' };
            for(int c = 0; c < vertexCount; c++)
            {
                // Get the new input and look if it is a correct input.
                string inputString = Console.ReadLine();
                // Split the string in x and y value and convert them.
                string[] inputValues = inputString.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
                xValues[c] = int.Parse(inputValues[0]);
                yValues[c] = int.Parse(inputValues[1]);
            }

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