using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class student
    {
        ///Properties
        string SFname;
        string SLname;
        string SUname;
        long phone;
        attendance att = new attendance();
        //Lists for assignments

        ///constructor
        public student()
        {

        }

        ///Methods
        public void addStudent(string firstName, string lastName, string username, long phoneNumber) //creates a new student
        {
            SUname = username;
            SFname = firstName;
            SLname = lastName;
            phone = phoneNumber;
        }
        //used to add assignment 
        //used to get scores
        //used to apply score
        public void getTardies(string username)//used to get tardies
        {
            int tardies = att.GetTardyCount("");
            Console.WriteLine(SUname + " has "+tardies+" tardies");
        }
        public void getAbsent(String username)//used to get absences
        {
            int absent = att.getAbsentCount("");
            Console.WriteLine(SUname + " has " + absent + " absences");
        }
        public void giveTardies(string username)//used for adding to tardies
        {
            att.markTardy("");
        }
        public void giveAbsent(string username)//used for adding to absences
        {
            att.markAbsent("");
        }
    }
}
