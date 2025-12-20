using System;

class RecursiveBinarySearchDemo
{
    static void Main()
    {
        int[] data = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.Write("Enter value to search: ");
        int key = int.Parse(Console.ReadLine());

        int result = RecursiveBinarySearch(data, key, 0, data.Length - 1);

        if (result != -1)
            Console.WriteLine($"Value {key} found at index {result}.");
        else
            Console.WriteLine($"Value {key} not found.");
    }

    // Recursive binary search method
    static int RecursiveBinarySearch(int[] array, int key, int low, int high)
    {
        // Base case: key not found
        if (low > high)
            return -1;

        int middle = (low + high) / 2;

        // Check middle element
        if (array[middle] == key)
            return middle;

        // Search left half
        if (key < array[middle])
            return RecursiveBinarySearch(array, key, low, middle - 1);

        // Search right half
        return RecursiveBinarySearch(array, key, middle + 1, high);
    }
}