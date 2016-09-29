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

        /// <summary>
        /// Creates a new circle with a user input algrotihm.
        /// </summary>
        /// <returns>the created circle</returns>
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
