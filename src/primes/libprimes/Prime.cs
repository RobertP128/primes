using System;

namespace libprimes
{
    public class Prime
    {
        public bool IsPrime(Int64 x,out int firstFactor)
        {
            firstFactor = 1;

            if (x <=1 ) return false;
            if (x == 2) return true;
            // even numbers are not prime
            if ((x & 1) == 0)
            {
                firstFactor = 2;
                return false;
            }

            // test in steps of 2 until sqrt(x)
            Int64 maxTest = Convert.ToInt64(Math.Floor(Math.Sqrt(x)));

            for (int n=3;n<=maxTest;n+=2)
            {
                if (x % n == 0)
                {
                    firstFactor = n;
                    return false;
                }
            }

            
            return true;

        }
    }
}
