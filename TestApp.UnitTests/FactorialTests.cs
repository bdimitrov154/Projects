using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int number = 0;
        int expected = 1;
        
        // Act
        int result = Factorial.CalculateFactorial(number);

        // Assert
        Assert.AreEqual(result, expected, "Factorial does not work with 0");
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        int number = 5;
        int expected = 120;

        // Act

        int result = Factorial.CalculateFactorial(number);

        // Assert
        Assert.AreEqual(expected, result, "Does not work with positive numbers");


    }
}
