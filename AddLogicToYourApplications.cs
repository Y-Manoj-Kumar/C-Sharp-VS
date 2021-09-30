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
            int myparse = int.Parse(level);
            if(myparse > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else if(myparse <= 55)
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
            int myparse = int.Parse(level);
            if(myparse >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else if(myparse < 20)
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