using System;

namespace AlgorithmProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: For Prime Number");
            Console.WriteLine("2: For BubbleSort");
            Console.WriteLine("3.String Permutation");
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
                    case 3:
                    Console.WriteLine("Enter the string");
                    String str =Console.ReadLine();
                    Permutation permutation= new Permutation();

                    permutation.solution(str);
                    break;

            }
        }

    }

}