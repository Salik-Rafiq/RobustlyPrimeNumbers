using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CheckIsRPN
{
    public static byte isRPN(UInt32 candidate, byte[] primes)
    {
        /* convert to string and substring the digits out, no "0" allowed */
        string strCandidate = candidate.ToString();
        if (strCandidate.Contains("0"))
        {
            return 0;
        }
        strCandidate = strCandidate.Remove(0, 1);

        while (strCandidate.Length > 0)
        {
            int subCandidate = Int32.Parse(strCandidate);

            if (primes[subCandidate] == 0)//    CheckPrime.isCandidatePrime(subCandidate))
            {
                return 0;
            }
            strCandidate = strCandidate.Remove(0, 1);
        }
        return 1;
    }

}
