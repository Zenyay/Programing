using System;
using System.Collections;


class assignments
{
    int pointsPossible;
    int pointsEarned;
    string assignmentName;

    public assignments(int pointsPossible, int pointsEarned, string assignmentName)
    {
        this.pointsPossible = pointsPossible;
        this.pointsEarned = pointsEarned;
        this.assignmentName = assignmentName;
    }

    public string getAssignmentName()
    {
        return assignmentName;
    }
}

