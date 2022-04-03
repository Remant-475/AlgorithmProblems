using System;

namespace AlgorithmProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: For Prime Number");
            Console.WriteLine("2: For BubbleSort");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Primenumber();
                    Console.WriteLine();
                    break;
                    case 2:
                    Bubblesort bubbleSort = new Bubblesort();
                    bubbleSort.BubbleSorting();
                    Console.WriteLine();
                    break;

            }
        }

    }
}