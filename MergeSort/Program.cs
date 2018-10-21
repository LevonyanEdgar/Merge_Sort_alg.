using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MergeSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("pleas Enter 10 nubers");
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] sorted = MergeSortClass.MergeSort(arr);
            


            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i] + " ");
            }

            Console.ReadLine();
        }
    
    }
}
