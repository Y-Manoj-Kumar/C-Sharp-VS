using System;
using System.Linq;
using System.Collections.Generic;

// In case of using interface use "I" before a respective name

/*
-->Interface is an user-defined data type only. 
-->A method without method body is Abstract method.

*/

/*
class Interface : IEquatable<GameFinishTime>
{

    public int GameFinishTime { get; set; }

    public Interface(int gamefinishtime)
    {
        GameFinishTime = gamefinishtime;
    }

    public bool  equals(GameFinishTime other)
    {
        return this.GameFinishTime == other.GameFinishTime ;
    }


}
*/


#region  InheritanceDemo

namespace InheritanceDemo
{
    class Furniture
    {
        public string Colour { get; set; }
        public string WoodType { get; set; }

    // Default constructor
        public Furniture()
        {
            Colour = "PaleYellow";
            WoodType = "Bamboo";
        }

    //  simple constructor
        public Furniture(string colour,string woodType)
        {
            this.Colour = colour;
            this.WoodType = woodType;
        }
    }


    //  Inherited from Furniture
    class Chair : Furniture,IDestroyable
    {
        // implementing the INTERFACE property
        public string  DesctructionSound { get; set; }
        public Chair(string colour,string woodType):base(colour,woodType) 
        {
            // this.Colour = colour;        we can write as well as like this tooo
            // this.WoodType = woodType;
        }

        // implementing the INTERFACE method
        public void destroy()
        {
            Console.WriteLine($"The {Colour} chair was destroyed");
            Console.WriteLine($"Plating Destrucion sound{DesctructionSound}");
        }

    }

}

#endregion 


#region  InheritanceDemo2  CREATING INTERFACE

    interface IDestroyable // creating INTERFACE 
    {

        public string DesctructionSound { get; set; }

        void destroy();
    }
     

#endregion



#region  IEnumerable and IEnumerator

// IEnumerable<T> contains a single method you just implement when implemening this interface






#endregion





