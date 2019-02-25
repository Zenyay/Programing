using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = new int[50];
            int[] ArrayofNumbers = new int[3];
            int[] numberArray = new int[5];

            double[] dblArray = new double[4];
            double[] arrayOfDoubles = new double[15];
            double[] playerPoints = new double[39];

            string[] stringArray1 = new string[20];
            string[] arrayOfStrings = new string[25];
            string[] wordArray = new string[6];

            numberArray[0] = 12;
            numberArray[1] = 13;
            numberArray[2] = 14;
            numberArray[3] = 15;
            numberArray[4] = 16;

            ArrayofNumbers[0] = 47;
            ArrayofNumbers[1] = 46;
            ArrayofNumbers[2] = 39;

            dblArray[0] = 12.43;
            dblArray[1] = 5.12;
            dblArray[2] = 43.21;
            dblArray[3] = 1.34;

            wordArray[0] = "What";
            wordArray[1] = "is";
            wordArray[2] = "Forrest";
            wordArray[3] = "Gump's";
            wordArray[4] = "password?";
            wordArray[5] = "1Forrest1";

            Console.WriteLine(numberArray[0]);
            Console.WriteLine(numberArray[1]);
            Console.WriteLine(numberArray[2]);
            Console.WriteLine(numberArray[3]);

            Console.WriteLine(wordArray[0]);
            Console.WriteLine(wordArray[1]);
            Console.WriteLine(wordArray[2]);
            Console.WriteLine(numberArray[3]);
            Console.WriteLine(numberArray[4]);
            Console.WriteLine(wordArray[5]);

            Console.ReadLine();
        }
    }
}
