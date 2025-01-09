using System;

namespace CircleAreaProgram {
  class CircleArea{
    public static void Main(string[] args){
      const double pi = 3.14;

      double radius;
      Console.WriteLine("Enter radius: ");
      radius = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine($"radius {radius}");
      double area = pi * radius * radius;
  
      Console.WriteLine($"Area: {area}");
    }
  }
}
