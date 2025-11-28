using System;

class GradeBook
{
   private int[] grades; 

   public string CourseName { get; }

    
     public GradeBook(string name, int[] gradesArray)
   {
      CourseName = name; 
      grades = gradesArray; 
   }

   
   public void DisplayMessage()
   {
     
      Console.WriteLine(
         $"Welcome to the grade book for\n{CourseName}!\n");
   }

  
   public void ProcessGrades()
   {
     
      OutputGrades();

       
      Console.WriteLine($"\nClass average is {GetAverage():F}");

      
      Console.WriteLine($"Lowest grade is {GetMinimum()}");
      Console.WriteLine($"Highest grade is {GetMaximum()}\n");

     
      OutputBarChart();
   }

  
   public int GetMinimum()
   {
      var lowGrade = grades[0]; 
                         
      foreach (var grade in grades)
      {
         
         if (grade < lowGrade)
         {
            lowGrade = grade;         
         }
      }

      return lowGrade; 
   }

  
   public int GetMaximum()
   {
      var highGrade = grades[0]; 

      
      foreach (var grade in grades)
      {
         
         if (grade > highGrade)
         {
            highGrade = grade; 
         }
      }

      return highGrade;
   }


   public double GetAverage()
   {
      var total = 0.0; 
     
      foreach (var grade in grades)
      {
         total += grade;
      }

      return total / grades.Length;
   }

   public void OutputBarChart()
   {
      Console.WriteLine("Grade distribution:");

      var frequency = new int[11];

      foreach (var grade in grades)
      {
         ++frequency[grade / 10];
      }

      for (var count = 0; count < frequency.Length; ++count)
      {
        
         if (count == 10)
         {
            Console.Write("  100: ");
         }
         else
         {
            Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
         }

         for (var stars = 0; stars < frequency[count]; ++stars)
         {
            Console.Write("*");
         }

         Console.WriteLine(); 
      }
   }

   public void OutputGrades()
   {
      Console.WriteLine("The grades are:\n");
                            
      for (var student = 0; student < grades.Length; ++student)
      {
         Console.WriteLine(
            $"Student {student + 1, 2}: {grades[student],3}");
      }
   }
}
