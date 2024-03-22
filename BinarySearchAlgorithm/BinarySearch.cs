using System;

namespace BinarySearchAlgorithm
{
    internal class BinarySearch
    {
        public static int Search(int[] arr, int size, int value)
        {
            var mid = 0;
            int low  = 0;
            int high = size - 1;

            //At each step, we compare the middle value with the value we are
            //searching.If mid value is equal to the value we are searching for then
            //we return the middle index.

            while (low <= high)
            {
                // If the value is smaller than the middle value, we search the left half of the array.

                mid = low + (high - low) / 2; // to avoid overflow

                if (arr[mid] == value)
                {
                    return mid;
                }
                else if (arr[mid] < value) 
                {
                    //If the value is greater than the middle value then we search the right half of the array.

                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            // If we find the value we are looking for then its index is returned
            // otherwise - 1 is returned.
            return -1;
        }
    }
}
