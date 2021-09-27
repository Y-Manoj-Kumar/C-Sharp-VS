using System;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
using System.Collections;
using System.Linq;
using System.Collections.Generic;

class Array
{
    #region   ARRAY 
    public void typeArray()
    {
        int[] num = new int[10];
        for (int i = 0; i < 10; i++)                                                    
        {
            Console.WriteLine(num[i] = i);
        }

        // for(int j = 0; j<num.Length; j++)
        // {
        //     Console.WriteLine("Element at {0} = {1}",j,num[j]);
        // }

        int counter = 0;
        foreach(int k in num)
        {
            num[k] += k + 10;
            Console.WriteLine("Element at {0} = {1}",counter, num[k]);
            counter++;
        }
    }
    #endregion       


    #region  2D ARRAY

// Declaring a 2D array string[,]matrix;
    public void array2D()
    {

        int[,] matrix = new int[,]
        {
            {12,23},
            {34,45},
            {54,56}
        };
        Console.WriteLine("The value you need is :{0}",matrix[2,1]); // It's the way to call a value 

    }

    public void arrayDecSecondMethod()
    {
        int[,] matrix=
        {
            {12,43},
            {23,43},
            {67,88}
        };
         Console.WriteLine("The value you need is :{0}",matrix[2,1]);

    }

    #endregion
   

    #region  3D ARRAY

    public void array3D()
    {
        int[,,] marks=new int[,,]
        {
            {
                {123,123,1232},
                {644,675,766}
            },
            {
                {767,757,643},
                {232,546,655}
            }
        };
        Console.WriteLine("This is the value which you selected :{0}",marks[1,1,1]);

    }

    public void arrayDecleration()
    {
        int[,] score = new int[3,3]
        {
            {12,23,43},
            {34,5,6},
            {343,676,76}
        };
        Console.WriteLine("before change :{0}",score[1,2]);
        score[1,2] = 5555;
        Console.WriteLine("AFter change :{0}",score[1,2]);
        Console.WriteLine("And it's a {0}D dimension",score.Rank);// results the type of dimension 

    }
    #endregion

    public void pritingUsingLoops()
    {
       int[,] marks=new int[,]
       {
           {12,34,45},
           {56,67,78},
           {89,90,09}
           
        };

        Console.WriteLine("WHICH IS ANOTHER METHOD");

        foreach (var element in marks)
        {
            Console.Write(element);// this should be WRITE NOT WRIELINE
        }

        for(int i=0; i<marks.GetLength(0); i++) //outerfor loop which is ROWS
        {

            for(int j=0; j<marks.GetLength(1); j++)// inner for loop which is COLUMN
            {
                     Console.Write(marks[i,j]);// this should be WRITE NOT WRIELINE
        
            }
        }  
    }


    #region  Jagged Array
    //It's a combination of multiple arrays which is an array within array

    public void jaggedArray()
    {
        int[][] jaggArray = new int[3][]; // way of declaring

        jaggArray[0] = new int[5];  
        jaggArray[1] = new int[3];
        jaggArray[2] = new int[2];

        jaggArray[0] = new int[] {2,3,45,65,6};  // adding values 
        jaggArray[1] = new int[] {45,65,6}; 
        jaggArray[2] = new int[] {2,6}; 

        // Another method fro adding and declaring values

        int[][] jaggArray2 = new int[][]
        {
            new int[] {2,3,45,65,6}, //Row 1
            new int[] {45,65,6}, //Row 2
            new int[] {2,6} //Row 3
        };
    
        //   Console.WriteLine("Elements at {0}   :" ,jaggArray2[2][1]); // accessing the elements 
        //   Console.WriteLine("Elements at {0}   :" ,jaggArray[0][1]); // accessing the elements 

          for (int i = 0; i <jaggArray.Length; i++)
          {
              Console.WriteLine("Element {0}:",i);
              for (int j = 0; j < jaggArray[i].Length; j++)
              {
                  Console.WriteLine(jaggArray[i][j]);
              }
      
        }


    }

    #endregion

 
    #region  Functions with Array Parameters
    
    public void methodsWithArrayAsParams(int[] getaverage)
    {             
        int size = getaverage.Length;
        double average;
        int sum  = 0;

        for (int i = 0; i < size; i++)
        {   
            sum += getaverage[i];      
        } 
        average = (double)sum/size; // adding double to sum for getting average in decial form
    }

   #endregion


    #region Param KeyWords

    public void ParamsMethod(params string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i]+" ");
        }
    }

 

    #endregion


    #region Array Lists
    
    public void arrayList()
    {
        //declaring an ArrayList with undefined objects.
        ArrayList myArrayList = new ArrayList();//using System.Collections; have to add this header for ArrayList
        //declaring  an ArrayList with defined objects.
        ArrayList myArrayList2 = new ArrayList(23);

        //Adding objects to the arraylist
        myArrayList.Add(43);
        myArrayList.Add(32.54);
        myArrayList.Add(765.4);
        myArrayList.Add(323);
        myArrayList.Add(43.2);
        myArrayList.Add("any thing you can add of different data types");

        // myArrayList.Clear(); it clears all the elements in the arrayList.

        // if we have multiple same element it removes the first declared element

        //Removing element from the arrayList by SPECIFIC VALUE.
        // myArrayList.Remove(32.54); 

        //Removing element from the arrayList by  SPECIFIC POSITION.
        // myArrayList.RemoveAt(2); // in case of position have to use index.

        Console.WriteLine("The arraylist contains " + myArrayList.Count +" elements ");

        int sum =0;

        foreach (object obj in myArrayList)
        {
            if(obj is double)
            {
                sum += Convert.ToInt32(obj);
            }
            else if(obj is int)
            {
                sum += (int)obj;
            }
            else if(obj is string)
            {
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine("............. The End............");
            }
        }

        Console.WriteLine(sum);
 
    }

    #endregion


    #region  Lists

     public void Lists()
    {
        var evennum = new List<int>(); // Type 1 declaration
        evennum.Add(12);
        evennum.Add(32);


        var oddNUm = new List<int>{1,3,5,7,9}; // Type 2 decleration

        foreach (var elements in oddNUm)
        {
            Console.WriteLine(oddNUm);
        }

        for (int i = 0; i < oddNUm.Count; i++)  // Lists does'nt work with  "LENGTH" have to use "COUNT".
        {
            Console.WriteLine(oddNUm);
        }
    }

    #endregion


    #region HashTables

    public void HashTables()
    {

        // HashTable tables = new HashTable();








    }

    class Student // Constructor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public float Gpa { get; set; }

        public Student(int id,string name,float gpa) // The CONSTRUCTOR "NAME"  must be equal to "CLASS NAME".
        {
            this.Id= id;
            this.Name= name;
            this.Gpa= gpa;
        }

        
    }


    #endregion

   
   #region  Dictionarys

    public void dictionary()
    {
        Dictionary<int, Employe> myDictionary = new Dictionary<int, Employe>();// key, value respectively

        Employe[] members =  
        {
            new Employe(1,"Bruce",45),
            new Employe(2,"Stark",75),
            new Employe(3,"Hulk",34),
            new Employe(4,"Banner",65)
        };

      
        foreach (Employe emp in members)
        {
            myDictionary.Add(emp.Id,emp);
        }

        
    }
   class Employe // Constructor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public float Percentage { get; set; }

        public Employe(int id,string name,float Percentage) // The CONSTRUCTOR "NAME"  must be equal to "CLASS NAME".
        {
            this.Id= id;
            this.Name= name;
            this.Percentage= Percentage;
        }
    }

   #endregion


    #region  Stacks and Queues

    public void stackDec()
    {
        Stack<int> stack = new Stack<int>(); // Need to add using System.Collections.Generic;
        stack.Push(2);
        stack.Push(54);
        stack.Push(186);  
        // int mypop= stack.Pop();
        // //wil return the value which is at the top level without removing.
        // Console.WriteLine("{0} which is poped value",mypop);//output = 186
        // Console.WriteLine("{0} which is peek value",stack.Peek());//beaware with those braces after PEEK

        while (stack.Count > 0)
        {
            Console.WriteLine("The outmost value {0} removed from the stack",stack.Pop());

            Console.WriteLine("current value is {0}",stack.Count);
        }


    }
   
    #endregion



}


 