using NUnit.Framework;
using System.Globalization;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange 
        string input = "";
        string expected = "Empty string";

        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert 
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange 
        string input = "  ";
        string expected = "Empty string";

        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange 
        string input = "y";
        string expected = "y";

        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert 
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange 
        string input = "even";
        string expected = "ve";

        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange 
        string input = "odd";
        string expected = "d";

        // Act
        string actual = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
