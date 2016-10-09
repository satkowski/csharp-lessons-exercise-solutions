using System;

namespace ExerciseSolution
{
    public class Point2D
    {
        public int X;
        public int Y;

        
        public Point2D()
        {
            X = 0;
            Y = 0;
        }
        
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        
        public double calculateEuclideanDistanceTo(Point2D point)
        {
            double distance = Math.Sqrt((this.X - point.X) * (this.X - point.X) +
                                        (this.Y - point.Y) * (this.Y - point.Y));
            return distance;
        }
    }
}
