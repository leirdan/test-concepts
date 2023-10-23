using MyCalculator.Classes;

namespace MyCalculator.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void AddNumbersTest()
    {
        // Arrange
        var calculator = new Calculator();
        // Act
        var res = calculator.Add(5, 3, 1);
        // Assert
        Assert.AreEqual(9, res);
    }
    [TestMethod]
    public void SubtractNumbersTest()
    {
        var calculator = new Calculator();
        var res = calculator.Subtract(10, 3, 5);
        Assert.AreEqual(2, res);
    }
    [TestMethod]
    public void MultiplyNumbersTest() { 
        var calculator = new Calculator();
        var res = calculator.Multiply(10, -1, -2);
        Assert.AreEqual(20, res);
    }
    [TestMethod]
    public void DivideNumbersTest()
    {
        var calculator = new Calculator();
        var res = calculator.Divide(100, 2, 5, 5, 2);
        Assert.AreEqual(1, res);
    }
    [TestMethod]
    public void DivideByZeroTest()
    {
        var calculator = new Calculator();
        var res = calculator.Divide(20, 0);
        Assert.AreEqual(null, res);
    }
}