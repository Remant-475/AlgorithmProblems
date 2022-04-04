using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems

{
    class Permutation
    {

        public void solution(String str)
        {
            int number = str.Length;
            int fact = Factorial(number);

            for (int num = 0; num < fact; num++)
            {
                StringBuilder sb = new StringBuilder(str);
                int temp = num;

                for (int divisor = number; divisor >= 1; divisor--)
                {
                    int quotient = temp / divisor;
                    int remainder = temp % divisor;

                    Console.Write(sb[remainder]);
                    sb.Remove(remainder, 1);
                    temp = quotient;
                }
                Console.WriteLine(); ;
            }
        }

        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}