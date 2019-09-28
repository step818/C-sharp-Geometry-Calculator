using System;
using System.Collections.Generic;
using Shapes.Models;

namespace Shapes
{
  public class Program
  {
    public static void Main()
    {
      Rectangle newRectangle = new Rectangle(4, 4);
      Console.WriteLine("Hi! Lets get geometric with shapes. Type in any one of the following shapes to calculate its standard dimensions.");
      Console.WriteLine("(Rectangle, Square, Cube, Circle, Sphere) ...more to come...");
      string userShape = Console.ReadLine();
      if (userShape == "Rectangle")
      {
        Console.WriteLine("Type in the length of the rectangle:");
        int userLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Now type in the width of the rectangle:");
        int userWidth = int.Parse(Console.ReadLine());
        Rectangle uRect = new Rectangle(userLength, userWidth);
        int result = uRect.GetArea();
        bool squa = uRect.IsSquare();
        Console.WriteLine("The area is : " + result);
        Console.WriteLine("Is it a square? " + squa);
        // newRectangle.GetArea(userLength, userWidth);
        // newRectangle.IsSquare(userLength, userWidth);
      }
    }
  }
}