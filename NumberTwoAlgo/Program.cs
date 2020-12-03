using System;

namespace NumberTwoAlgo
{
    class Program
    {
            static void Main(string[] args)
            {
                int maxval = Int32.MaxValue;
            bool primes = false;

             ulong sumPrimeNumbers = 0;
            for (int i = 1; i < maxval; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        primes = false;
                    }
                }
                if (primes)
                {
                    sumPrimeNumbers +=Convert.ToUInt64(i);
                    Console.WriteLine(sumPrimeNumbers);
                }
                primes = true;
            }

                
                Console.ReadLine();
            } 
    }
}
