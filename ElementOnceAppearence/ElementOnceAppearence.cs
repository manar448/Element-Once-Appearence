using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class ElementOnceAppearence
    {
        #region YOUR CODE IS HERE
        //Your Code is Here:
        //==================
        /// <summary>
        /// Write efficient algorithm to get the element that appears once in the array
        /// </summary>
        /// <param name="arr">sorted array of all elements appear twice except one element </param>
        /// <param name="N">number of elements in the array</param>
        /// <returns>return the element that is appeared once </returns>
        public static int FindUniqueElement(int[] arr, int N)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            return Find(arr, 0, N - 1);

        }
        public static int Find(int[] arr, int start, int end)
        {
            int half = (start + end) / 2;
            Boolean even = false;

            if (half % 2 == 0)
                even = true;
            else
                even = false;

            if (start == end)
                return arr[start];

            //If mid is even
            if (even)
            {
                if (arr[half] == arr[half + 1])
                    return Find(arr, half + 2, end);
                else
                    return Find(arr, start, half);
            }

            // If mid is odd
            else
            {
                if (arr[half] == arr[half - 1])

                    return Find(arr, half + 1, end);
                else
                    return Find(arr, start, half - 1);
            }

            return -1;
        }
        #endregion
    }
}