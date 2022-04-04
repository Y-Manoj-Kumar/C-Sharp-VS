using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;

/*
1.Prime Number 
2.Fibonacci Series
3.Fibonacci series without Recursion
4.Factorial NUmber Program
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
    



}