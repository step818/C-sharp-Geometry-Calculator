using System;
using System.Collections.Generic;
using Shapes.Models;

namespace Shapes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hi! Lets get geometric with shapes. Type in any one of the following shapes to calculate its standard dimensions.");
      Console.WriteLine("(Rectangle, Square, Circle) ...more to come...");
      string userShape = Console.ReadLine();
      // User chose Rectangle
      if (userShape == "Rectangle" || userShape == "rectangle")
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
        if (squa)
        {
          Console.WriteLine("Since your dimensions are that of a square...\n");
          Console.WriteLine("Let's transform your \"square\" in to a cube...\n");
          Box uBox = new Box(uRect);
          int resVol = uBox.GetVolume();
          int resSur = uBox.GetSurfaceArea();
          Console.WriteLine("The volume of your cube is: " + resVol);
          Console.WriteLine("The surface area of your cube is: " + resSur);
        }
        else
        {
          Console.WriteLine("Lets transform you rectangle in to a box...\n");
          Box uBox = new Box(uRect);
          int resVol = uBox.GetVolume();
          int resSur = uBox.GetSurfaceArea();
          Console.WriteLine("The volume of your box is: " + resVol);
          Console.WriteLine("The surface area of your box is: " + resSur);
        }
      }
      else if (userShape == "Square" || userShape == "square")
      {
        Console.WriteLine("Type in the length of the sides: ");
        int userLength = int.Parse(Console.ReadLine());
        Square uSquare = new Square(userLength);
        int resArea = uSquare.GetArea();
        Console.WriteLine("The area of your square is: " + resArea);
        Console.WriteLine("Now let's transofm you square in to a cube...\n");
        Cube uCube = new Cube(uSquare);
        int resVol = uCube.GetVolume();
        int resSur = uCube.GetSurfaceArea();
        Console.WriteLine("The volume of your cube is: " + resVol);
        Console.WriteLine("The Surface Area of your Cube is: " + resSur);
      }
      else if (userShape == "Circle" || userShape == "circle")
      {
        Console.WriteLine("Type in the length of the radius: ");
        int userRadius = int.Parse(Console.ReadLine());

      }
    }
  }
}