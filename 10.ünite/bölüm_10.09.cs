// Fig. 10.9: EmployeeTest.cs
// Composition demonstration.
using System;

class EmployeeTest
{
   static void Main()
   {
      var birthday = new Date(7, 24, 1949);
      var hireDate = new Date(3, 12, 1988);
      var employee = new Employee("Bob", "Blue", birthday, hireDate);

      Console.WriteLine(employee);
   }
}