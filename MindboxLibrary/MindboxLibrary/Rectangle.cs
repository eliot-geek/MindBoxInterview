using MindboxLibrary;

/// <summary>
/// Rectangle
/// </summary>
public class Rectangle : IShape
{
    /// <summary>
    /// Rectangle's sides
    /// </summary>
    private readonly double length;
    private readonly double width;


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="length">length</param>
    /// <param name="width">width</param>
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    /// <summary>
    /// Returns the area
    /// </summary>
    /// <returns>Rectangle area</returns>
    public double CalculateArea()
    {
        return length * width;
    }
}
