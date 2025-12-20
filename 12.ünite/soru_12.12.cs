using System;

// IPayable interface
public interface IPayable
{
    decimal GetPaymentAmount();
}

// Invoice class
public class Invoice : IPayable
{
    public string PartNumber { get; }
    public string PartDescription { get; }
    public int Quantity { get; }
    public decimal PricePerItem { get; }

    public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        Quantity = quantity;
        PricePerItem = pricePerItem;
    }

    public decimal GetPaymentAmount()
    {
        return Quantity * PricePerItem;
    }

    public override string ToString()
    {
        return $"Invoice:\nPart Number: {PartNumber}\nDescription: {PartDescription}\n" +
               $"Quantity: {Quantity}\nPrice Per Item: {PricePerItem:C}";
    }
}

// Abstract Employee class
public abstract class Employee : IPayable
{
    public string FirstName { get; }
    public string LastName { get; }
    public string SSN { get; }

    protected Employee(string firstName, string lastName, string ssn)
    {
        FirstName = firstName;
        LastName = lastName;
        SSN = ssn;
    }

    public abstract decimal GetPaymentAmount();

    public override string ToString()
    {
        return $"{FirstName} {LastName}\nSSN: {SSN}";
    }
}

// SalariedEmployee
public class SalariedEmployee : Employee
{
    public decimal WeeklySalary { get; }

    public SalariedEmployee(string first, string last, string ssn, decimal salary)
        : base(first, last, ssn)
    {
        WeeklySalary = salary;
    }

    public override decimal GetPaymentAmount()
    {
        return WeeklySalary;
    }

    public override string ToString()
    {
        return $"Salaried Employee:\n{base.ToString()}\nWeekly Salary: {WeeklySalary:C}";
    }
}

// HourlyEmployee
public class HourlyEmployee : Employee
{
    public decimal Wage { get; }
    public double Hours { get; }

    public HourlyEmployee(string first, string last, string ssn, decimal wage, double hours)
        : base(first, last, ssn)
    {
        Wage = wage;
        Hours = hours;
    }

    public override decimal GetPaymentAmount()
    {
        return (decimal)Hours * Wage;
    }

    public override string ToString()
    {
        return $"Hourly Employee:\n{base.ToString()}\nHourly Wage: {Wage:C}, Hours: {Hours}";
    }
}

// CommissionEmployee
public class CommissionEmployee : Employee
{
    public decimal GrossSales { get; }
    public decimal CommissionRate { get; }

    public CommissionEmployee(string first, string last, string ssn,
                              decimal sales, decimal rate)
        : base(first, last, ssn)
    {
        GrossSales = sales;
        CommissionRate = rate;
    }

    public override decimal GetPaymentAmount()
    {
        return GrossSales * CommissionRate;
    }

    public override string ToString()
    {
        return $"Commission Employee:\n{base.ToString()}\n" +
               $"Gross Sales: {GrossSales:C}, Commission Rate: {CommissionRate:P}";
    }
}

// BasePlusCommissionEmployee
public class BasePlusCommissionEmployee : CommissionEmployee
{
    public decimal BaseSalary { get; private set; }

    public BasePlusCommissionEmployee(string first, string last, string ssn,
                                      decimal sales, decimal rate, decimal baseSalary)
        : base(first, last, ssn, sales, rate)
    {
        BaseSalary = baseSalary;
    }

    public void IncreaseBaseSalary(decimal percent)
    {
        BaseSalary += BaseSalary * percent;
    }

    public override decimal GetPaymentAmount()
    {
        return BaseSalary + base.GetPaymentAmount();
    }

    public override string ToString()
    {
        return $"Base-Salaried Commission Employee:\n{base.ToString()}\n" +
               $"Base Salary: {BaseSalary:C}";
    }
}

// Test application
class PayableInterfaceTest
{
    static void Main()
    {
        IPayable[] payableObjects =
        {
            new Invoice("01234", "Seat", 2, 375.00m),
            new Invoice("56789", "Tire", 4, 79.95m),

            new SalariedEmployee("John", "Smith", "111-11-1111", 800.00m),
            new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75m, 40),
            new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000m, 0.06m),
            new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444",
                                           5000m, 0.04m, 300.00m)
        };

        foreach (IPayable payable in payableObjects)
        {
            Console.WriteLine(payable);

            if (payable is BasePlusCommissionEmployee emp)
            {
                emp.IncreaseBaseSalary(0.10m);
                Console.WriteLine("Base salary increased by 10%");
            }

            Console.WriteLine($"Payment Due: {payable.GetPaymentAmount():C}\n");
        }
    }
}