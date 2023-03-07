using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;

namespace TestLibrary;

/// <summary>
/// Triangle's Tests
/// </summary>
[TestClass]
public static class TestRectangle
{
    public static void RunTests()
    {
        TestRectangleArea();
    }

    /// <summary>
    /// checks the CalculateArea method with a given width and length
    /// </summary>
    /// <exception cref="Exception"></exception>
    [TestMethod]
    private static void TestRectangleArea()
    {
        Rectangle rectangle = new Rectangle(3, 5);
        double expectedArea = 15;
        double actualArea = rectangle.CalculateArea();
        if (expectedArea != actualArea)
        {
            throw new Exception($"Expected rectangle area to be {expectedArea}, but was {actualArea}.");
        }
    }
}