using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(2.10, "Fail")]
    [TestCase(2.49, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.10, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(3.51, "Good")]
    [TestCase(4.49, "Good")]
    [TestCase(4.50, "Very Good")]
    [TestCase(4.51, "Very Good")]
    [TestCase(5.49, "Very Good")]
    [TestCase(5.50, "Excellent")]
    [TestCase(5.51, "Excellent")]
    [TestCase(6.00, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(1,"Invalid!")]
    [TestCase(1.66,"Invalid!")]
    [TestCase(18,"Invalid!")]
    [TestCase(6.10, "Invalid!")]
    [TestCase(9090,"Invalid!")]
    [TestCase(111,"Invalid!")]
    
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
