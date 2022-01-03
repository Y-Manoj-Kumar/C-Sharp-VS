using System;

class StringManipulation
{

    public void Types()
    {
        //String Concatination
        int a = 40000000;
        string car= "Benz";
        Console.WriteLine("its a new model " + car + " which is nearly " , a +"Rs");

        //String Formatting
        Console.WriteLine("it's a new model{0},which is nearly {1}Rs ", car,a);

        //String Interpolation
        Console.WriteLine($"it's a new model{car},which is nearly {a}Rs",car,a);

    }

    public void ExerciseOne()
    {
        string user ;

        Console.WriteLine("Please enter your name " );
        user = Console.ReadLine();

        Console.WriteLine("Hi this is "+ user);

    }

    public void AddingNames()
    {

        Console.WriteLine("Enter your first name");
        string firstname=Console.ReadLine();
        
        Console.WriteLine("Enter your last name");
        string lastname=Console.ReadLine();
      
         Console.Write("hello Mr.{0} {1}",firstname,lastname);


    }


        public void str()
    {
        string str1 = "This is Denis Panjuta from ukarine";

        // int stringContains = str1.IndexOf("p",StringComparison.CurrentCultureIgnoreCase);
        // Console.WriteLine(stringContains);

        var replacement =str1.Replace("DeNis","Marry",StringComparison.CurrentCultureIgnoreCase);
        Console.WriteLine(str1);
        Console.WriteLine(replacement);

         
    }

}