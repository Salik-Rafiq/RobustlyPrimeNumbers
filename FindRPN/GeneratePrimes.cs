using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GeneratePrimes
{
    /* generate primes to limit a vector using seive of erathosenes */
    public static byte[] GeneratePrimesList()
    {
        var arraySize = int.MaxValue-1000;

        var isPrime = new byte[arraySize];
        SetAllToPrime(isPrime);
        isPrime[0] = 0;
        isPrime[1] = 0;
        Sieve(isPrime);

        return isPrime;
    }

    static void SetAllToPrime(byte[] isPrime)
    {
        for (int i = 0; i < isPrime.Length; i++)
        {
            isPrime[i] = 1;
        }
    }

    static void Sieve(byte[] isPrime)
    {
        uint i = 2;
        while ((i * i) <= isPrime.Length)
        {
            if (isPrime[(int)i] == 0)
            {
                i++;
                continue;
            }
            uint j = 2 * (uint)i;
            while (j < isPrime.Length)
            {
                isPrime[(int)j] = 0;
                j += (uint)i;
            }
            i++;
        }
    }
}
