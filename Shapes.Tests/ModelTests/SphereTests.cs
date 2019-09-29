using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void GetVolume_OfSphere_Int()
    {
      // Arrange
      Circle newCirc = new Circle(3);
      Sphere newSphere = new Sphere(newCirc);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(113.1, result);
    }
    [TestMethod]
    public void GetSurfaceArea_OfSphere_Int()
    {
      // Arrange
      Circle newCirc = new Circle(5);
      Sphere newSphere = new Sphere(newCirc);
      // Act
      double result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(314.16, result);
    }
  }
}