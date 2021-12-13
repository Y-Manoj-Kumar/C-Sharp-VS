using System;
using System.Linq;
using System.Collections.Generic;

/*
The word polymorphism means having many forms. In simple words, we can define polymorphism as the 
ability of a message to be displayed in more than one form. Real life example of polymorphism: A person 
at the same time can have different characteristic. Like a man at the same time is a father, a husband, 
an employee.
*/

/*
OVERLOADING:
    *In this case we can define multiple methods with the SAME NAME but DIFFERENT PARAMETERS
    *This can be perform either within a class as well as between parent child classes.

OVERRIDING:
    *In this case we can define multiple methods with the SAME NAME and PARAMETERS TOO.
    *This can be performed only between the parent child classes ,never be performed within the same class.

VIRTUAL:
    *Any virtual method of the parent class can be overridden by the child class if reqired by using the override
     modifier.

METHOD OVERRIDING:
    *In this case Child class re-implements it's Parent class method which are declared as Virtual.

Method Hiding/Shadowing:
    *In this case Child class can re-implement's the any Parent's method  even if the method is not
     declared as Virtual.
*/

//  VIRTUAL,OVERRIDE,SEALED,ABSTRACT


#region  Polymorphism


    class IceCream // Base Class
    {
        public string Flavour { get; set; }

        public bool  Taste { get; set; }

        //  simple constructor
        public IceCream(string flavour,bool taste)
        {
            this.Flavour = flavour;
            this.Taste = taste;
        }

        // public IceCream()
        // {
        //     Flavour = "Vanilla";
        //     Taste = true;
        // }

        public void iceCreamShop()
        {
            Console.WriteLine("Natural's");
        }

        public virtual void cost() // Overridable
        {
            if (Taste == true)
            {
                Console.WriteLine("Its worth to buy at that price");
            }

            else
            {
                Console.WriteLine("Don't buy it");
            }
        }

    }


    class ConeIceCream : IceCream // Its a SUB CLASS    
    {

        public ConeIceCream(string flavour,bool taste):base(flavour,taste)
        {

        }

        public override void cost() // Overriding
        {
            base.cost();
        }

        public new void iceCreamShop()
        {
            Console.WriteLine("POLAS Iam from child class");
        }



    }

        
#endregion


#region  Reading Text


class ReadingText
{

 








}





#endregion