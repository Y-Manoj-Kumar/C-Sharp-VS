using System;
using System.Linq;
using System.Collections.Generic;
/*
    Inheritance is a process in which one object acquires all the properties and
    behaviors of its parent object automatically. In such way, you can reuse, extend or modify 
    the attributes and behaviors which is defined in other class.

==>Default parent class for .NET is  "OBJECT CLASS OF SYSTEM NAMESPACE".
==> Parent class constructor must be accessible to child class,otherwise inherirance will not work
==> Parent class can't acces variables in child 
==>But Child class can access variables in Parent class
==>When we create an instance there is memory allocarion for that particular instan
==>Memory allocation only done for instances not for referrences

-------------------Types of Inheritance-------------------
1.Single
2.Multi-level
3.Hierarchcal [combination of 1&2]
4.Hybrid
5.Multiple

-----------------Simply Defined in Two Types-----------------
    #If a class has 1 Immediate Parent class  we call it as SINGLE Inheritance.
    #If a class has more than 1 Immediate Parent class we call it as MULTIPLE Inheritance.
*/

    #region  Electrical Device // It's a parent, TV and WateraHeater are it's childrens 
//  Its a Child Of Electrical Device
    class WaterHeater : ElectricalDevice //Getting INheretence from ElectricalDevice
    {

        //properties for waterheater

        public WaterHeater(bool ison, string gettingHeat):base(ison,gettingHeat)        //Constructor
        {

        }

        public void checking()
            {
                if(IsOn)
                {
                    Console.WriteLine("Good to go for bath");
                    
                }
                else
                {
                    Console.WriteLine("Wait for some time");
                }
            }

    }

    //......................................//

    class TV : ElectricalDevice // Inheritance from ElectricalDEvice
    {

        public TV(bool ison, string telecost):base(ison,telecost) // Constructor
        {

        }

        public void checking()
        {
            if(IsOn)
            {
                Console.WriteLine("enjoy the show");
                
            }
            else
            {
                Console.WriteLine("check the connection");
            }
        }
    }


    //            INHERITANCE EXAMPLE 
    // Electrical Device 



    class ElectricalDevice 
    {
        public bool IsOn { get; set; }
        public string Telecost { get; set; }


        public void switchOn ()
        {
                IsOn = true;

        }
        public void switchOff ()
        {
                IsOn = false;

        }

        public ElectricalDevice(bool ison,string working)
        {

        }


    }

    #endregion


    #region  Animal 

    class Animal        // PARENT CLASS WHICH IS USED FOR INHERITANCE FOR HIS CHILDRENS
                    // It's also called BASECLASS   
    {

        public  string  Name { get; set; } // properties name always start with CAPITAL
        public  int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name,int age)
        {
            // this.name = name;  
            Name = name; 
            Age = age;
            // we are setting the animals are hungry by default  
            IsHungry = false;

        }

        //an empty virtual method "makeSound" to override other classes
        public virtual void makeSounds() // Virtual method for override other classes
        {

            Console.WriteLine("He make's sound like awooooooo");

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("He/She is eating");         
            }
            else
            {
                Console.WriteLine("He/She taking rest");
            }

        }

    }

        //................................................//


    class Wolf  : Animal // It's Inherited from ANIMAL [Child of anilmal]
                // Wolf is a INHERITED CLASS OR SUB CLASS           
    {
        public Wolf(string name,int age) : base(name,age)
        {

        }

        public override void makeSounds()
        {
            base.makeSounds();
        }
        public override void Eat()
        {
            base.Eat();
        }

    }
    
    #endregion


   #region Inheritance Explanation 
   
   class College // Parent Class

   {
       public College() // always need to keep constructor in  public mode orelse it cause error
       {
           Console.WriteLine("Main Class Constructor");
       }

       public void staff()
       {
           Console.WriteLine("Hii Iam a Staff from parent class");
       }

       public void  hod ()
       {
           Console.WriteLine("Hii Iam  hod from parent class");
       }
   }


   class Students : College //Child Class
   {
       public void sec()
       {
           Console.WriteLine("Hey Iam student from Child Class");
       }
       static void Main()
       {
           College p1;   //it's a  Parent class variabel,but not initialised 
           Students p2 = new Students();   // new keyword is used for initialising and it's a Inastance
           p1=p2;   //p1[Parent class] is initialised using p2[Child Class] instance
           // Here "P1" is a reference of parent class created by using child class instance
           // So that refrence will be consuming the memory of child class instance
           // Even though parent class can't access the child class variables
           // p1 = new  College(); we can initialise like this too

           p1. hod();
           p1.staff();
           p2.sec();
           p2.hod();

           object obj = new Object();

           Console.WriteLine("Type of p1 is:"+p1.Equals(p2)) ;
            /*
            EQUALS
            GETHASHCODE
            TOSTRING
            GETTYPE
            */

        //    obj.GetType();          

       }
   }

   #endregion


    #region 



    #endregion
































