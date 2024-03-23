using System.Collections.Generic;

namespace RotateArray
{
    public static class ReverseArrayClass
    {

        // Rotating list is done in two parts trick.In the first part, we first reverse
        // elements of list first half and then second half.
        public static void rotateArray(int[] a, int n, int k)
        {
            ReverseArray(a, 0, k - 1);
            ReverseArray(a, k, n - 1);
            ReverseArray(a, 0, n - 1);
        }

        //Then we reverse the whole list there by completing the whole rotation.
        //• First reversal of the two parts of list is done in O(n) time and the final
        //list reversal is also done in O(n) so the total time complexity of this
        //algorithms is O(n)

        public static void ReverseArray(int[] a, int start, int end)
        {
            for (int i = start, j = end; i<j;  i++,j--)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }

        internal static void PrintArray(int[] arr, int length)
        {
            foreach (int i in arr)
            { 
                Console.WriteLine(i);
            }
        }
    }
}
