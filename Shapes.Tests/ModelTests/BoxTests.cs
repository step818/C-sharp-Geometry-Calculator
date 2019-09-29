using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class BoxTests
  {
    [TestMethod]
    public void GetVolume_VolumeOfBox_Int()
    {
      //Arrange
      Rectangle newRect = new Rectangle(5,4);
      Box newBox = new Box(newRect);
      //Act
      int result = newBox.GetVolume();
      //Assert
      Assert.AreEqual(100, result);
    }
    [TestMethod]
    public void GetSurfaceArea_OfBox_Int()
    {
      //Arrange
      Rectangle newRect = new Rectangle(4,4);
      Box newBox = new Box(newRect);
      //Act
      int result = newBox.GetSurfaceArea();
      //Assert
      Assert.AreEqual(96, result);
    }
  }
}