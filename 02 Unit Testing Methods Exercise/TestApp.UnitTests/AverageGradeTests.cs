using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grade = new List<double> { 1.99, -1, 4, 3 };
        string expectedText = "Incorrect grades";

        // Act
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert
        Assert.AreEqual(expectedText, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        // Arrange 
        List<double> grade = new List<double> { 12, 7, 8, 14 };
        string expectedText = "Incorrect grades";

        // Act 
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert
        Assert.AreEqual(expectedText, actual);
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        // Arrange 
        List<double> grade = new List<double> {2, 2, 3 };
        string expectedText = "Fail";

        // Act 
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert 
        Assert.AreEqual(expectedText, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        // Arrange 
        List<double> grade = new List<double> { 3, 3, 3.3 };
        string expectedText = "Poor";

        // Act 
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert 
        Assert.AreEqual(expectedText, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        // Arrange
        List<double> grade = new List<double> {3.5, 4, 4.2, 4,4 };
        string expectedText = "Good";

        // Act
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert
        Assert.AreEqual(expectedText, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        // Arrange
        List<double> grade = new List<double> {4.5, 4.6, 4.9, 5.5 };
        string expecatedText = "Very good";

        // Act
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert
        Assert.AreEqual(expecatedText, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        // Arrange
        List<double> grade = new List<double> { 5.5, 5.8, 5.9, 6 };
        string expectedText = "Excellent";

        // Act
        string actual = AverageGrade.GetGradeDefinition(grade);

        // Assert
        Assert.AreEqual(expectedText, actual);

    }
}
