using NUnit.Framework;
using System.Linq;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        expected = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, input);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        //Arrange
        string input = "r";
        string expected = "r";

        // Act 
        expected = StringReverse.Reverse(input);

        //Assert
        Assert.AreEqual(expected, input);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        //Arrange
        string input = "Selenium";
        string expected = "muineleS";
        //Act
        string actual = StringReverse.Reverse(input);
        //Assert
        Assert.AreEqual(expected, actual);
    }
}
