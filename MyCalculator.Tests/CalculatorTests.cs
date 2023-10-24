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
    // Teste controlado por dados, ou teste parametrizado.
    [DataTestMethod]
    [DataRow(3, -2, 0, 5)]
    [DataRow(1, 2, 4, -5)]
    [DataRow(-22, -2, 20, -40)]
    public void SubtractNumbersTest(int x, int y, int z, int expect)
    {
        var calculator = new Calculator();
        var res = calculator.Subtract(x, y, z);
        Assert.AreEqual(expect, res);
    }
    [DataTestMethod]
    [DataRow(3, -4, -1, 12)]
    [DataRow(6, 5, 2, 60)]
    public void MultiplyNumbersTest(int x, int y, int z, int expect) { 
        var calculator = new Calculator();
        var res = calculator.Multiply(x, y, z);
        Assert.AreEqual(expect, res);
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