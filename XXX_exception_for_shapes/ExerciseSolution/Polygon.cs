using System;

namespace ExerciseSolution
{
    /// <summary>
    /// Represent a polygon shape.
    /// </summary>
    public class Polygon : Shape
    {
        /// <summary>
        /// The listing of all vertex that this polygon owns.
        /// </summary>
        public Point2D[] Vertices
        {
            get { return vertices; }
            set
            {
                vertices = value;
                Area = calculateArea();
            }
        }
        private Point2D[] vertices;

        /// <summary>
        /// The count of the vertices.
        /// </summary>
        public int VertexCount
        {
            get { return Vertices.Length; }
        }

        /// <summary>
        /// Constructor. Creates a polygon with the given number of vertices, but all of them are 0.
        /// </summary>
        /// <param name="vertexCount">the number of vertices</param>
        /// <param name="position">the position of this shape</param>
        public Polygon(int vertexCount, Point2D position)
            : base(position)
        {
            vertices = new Point2D[vertexCount];
        }

        /// <summary>
        /// Constructor. Creates a polygon with the given array of vertices.
        /// </summary>
        /// <param name="vertices">the vertices</param>
        public Polygon(Point2D[] vertices, Point2D position)
            : base(position)
        {
            Vertices = vertices;
        }


        /// <summary>
        /// Calculates the area of this polygon.
        /// </summary>
        /// <returns>the area</returns>
        protected override float calculateArea()
        {
            float area = 0;
            // Go through all vertices and calculate the area.
            for(int c = 0; c < Vertices.Length; c++)
            {
                // Add all point pairs.
                if(c < Vertices.Length - 1)
                    area += (Vertices[c].X - Vertices[c + 1].X) * (Vertices[c].Y + Vertices[c + 1].Y);
                // Don't forget the last pair (last and first point).
                else
                    area += (Vertices[c].X - Vertices[0].X) * (Vertices[c].Y + Vertices[0].Y);
            }
            // Take the absolute half value.
            return Math.Abs(area / 2);
        }

        /// <summary>
        /// Creates a new polygon with a user input algrotihm.
        /// </summary>
        /// <returns>the created polygon</returns>
        public static Polygon CreatePolygon()
        {
            int vertexCount = 0;
            // Only continue if the right input was taken.
            bool inputFinished = false;
            while(!inputFinished)
            {
                // Read the number of vertices of the polygon.
                Console.WriteLine("How many vertices:");
                string vertexCountString = Console.ReadLine();
                // Try if the parsing works.
                try
                {
                    vertexCount = int.Parse(vertexCountString);
                }
                catch(Exception)
                {
                    Console.WriteLine("Your input wasn't a number.");
                    continue;
                }
                // Look if the count is to low.
                if(vertexCount < 3)
                    Console.WriteLine("The vertex count is too low (need to be greater than 2).");
                else
                    inputFinished = true;
            }

            // The arrays of the points.
            Point2D[] vertices = new Point2D[vertexCount];
            Console.WriteLine("Your vertex input:");

            for(int c = 0; c < vertexCount; c++)
            {
                Point2D newPoint = Point2D.CreatePoint(Console.ReadLine());
                // If the vertex input wasn't correct, the user need to make a new input.
                if(newPoint == null)
                {
                    Console.WriteLine("Your input wasn't correct. Please re-enter:");
                    c--;
                }
                else
                    vertices[c] = newPoint;
            }
            return new Polygon(vertices, new Point2D());
        }
    }
}
