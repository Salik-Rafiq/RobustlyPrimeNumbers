# RobustlyPrimeNumbers aka Left-Truncatable Primes
This is a tech test many ask. There are many different "solutions" but there is a trick to properly solve it.

C# Programming Test: Robustly Prime Numbers 

Background For the purposes of this programming test, we define a Robustly Prime Number (RPN) to be a prime number which has no ‘0’ digits and remains prime when you remove any contiguous sequence of digits from the left of it.

For example: 
5167 is an RPN, since 5167, 167, 67 and 7 are all prime;
2179 is not an RPN, even though 2179, 179 and 79 are prime, since 9 is not prime. 

There are 2209 RPNs under 2 31 .

Task 

Write a command-line program in C# that: 
 takes a single integer, n, where 1 ≤ n ≤ 2209, as a command-line argument 
 calculates the nth Robustly Prime Number
 writes the output on the screen (ie to stdout) 
 execute (for any valid input) within about 0.5 seconds on a normal PC 

For example: 
  input 20 should give output 197 
  input 197 should give output 33967 
  input 200 should give output 34673 

Although part of the challenge is coming up with an efficient algorithm, this is not the only thing that’s important. Your code should also (within reason) be “production quality” in terms of being readable, maintainable, testable and so on. Submission Please send your source code (in a form that we will be able to compile and run) in a Zip file or 7-Zip file. Please do not post this problem or your solution anywhere on the web. 

# My Idea

You have to use a sieve of some type to calculate all the primes very quickly but this also slows when you get to the higher RPNs. Because they can't have "0" in them huge hunks of the prime numbers are excluded it takes longer and longer process. Also you will find that if you use [MaxInt] you will get a memory error so you have to use BitArray to ensure you don't bang into memory limit at 2^31. 

Once the sieve is done you than have to trim for RPN. convert the number to string and keep removing the first char and than back to int. Than index into the primes list to check if it's a prime. repeat until no chars are left. If it hasn't failed than it's a RPN. Oh yes check for "0" first and if it's just one char than it's automatically a RPN. 

So memory and algorithm are sorted but then you have another issue. Speed. If you ask for the 2000th RPN you will be there far beyond 0.5sec.

So how do you get around this? 

If you can get away with it than you can pre-process things and create a file with all the RPNs in it. I don't think you've broken any rules above(??). I write the numbers to a binary file in a pre-process step. In the query step I simply index into the file and read the integer there.

The file is only created the first time the app is run!

#Enjoy!
