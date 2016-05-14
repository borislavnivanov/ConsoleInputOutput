/*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.


Examples:

n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
*/


using System;
using System.Numerics;


class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the amount of memebers to show");
        int lenght = int.Parse(Console.ReadLine());

        BigInteger firstnumber = 0;
        BigInteger secondnumber = 1;
        BigInteger currentnumber;

        Console.Write(firstnumber);
        if (lenght > 2)
        {
            Console.Write(", {0}", secondnumber);
        }

        for (int i = 2; i < lenght; i++)
        {
            currentnumber = firstnumber + secondnumber;
            Console.Write(", {0}", currentnumber);
            firstnumber = secondnumber;
            secondnumber = currentnumber;

        }
        Console.WriteLine();
    }
}
