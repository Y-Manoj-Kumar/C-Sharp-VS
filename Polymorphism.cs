using System;
using System.Linq;
using System.Collections.Generic;

/*
The word polymorphism means having many forms. In simple words, we can define polymorphism as the 
ability of a message to be displayed in more than one form. Real life example of polymorphism: A person 
at the same time can have different characteristic. Like a man at the same time is a father, a husband, 
an employee.
*/


#region  Polymorphism


    class IceCream // Base Class
    {
        public string Flavour { get; set; }

        public bool  Taste { get; set; }

        //  simle constructor
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

        public virtual void cost()
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

        public override void cost()
        {
            base.cost();
        }

    }

            

#endregion