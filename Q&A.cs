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



    #region Comparing two arrays using LINQ
    /*
    -->Here we have to use bool conditin bcz we are checking given  two arrays are equal are not
    -->Declare two Arrays 
    -->
    */

    int[] q = {1,2,3,4};
    int[] w ={1,2,3,4};
    public void comparearray()
    {
        if(q == w)
        {
            Console.WriteLine("The given two arrays are equal");
        }
        else
        {
            Console.WriteLine("Given arrays are not equal");
        }
    }
 
    #endregion

}
