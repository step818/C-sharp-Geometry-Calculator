using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Radius { get; set; }
    public Sphere (Circle rad)
    {
      Radius = rad;
    }
    public double GetVolume()
    {
      int radLength = Radius.Radius;
      return Math.Round((4f /3f) * Math.PI * Math.Pow(radLength, 3), 2);
    }
    public double GetSurfaceArea()
    {
      int radLength = Radius.Radius;
      return Math.Round(4f * Math.PI * Math.Pow(radLength, 2), 2);
    }
  }
}