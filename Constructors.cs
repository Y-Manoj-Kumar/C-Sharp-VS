using System;
using System.Linq;
using System.Collections.Generic;

/*
 ==>EVERY CLASS CONTAINS AN IMPLICIT CONSTRUCTOR[public accessible] IF NOT DEFINED EXPLICITLY
 ==>Constructor is a special method,responsible for initialising the variables of a class.
 ==>Every class reqired a constructor for creating the instance
 ==>Implict constructors(parameter less/default constructor) = defined by Compiler
 ==>Expilict constructors = defined by user

==>Types of Constructors

#Default or parameterless constructor [Wihtout parameters]
#Parameterized Constructor [With parameters]
#Copy Constructor 
#Static Constructor (calls implicitly) [Even thogh it's a static construtor it contains Default Constructor by compiler]
==>If a class contains any static variables then only implicit static constructors(need no to be called) will be defined orelse
defined by explicitly)(non-static constructors must be called)
==>Can't pass values as parameters 
*/
// CONSTRUCTORS(Defining and Calling)

#region Constructors
class Gadgets
{

    // essential variables [Fields]
    private string laptop;
    private string mobile;
    private string ps;
    private string headPhones;

    //Creating Constuctors 

    public Gadgets()  //Default Constructor 
    {
        Console.WriteLine("Ooooops! go get some gadgets ");
    }

    public Gadgets(string laptop,string mobile,string ps,string headPhones)//Parametrized Construcutor
    {
        this.laptop = laptop;
        this.mobile = mobile;
        this.ps = ps;
        this.headPhones = headPhones;
    }

     public Gadgets(string laptop,string mobile,string ps)
    {
        this.laptop = laptop;
        this.mobile = mobile;
        this.ps = ps;
        
    }

     public Gadgets(string laptop,string mobile)
    {
        this.laptop = laptop;
        this.mobile = mobile;
    }
     public Gadgets(string laptop)
    {
        this.laptop = laptop;
        
    }

    // we need a method 

    public void thingsIHave() // here we need to confirm that, input value need not be equal to  NULL.
    { 
        if(laptop != null && mobile != null && ps != null && headPhones != null)
        {
            Console.WriteLine("I have {0} {1}  {2}  {3} ",laptop,mobile,ps,headPhones);
        }
        else if(laptop != null && mobile != null && ps != null)
        {
               Console.WriteLine("I have {0} {1} {2} ",laptop,mobile,ps);
        }
         else if(laptop != null && mobile != null  )
        {
               Console.WriteLine("I have {0} {1} ",laptop,mobile );
        }
         else if(laptop != null    )
        {
               Console.WriteLine("I have {0}  ",laptop );
        }   
    }
}

#endregion 


#region  properties

class GetSet
{
    private int length;   // any one can access it from outside to overcome that, change it to private.

     private int breadth;  // by using property method 
                             // The property name should be start with capital letter.
    // public int height;   
    public int  volume;     // IN case of volume we use only get beacuse we are not setting the volume.
                            // we need to get it.


    public int Height { get; set; } // prop tab == new property
    public int Breadth
    { 
        get
        {
            return breadth;
        }
        set
        {
            if(value < 0)
            {
                breadth = -value;  // changing a negative value to positive
            }
            else
            {
                breadth = value;
            }
            
        }
    }

    public void SetLength(int length)
    {
        if(length<0)
        {
           throw new Exception("Please enter the valid vlaue.");
        }
        this.length= length;
    }

    public int GetLength() // in this case use the same data type used by the respective one .
    {
        return this.length;
    }
    // meanwhile we can set other measures too.
    public void volumeOFGiven()
    {
        Console.WriteLine("lenght is {0}  breadth is {1} and height is {2} then the volume of the given is {3}"
        ,length,breadth,Height,volume = length*breadth*Height);
    }

}


#endregion

 
 #region Collecting data by Constructors fav logic

 
 class CollectingData
 {
     private string name;
     private string jobtitle;
     private int age;
    //  private int salary;


     public void information(bool isfriend)
     {
         if(isfriend)
         {
             secretOne();// even though it is private we can access it from public one.
         }
         else
         {
             Console.WriteLine("hey this is{0} I am working in {1} company as a developer and I am {2} years old",name,jobtitle,age);
         }

     }

     private void secretOne()
     {
         Console.WriteLine("Hi bruce I bought a new car ");
     }

     public CollectingData() // constructor
     {
         name = "Martin";
         age = 43;
         jobtitle = "MediaMOnks";
        //  salary = 500000;
     }

 }

 #endregion


#region non-static constructor

        // ConDemo check = new ConDemo(12);
        // ConDemo check2 = new ConDemo(check);
        //check.display;

class ConDemo // non-static constructor
{
 int q; //[non-static field]
 public ConDemo(int q)
 {
     this.q/* Class variable */ =q;
 }

 public ConDemo(ConDemo obj) // Copy Constructor
 {
     q = obj.q;
 }

 public void display()
 {
     Console.WriteLine("Value of q:" + q);
 }
 
}

#endregion


#region static constructor

 class StaticCon //Static Constructors are implicitly called
 {
     static int q =12; //static field
    //  int w =32;
    static StaticCon()
    {
       Console.WriteLine("Static Constructor is called");// static constructor executes first
    } 

    public StaticCon()
    {
        Console.Write("non-static constructot is called");//we can also called instance constructor
    }

    public void display()
    {
        Console.WriteLine("Static field declared value:"+q);
    }

    // static void Main( )
    // {
    //     // Console.WriteLine("Main method executes");
    //     StaticCon con = new StaticCon();
    //     Console.WriteLine("non-static field:"+con.w);
    //     Console.WriteLine("static field:"+q);
        
    // }
 }

#endregion





