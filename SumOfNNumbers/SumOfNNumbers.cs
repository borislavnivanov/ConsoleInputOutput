/*
 * Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
 * Note: You may need to use a for-loop.
 * Examples:

numbers	sum
3	    90
20	
60	
10	
5	    6.5
2	
-1	
-0.5	
4	
2	
1	    1
1	
 */

using System;


class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the count of N numbers");
        int count = int.Parse(Console.ReadLine());

        double sum = 0;

        Console.WriteLine("Please enter number to be calculated");


        for (int i = 1; i <= count; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("The sum of the numbers is {0}.", sum);
    }
}