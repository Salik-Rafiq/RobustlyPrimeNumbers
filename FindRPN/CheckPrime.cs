using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CheckPrime
{
    public static bool isCandidatePrime(UInt32 candidate)
    {
        if (candidate == 1 ) 
        {
            return false;
        }
        UInt32 limit = (UInt32)Math.Sqrt(candidate);
        for (UInt32 i = 2; i <= limit; i++)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return true;
    }
}

