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
    [TestMethod]
    public void SubtractNumbers()
    {
        var calculator = new Calculator();
        var res = calculator.Subtract(10, 3, 5);
        Assert.AreEqual(2, res);
    }
    [TestMethod]
    public void MultiplyNumbers() { 
        var calculator = new Calculator();
        var res = calculator.Multiply(10, -1, -2);
        Assert.AreEqual(20, res);
    }
    [TestMethod]
    public void DivideNumbers()
    {
        var calculator = new Calculator();
        var res = calculator.Divide(20, 5, 2);
        Assert.AreEqual(2, res);
    }
}