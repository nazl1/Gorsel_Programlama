using System;

class Craps
{

   private static Random randomNumbers = new Random();

   private enum Status {Continue, Won, Lost}

   private enum DiceNames
   {
      SnakeEyes = 2,
      Trey = 3,
      Seven = 7,
      YoLeven = 11,
      BoxCars = 12
   }

   static void Main()
   {
      Status gameStatus = Status.Continue;
      int myPoint = 0; 

      int sumOfDice = RollDice(); 

      switch ((DiceNames)sumOfDice)
      {
         case DiceNames.Seven:   
         case DiceNames.YoLeven: 
            gameStatus = Status.Won;
            break;
         case DiceNames.SnakeEyes: 
         case DiceNames.Trey:    
         case DiceNames.BoxCars: 
            gameStatus = Status.Lost;
            break;
         default: 
            gameStatus = Status.Continue; 
            myPoint = sumOfDice;   
            Console.WriteLine($"Point is {myPoint}");
            break;
      }

      while (gameStatus == Status.Continue) 
      {
         sumOfDice = RollDice(); 

         if (sumOfDice == myPoint) 
         {
            gameStatus = Status.Won;
         }
         else
         {
    
            if (sumOfDice == (int)DiceNames.Seven)
            {
               gameStatus = Status.Lost;
            }
         }
      }

      if (gameStatus == Status.Won)
      {
         Console.WriteLine("Player wins");
      }
      else
      {
         Console.WriteLine("Player loses");
      }
   }

   static int RollDice()
   {
      int die1 = randomNumbers.Next(1, 7); 
      int die2 = randomNumbers.Next(1, 7); 

      int sum = die1 + die2; 

      
      Console.WriteLine($"Player rolled {die1} + {die2} = {sum}");
      return sum; 
   }
}
