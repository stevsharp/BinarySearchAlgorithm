
using BinarySearchAlgorithm;

try
{
    int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];

    Console.WriteLine("Sum of values in array:" + BinarySearch.Search(arr, arr.Length, 7));
    
    Console.WriteLine("Sum of values in array:" + BinarySearch.Search(arr, arr.Length, 7));
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.BackgroundColor = ConsoleColor.Red;
}

Console.ReadLine();