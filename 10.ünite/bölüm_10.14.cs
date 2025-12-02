// Fig. 10.14: ComplexNumber.cs
// Value type that overloads operators for adding, subtracting
// and multiplying complex numbers.
using System;

public struct ComplexNumber
{
   // read-only properties that get the real and imaginary components
   public double Real { get; }
   public double Imaginary { get; }

   // constructor
   public ComplexNumber(double real, double imaginary)
   {
      Real = real;
      Imaginary = imaginary;
   }

   // return string representation of ComplexNumber
   public override string ToString() =>
      $"({Real} {(Imaginary < 0 ? "-" : "+")} {Math.Abs(Imaginary)}i)";

   // overload the addition operator
   public static ComplexNumber operator+(ComplexNumber x, ComplexNumber y)
   {
      return new ComplexNumber(x.Real + y.Real,
         x.Imaginary + y.Imaginary);
   }

   // overload the subtraction operator         
   public static ComplexNumber operator-(ComplexNumber x, ComplexNumber y)
   {
      return new ComplexNumber(x.Real - y.Real,
         x.Imaginary - y.Imaginary);
   }

   // overload the multiplication operator
   public static ComplexNumber operator*(ComplexNumber x, ComplexNumber y)
   {
      return new ComplexNumber(
         x.Real * y.Real - x.Imaginary * y.Imaginary,
         x.Real * y.Imaginary + y.Real * x.Imaginary);
   }
}