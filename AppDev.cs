
using System;
using System.Collections;
using System.Linq;

class AppLogic
{


    public static void Main ()
    {
        AppLogic al = new AppLogic();
        al.start();
        // FavouriteTab ft = new FavouriteTab();
        
    }

    public void start()
    {
        
        Console.WriteLine("Loading App Data");
        Console.WriteLine("choose 1)ContactsTab 2)RecentTab 3)FavouriteTab");
        int userinput = int.Parse(Console.ReadLine());
        if(userinput == 1)
        {
            displayscontact();
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
        

    }

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
            Console.WriteLine("Shows the contact list");
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
            Console.WriteLine("FirstName:Harry ");
            Console.WriteLine("lastname:Potter");
            Console.WriteLine("MobileNumber:873625326");
            Console.WriteLine("Email:harry@gmai.com");
        }

    // }


}