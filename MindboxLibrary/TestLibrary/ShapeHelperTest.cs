using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;
using Xunit;

namespace TestLibrary;

/// <summary>
/// AnyShape's Tests
/// </summary>
[TestClass]
public class ShapeHelperTest
{
    /// <summary>
    /// ShapeHelperTestArea checks that the calculateArea() method from the Shape Helper class returns the correct area value of the shape.
    /// </summary>
    /// <exception cref="Exception"></exception>
    [Fact]
    public void ShapeHelperTestArea()
    {
        // Arrange
        IShape shape = new MockShape();
        ShapeHelper shapeHelper = new ShapeHelper();

        // Act
        double expectedArea = 42.42;
        double actualArea = shapeHelper.CalculateArea(shape);

        if (expectedArea != actualArea)
        {
            throw new Exception($"Expected circle area to be {expectedArea}, but was {actualArea}.");
        }

    }

    /// <summary>
    /// MockShape implements the IShape interface and returns a hard-coded area value. Instead of a mock object, an object of a real figure will be transmitted
    /// </summary>
    private class MockShape : IShape
    {
        public double CalculateArea()
        {
            return 42.42;
        }
    }
}