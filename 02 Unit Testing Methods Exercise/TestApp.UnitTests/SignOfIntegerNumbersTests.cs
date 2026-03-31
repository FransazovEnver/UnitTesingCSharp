using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        // Arrange
        string number = "#";
        string expectedErr = "The input is not an integer!";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(number);

        // Assert 
        Assert.AreEqual(expectedErr, result);

    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        // Arrange
        string input = "0";
        string expected = $"The number {input} is zero.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        // Arrange
        string input = "-45";
        string expected = $"The number {input} is negative.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        // Arrange
        string input = "23";
        string expected = $"The number {input} is positive.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
