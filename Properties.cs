using System;              // TOP LEVEL STATEMENTS
using System.Linq;
using System.Collections.Generic;
using System.Configuration;

/*
-->// In properties it's better to declare the variables with "_[underscore]"


*/

class Student
{
    int _Stuid;
    string _StuName;
    int _MobileNo;
    string _MailId;

    public Student(int stuid,string stuname,int mobileno,string mailid)
    {
     this._Stuid = stuid;
     this._StuName = stuname;
     this._MobileNo = mobileno;
     this._MailId = mailid;  
    }

    public int Stuid
    { 
        get
        { 
            return _Stuid;
        }
        set
        {
            if(value < 21)
            {
                _Stuid = value;
            }
            else 
            {
                Console.WriteLine("please enter value below 21 ;)");
            }
        
        }

    }

}   
