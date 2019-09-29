using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CubeTests
  {
    [TestMethod]
    public void GetVolume_OfCube_Int()
    {
      // Arrange
      Square newSquare = new Square(9);
      Cube newCube = new Cube(newSquare);
      // Act
      int result = newCube.GetVolume();
      // Assert
      Assert.AreEqual(729, result);
    }
    [TestMethod]
    public void GetSurfaceArea_OfCube_Int()
    {
      // Arrange
      Square newSquare = new Square(9);
      Cube newCube = new Cube(newSquare);
      // Act
      int result = newCube.GetSurfaceArea();
      // Assert
      Assert.AreEqual(486, result);
    }
  }
}