using System;
using System.Collections.Generic;

class Triangle
{
  private int _lengthA;
  private int _lengthB;
  private int _lengthC;

  public void SetLengthA(int newLengthA)
  {
      _lengthA = newLengthA;
  }

  public void SetLengthB(int newLengthB)
  {
      _lengthB = newLengthB;
  }

  public void SetLengthC(int newLengthC)
  {
      _lengthC = newLengthC;
  }

  public void CheckTriangle()
  {
    if (_lengthA == _lengthB && _lengthB == _lengthC)
    {
        Console.WriteLine("equalateral");
    }
    else if(_lengthA == _lengthB || _lengthB == _lengthC || _lengthA == _lengthC)
    {
        Console.WriteLine("isosceles");
    }
    else if(!(_lengthA == _lengthB && _lengthB == _lengthC && _lengthA == _lengthC))
    {
        Console.WriteLine("scalene");
    }
    else
    {
      Console.WriteLine("Second Check");
    }
  }
}


public class Program
{
  public static void Main()
  {
    Triangle newTriangle = new Triangle();
    Console.WriteLine("Set side length A");
    string lengthA = Console.ReadLine();
    newTriangle.SetLengthA(int.Parse(lengthA));
    Console.WriteLine("Set side length B");
    string lengthB = Console.ReadLine();
    newTriangle.SetLengthB(int.Parse(lengthB));
    Console.WriteLine("Set side length C");
    string lengthC = Console.ReadLine();
    newTriangle.SetLengthC(int.Parse(lengthC));
    // newTriangle.SetLengthA(1);
    // newTriangle.SetLengthB(12);
    // newTriangle.SetLengthC(13);

    newTriangle.CheckTriangle();

  }
}
