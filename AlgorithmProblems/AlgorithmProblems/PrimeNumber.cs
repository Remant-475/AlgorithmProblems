using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class PrimeNumber
    {
        public void Primenumber()
        {
            int Num, Start, End, Count ;
            Console.WriteLine("Enter a Range for Prime number ");
            Console.WriteLine("Enter a starting value");
            Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Ending value");
            End = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : \n", Start, End);

            for (Num = Start; Num <= End; Num++)
            {
                 Count= 0;

                for (int i = 2; i <= Num / 2; i++)
                {
                    if (Num % i == 0)
                    {
                        Count = 1;
                        break;
                    }
                }
                if (Count == 0 && Num != 1)
                    Console.Write("{0} ", Num);
            }
            Console.ReadLine();
        }
    }
}