using System;

class RecursiveLinearSearchDemo
{
    static void Main()
    {
        int[] data = { 3, 7, 1, 9, 4, 6, 8 };
        
        Console.Write("Enter value to search: ");
        int key = int.Parse(Console.ReadLine());

        int result = RecursiveLinearSearch(data, key, 0);

        if (result != -1)
            Console.WriteLine($"Value {key} found at index {result}.");
        else
            Console.WriteLine($"Value {key} not found.");
    }

    // Recursive linear search method
    static int RecursiveLinearSearch(int[] array, int key, int index)
    {
        // Base case: end of array
        if (index >= array.Length)
            return -1;

        // Check current index
        if (array[index] == key)
            return index;

        // Recursive call for next index
        return RecursiveLinearSearch(array, key, index + 1);
    }
}