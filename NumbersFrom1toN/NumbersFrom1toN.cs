/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.

Examples:

input	output
3      	1
        2
        3
5      	1
        2
        3
        4
        5
1	    1
*/

using System;


class NumbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("Please enter the number up to which to count");
        int countLimit = int.Parse(Console.ReadLine());
        for (int i = 1; i <= countLimit; i++)
        {
            Console.WriteLine(i);
        }
    }
}
