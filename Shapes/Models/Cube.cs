namespace Shapes.Models
{
  public class Cube
  {
    public Square EqualSide { get; set; }
    public Cube (Square side)
    {
      EqualSide = side;
    }
    public int GetVolume()
    {
      int length = EqualSide.Length;
      return length * length * length;
    }
    public int GetSurfaceArea()
    {
      int length = EqualSide.Length;
      return length * length * 6;
    }
  }
}