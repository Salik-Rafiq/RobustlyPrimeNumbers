// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
while (1==1) {
    bool isValid = false;
    int nthRPN = 0;
    while (!isValid)
    {
        Console.WriteLine("Enter a number between 1 and 2209 (exit with Ctrl+C) : ");
        string? input = Console.ReadLine();
        bool isANumber = Int32.TryParse(input, out nthRPN);
        isValid = (isANumber && nthRPN > 0 && nthRPN <= 2209);
    }
    FindRPN(nthRPN);
}

void FindRPN(int nthRPN)
{
    /* save the start time to display timing */
    DateTime startTime = DateTime.Now;

    var primes = GeneratePrimes.GeneratePrimesList(nthRPN);

    /* Mark the primes that are RPN, the first 9 can be skipped */
    for (int i = 10; i < primes.Length; i++)
    {

        if (primes[i])
        {
            primes[i] = CheckIsRPN.isRPN((uint)i, primes);
        }
    }
     
    /* Now find the Nth one! */
    int currentNthPrime = 0;
    bool found = false;
    for (int i = 0; i < primes.Length; i++)
    {
        if (primes[i])
        {
            currentNthPrime++;
            if (currentNthPrime >= nthRPN)
            {
                Console.WriteLine("found RPN {0}", i);
                found = true;
                break;
            }
        }
    }
    if (!found)
    {
        Console.WriteLine("did not find the {0}th on in the list. :(", nthRPN);
    }
    /* print timing */
    DateTime endTime = DateTime.Now;
    Console.WriteLine("elapsed time in milliseconds : {0}", (endTime - startTime).TotalMilliseconds);
}