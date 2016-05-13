/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Examples:

a	    b	     c	    roots
2	    5	    -3  	x1=-3; x2=0.5
-1  	3	     0   	x1=3; x2=0
-0.5	4	    -8  	x1=x2=4
5	    2	     8	    no real roots
*/

using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter value for a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for c");
        double c = double.Parse(Console.ReadLine());


        // calcualte discriminant
        double d = (b * b) - (4 * a * c);

        // find the case of equation and calculate the result
        if (d > 0 && b % 2 != 0)
        {
            // case descriminant is above 0 and even number
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("\nThe equation has 2 real roots: x1={0} ; x2={1}", x1, x2);
        }
        else if (d > 0 && b % 2 == 0)
        {
            // case descriminant is above 0 and odd number
            double x1 = (-b - Math.Sqrt(d)) / a;
            double x2 = (-b + Math.Sqrt(d)) / a;
            Console.WriteLine("\nThe equation has 2 real roots: x1={0} ; x2={1}", x1, x2);
        }
        else if( d == 0)
        {
            // case descriminant is 0
            double x = -b / (2 * a);
            Console.WriteLine("\nThe equation has 1 real root: x1=x2={0}", x);
        }
        else
        {
            // case descriminant is below 0
            Console.WriteLine("\nThe equation has no real roots");
        }

    }
}
