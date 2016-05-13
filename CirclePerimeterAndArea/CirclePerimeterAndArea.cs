/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:

r	    perimeter	area
2	    12.57	    12.57
3.5 	21.99	    38.48
*/

using System;


class CirclePerimeterAndArea
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter the radious");
            double r = double.Parse(Console.ReadLine());

            double area = (Math.Pow(r, 2)) * (Math.PI);
            double perimeter = (2 * Math.PI) * r;

            Console.WriteLine("\n\nCircle's area is {0:0.00}\n circle's perimeter is {1:0.00}", area, perimeter);
        }
        catch (Exception a)
        {
            Console.WriteLine("Please enter valid number for radius");
        }
    }
}