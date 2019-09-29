using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void GetCircumference_OfCircle_Double()
    {
      // Arrange
      Circle newCircle = new Circle(3);
      // Act
      double result = newCircle.GetCircumference();
      // Assert
      Assert.AreEqual(18.85, result);
    }
    [TestMethod]
    public void GetArea_OfCircle_Double()
    {
      // Arrange
      Circle newCircle = new Circle(3);
      // Act
      double result = newCircle.GetArea();
      //Assert
      Assert.AreEqual(28.27, result);
    }
  }
}