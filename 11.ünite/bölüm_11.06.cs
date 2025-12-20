using System;

public class BasePlusCommissionEmployee
{
   public string FirstName { get; }
   public string LastName { get; }
   public string SocialSecurityNumber { get; }
   private decimal grossSales; // gross weekly sales 
   private decimal commissionRate; // commission percentage
   private decimal baseSalary; // base salary per week

   // six-parameter constructor
   public BasePlusCommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales,
      decimal commissionRate, decimal baseSalary)
   {
      // implicit call to object constructor occurs here
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
      GrossSales = grossSales; // validates gross sales
      CommissionRate = commissionRate; // validates commission rate
      BaseSalary = baseSalary; // validates base salary
   }

   // property that gets and sets gross sales
   public decimal GrossSales
   {
      get
      {
         return grossSales;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(GrossSales)} must be >= 0");
         }

         grossSales = value;
      }
   }

   // property that gets and sets commission rate
   public decimal CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         if (value <= 0 || value >= 1) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(CommissionRate)} must be > 0 and < 1");
         }

         commissionRate = value;
      }
   }

   // property that gets and sets BasePlusCommissionEmployee's base salary
   public decimal BaseSalary
   {
      get
      {
         return baseSalary;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(BaseSalary)} must be >= 0");
         }

         baseSalary = value;
      }
   }

   // calculate earnings
   public decimal Earnings() =>
      baseSalary + (commissionRate * grossSales);

   // return string representation of BasePlusCommissionEmployee
   public override string ToString() =>
      $"base-salaried commission employee: {FirstName} {LastName}\n" +
      $"social security number: {SocialSecurityNumber}\n" +
      $"gross sales: {grossSales:C}\n" +
      $"commission rate: {commissionRate:F2}\n" +
      $"base salary: {baseSalary:C}";
}
