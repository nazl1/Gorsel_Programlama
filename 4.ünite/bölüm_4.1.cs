// Fig. 4.1: AccountTest.cs
// Creating and manipulating an Account object.
using System;

class AccountTest
{
   static void Main()
   {
      // create an Account object and assign it to myAccount
      Account myAccount = new Account();

      // display myAccount's initial name (there isn't one)
      Console.WriteLine($"Initial name is: {myAccount.GetName()}");

      // prompt for and read the name, then put the name in the object
      Console.Write("Enter the name: "); // prompt
      string theName = Console.ReadLine(); // read the name
      myAccount.SetName(theName); // put theName in the myAccount object

      // display the name stored in the myAccount object
      Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
   }
}
