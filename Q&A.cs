using System;
using System.Linq;
using System.Collections.Generic;



class Problems
{
    

    #region ReverseString

/*                                   
        #1  METHOD-1     Using TocharArray and For loop
       
    -> We need declare a string variable that should be constant or it's your choice.
    -> Convert the String to Char type.
    -> Create a "for loop" which is used to reverse the string order. 
    -> In case of printing anything in reverse order the repsective condition should be reversed.
 */

    public void stringReversingWithCharArray1()
    {
        const string str = "BRUCEBANNER";

        var chars = str.ToCharArray();
        var length = chars.Length;

        Console.WriteLine($"Lenght of String is:{length}");

        for (var i = length-1; i>=0; i--)    // here length-1 used for counting the string in reverse  order.
        {                                   
            Console.WriteLine(chars[i]); // it prints every letter in new line.
            Console.Write(chars[i]);    // it prints word together.
        }


    }

                     //METHOD-2 
      public void stringReversingWithCharArray2()
    {
        const string str = "BRUCEBANNER";

        var chars = str.ToCharArray();
        var length = chars.Length;

        Console.WriteLine($"Lenght of String is:{length}");

        var revStr = string.Empty;

        for (var i = length-1; i>=0; i--)    // here length-1 used for counting the string in reverse  order.
        {                                   
           revStr= revStr +chars[i];         
        }

        Console.Write(revStr); // this should be declare outside the forloop
    }
    

        	         //METHOD-3

    // public void stringReversingWithInbuiltFunction()
    // {
    //     const string str = "BRUCEBANNER";
    //     var chars = str.ToCharArray();

    //     Array.Reverse(chars);                  here getting error it's possible in case of LINQ....
    //     Console.WriteLine(new string(chars));
    // }

    #endregion


    #region Removing WhiteSpaces from a String
    public void RemovingWhiteSpaces()
    {

        string str = "Are you really willing to buy a SuperBike?";
        var chars = str.ToCharArray();

        string str1 = string.Empty;

        foreach(var eachchar in chars)
        {
            if(eachchar != ' ')  // here you have to use singlequotes[''] resembles an empty space.
            {
                str1 = str1 + chars;
            }
        }

        Console.WriteLine(str1);

    }
    #endregion


    #region Checks for Armstrong Number

    /* 
    -> An Armstrong number of three digits is an integer such that the sum of the cubes of its digits 
       is equal to the number itself. For example, 371 is an Armstrong number since 3**3 + 7**3 + 1**3 = 371
    ->
    */

    public void checksForArmstrong()
    {
         int temp,sum=0,rem;  // here sum is the final result 
    
         Console.WriteLine("Enter the value to be checked ");
         string num = Console.ReadLine();
        // we can use parse method also 
        // num = Convert.ToInt32(Console.WriteLine());
         
         int num2;
         bool value= int.TryParse(num,out num2); // In TryParse method you have to use bool 
        //  Console.WriteLine(value);
         if(value)
         {
             Console.WriteLine("Go on");
         }
         else
         {
             Console.WriteLine("enter again");
         }
         temp=num2; // 153
        
        while (num2>0)
        {
            rem= num2 % 10;  // we get rem as 3
            sum= sum+rem*rem*rem;//0+3*3*3 =27    here sum = 27 ==> 27=sum+rem*rem*rem;
            num2= num2/10; //153/10 = 15 as quotient then the num2 value set to be as 15 
        }

        if(sum==temp) //153==153  
        {
            Console.WriteLine("Yes it's an ARMSTRONG NUMBER");
        }
        else
        {
            Console.WriteLine("NO  it's not an ARMSTRONG NUMBER");
        }

    }
    #endregion


    #region Checks for Polindrome

    /*
        A palindromic number is a number that remains the same when its digits are reversed. In other words, 
        it has reflectional symmetry across a vertical axis.
    */
    int num,revnum = 0,temp,rem; // declared as global varibale for multiple use 
    public void checkForPolindrome()
    {
        
        // Console.WriteLine("Enter a number ");
        // try
        // {
        //      num = Convert.ToInt32(Console.ReadLine());
        // }
        // catch (System.Exception)
        // {
            
        //    Console.WriteLine("Please enter valid value");
        // }
        Console.WriteLine("Enter a number to be checked");
        num = Convert.ToInt32(Console.ReadLine());
       
        temp=num;    

        while (num>0)
        {
            rem = num%10; // if numerator is smaller than denominator then the remainder is numerator
            revnum = revnum*10 +rem;
            num = num/10;
        }
        if(temp==revnum)
        {
            Console.WriteLine("Yes it is a Palondrome");
        }
        else
        {
             Console.WriteLine("NO it's not a Palondrome");
        }
    }

    #endregion


    #region Comparing two arrays 
    /*
    
    -->Here we have to use bool conditin bcz we are checking given  two arrays are equal are not.
    -->Declare two Arrays, containing equal number of elemnts
    -->Declare a bool 
    -->
    */

int[] x = new int[]{1, 2, 3, 4};
int[] y = new int[] { 5, 6, 1, 2, 7, 8};
public bool IsPresentInArray(int[] a, int[] b)
{
    if (a.Length != b.Length) // checking equal number of elements present are not
    {
        return false;
    }
    else //checking elements in their respective index values  equal are not
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }
    }
    return true ;
}

    #endregion


    #region reverse the string in its original place

public void orderIdstartsWithB()
{

    string orderStream = "B123,C234,  ,A345,C15,B177,   ,G3003,C235,B179";
    string[] items = orderStream.Split(',');
    foreach(var item in items)
    {
        if(item.StartsWith("B"))
        {
            Console.WriteLine(item);
        }
    }
}

    #endregion


    #region pick the word out from the string

    public void pickOut()
    {
        string str = "Hey I am from paris";
        
        Console.WriteLine(str.Substring(15));
        Console.WriteLine(str.Substring(9,7));

    }

    #endregion


    #region  Toll CalculatorDemo

    /*
        Calculate Toll prices according to the vehicel ,number of passengers in vehicel 

        Logic to write program

        I want to make the program using userinput method
        all this code done by using conditoinal statements 

    */

        // public int passengersTravelling;
    public void calculatingToll()
    {
         
        Console.WriteLine("Enter your vehicel from below list");   
        // Console.WriteLine("1.Car 2.Lorry");
        // string vehicle = Console.ReadLine();
        
        List<string> vehicle = new List<string>
        {
            {"1.CAR"},{"2.LORRY"},{"3.LORRY WITH 12 TIRES"}
        };

        foreach (var item in vehicle)
        {
            Console.WriteLine(item);
        }

        string vehicle1= Console.ReadLine();

//CAR 
        if (vehicle1.ToLower().Equals("car")) // ignoring case sensetive
        {
            Console.WriteLine("How many passengers are travelling?");
            string passengersTravelling = Console.ReadLine();
            int passengers =int.Parse(passengersTravelling);
           
            if (passengers <= 4)
            {
                Console.WriteLine("you have to pay 100Rs/-");
            }
            else if (passengers > 4)
            {
                Console.WriteLine("you have to pay 200/-");
            }
        }

//LORRY 
        if (vehicle1.ToLower().Equals("lorry")) // ignoring case sensetive
        {
            Console.WriteLine("overloaded yes or no");
            string passengersTravelling = Console.ReadLine();
            // int passengers =int.Parse(passengersTravelling);
           
            if (passengersTravelling.Equals("yes"))
            {
                Console.WriteLine("you have to pay 1000Rs/-");
            }
            else if(passengersTravelling.Equals("no"))
            {
                 Console.WriteLine("you have to pay 500");
            }
        }
        if(vehicle1.Equals(""))
        {
            Console.WriteLine("Please  enter your vehicle type ");
            
        }

    }
    
    #endregion


    #region login through user id and password

    public void login()
    {

        Console.WriteLine("Please enter your user Id");
        string userId = Console.ReadLine();
        int Id = int.Parse(userId);

        int[] idDataBase = {123,456,789};

        if (Id.Equals(idDataBase))
        {
            Console.WriteLine("Enter your passsword");
        }
        else
        {
            Console.WriteLine("Please enter correct user id");
        }
      

    }


    #endregion


    #region Area of a rectangle     "1"

    public void rectangleArea()
    {
        int len = 8;
        int bre = 4;
        int area = len*bre;
        Console.WriteLine("Area of rectangle:" +area);
    }

    #endregion


    #region  Finding ASCII value of character      "2"
    //ASCII[American Standard Code for Information Interchange]
    // Basically its an integer
    public void ascii()
    {
        string str = "qwerty";

    foreach (var item in str)
    {
        Console.WriteLine((int)item);// need to typecast to int 

    }

    }

    #endregion
    

    #region Converting Celcius to Farenheits       "3"

        int farenheits;
        int degrees;
        
    public void celciusTOFarenheit()
    {
 
        Console.WriteLine("Enter the celcius you want to change to farenheit");
        String celcius = Console.ReadLine();
        int degrees = int.Parse(celcius);
 
        if ( int.TryParse(celcius,out temp))// By using tryparse method we can't get error incase the input is
                                            // other than integer
        {
            if (temp >=0 && temp <=100)
            {
                Console.WriteLine( "Farenheit temperature:"+ ((temp*9/5)+32));
            }
        }
        else
        {
            Console.WriteLine("Please enter  value from 1 to 100");
        }

 
        
 
    }

    #endregion


    #region swapping variables      "4"
    int  q= 12;
    int w = 13;
    int e;
    public void swapping()
    {
        Console.WriteLine($"Before swapping q is {q} and w is {w}",q,w);

        e =q;
        q = w;
        w = e;

        Console.WriteLine($"After swapping q is {q} and w is {w}",q,w );
    }

    #endregion


    #region Checking the number is even or odd      "5"

    public void evneOrOdd()
    {
        Console.WriteLine("Enter a number");
        string num = Console.ReadLine();
        int temp;

        if (int.TryParse(num,out temp))
        {
            if (((temp % 2) == 0))
            {
                Console.WriteLine("Yes it is even number");
            }
            else
            {
                Console.WriteLine("It's an odd number");
            }
        }

        else
        {
            Console.WriteLine("Please enter valid number");
        }


    }



    #endregion


    #region Check whether a character is vowel or consonant    "6"

    /*
        Vowels = a e i o u
        Consonants = other than vowels

        input char it checks whether the input is related to which one 

    */

     public void vowelOrConsonent()
     {
         Console.WriteLine("Enter a character");
         string inputChar = Console.ReadLine();

        //ToLower() = It converts the input char capital to small 
         if (inputChar.ToLower()== "a"|| inputChar.ToLower()== "e" || inputChar.ToLower()== "i"|| inputChar.ToLower()== "o"|| inputChar.ToLower()== "u")
         {
             Console.WriteLine("Its an vowel ");
         }

         else
         {
             Console.WriteLine("Its a consonant");
         }
     }

    #endregion


    #region Find largest among three numbers             "7"
    // 12,23,54
    public void largestAmongThree(int a,int b,int c)
    {
        
    }

    #endregion





}
