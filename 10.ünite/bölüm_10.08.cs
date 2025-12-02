// Fig. 10.8: Employee.cs
// Employee class with references to other objects.
public class Employee
{
   public string FirstName { get; }
   public string LastName { get; }
   public Date BirthDate { get; }
   public Date HireDate { get; }

   // constructor to initialize name, birth date and hire date
   public Employee(string firstName, string lastName,
      Date birthDate, Date hireDate)
   {
      FirstName = firstName;
      LastName = lastName;
      BirthDate = birthDate;
      HireDate = hireDate;
   }

   // convert Employee to string format
   public override string ToString() => $"{LastName}, {FirstName} " +
       $"Hired: {HireDate}  Birthday: {BirthDate}";
}