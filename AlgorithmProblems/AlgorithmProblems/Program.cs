using System;

namespace AlgorithmProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: For Prime Number");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Primenumber();
                    Console.WriteLine();
                    break;
                    
            }
        }

    }
}