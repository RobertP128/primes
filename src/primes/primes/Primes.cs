using System;
using System.Collections.Generic;

namespace primes
{
    public class Primes
    {

        private List<int> _primes;


        public Primes()
        {
            _primes = new List<int>() { 2 };
        }




        public void CreatePrimes() { 
            for (int n = 3; n < 100000000; n += 2) {
                int sqrt = (int)Math.Floor(Math.Sqrt(n));
                int k = 0;
                int p = 2;
                bool isPrime = true;
                while ((sqrt > p) && (k<_primes.Count)) {
                    p = _primes[k];
                    int rest = n % p;
                    if (rest == 0) {
                        isPrime = false;
                        break;
                    }
                    k++;
                }

                if (isPrime) {
                    _primes.Add(n);
                    Console.Write(n + "\n");
                }

            }

            Console.Write("Found " + _primes.Count + " Primes...");
        }
    }
}
