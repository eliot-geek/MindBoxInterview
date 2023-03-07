using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;

namespace TestLibrary;

/// <summary>
/// Triangle's Test
/// </summary>
[TestClass]
public static class TestTriangle
{
    public static void RunTests()
    {
        TestTriangleArea();
    }

    /// <summary>
    /// checks the calculateArea method with the specified sides
    /// </summary>
    /// <exception cref="Exception"></exception>
    [TestMethod]
    private static void TestTriangleArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        double actualArea = triangle.CalculateArea();
        if (expectedArea != actualArea)
        {
            throw new Exception($"Expected triangle area to be {expectedArea}, but was {actualArea}.");
        }
    }
}