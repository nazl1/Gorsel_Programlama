

class GradeBookTest
{
   static void Main()
   {                     
      int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

      var myGradeBook = new GradeBook(
         "CS101 Introduction to C# Programming", gradesArray);
      myGradeBook.DisplayMessage();
      myGradeBook.ProcessGrades();
   }
}