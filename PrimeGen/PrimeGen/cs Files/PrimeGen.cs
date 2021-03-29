using System;
using System.Collections.Generic;

namespace PrimeGen.cs_Files
{
    class PrimeGen
    {
        static void Main(string[] args)
        {

            // Write prime numbers between 0 and 100.
            Console.WriteLine("Enter the maximum value : ");
            var UserInput = Console.ReadLine();
            int NumOfPrimes;

            while(!int.TryParse(UserInput, out NumOfPrimes) | NumOfPrimes < 1)
            {
                Console.WriteLine("This is not an interger, please try again : ");
                UserInput = Console.ReadLine();
            }

            Console.WriteLine("--- Primes below {0} ---", NumOfPrimes);

            var PrimeList = new List<int>();

            for (int i = 2; i < NumOfPrimes; i++)
            {
                foreach (int p in PrimeList)
                {
                    if(i % p == 0)
                    {
                        goto NotPrime;
                    }
                }
                
                PrimeList.Add(i);
                Console.WriteLine("Prime : {0}", i);
                
            NotPrime:;
            }
        }
    }
}