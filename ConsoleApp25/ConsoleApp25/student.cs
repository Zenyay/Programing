using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class student
    {
        //properties
        int studentID;
        string name;
        double contentGrade;
        double workHabitGrade;
        double participation;
        int age;

        public student(string Name, int ID, int Age)
        {
            name = Name;
            studentID = ID;
            age = Age;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
        }

        public student()
        {
            name = "testStudent";
            studentID = -1;
            contentGrade = 0;
            workHabitGrade = 0;
            participation = 0;
            age = 18;
        }

        public void SetContentGrade(int grade)
        {
            contentGrade = grade;
        }

        public void SetWorkHabitGrade(int grade)
        {
            workHabitGrade = grade;
        }

        public void SetParticipation(int grade)
        {
            participation = grade;
        }

        public void getGrade()
        {
            Console.WriteLine(.35 * workHabitGrade + .4 * contentGrade + .25 * participation);
        }

        public void printGrade()
        {
            getGrade();
        }
    }
}
