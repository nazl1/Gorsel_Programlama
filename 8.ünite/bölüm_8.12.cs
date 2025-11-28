using System;

class DeckOfCardsTest
{
   static void Main()
   {
      var myDeckOfCards = new DeckOfCards();
      myDeckOfCards.Shuffle(); 

      for (var i = 0; i < 52; ++i)
      {
         Console.Write($"{myDeckOfCards.DealCard(),-19}");

         if ((i + 1) % 4 == 0)
         {
            Console.WriteLine();
         }
      }
   }
}