using System;
using System.Linq;
using System.Collections.Generic;

// In case of using interface use "I" before a respective name

/*
-->Class contains only non-abstract methods
-->Where as Abstract class contains  Abstract methods and non-abstract methods[Methods with method body]
-->#INTERFACE Contains only Abstract methods[Methods without method body]
-->Interface is an user-defined data type only. 
-->Generally a class inherits form other class to consume the members of its parent,where as in INTERFACE 
   it implements the members of its parent.
-->A class can Inherits from a Class and Interface at a time.
-->#The default scope of Interface is Public whereas it is private in Class
-->#BY default every member  of an interface is abstract so we don't require to use abstract modifier.

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


#region 

 interface IInterface1
 {
    //  int w;// Interfaces cannot contains fields[variables].
    //If require an interface can inherits from another interface.
     void add(int q ,int w); // by default it set to be  in public and it also add abstract modifier to it
 }

 interface IInterface2 : IInterface1
 {
     void sub(int q,int w);
 }

//  class ImplementationClass : IInterface2
//  {
//      public void add(int q,int w);
//      {
          
//      }
//      public void sub(int q , int w);
//      {
//          Console.WriteLine(a - b);
//      }
        
//     declare insance of implementat....ss
//    and input some values
//  }
 

#endregion


