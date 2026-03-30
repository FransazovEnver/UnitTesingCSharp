using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    private Calculate calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculate();
    }

    [TestCase(2, 5, 7)]
    [TestCase(123, 666, 789)]
    [TestCase(14 + 14, 2, 30)]
    public void Test_Addition(int firstNumber, int secondNumber, int expected)
    {
        // Act
        int actual = calculator.Addition(firstNumber, secondNumber);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }


    [TestCase(5, 2, 3)]
    [TestCase(29, 14, 15)]
    [TestCase(100, 51, 49)]
    [TestCase(10 - 7, 1, 2)]
    [TestCase(10 + 7, 1, 16)]
    public void Test_Subtraction(int firstNumber, int secondNumber, int expected)
    {
        // Act
        int actual = calculator.Subtraction(firstNumber, secondNumber);

        // Assert
        Assert.AreEqual(expected, actual, "Subtraction did not work properly.");
    }
}
