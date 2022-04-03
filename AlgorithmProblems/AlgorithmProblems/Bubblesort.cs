using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class Bubblesort
    {


        public void BubbleSorting()
        {
            int[] arr = { 89, 76, 45, 92, 67, 12, 99 };
            Console.WriteLine("Original:");
            foreach(int Unsorted in arr)
                Console.Write(Unsorted + " ");
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int sorted in arr)
                Console.Write(sorted + " ");
            Console.Read();
        }
    }
}