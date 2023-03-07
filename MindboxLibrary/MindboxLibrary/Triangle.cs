using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLibrary
{
    /// <summary>
    /// Triangle
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Triangle's sides
        /// </summary>
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="side1">side 1</param>
        /// <param name="side2">side 2</param>
        /// <param name="side3">side 3</param>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("The side of the triangle cannot be less than or equal to zero.");
            }

            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("There is no triangle with such sides.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        /// <summary>
        /// Indicates whether the triangle is correct
        /// </summary>
        /// <param name="a">side 1</param>
        /// <param name="b">side 2</param>
        /// <param name="c">side 3</param>
        /// <returns>true if the triangle exists, otherwise false</returns>
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }


        /// <summary>
        /// Returns the area
        /// </summary>
        /// <returns>The area of the triangle</returns>
        public double CalculateArea()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        /// <summary>
        /// Indicates whether the triangle is rectangular
        /// </summary>
        /// <returns>true if the triangle is rectangular, otherwise false</returns>
        public bool IsRightAngled()
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
