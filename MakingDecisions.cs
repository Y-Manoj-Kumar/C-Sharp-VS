using System;
using System.Linq;
using System.Collections.Generic;

/*
1.Username that too in string.
2.LoginId in string.
3.we need to declare these two variables.
4.creating a method for Register by using user input method.
5.creating another method for login that too by using user input method.
6.Finally calling through main method.  
*/

#region  User Login Details
class UserLoginDetails
{
   
    public string username;       // Which is GLOBAL VARIABLE
 
    public string password;        // Which is GLOBAL VARIABLE

    public void register() // Registration form 
    {
        Console.WriteLine("Please enter your username");
        username=Console.ReadLine();
        Console.WriteLine("Please enter your password");
        password=Console.ReadLine();
        Console.WriteLine("Successfully registered");
        Console.WriteLine("........................................");
    }

    public void login()
    {
       Console.WriteLine("Please enter your username");
       if( username==Console.ReadLine())
       {
           Console.WriteLine("Please enter your password");
           if( password==Console.ReadLine())
           {
               Console.WriteLine("welcome to login page");
           }
           else
           {
               Console.WriteLine("Login failed please restart your program");
           }
       }
       else
       {
           Console.WriteLine("enter valid login username");
       }

    }
    
}
#endregion



#region ScoreBoard 

/*
  1.score as a int which is param1 
  2.highscore as a int whcich is param2
  3.highscoreplayer as a string which is declared as GLOBAL VARIABLE    
  4.Need to create method having two parameters 
  5.by using if statements we gona crosscheck the score and highscore 
*/
class Scoreboard
{
    string highScoreHolder ="BruceBanner";


    public void scoreCard(int score,int highscore)
    {
        if(score>highscore)
        {
            Console.WriteLine("New Highscore is :"+score);
            Console.WriteLine("New Highscore holder is :"+highScoreHolder);
        }
        else if(score<highscore)
        {
            Console.WriteLine("The older Highscore : " + highscore + "which is broken by "+highScoreHolder+" is still unbetable ");
        }
        else 
        {
            Console.WriteLine("Better luck next time");
        }

    }

}
#endregion


 class EnhancedIf 
 // you can minimise the code by using this method
     // By using ENHANCED IF STATEMENT  you can shorten the code in just one line.
    // as well as we can use it instead of "if else" condition 

    // TERNARY OPERATORS
    {
        public void enhancedStatement(int numberOfPassengers)// passing a value through param
        { 
            string vehicle; //declaring a variable
         
            vehicle = numberOfPassengers >2? "you guys need a car" : 
            numberOfPassengers <2? "you guys need a bike" :  
            numberOfPassengers ==1? "go by walk" : "orelse take a lift";
          
            Console.WriteLine(vehicle);
        }
    }  

    
class NestedIf
{
  
    public  void nestedStataments()
    {
        bool student = true;
        bool isJoined = true;

        string studentName ="";
        Console.WriteLine("Please Enter your NAME?");
        studentName=  Console.ReadLine();

         if(student)
         {
             Console.WriteLine("Yes he is a STUDENT");
             if(isJoined)
             {
                 Console.WriteLine("He's joined in our school");
                 if(studentName !="")
                 {
                     Console.WriteLine("His full name is Bruce " + studentName);
                     if(studentName.Equals("Bruce"))
                     {
                         Console.WriteLine("Perfectly right It's HIM");
                     }
                 }
               
             }

         }

    }





}


class Parsing
{
    public string Parseexmp()  // here STATIC will be ignored
    {
        Console.WriteLine("Please enter the value:");
        string myValue= Console.ReadLine();
        int myParse= int.Parse(myValue);

        if(myParse==13)
        {
            Console.WriteLine("yeeeah!");
        }
        else
        {
            Console.WriteLine("Ooooo !");
        }

        return "";
    }
}


class Tryparsing

{
    public void TryParseExmp()// useful for not getting our code crash by combining with "if-else"statements
    {

        string myTryParse = "1910"; //3244.htdfd like this not accepted by TryParse
        int mytry ;
        bool success = int.TryParse(myTryParse,out mytry);//here you has to use BOOL conditon 
        Console.WriteLine(success);
    }


    public void challengeCode()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

float total = 0f;
string message = "";

foreach (var value in values)
{
    float number;
    if (float.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
    }

}

// Incluidng SWITCH statements




