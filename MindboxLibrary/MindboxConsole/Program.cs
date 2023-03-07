using MindboxLibrary;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                string triangle = TriangleArea();
                if (triangle != null)
                    Console.WriteLine("The area of the triangle is equal to: " + triangle);
            }
            else if (c == 2)
            {
                string circle = CircleArea();
                if (circle != null)
                    Console.WriteLine("The area of the circle is equal to: " + circle);
            }
            else if (c == 3)
            {
                string rectangle = RectangleArea();
                if (rectangle != null)
                    Console.WriteLine("The area of the rectangle is equal to: " + rectangle);
            }
            else if (c == 4)
            {
                throw new ArgumentException($"Unknown shape type");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Display Triangle's Area
        /// </summary>
        /// <returns></returns>
        public static string TriangleArea()
        {
            Console.WriteLine("Enter the lengths of the sides of the triangle: ");
            Console.Write("Side А: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            Triangle areaLibrary = new Triangle(sideA, sideB, sideC);
            string result = areaLibrary.CalculateArea().ToString();

            return result;
        }

        /// <summary>
        /// Display Circle's Area
        /// </summary>
        /// <returns></returns>
        public static string CircleArea()
        {
            Console.WriteLine("Enter the length of the circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle areaLibrary = new Circle(radius);
            string result = areaLibrary.CalculateArea().ToString();

            return result;
        }


        /// <summary>
        /// Display Rectangle's Area
        /// </summary>
        /// <returns></returns>
        public static string RectangleArea()
        {
            Console.WriteLine("Enter the lengths of the sides of the rectangle: ");
            Console.Write("Side А: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle areaLibrary = new Rectangle(sideA, sideB);
            string result = areaLibrary.CalculateArea().ToString();

            return result;
        }
    }
}