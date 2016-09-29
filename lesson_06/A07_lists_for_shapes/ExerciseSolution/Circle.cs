using System;

namespace ExerciseSolution
{
    /// <summary>
    /// Represent a circle shape.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// The radius of the shape.
        /// </summary>
        public float Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Area = calculateArea();
            }
        }
        private float radius;


        /// <summary>
        /// Constructor. Creates a circle with the given radius.
        /// </summary>
        /// <param name="radius">the radius of this shape</param>
        /// <param name="position">the position of this shape</param>
        public Circle(float radius, Point2D position) 
            : base(position)
        {
            Radius = radius;
        }


        /// <summary>
        /// Calculates the area of this circle.
        /// </summary>
        /// <returns>the area</returns>
        protected override float calculateArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }
    }
}
