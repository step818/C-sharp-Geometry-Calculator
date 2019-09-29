using System;

namespace Shapes.Models
{
  public class Circle
  {
    public int Radius { get; set; }
    public Circle(int radLength)
    {
      Radius = radLength;
    }
    public double GetCircumference()
    {
      double result = 2 * Math.PI * Radius;
      return Math.Round(result, 2);
    }
    public double GetArea()
    {
      return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }
  }
}