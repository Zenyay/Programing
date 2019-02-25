using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>();
            List<int> listOfInts = new List<int>();
            List<int> testScores = new List<int>();

            List<double> dblList = new List<double>();
            List<double> listOfDouble = new List<double>();
            List<double> playerPoints = new List<double>();

            List<string> stringList = new List<string>();
            List<string> listOfStrings = new List<string>();
            List<string> studentNeame = new List<string>();

            List<int> intList = new List<int>();
            List<double> DblList = new List<double>();
            List<string> strList = new List<string>();

            intList.Add(12);
            intList.Add(5);
            intList.Add(7);
            intList.Add(3);

            int intElement = intList[0];
            Console.WriteLine(intElement);
            intElement = intList[1];
            Console.WriteLine(intElement);
            intElement = intList[2];
            Console.WriteLine(intElement);
            intElement = intList[3];
            Console.WriteLine(intElement);

            intList[0] = 13;
            intList[3] = 8;
            intElement = intList[0];
            Console.WriteLine(intElement);
            intElement = intList[1];
            Console.WriteLine(intElement);
            intElement = intList[2];
            Console.WriteLine(intElement);
            intElement = intList[3];
            Console.WriteLine(intElement);

            DblList.Add(12.1);
            DblList.Add(5.2);
            DblList.Add(7.3);

            double dblElement = DblList[0];
            Console.WriteLine(dblElement);
            dblElement = DblList[1];
            Console.WriteLine(dblElement);
            dblElement = DblList[2];
            Console.WriteLine(dblElement);

            DblList[1] = 13.1;
            DblList[2] = 8.2;
            dblElement = DblList[0];
            Console.WriteLine(dblElement);
            dblElement = DblList[1];
            Console.WriteLine(dblElement);
            dblElement = DblList[2];
            Console.WriteLine(dblElement);

            strList.Add("Hi");
            strList.Add("How");
            strList.Add("Are");
            strList.Add("You?");

            string strElement = strList[0];
            Console.WriteLine(strElement);
            strElement = strList[1];
            Console.WriteLine(strElement);
            strElement = strList[2];
            Console.WriteLine(strElement);
            strElement = strList[3];
            Console.WriteLine(strElement);

            strList[1] = "good";
            strList[2] = "thanks";
            strElement = strList[0];
            Console.WriteLine(strElement);
            strElement = strList[1];
            Console.WriteLine(strElement);
            strElement = strList[2];
            Console.WriteLine(strElement);
            strElement = strList[3];
            Console.WriteLine(strElement);

            Console.ReadLine();
        }
    }
}
