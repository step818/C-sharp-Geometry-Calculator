using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SquareTests
  {
    [TestMethod]
    public void GetArea_OfSquare_Int()
    {
      // Arrange
      Square newSquare = new Square(4);
      // Act 
      int result = newSquare.GetArea();
      // Assert 
      Assert.AreEqual(16, result);
    }
  }
}