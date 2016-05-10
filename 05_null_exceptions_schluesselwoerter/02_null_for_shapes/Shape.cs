
namespace ExerciseSolution
{
    public abstract class Shape
    {
        /// <summary>
        /// The position of this shape on the 2D plane.
        /// </summary>
        public Point2D Position;

        /// <summary>
        /// The area of the polygon.
        /// </summary>
        public float Area
        { get; protected set; }


        /// <summary>
        /// Constructor. Creates a shape with a given position.
        /// </summary>
        /// <param name="position">the position of this shape</param>
        public Shape(Point2D position)
        {
            Area = 0;
            Position = position;
        }


        /// <summary>
        /// Calculates the area of this shape.
        /// </summary>
        /// <returns>the area</returns>
        protected abstract float calculateArea();
    }
}
