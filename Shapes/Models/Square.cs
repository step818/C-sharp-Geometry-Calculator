using System;

namespace Shapes.Models
{
  public class Square
  {
    public int Length { get; set; }
    public Square(int sideLength)
    {
      Length = sideLength;
    }
    public int GetArea()
    {
      return Length * Length;
    }
  }
}