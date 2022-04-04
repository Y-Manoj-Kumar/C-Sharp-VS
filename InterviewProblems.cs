using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;

/*
1.Prime Number 
2.Fibonacci Series
3.Fibonacci series without Recursion
4.Factorial Number Program
5.Pattern Program(**)
6.Sum of Digits in a program
7.Palindrome or not 
8.Leap year or not
9.Armstrong Nunber or not
10.Given number is strong or not
11.Given number is perfect or not
12.Swapping variables with and without using 3rd variable
13.Harshad number program
14.Even number or odd checking
15.Reversing a number 
16.Convert decimal to binary  
17.Matrix multiplication
18.Number triangle
19.Printing random numbers

*/
class ImpProblems
{
    public static void Main()
    {
        ImpProblems learn = new ImpProblems();
        learn.patternProgram();
    }

    #region Prime Number
    /*
    -->We can provide input in many ways like through parameters,userinput,direct value declaring..........
    -->We need to check wether the input is number or not 
    -->By using "TryParse" we can check whether the input is number or not.
    */

    public void PrimeNumber() // Value passing by parameters
    {
      Console.WriteLine("Input a number to be check whether it is a prime number or not ?");
      string rawInput = Console.ReadLine();
    //   int userInput = Convert.ToInt32(rawInput);
      int userInput2;
    //   bool inputValue = int.TryParse(rawInput,out userInput2);
      
        
      if(int.TryParse(rawInput,out userInput2))
      {
        if (userInput2*1 == userInput2 && userInput2%2 == 0) 
        {
            Console.WriteLine("Not a Prime number");
        }
        else
        {
            Console.WriteLine("Prime Number");
        }
      }  
      else
      {
        Console.WriteLine("Enter a valid INPUT");
      }
    }

    #endregion


    #region Fibonacci Series

    /*
    -->Each number is equal to the sum of the preceding two numbers.
    -->     1 2 = 3    3 4 = 5      
    */   
    public void fibonacciSeries()
    {
        Console.WriteLine("Enter number of elements to be print as a Fibonacci series");
        int inputNum = int.Parse(Console.ReadLine());
        int a=0,b=1,c;
        Console.Write(a+" "+b+" ");
        for (int i = 1; i < inputNum; i++)
        {
            c=a+b;
            Console.Write(c +" ");
            a=b; // assigning the proceding value to the preceding variable like wise the porcess keeps go on
            b=c;
        }
        // Console.Write(a + b  );
    }

    #endregion
    

    #region Fibonacci series without Recrussion

    /*
    -->The recursive function or method is a very strong functionality in C#. 
        A recursive method is a method which calls itself again and again on basis 
        of few statements which need to be true. Similarly, when a function calls 
        itself again and again it is known as a recursive function.
    -->
    */
    public void Fibowithoutrecrussion()
    {

    }

 
    #endregion


    #region Factorial Number

    public  void FactorialNum()
    {
        Console.WriteLine("Enter a number");
        int userInput =Convert.ToInt32(Console.ReadLine());
        long factorial=1;

        if (userInput == 0)
        {   
            Console.WriteLine("Factorial of 0 is 1");
        }
        else
        {
            for (int i = userInput; i >= 1; i--)
            {
                factorial = factorial*i;
            }
            Console.WriteLine("Factorial of "+userInput+" is " +factorial);
        }

    }

    #endregion


    #region Pattern Program

    public void patternpenis()
    {   
        Console.WriteLine("               *  ");
        Console.WriteLine("             * * *  ");
        Console.WriteLine("            * * * *" );
        Console.WriteLine("            * * * * ");
        Console.WriteLine("            * * * * ");
        Console.WriteLine("            * * * * ");
        Console.WriteLine("            * * * * ");
        Console.WriteLine("            * * * * ");
        Console.WriteLine("            * * * *  ");
        Console.WriteLine("            * * * * ");
        Console.WriteLine("            * * * *  ");
        Console.WriteLine("      * * * * * * * * * * ");
        Console.WriteLine("    * * * * * * * * * * * * ");
        Console.WriteLine("  * * * * * * * * * * * * * ");
        Console.WriteLine("  * * * * * *    * * * * * * ");
        Console.WriteLine("  * * * * * *     * * * * * *");
        Console.WriteLine("     * * * *        * * * *");

    }


    public void patternProgram()
    {

        

    }


    #endregion







}