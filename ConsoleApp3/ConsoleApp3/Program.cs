using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static List<string> accounts = new List<string>();
        static List<string> passwords = new List<string>();
        static void Main(string[] args)
        {
            //pass for use
            //combine acc
            //login w/no acc made
            //reuse use
            Menu();

            Console.ReadLine();
        }
        public static void Menu()//orginizes evything
        {
            Console.WriteLine("Would you like to (create account) or (login)?");//givse choices
            string input = Console.ReadLine();
            if (input == "create account")
            {
                makeAcc();//calls the function for creating accounts
                Menu();
            }
            else if (input == "login")
            {
                login();//calls login function
            }
        }
        public static void makeAcc()
        {
            string username, password;

            while (true)
            {
                bool exist = false;

                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                for (int k = 0; k < accounts.Count; k++)//checks for repeats
                {
                    if (username.Equals(accounts[k]))
                    {
                        exist = true;
                    }
                }
                if (exist == false)
                {
                    break;
                }
            }
            Console.WriteLine("Enter password");//get password
            password = Console.ReadLine();
            accounts.Add(username);
            passwords.Add(password);
        }
        public static void login()
        {
            string username, password;

            bool exist = false;
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();
            for (int k = 0; k < accounts.Count; k++)//checks for existing account
            {
                if (username.Equals(accounts[k]) && password.Equals(passwords[k]))
                {
                     exist = true;
                     Console.WriteLine("welcome");
                }
               
            }
            if(exist==false)
            {
                Console.WriteLine("sorry account does not match records ");
                Menu();
            }
        }
    }
}
