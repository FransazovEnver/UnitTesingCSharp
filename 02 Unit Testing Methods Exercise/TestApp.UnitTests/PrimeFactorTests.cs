using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        int primeNumber = 71;

        // Act
        long expectedNumber = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        // Assert
        Assert.AreEqual(expectedNumber, primeNumber);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long largeNumber = 1234567;

        long expected = 9721;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largeNumber);

        // Assert
        Assert.AreEqual(result, expected);
    }
}
