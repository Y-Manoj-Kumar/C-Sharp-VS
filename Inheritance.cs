using System;
using System.Linq;
using System.Collections.Generic;
/*
    Inheritance is a process in which one object acquires all the properties and
    behaviors of its parent object automatically. In such way, you can reuse, extend or modify 
    the attributes and behaviors which is defined in other class.
*/

//  Its a Child Of Electrical Device
    class WaterHeater : ElectricalDevice //Getting INheretence from ElectricalDevice
    {

        //properties for waterheater

        public WaterHeater(bool ison, string gettingHeat):base(ison,gettingHeat) // Constructor
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

    #region  Electrical Device // It's a parent, TV and WateraHeater are it's childrens 

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




