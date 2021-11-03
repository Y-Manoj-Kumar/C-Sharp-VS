using System;
using System.IO;  // used in case of SimpleFile 

class SimpleFile
{
    public void WriteFile()
    {
        // declare a variable which is path
        string path = "Chanti.txt";

        // Creates a new file to write 
        string createText = "Welcome to File" + Environment.NewLine;
        File.WriteAllText(path,createText);

        // EXISTING FILE/NEW FILE: Update text
        // This text is always added, making the file longer over time
        // if it is not deleted.
        string appendText = "Lets go" + Environment.NewLine;
        File.AppendAllText(path,appendText);


        // EXISTING FILE ONLY: Read data
        // Open the file to read from.

        if (File.Exists(path))
        {
            Console.WriteLine(File.ReadAllText(path)); 
        }
        else
        {
            Console.WriteLine("Better luck next time Bye Byeeeee");
        }

    }



}