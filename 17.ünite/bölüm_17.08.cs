
using System;

namespace BankLibrary
{
   [Serializable]
   public class RecordSerializable
   {
      public int Account { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public decimal Balance { get; set; }

      // default constructor sets members to default values
      public RecordSerializable()
         : this(0, string.Empty, string.Empty, 0M) { }

      // overloaded constructor sets members to parameter values
      public RecordSerializable(int account, string firstName,
         string lastName, decimal balance)
      {
         Account = account;
         FirstName = firstName;
         LastName = lastName;
         Balance = balance;
      }
   }
}
