using System;
using System.Collections.Generic;
using System.Linq;

// ACCESS MODIFIERS,STRUCTS,ENUMS,MATH,RANDOM,REGULAR EXPRESSIONS

    struct Car
    {
        public string Model;
        public string Colour;
        public double Price;
        public string Name;

        public void carDetails()
        {
            Car car1;
            car1.Name = "AUDI";
            car1.Colour = "RED";
            car1.Model = "A6";
            car1.Price = 2.5;

            System.Console.WriteLine("Car Name: {0}",car1.Name);
            System.Console.WriteLine("Car Model:{0}",car1.Model);
            System.Console.WriteLine("Car Price:{0}",car1.Price);
            System.Console.WriteLine("Car Colour: {0}",car1.Colour);

        }

    }

    //  An enum is a special "class" that represents a group of constants

    class Enum
    {

        enum Months{Jan =1,Feb,Mar,Apr,May,Jun,Jul,AugSep,Oct,Nov,Dec}; // We can re assign the index

        Months one = Months.Jan;
        // Months two = Months.Feb;
        // Months three = Months.Mar;

        public void enums()
        {
            Console.WriteLine(one );
            
        }
        
    }


    class Math
    {

        // CEILING,FLOOR,MIN,MAX,POW,PI,SQRT,
        public void math()
        {
            // int num1 = 12;
            // int num2 = 10;

            // Console.WriteLine("Minimum of num1 {0} and num2 {1} is {2}",num1,num2,Math.Min(num1,num2));

        }
    }


    class RandomDemo
    {
        public void random()
        {

            Console.WriteLine("Please enter your question ? ");
            Console.ReadLine();

            Random var = new Random();
            int solution;

            solution = var.Next(1, 4);
            if (solution == 1)
            {
                Console.WriteLine("YES");
                
            }
            else if(solution == 2)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("MayBe");
            }

        }
    }


    class RegularExpressions
    {
        public void regExp()
        {

        }

    }


    //  While using Nullables you have to use "?" after the data type.
class Nullables
{

    public void nullables()
    {
        // int? num1 = null;
        // int num2 = null;  This not gonna work in  case of nullable

        // double? doubNum1 = 23.4;
        // double? doubNum2 = new double? ();

        

        
         
    }






}







    