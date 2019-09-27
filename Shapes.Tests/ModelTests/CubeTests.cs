using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CubeTests
  {
    [TestMethod]
    public void GetVolume_VolumeOfCube_Int()
    {
      //Arrange
      Rectangle newRect = new Rectangle(5,4);
      Cube newCube = new Cube(newRect);
      //Act
      int result = newCube.GetVolume();
      //Assert
      Assert.AreEqual(100, result);
    }
    [TestMethod]
    public void GetSurfaceArea_OfCube_Int()
    {
      //Arrange
      Rectangle newRect = new Rectangle(4,4);
      Cube newCube = new Cube(newRect);
      //Act
      int result = newCube.GetSurfaceArea();
      //Assert
      Assert.AreEqual(96, result);
    }
  }
}