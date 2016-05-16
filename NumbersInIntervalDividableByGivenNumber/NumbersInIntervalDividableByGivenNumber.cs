/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
 * the reminder of the division by 5 is 0.
Examples:

start	end 	p	    comments
17	    25	    2	    20, 25
5	    30	    6	    5, 10, 15, 20, 25, 30
3	    33	    6	    5, 10, 15, 20, 25, 30
3	    4	    0	    -
99	    120	    5	    100, 105, 110, 115, 120
107	    196	    18	    110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
*/

using System;


class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter strat number");
        uint start = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter end number");
        uint end = uint.Parse(Console.ReadLine());

        int count = 0;

        if (start < end)
        {
            for (uint i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }
        // Handles the case where end number is less then the start number
        else
        {
            for (uint i = end; i <= start; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }
        
        Console.WriteLine("The count of the numbers that are dvisible by 5 is {0}", count);
    }
}
