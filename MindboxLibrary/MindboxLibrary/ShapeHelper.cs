namespace MindboxLibrary
{
    /// <summary>
    /// A class that accepts any object implementing the IShape interface and returns its area
    /// </summary>
    public class ShapeHelper
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }

}
