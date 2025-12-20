
namespace BankLibrary
{
   public class Record
   {
      public int Account { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public decimal Balance { get; set; }

      // parameterless constructor sets members to default values
      public Record() : this(0, string.Empty, string.Empty, 0M) { }

      // overloaded constructor sets members to parameter values
      public Record(int account, string firstName,
         string lastName, decimal balance)
      {
         Account = account;
         FirstName = firstName;
         LastName = lastName;
         Balance = balance;
      }
   }
}

