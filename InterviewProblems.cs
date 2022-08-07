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
    // public static void Main()
    // {
    //     ImpProblems learn = new ImpProblems();
    //     learn.swpapingVariablesWithoutThirdVariable();
    // }


    #region #1 Prime Number
    /*
    -->We can provide input in many ways like through parameters,userinput,direct value declaring..........
    -->We need to check wether the input is number or not 
    -->By using "TryParse" we can check whether the input is number or not.
    */



    // public void PrimeNumber() // Value passing by parameters
    // {
    //   Console.WriteLine("Input a number to be check whether it is a prime number or not ?");
    //   int userVal = int.Parse(Console.ReadLine());
    //   int userInput = Convert.ToInt32(rawInput);
    //   int userInput2;
    //   bool inputValue = int.TryParse(rawInput,out userInput2);
      
    
    //     int i; //Declare i as a golbal variable........
    //     for ( i = 2; i < userVal; i++)
    //     {
    //         if (userVal % i ==0)
    //         {
    //             Console.WriteLine("{0} is not a prime ",userVal);
    //             break;
    //         }
    //     }
    //     if (i==userVal)
         
    //         Console.WriteLine("{0} is a prime number",userVal);
    //     }

    // }

 

    #endregion


    #region #2 Fibonacci Series  

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
    

    #region #3 Fibonacci series without Recrussion

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


    #region #4 Factorial Number 

    public  void FactorialNum()
    {
        Console.WriteLine("Enter a number");
        int userInput =Convert.ToInt32(Console.ReadLine());
        int factorialSum = 1;

        if (userInput == 0)
        {   
            Console.WriteLine("Factorial of 0 is 1");
        }
        else
        {
            for (int i = userInput; i >= 1; i--)
            {
                factorialSum = factorialSum*i;
            }
            Console.WriteLine("Factorial of "+userInput+" is " +factorialSum);
        }

    }

    #endregion


    #region #5 Pattern Program


    public void patternProgram()
    {
        /*
        --> For this we need row and column such i and j respectively
        --> 
        */
        Console.WriteLine("How many rows you want to print ? ");
        int numValue = Convert.ToInt32(Console.ReadLine());
        // int startNum = 1;

        for (int i = 0; i < numValue; i++) // Remember there is no equal symbol only lesser than 
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine("");
            // startNum = startNum+1;
        }

    }


    public void pyramidPattern()
    {
        int spc,len =1;
        Console.WriteLine("Enter a number");
        int inputVal = Convert.ToInt32(Console.ReadLine());
        spc = inputVal-1;

        for (int i = 0; i < inputVal; i++)
        {
            for (int j = 0; j < spc; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < len; k++)
            {
                Console.Write("@");
            }
            spc--;
            len=len+2;
            Console.WriteLine();
        }



    }


    public void numberSequence()
    {
        Console.WriteLine("Enter a number ");
        int inputNum = Convert.ToInt32(Console.ReadLine());
        int startNum= 0;

        for (int i = 0; i < inputNum; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" "+startNum);
                startNum++;
            }
            Console.WriteLine("");
        }


    }


    public void stringPattern()
    {
        Console.WriteLine("Enter a string ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j <=i; j++)
            {
                Console.Write(str[j]);
            }
            Console.WriteLine();
        }

    }

    #endregion


    #region #6 Sum of Digits
    /*
    -->Just finding the sum of given integer
    */

    public void sumOfDigits()
    {
        Console.WriteLine("Enter a number for sum of digits");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum=0,rem,temp;
        temp=num;

        while (num>0)
        {
            rem = num%10;
            sum = sum+rem;
            num = num/10;
        }

        Console.WriteLine("Sum of "+ temp +" is "+sum );

    }



    #endregion


    #region #7 Palindrome
    /*
    -->A palindromic number is a number that remains the same when its digits are reversed. In other words, 
    it has reflectional symmetry across a vertical axis.
    */

    public void palindrome()
    {
        Console.WriteLine("Enter a number to check whether it is a palindrome or not ");
        int num = Convert.ToInt32(Console.ReadLine());

        int temp,rem,revnum=0;
        temp=num;

        while (num>0)
        {
            rem =num%10;
            revnum =revnum*10+rem;
            num = num/10;
        }
        if (temp==revnum)
        {
            Console.WriteLine("It's a palindrome"); 
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
        
    }

    #endregion


    #region #8 Leap Year or not

    public void leapYearOrNot()
    {
        Console.WriteLine("Enter a year to be check wehtere it's a leap year or not");
        string yearInput=Console.ReadLine();
        int year;

        if (int.TryParse(yearInput,out year))
        {
            if ((year%4)==0)
            {
                Console.WriteLine("It's a leap year");
            }
            else
            {
                Console.WriteLine("No it's not a lepa year");
            }
        }

        else
        {
            Console.WriteLine("Please enter a year");
        }


    }

    public void tempPalindrome()
    {

        Console.WriteLine("Enter a year");
        string year = (Console.ReadLine());
        int changedyear;

            // if ((year%4)==0)
            // {
            //     Console.WriteLine("It's a leap year");
            // }
            // else
            // {
            //     Console.WriteLine("No it's not a lepa year");
            // }

        // while (int.TryParse(year,out changedyear))
        // {

        //     if ((changedyear%4)==0)
        //     {
        //         Console.WriteLine("It's a leap year");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("No it's not a lepa year");
        //         break;
        //     }
        // }


 

    }



    #endregion


    #region #9 Armstrong or Not 
    /*
    -->An Armstrong number of three digits is an integer such that the sum of the cubes of its digits 
       is equal to the number itself. For example, 371 is an Armstrong number since 3**3 + 7**3 + 1**3 = 371
    */

    public void Armstrong()
    {

        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum=0,rem,temp;
        temp=num;

        while (num>0)
        {
            rem = num%10;
            sum = sum+rem*rem*rem;
            num=num/10;
        }

        if (temp==sum)
        {
            Console.WriteLine("It's an armstrong");
        }
        else
        {
            Console.WriteLine("Not an armstrong");
        }

    }

    #endregion


    #region #10 Given number is PERFECT or not
    //A perfect number is a positive integer that is equal to the sum of its proper divisors

    public void givenNumIsPerfectOrNot()
    {
        Console.WriteLine("Enter a number to check whether it's a perfect number or not");
        int inputNum = Convert.ToInt32(Console.ReadLine());

        int sum=0;
        Console.Write("The positive divisors of " + inputNum + " is :   ");
        for (int i = 1; i < inputNum; i++)
        {
            if (inputNum%i==0)
            {
                sum = sum+i;
                 Console.Write( "{0} ",i);  
            }
 
        }
        Console.WriteLine();
        Console.WriteLine("The sum of positive divisors of " + inputNum + " is " + sum);

        if (inputNum==sum)
        {
            Console.WriteLine(inputNum + " is a PERFECT number");
        }
        else
        {
            Console.WriteLine(inputNum + " is a not a PERFECT number");
        }
       
    }

    #endregion


    #region #11 Given number is STRONG or not
    /* If sum of factorial of digits is equal to original number then it is Strong number */

    public void givenNumIsStrongOrNot()
    {
        Console.WriteLine("Enter an number to check whether it is a strong number or not");
        int inputNum = Convert.ToInt32(Console.ReadLine());

        int n1,s1=0,fact=1;
        n1=inputNum;

        for (int i = inputNum; i > 0; i = i/10)
        {
            for (int j = 1; j <= i%10; j++)
            {
                fact = fact*j;
            }
            s1 =s1+fact;
        }

        if (s1==n1)
        {
            Console.WriteLine("Its is a STRONG number");   
        }
        else
        {
            Console.WriteLine("No it's not a STRONG number");
        }

    }

    #endregion


    #region #12 Swapping Varibales without using third variable

    int q =11;
    int w = 13;
    int e;
    public void swpapingVariablesWithoutThirdVariable()
    {
        Console.WriteLine("Before swapping variables where q = " + q + " and w = " + w);

        q=q*w;
        w=q/w;
        q=q/w;

        Console.WriteLine("After swapping variables where q = " + q + " and w = "+ w);
    }

    public void swappingVariableWithThirdVariable()
    {
        Console.WriteLine("Before swapping variables where q = " + q + " and w = " + w);

        e=q;
        q=w;
        w=e;

        Console.WriteLine("After swapping variables where q = " + q + " and w = "+ w);
        
    }

    #endregion


    #region #13 Harshad Number

    //Harshad number or Niven number is a number which is divisible by the sum of its digits

    public void harshadNumber()
    {
        Console.WriteLine("Ente a number to check whether it is a Harshad Number or not");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum=0,rem,temp=num;

        while (num>0)
        {
            rem=num%10;
            sum=sum+rem;
            num=num/10;// here in each iteration value get reseted
        }

        Console.WriteLine("Sum of Digits of " + temp + " is "+ sum);

        if((temp%sum) == 0)// Check once numerator value and denominator value
        {
            Console.WriteLine("It's a Harshad Number");
        }
        else
        {
            Console.WriteLine("No it's not a Harshad number");
        }


    }


    #endregion


    #region #14 Even and Odd number checking

    public void evenOrOdd()
    {
        Console.WriteLine("Enter a number to be check whether it is an even or not");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input%2 == 0)// we need to check reminder
        {
            Console.WriteLine("It's an even number");
        }
        else
        {
            Console.WriteLine("It's an odd number");
        }


    }



    #endregion


    #region #15 Reversing a number

    public void reversingANumber()
    {
        Console.WriteLine("Enter a number to be print in reverse");
        int revnum = Convert.ToInt32(Console.ReadLine());

        int rem,reverse=0,temp;
        temp=revnum;

        while (revnum != 0)
        {
            rem = revnum % 10;
            reverse = reverse*10+rem;
            revnum = revnum/10;
        }    

        Console.WriteLine("Reversed number of " + temp + " is " + reverse);

 
    }

    #endregion


    #region Decimal to Binary
  
 
 

    #endregion


}

