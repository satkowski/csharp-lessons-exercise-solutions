using System;

namespace ExerciseSolution
{
    class Program
    {
        public static void Main()
        {
            // The arrays of the values.
            int[] xValues = new int[100];
            int[] yValues = new int[100];
            int vertexCount = 0;

            Console.WriteLine("Your input:");

            bool continueInput = true;
            char[] splitChar = { ':' };
            while(continueInput)
            {
                // Get the new input and look if it is a correct input.
                string inputString = Console.ReadLine();
                if(inputString == "")
                {
                    if(vertexCount >= 3)
                    {
                        Console.WriteLine("You ended the input.");
                        continueInput = false;
                    }
                    else
                        Console.WriteLine("There are too less input vertices. Please input more.");
                }
                else
                {
                    // Split the string in x and y value and convert them.
                    string[] inputValues = inputString.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
                    xValues[vertexCount] = int.Parse(inputValues[0]);
                    yValues[vertexCount] = int.Parse(inputValues[1]);
                    vertexCount++;
                }
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