namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle EqualSide { get; set; }
    public Cube (Rectangle side)
    {
      EqualSide = side;
    }
    public int GetVolume()
    {
      int length = EqualSide.Length;
      int width = EqualSide.Width;
      return length * width * length;
    }
    public int GetSurfaceArea()
    {
      int length = EqualSide.Length;
      return length * length * 6;
    }
  }
}