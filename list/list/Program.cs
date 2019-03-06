using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu

            student st = new student();
            st.addStudent("Able", "che", "AC", 5177889876);
            st.giveTardies("AC");
            st.giveTardies("AC");
            st.getTardies("AC");
            st.giveAbsent("AC");
            st.getAbsent("ag");

            Console.ReadLine();
        }
    }
}
