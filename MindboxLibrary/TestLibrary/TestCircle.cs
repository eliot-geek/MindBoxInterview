using MindboxLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary;

/// <summary>
/// Circle's Tests
/// </summary>
[TestClass]
public static class TestCircle
{
    public static void RunTests()
    {
        TestCircleArea();
    }

    /// <summary>
    /// checks the CalculateArea method with a given radius
    /// </summary>
    /// <exception cref="Exception"></exception>
    [TestMethod]
    private static void TestCircleArea()
    {
        Circle circle = new Circle(5);
        double expectedArea = Math.PI * 25;
        double actualArea = circle.CalculateArea();
        if (expectedArea != actualArea)
        {
            throw new Exception($"Expected circle area to be {expectedArea}, but was {actualArea}.");
        }
    }
}