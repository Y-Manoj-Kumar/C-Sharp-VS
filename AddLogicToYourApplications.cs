using System;
using System.Linq;
using System.Collections.Generic;

/*                                                   
  
                                                   OPERATORS 

    Console.WriteLine("a" == "a");
    Console.WriteLine("a" == "A");
    Console.WriteLine(1 == 2);
    string myValue = "a";
    Console.WriteLine(myValue == "a");

    Its a case sensitive too.

TRIM AND LOWER/UPPER    
    string value1 = " a";
    string value2 = "A ";
    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

CONDITIONAL OPERATOR
    <evaluate this condition> ? <if condition is true, return this value>
     : <if condition is false, return this value>

    int value = 12;
    int val = value/2 > 2 ? 2 : 3;
    Console.WriteLine(val);

*/

#region  My
class BusinessRules
{

    public void position()
    {
        // Business rules
        // permisssions and level

        // string permission = "Admin|Manager";
        // Console.WriteLine(permission.Contains("Admin"));

        Console.WriteLine("Enter position in company Admin or Manager");
        string myPos = Console.ReadLine();

        if(myPos == "Admin")
        {
            Console.WriteLine("Please enter your level");
            String level = Console.ReadLine();
            int myParse = int.Parse(level);
            if(myParse > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else if(myParse <= 55)
            {
                Console.WriteLine("Welcome, Admin user.");
            }
            else
            {
                Console.WriteLine("Better Luck Next time ADMIN");
            }

        }

        else if(myPos == "Manager")
        {
            Console.WriteLine("Please enter your level");
            String level = Console.ReadLine();
            int myParse = int.Parse(level);
            if(myParse >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else if(myParse < 20)
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
            else
            {
                Console.WriteLine("Better Luck Next time MANAGER");
            }

        }

        else
        {
            Console.WriteLine("...........Position Error.........");
        }   
        
 
    }

}

#endregion


#region Make it ErrorFree

class ErrorIdentification
{
 
    // public void error()
    // {
    //     int[] numbers = { 4, 8, 15, 16, 23, 42 };
    //     foreach (int number in numbers)
    //     {
    //         int total;
    //         total += number;
    //         if (number == 42)
    //         {
    //         bool found = true;
    //         }
    //     }
    //     if (found) 
    //     {
    //         Console.WriteLine("Set contains 42");
    //     }
    //     Console.WriteLine($"Total: {total}");
    // }

    // METHOD - 1 By using Nested-if

    public void errorFree1()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        foreach (int number in numbers)
        {
            int total= 0;
            total += number;

            if (number == 42)
            {
                bool found = true;
                if (found) 
                {
                    Console.WriteLine("Set contains 42");
                }

                Console.WriteLine($"Total: {total}");
            }
        
        }
            
    }

    // METHOD - 2  By making Local to Global variables

    public void errorFree2()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {
            total += number;
            if (number == 42) found = true;
        }

        if (found) Console.WriteLine("Set contains 42"); // Code blocks has been removed

        Console.WriteLine($"Total: {total}");
    }


}



#endregion


