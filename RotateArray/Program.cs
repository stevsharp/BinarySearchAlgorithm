using RotateArray;

try
{
    int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

    ReverseArrayClass.rotateArray(arr, arr.Length, 2);
    ReverseArrayClass.PrintArray(arr, arr.Length);

    int[] arrMax = [1, -2, 3, 4, -4, 6, -4, 3, 2];

    //Maximum subarray in an Array is found in a single scan.We keep track
    //of global maximum sum so far and the maximum sum, which include
    //the current element.
    //When we find global maximum value so far is less than the maximum
    //value containing current value we update the global maximum value.
    //Finally return the global maximum value.

    Console.WriteLine("Max sub array sum :" + ReverseArrayClass.maxSubArraySum(arrMax, arrMax.Length));

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.BackgroundColor = ConsoleColor.Red;
}

Console.ReadLine();
