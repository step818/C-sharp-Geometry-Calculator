namespace Shapes.Models
{
  public class Box
  {
    public Rectangle EqualSide { get; set; }
    public Box (Rectangle side)
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
      int width = EqualSide.Width;
      return length * width * 6;
    }
  }
}