using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GeneratePrimes
{
    /* generate primes to limit a vector using seive of erathosenes */
    public static BitArray GeneratePrimesList()
    {
        var arraySize = int.MaxValue-1;

        var isPrime = new BitArray(arraySize,true);
        //SetAllToPrime(isPrime);
        isPrime[0] = false;
        isPrime[1] = false;
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

    static void Sieve(BitArray isPrime)
    {
        uint i = 2;
        while ((i * i) <= isPrime.Length)
        {
            if (!isPrime[(int)i])
            {
                i++;
                continue;
            }
            uint j = 2 * (uint)i;
            while (j < isPrime.Length)
            {
                isPrime[(int)j] = false;
                j += (uint)i;
            }
            i++;
        }
    }
}
