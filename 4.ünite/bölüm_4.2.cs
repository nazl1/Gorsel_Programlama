// Fig. 4.2: Account.cs
// A simple Account class that contains a private instance
// variable name and public methods to Set and Get name's value.

class Account
{
   private string name; 

  
   public void SetName(string accountName) 
   {
      name = accountName; 
   }

   
   public string GetName()
   {
      return name; 
   }
}

