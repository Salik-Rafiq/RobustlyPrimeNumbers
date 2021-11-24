// See https://aka.ms/new-console-template for more information
const string dataFilePath = "./ListOfLTPrimes.dat";

Console.WriteLine("Hello!");

if (!File.Exists(dataFilePath))
{
    Console.WriteLine("Preparing...this may take a few minutes.");

    var primes = GeneratePrimes.GeneratePrimesList();
    //strip out the non-RPN and write to the file at the same time
    using (var primesFile = new BinaryWriter(File.OpenWrite(dataFilePath)))
    {
        for (int i = 0; i < primes.Length; i++)
        {
            if (primes[i])
            {
                primes[i] = CheckIsRPN.isRPN((uint)i, primes);

                if (primes[i])
                {
                    primesFile.Write((uint)i);

                }
            }
        }
    }
}
Console.WriteLine("Ready");

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
    /* save the start time to display timing */
    DateTime startTime = DateTime.Now;

    FindRPN(nthRPN);

    /* print timing */
    DateTime endTime = DateTime.Now;
    Console.WriteLine("elapsed time in milliseconds : {0}", (endTime - startTime).TotalMilliseconds);
}

void FindRPN(int nthRPN)
{

    /* Now find the Nth one! */
    /* load the file and skip n */
    using (var primesFile = new BinaryReader(File.OpenRead(dataFilePath)))
    {
        primesFile.BaseStream.Position = (nthRPN-1) * sizeof(int);

        int RPN = primesFile.ReadInt32(); 
        Console.WriteLine("Found RPN: {0}", RPN);
    }
}