using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_3
{
    public static class PrimeNumbers
    {
        private static int[] primeArray = { 2,3,5,7,11,13,17,19,23,29 };

        public static int GetPrime(int n)
        {
            return primeArray[n - 1];

        }
    }
}
