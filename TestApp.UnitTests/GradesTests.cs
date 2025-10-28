using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{

   


    [TestCase(2.50, "Fail")]
    [TestCase(3.00, "Fair")]
    [TestCase(2.99, "Good")]
    [TestCase(2.99, "Very Good")]
    [TestCase(2.99, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange
         grade = 4.50;
         expected = "Very Good";
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestCase(2.99, "Fail")]
    [TestCase(3.50, "Good")]
    [TestCase(4.50, "Very Good")]
    [TestCase(5.50, "Excellent")]
    [TestCase(6.50, "Invalid")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange
        grade = 2.99;
        expected = "Fail";

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
