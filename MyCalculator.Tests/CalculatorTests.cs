using MyCalculator.Classes;

namespace MyCalculator.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void AddNumbers()
    {
        // Arrange
        var calculator = new Calculator();
        // Act
        var res = calculator.Add(5, 3, 1);
        // Assert
        Assert.AreEqual(9, res);
    }
}