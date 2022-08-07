
using System;
using System.Collections;
using System.Linq;
using System;
using System.IO;

class AppLogic
{


    public static void Main ()
    {
        AppLogic al = new AppLogic(); 
        al.start();
        // FavouriteTab ft = new FavouriteTab();


        // SimpleFile file = new SimpleFile();
        // file.WriteFile();
        
    }

    public void start()
    {
        
        Console.WriteLine("Loading App Data");
        Console.WriteLine("choose 1)ContactsTab 2)RecentTab 3)FavouriteTab");
        int userinput = int.Parse(Console.ReadLine());
        if(userinput == 1)
        {
           displayscontact(); // need to link with the respective class
        }
        else if(userinput == 2)
        {
            Console.WriteLine("Displays RecentTab"); 
        }
        else if(userinput == 3)
        {
             Console.WriteLine("Displays FavouriteTab");
        }
        else
        {
             Console.WriteLine("DefaultTab");
        }
        
        string path = "SimpleFile.txt";
        string createText= "createnewcontact" + Environment.NewLine;
        File.WriteAllText(path,createText);


    }

    #region  ContactsTab

    // public class ContactsTab
    // {
        /*
    -->In ContactsTab you can find the list of contacts and you can create new concact.
    -->The contacts are sorted by using Alphabet sequence.
    -->You can search the contacts in Search Bar and NumPad.
    -->You can view the Contact details by clicking on the profile bar/template.
    -->The unasigned concact photos are set to be first name of contact letter with a random colour
        */
        public void displayscontact()
        {
            Console.WriteLine("\nDisplays ContactsTab"); 
            Console.WriteLine("\nShows the contact list");
            Console.WriteLine("Choose 1)createnewcontact 2)contactdetails");
            int userinput = int.Parse(Console.ReadLine());
            if (userinput == 1)
            {
                createnewcontact();
            }
            else if(userinput == 2)
            {
                contactdetails();
            }

        }

        public void createnewcontact()//keyword for int and string for gmail
        {
            Console.WriteLine("Enter yout Firstname and last name");
            string firstandlastname = Console.ReadLine();
            Console.WriteLine("Enter your mobile number");
            long  mobilenumber = long.Parse(Console.ReadLine());
    
            Console.WriteLine("Name:"+firstandlastname + "\n MobileNumber:"+mobilenumber);
        }

        //The details which we entered above need to link below
        public void contactdetails()
        {
            //You can make a videocall,audiocall and message
            //You can edit the details and bookmark too
            //And also you can find the other apps too which are similar to it ,where that respective number is registered 

            Console.WriteLine("FirstName:Harry ");
            Console.WriteLine("lastname:Potter");
            Console.WriteLine("MobileNumber:873625326");
            Console.WriteLine("Email:harry@gmai.com");
        }

        

    // }    

    #endregion



    #region RecentTab

    /*
    
-->In this tab you can find the contacts that are sorted by time based and also sorted by days tooo.
-->Here you can find the contacts which you called,missed call and rejected calls with date ,time and sim connection.
-->From here also you can view the contact details .
-->Here you can find the quick dial symbol where You can make a call without entering into the conatact details.
-->When you cliclks on the profile bar the bar gets extended and shows the video and audio call option
   and as you can find the call history of the respective contact 
-->In this tab when you clicks on the profile the contact details will display and when you clicks on other than
   profile you can find those extended options
-->Here also you can search the contacts by using search bar and numpad.
-->

    */

    #endregion
}