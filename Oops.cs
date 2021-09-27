using System;
using System.Linq;
using System.Collections.Generic;


// CONSTRUCTORS

#region Constructors
class Gadgets
{

    // essential variables
    private string laptop;
    private string mobile;
    private string ps;
    private string headPhones;

    // Creating Constuctors 

    public Gadgets() // have to ignore VOID
    {
        Console.WriteLine("Ooooops! go get some gadgets ");
    }

    public Gadgets(string laptop,string mobile,string ps,string headPhones)
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

    // we need a method for 

    public void thingsIHave() // here we need to confirm that, input value need not be equal to  NULL.
    { 
        if(laptop != null && mobile != null && ps != null && headPhones != null)
        {
            Console.WriteLine("I have {0}LapTop {1}Mobile {2}PlayStation {3}HeadPhones",laptop,mobile,ps,headPhones);
        }
        else if(laptop != null && mobile != null && ps != null)
        {
               Console.WriteLine("I have {0}LapTop{1}Mobile{2}PlayStation",laptop,mobile,ps);
        }
         else if(laptop != null && mobile != null  )
        {
               Console.WriteLine("I have {0}LapTop{1}Mobile",laptop,mobile );
        }
         else if(laptop != null    )
        {
               Console.WriteLine("I have {0}LapTop ",laptop );
        }
         
    }

}

#endregion 



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

 
 class CollectingData
 {
     private string name;
     private string jobtitle;
     private int age;
     private int salary;


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
         salary = 500000;
     }


 }
