# RobustlyPrimeNumbers
This is a tech test many ask. There are many different "solutions" but there is a trick to properly solve it.

C# Programming Test: Robustly Prime Numbers 

Background For the purposes of this programming test, we define a Robustly Prime Number (RPN) to be a prime number which has no ‘0’ digits and remains prime when you remove any contiguous sequence of digits from the left of it. For example: 
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

