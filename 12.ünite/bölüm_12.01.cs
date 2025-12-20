using System;

class PolymorphismTest
{
   static void Main()
   {
      // assign base-class reference to base-class variable
      var commissionEmployee = new CommissionEmployee(
         "Sue", "Jones", "222-22-2222", 10000.00M, .06M);

      // assign derived-class reference to derived-class variable
      var basePlusCommissionEmployee = new BasePlusCommissionEmployee(
         "Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

      // invoke ToString and Earnings on base-class object 
      // using base-class variable
      Console.WriteLine(
         "Call CommissionEmployee's ToString and Earnings methods " +
         "with base-class reference to base class object\n");
      Console.WriteLine(commissionEmployee.ToString());
      Console.WriteLine($"earnings: {commissionEmployee.Earnings()}\n");

      // invoke ToString and Earnings on derived-class object 
      // using derived-class variable      
      Console.WriteLine("Call BasePlusCommissionEmployee's ToString and" +
         " Earnings methods with derived class reference to" +
         " derived-class object\n");
      Console.WriteLine(basePlusCommissionEmployee.ToString());
      Console.WriteLine(
         $"earnings: {basePlusCommissionEmployee.Earnings()}\n");

      // invoke ToString and Earnings on derived-class object 
      // using base-class variable
      CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;
      Console.WriteLine(
         "Call BasePlusCommissionEmployee's ToString and Earnings " +
         "methods with base class reference to derived-class object\n");
      Console.WriteLine(commissionEmployee2.ToString());
      Console.WriteLine(
         $"earnings: {basePlusCommissionEmployee.Earnings()}\n");
   }
}
