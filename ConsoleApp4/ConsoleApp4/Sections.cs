using System;
using System.Collections;
using System.Collections.Generic;

public class Sections
{
    //list of students
    private List<students> Students;
    private string sectionName;

    public Sections(string sectionName)
    {
        this.sectionName = sectionName;
        Students = new List<students>();
    }

    public string getSectionName()
    {
        return sectionName;
    }

    //create a new student if the username does not exist and add to the studentList
    //returns false if username exists, return true otherwise
    public bool addStudent(string firstName,string lastName,string username,long phoneNumber)
    {
        //check if username exists
        int studentIndex = getStudentIndexByUsername(username);
        //if exists return false
        if(studentIndex != -1)
        {
            return false;
        }
        //otherwise create student and add and return true
        Students.Add(new students(firstName, lastName, username, phoneNumber));
        return true;
    }

    //mark the student specified by username tardy (increase tardy count)
    //if student is not foung return false otherwise true
    public bool markTardy(string username)
    {
        //get the student specified by username
        students currStudent = getCurrentStudent(username);
        //if no student return null
        if (currStudent == null)
        {
            return false;
        }
        //mark student as tardy
        currStudent.markTardy();
        return true;
    }

    //mark the student specified by username absent (increase absent count)
    //if student is not foung return false otherwise true
    public bool markAbsent(string username)
    {
        //get the student specified by username
        students currStudent = getCurrentStudent(username);
        //if no student return null
        if (currStudent == null)
        {
            return false;
        }
        //mark student as tardy
        currStudent.markAbsent();
        return true;
    }

    public int getTardyCount(string username)
    {
        //get the student specified by username
        students currStudent = getCurrentStudent(username);
        //if no student return null
        if (currStudent == null)
        {
            return -1;
        }
        //mark student as tardy
        return currStudent.getTardyCount();
    }

    public int getAbsentCount(string username)
    {
        //get the student specified by username
        students currStudent = getCurrentStudent(username);
        //if no student return null
        if (currStudent == null)
        {
            return -1;
        }
        //mark student as tardy
        return currStudent.getAbsentCount();
    }

    public bool addAssignmentToSection(string assignmentName, int pointsPossible)
    {
        //find out if students already have assignments
        for (int k = 0; k < Students.Count; k++)//checks for repeats
        {
            if (assignmentName.Equals(Students[k]))
            {
                return false;
            }
        }
        //add assignment to all students
        return true;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //returns -1 if no section was found with the given sectionname
    //otherwise returns the index of the section with matching name
    private int getStudentIndexByUsername(string username)
    {
        int index = 0;
        while (index < Students.Count)
        {
            if (username.Equals(Students[index].getUsername()))
            {
                return index;
            }
            index++;
        }
        return -1;
    }

    //return the section if there are any sections
    //return null if there are no current sections
    private students getCurrentStudent(string username)
    {
        
        int index = getStudentIndexByUsername(username);

        if (index == -1)
        {
            return null;
        }
        
        return Students[index];
    }

}

