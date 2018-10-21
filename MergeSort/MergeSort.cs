using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort

{
   public static class MergeSortClass
    {


        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length==1)
            {
                return arr;
            }

            int[] left = arr.Take(arr.Length / 2).ToArray();
            int[] right= arr.Skip(arr.Length/2 ).ToArray();
            return Merge(MergeSort(left), MergeSort(right));

        }

        private static int[] Merge(int[] v1, int[] v2)
        {
            int[] result = new int[v1.Length + v2.Length];
            int index_1 = 0;
            int index_2 = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (index_1 >= v1.Length)
                {
                    result[i] = v2[index_2++];
                    continue;
                }
                if (index_2 >= v2.Length)
                {
                    result[i] = v1[index_1++];
                    continue;
                }

                if (v1[index_1] <= v2[index_2])
                {
                    result[i] = v1[index_1++];

                }
                else
                {
                    result[i] = v2[index_2++];
                }

            }
            return result;
        }

    }
}
