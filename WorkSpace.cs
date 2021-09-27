
using System;
using System.Linq;
using System.Collections.Generic;

class Revision

{
    // username and password

   

        public string userName;
        public string password;
        public void harry()
        {
            
        }

        public void register()
        {
            Console.WriteLine("Create your username");
            userName=Console.ReadLine();
            Console.WriteLine("Create your password");
            password=Console.ReadLine();
            Console.WriteLine("Successfully created");
            Console.WriteLine("........................");

        }

        public void login()
        {
            
            Console.WriteLine("Please enter registered userName");
            if(userName==Console.ReadLine())
            {
                Console.WriteLine("enter your password");
                if(password==Console.ReadLine())
                {
                    Console.WriteLine("login successfully");
                }
                else 
                {
                    Console.WriteLine("login failed ");
                    Console.WriteLine("incorrect password");
                }
            }
            else 
            {
                Console.WriteLine("Please enter valid userName");
            }
            
        }

}

class CricketScore
{
        // highScoreHolder as a string
        // score
        // highSCore
    string highScoreHolder ="HarryBunner"; // as a global variable
    public void ScoreBoard(int score , int highScore)
    {
        if (score > highScore)
        {
            Console.WriteLine(" The new HighScore is = " + score + " by " + highScoreHolder);
        }
        else if (score < highScore)
        {
            Console.WriteLine("The highScore which is = "+ highScore +" by "+ highScoreHolder + "is unbetable");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }



    }

}


// Finding area of Triangle
 class GetSetters
 {

     // Truth according to the person
        //member variables which are Global Variables
        public string name;
        public int age;
        public string state;

    public void Information(bool buddy)
    {
        if (buddy)
        {
            secretOne();
        }
        else 
        {
            Console.WriteLine(" Hi this is {0} I am {1} years old and I'm from {2}",name,age,state);
        }
    }


    public void secretOne()
    {
        Console.WriteLine("Hi mama I bought a new car...");

    }

    public GetSetters()
    {
        name ="Harry";
        age = 32;
        state = "TamilNadu";
    }


 }

#region Arrays

class Arrays
{



    // Declaring arrays

    int [] even_num = new int [12]; // delcaring number of values 

    int [] odd_num = {1,3,5,7,9,11};
    // public  void arrays()
    // {
    //     Console.WriteLine("at place ;" + odd_num[2]);

    // }
    public void loop()
    {
        for (int i = 0; i < 13; i++)
    {
        Console.WriteLine("numbers to be print:" + i);
        
    }

    }








}

#endregion





















