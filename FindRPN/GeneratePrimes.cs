using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GeneratePrimes
{
    static public int ApproximatePlaceOfNthPrime(int n)
    {
        //if (n > 345) return int.MaxValue-1;
        return Math.Min( ((n * n) + n + 41) * (n >= 5000 ? 2 : 1), int.MaxValue-1);
    }
    /* generate primes to limit a vector using seive of erathosenes */
    /* limit is the nth prime so the array needs to be made larger by
     * and estimate */
    public static BitArray GeneratePrimesList(int limit)
    {
        /* need to estimate array size needed */
        var arraySize = ApproximatePlaceOfNthPrime(limit);
        /* need to scale it up - these are just guesses */
        arraySize += (int)(Math.Pow(limit * Math.Log(limit), 1.635));
            //(int)(limit*Math.Log10(limit) + limit * Math.Log10(Math.Log10(limit)));

        BitArray isPrime = new BitArray(arraySize,true);

        //SetAllToPrime(isPrime);
        isPrime[0] = false;
        isPrime[1] = false;
        Sieve(isPrime);

        return isPrime;
    }

    static void SetAllToPrime(int[] isPrime)
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
