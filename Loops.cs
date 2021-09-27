
using System;
using System.Linq;
using System.Collections.Generic;
class DoWhileLoop // First execute the code and then it check's the condition.
{

    public void LengthOfInput()
    {
        int lengthOftext = 0;
        string wholeText ="";
         
        do
        {
            Console.WriteLine("Enter your friends name");
            string nameOfAFriend= Console.ReadLine();
            int currentLength = nameOfAFriend.Length; 
            lengthOftext += currentLength;
            wholeText += nameOfAFriend;
            
        }while(lengthOftext<20);

        Console.WriteLine("its enough for now"+ wholeText);
    }

}


class WhileLoop  // first checks the condition and then execute's the code.
{
    public void enteredText()
    {
        int counter = 0;
        string text = "";

        while(text.Equals(""))
        {
            Console.WriteLine("Please press enter for increasing the persons");
            text = Console.ReadLine();
            counter++;
            Console.WriteLine("person number"+counter);
        }
        Console.WriteLine("Number of persons you have entered is :"+counter);


    }
}

/*
 calculate the average of  student marks ,and the mark entered between 1 to 20,and for result use -1 as a code
*/
class LoopProblem
{
    public void MarksAverage()
    {
        string input ="0"; // used as code for result
        int count = 0;          // these are the variables required for this problem
        int total = 0;
        int currentNumber = 0;// student marks

        while(input != "-1") //checks the condition and execute the code.
        {
                Console.WriteLine("Last number was {0}",currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries are {0}",count);
                Console.WriteLine("Please enter -1 for calculate the average");

                input = Console.ReadLine();
        
            if(input.Equals("-1")) // average calculation
            {
                Console.WriteLine("......................................");
                double average = (double)total/(double)count;
                Console.WriteLine("The average of the student marks is:" + average);
            }

            if(int.TryParse(input,out currentNumber) && currentNumber > 0 && currentNumber < 21 )
            {
                total += currentNumber; // adding the input marks such as total

            }
            else
            {
                if(!(input.Equals("-1")))
                {
                        Console.WriteLine("Please enter a value between 1 and 21");
                }
                 continue;         
            }
            count++;
        }
       
    }

}