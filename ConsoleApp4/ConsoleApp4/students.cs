using ConsoleApp4;
using System;
using System.Collections;
using System.Collections.Generic;

public class students
{
    string firstName;
    string lastName;
    string username;
    long phoneNumber;
    //list of assignments
    List<assignments> Assignments;
    int daysAbsent;
    int daysTardy;

    public students(string firstName, string lastName, string username, long phoneNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.username = username;
        this.phoneNumber = phoneNumber;
        this.daysAbsent = 0;
        this.daysTardy = 0;
        Assignments = new List<assignments>();
    }
    public string getUsername()
    {
        return username;
    }

    public void markTardy()
    {
        daysTardy = daysTardy + 1;
    }

    public void markAbsent()
    {
        daysAbsent = daysAbsent + 1;
    }

    public int getTardyCount()
    {
        return daysTardy;
    }

    public int getAbsentCount()
    {
        return daysAbsent;
    }

    public string getAssignmentName()
    {
        return getAssignmentName();
    }

    public void setAssignmentSection(string assignmentName, int pointsPossible)
    {

    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    //returns -1 if no section was found with the given sectionname
    //otherwise returns the index of the section with matching name
    public int getAssignmentIndexByAssignmentName(string assignmentName)
    {
        int index = 0;
        while (index < Assignments.Count)
        {
            if (assignmentName.Equals(Assignments[index].getAssignmentName()))
            {
                return index;
            }
            index++;
        }
        return -1;
    }
}
