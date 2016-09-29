using System;
using System.Collections.Generic;

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
        public List<Point2D> Vertices
        {
            get { return vertices; }
            set
            {
                vertices = value;
                Area = calculateArea();
            }
        }
        private List<Point2D> vertices;

        /// <summary>
        /// The count of the vertices.
        /// </summary>
        public int VertexCount
        {
            get { return Vertices.Count; }
        }

        /// <summary>
        /// Constructor. Creates a polygon with the given number of vertices, but all of them are 0.
        /// </summary>
        /// <param name="vertexCount">the number of vertices</param>
        /// <param name="position">the position of this shape</param>
        public Polygon(Point2D position)
            : base(position)
        {
            vertices = new List<Point2D>();
        }

        /// <summary>
        /// Constructor. Creates a polygon with the given array of vertices.
        /// </summary>
        /// <param name="vertices">the vertices</param>
        public Polygon(List<Point2D> vertices, Point2D position)
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
            for(int c = 0; c < Vertices.Count; c++)
            {
                // Add all point pairs.
                if(c < Vertices.Count - 1)
                    area += (Vertices[c].X - Vertices[c + 1].X) * (Vertices[c].Y + Vertices[c + 1].Y);
                // Don't forget the last pair (last and first point).
                else
                    area += (Vertices[c].X - Vertices[0].X) * (Vertices[c].Y + Vertices[0].Y);
            }
            // Take the absolute half value.
            return Math.Abs(area / 2);
        }
    }
}
