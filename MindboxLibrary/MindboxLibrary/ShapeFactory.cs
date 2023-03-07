namespace MindboxLibrary
{
    /// <summary>
    /// Ease of adding other shapes
    /// which allows you to create instances of different shapes, passing the necessary arguments depending on the type of shape.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Enumeration 
        /// </summary>
        public enum ShapeType { Circle, Triangle, Rectangle }

        public static IShape CreateShape(ShapeType shapeType, params double[] args)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    if (args.Length != 1)
                        throw new ArgumentException("Circle requires one argument: radius");
                    return new Circle(args[0]);

                case ShapeType.Triangle:
                    if (args.Length != 3)
                        throw new ArgumentException("Triangle requires three arguments: side1, side2, side3");
                    return new Triangle(args[0], args[1], args[2]);

                // Adding other shapes is implemented by adding a new case to this method.
                // For each new shape, you need to create a new class that implements IShape.
                // As arguments, you can pass everything that is necessary to calculate the area of this figure.

                // Example
                case ShapeType.Rectangle:
                    if (args.Length != 2)
                        throw new ArgumentException("Rectangle requires two arguments: width, height");
                    return new Rectangle(args[0], args[1]);

                default:
                    throw new ArgumentException($"Unknown shape type");
            }
        }
    }
}
