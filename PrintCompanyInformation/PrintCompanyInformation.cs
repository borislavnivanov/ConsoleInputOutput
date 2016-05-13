/*A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:


program             user
Company name:	    Telerik Academy
Company address:	31 Al.Malinov, Sofia
Phone number:	    +359 888 55 55 555
Fax number:	
Web site:	        http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	    25
Manager phone:	    +359 2 981 981

Example output:

Telerik Academy
Address: 231 Al.Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov(age: 25, tel. +359 2 981 981)
*/

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName, companyAddress, companyPhone, fax, webSite, manName, manFamName, manPhone;
        byte manAge;

        try
        {

            Console.WriteLine("Please enter company name");
            companyName = Console.ReadLine();
            Console.WriteLine("Please enter company address");
            companyAddress = Console.ReadLine();
            Console.WriteLine("Please enter company phone");
            companyPhone = Console.ReadLine();
            Console.WriteLine("Please enter company fax");
            fax = Console.ReadLine();
            Console.WriteLine("Please enter company website");
            webSite = Console.ReadLine();
            Console.WriteLine("Please enter manager name");
            manName = Console.ReadLine();
            Console.WriteLine("Please enter manager family name");
            manFamName = Console.ReadLine();
            Console.WriteLine("Please enter manager age");
            manAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter manager phone");
            manPhone = Console.ReadLine();



            Console.WriteLine("\n\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, companyPhone, fax, webSite, manName, manFamName, manAge, manPhone);

        }
        catch (Exception a)
        {
            Console.WriteLine("Please enter valid number for the manager age \n\n{0}", a);
        }
    }
}
