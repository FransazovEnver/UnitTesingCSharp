using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{

    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isExpectedValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(isExpectedValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "@example.com";

        // Act
        bool isExpectedInvalidEmail = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.IsFalse(isExpectedInvalidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string input = null;

        // Act
        bool isValidEmail = Email.IsValidEmail(input);

        // Assert
        Assert.IsFalse(isValidEmail);
    }
}
