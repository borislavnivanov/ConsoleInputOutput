/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:

numbers	sum
1 2 3 4 5	        15
10 10 10 10 10  	50
1.5 3.14 8.2 -1 0	11.84
*/

using System;


class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers:");
        string[] userInput = Console.ReadLine().Split();
        double a = double.Parse(userInput[0]);
        double b = double.Parse(userInput[1]);
        double c = double.Parse(userInput[2]);
        double d = double.Parse(userInput[3]);
        double e = double.Parse(userInput[4]);

        Console.WriteLine("The sum os the numbers is : {0}.", (a + b + c + d + e));

    }
}
