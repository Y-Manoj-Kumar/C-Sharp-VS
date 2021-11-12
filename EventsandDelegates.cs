using System;
using System.Linq;
using System.Collections.Generic;


// Delegates contain LISTs

/*
 Creating a DELEGATE

Filtering peoples based on their age like Minor,Major,SeniorCitizen
--> Variables required Name,Age.
-->Create a class Person and create properties called Name and Age
-->Defining a delegate type called FilterDelegate that takes a person an object P and return bool
-->Create  list of persons P1,P2,... objects containing Name and Age
-->Add that objects to the list called People 
-->Next need to print title(Major,Minor..),List of People,FilterDelegate filter .
-->By creating DisplayPeople method and above use as a parameters .
-->In the DisplayPeople method first print title
-->Using foreach check the whether the person asses the filter if yes then print Name and Age.
-->Create a filters for Minors,Majors and SeniorCitizen uisng bool and return type 

*/


class Person
{
   public string Name { get; set; }
   public int Age { get; set; }

}
class Delegate
{
    public delegate bool FilterDeleagte(Person P);
 
    public void delegateDemo()
    {  
        Person P1 = new Person(){Name="HulkBuster", Age=17};
        Person P2 = new Person(){Name="TonyStark", Age=47};
        Person P3 = new Person(){Name="BlackWidow", Age=23};
        Person P4 = new Person(){Name="Falcon", Age=68};  
        Person P5 = new Person(){Name="Loki", Age=98};   

        
        List<Person> people = new List<Person>(){P1,P2,P3,P4,P4};
    }

    public void DisplayPeople(string title,List<Person> people,FilterDeleagte filter)
    {
        Console.WriteLine(title);

        foreach (var P in people)
        {
            if (filter(P))
            {
                Console.WriteLine("{0},{1} years old",P.Name,P.Age);
            }
        }
    }

    static  bool IsMinor(Person p)
    {
        return p.Age<18;
    }

    static bool IsMajor(Person P)
    {
        return P.Age<50 && P.Age>18;
    }

    static bool IsSenior(Person P)
    {
        return P.Age>50;
    }


}
    
