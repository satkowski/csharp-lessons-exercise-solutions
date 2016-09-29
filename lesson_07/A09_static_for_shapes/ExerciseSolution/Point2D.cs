using System;

namespace ExerciseSolution
{
    /// <summary>
    /// Represent a point in 2D.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// The x value of the point.
        /// </summary>
        public int X;
        /// <summary>
        /// The y value of the point.
        /// </summary>
        public int Y;


        /// <summary>
        /// Constructor. Assign 0 to the coordinates.
        /// </summary>
        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Constructor. Assign the parameters to the coordinates.
        /// </summary>
        /// <param name="x">the x coordinate</param>
        /// <param name="y">the y coordinate</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }


        /// <summary>
        /// Calculates the euclidean distance between this and the parameter point.
        /// </summary>
        /// <param name="point">the other point</param>
        /// <returns>the distance between the points</returns>
        public double calculateEuclideanDistanceTo(Point2D point)
        {
            double distance = Math.Sqrt((this.X - point.X) * (this.X - point.X) +
                                        (this.Y - point.Y) * (this.Y - point.Y));
            return distance;
        }

        /// <summary>
        /// Creates a new Point2D object with a string.
        /// </summary>
        /// <param name="pointString">a string that represent the coordinates. Looks like "x-y".</param>
        /// <returns>the created Point2D</returns>
        public static Point2D CreatePoint(string pointString)
        {
            char[] splitChar = { '-' };
            string[] coordinateValues = pointString.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);

            Point2D newPoint;
            try
            {
                newPoint = new Point2D(int.Parse(coordinateValues[0]), int.Parse(coordinateValues[1]));
            }
            catch(Exception e)
            {
                newPoint = null;
            }

            return newPoint;
        }

    }
}
