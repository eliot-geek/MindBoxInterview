using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLibrary
{
    /// <summary>
    /// Circle
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Radius
        /// </summary>
        private readonly double radius;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Returns the area
        /// </summary>
        /// <returns>Circle's Area</returns>
        public double CalculateArea()
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "The radius of the circle cannot be less than 0.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
