// Fig. 10.11: EmployeeTest.cs
// static member demonstration.
using System;

public class EmployeeTest
{
   static void Main()
   {
      // show that Count is 0 before creating Employees
      Console.WriteLine(
         $"Employees before instantiation: {Employee.Count}");

      // create two Employees; Count should become 2
      var e1 = new Employee("Susan", "Baker");
      var e2 = new Employee("Bob", "Blue");

      // show that Count is 2 after creating two Employees
      Console.WriteLine(
         $"\nEmployees after instantiation: {Employee.Count}");

      // get names of Employees
      Console.WriteLine($"\nEmployee 1: {e1.FirstName} {e1.LastName}");
      Console.WriteLine($"Employee 2: {e2.FirstName} {e2.LastName}");

      // in this example, there is only one reference to each Employee,
      // so the following statements cause the CLR to mark each        
      // Employee object as being eligible for garbage collection      
      e1 = null; // mark object referenced by e1 as no longer needed
      e2 = null; // mark object referenced by e2 as no longer needed
   }
}