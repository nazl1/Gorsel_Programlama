using System;

class CommissionEmployeeTest
{
   static void Main()
   {
      // instantiate CommissionEmployee object
      var employee = new CommissionEmployee("Sue", "Jones",
         "222-22-2222", 10000.00M, .06M);

      // display CommissionEmployee data
      Console.WriteLine(
         "Employee information obtained by properties and methods: \n");
      Console.WriteLine($"First name is {employee.FirstName}");
      Console.WriteLine($"Last name is {employee.LastName}");
      Console.WriteLine(
         $"Social security number is {employee.SocialSecurityNumber}");
      Console.WriteLine($"Gross sales are {employee.GrossSales:C}");
      Console.WriteLine(
         $"Commission rate is {employee.CommissionRate:F2}");
      Console.WriteLine($"Earnings are {employee.Earnings():C}");

      employee.GrossSales = 5000.00M; // set gross sales   
      employee.CommissionRate = .1M; // set commission rate

      Console.WriteLine(
         "\nUpdated employee information obtained by ToString:\n");
      Console.WriteLine(employee);
      Console.WriteLine($"earnings: {employee.Earnings():C}");
   }
} 
