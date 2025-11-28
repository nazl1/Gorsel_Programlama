  using System;
  class Sphere
  {
    static void Main()
    {
      Console.Write("Enter radius of sphere: ");
      double radius = double.Parse(Console.ReadLine());
      Console.WriteLine("Volume is {SphereVolume(radius):F3}");
    } 

    static double SphereVolume(double radius) =>
       (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
  }       