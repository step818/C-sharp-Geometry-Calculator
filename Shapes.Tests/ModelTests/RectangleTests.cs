using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void GetArea_AreaOfRectangle_Int()
    {
      //Arrange
      Rectangle rect1 = new Rectangle(5,4);
      //Act
      int result = rect1.GetArea();
      //Assert
      Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void IsSquare_CompareSides_Bool()
    {
      //Arrange
      Rectangle rect2 = new Rectangle(9,9);
      //Act
      bool result = rect2.IsSquare();
      //Assert
      Assert.AreEqual(true, result);
    }
  }
}