using RotateArray;

try
{
    int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

    ReverseArrayClass.rotateArray(arr, arr.Length, 2);
    ReverseArrayClass.PrintArray(arr, arr.Length);

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.BackgroundColor = ConsoleColor.Red;
}

Console.ReadLine();
