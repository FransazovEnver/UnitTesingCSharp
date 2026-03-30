using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;
        int expected = 0;

        // Act
        expected = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, input);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int input = 23;
        int expected = 42;

        // Act
        expected = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.IsTrue(expected > input);
    }
}