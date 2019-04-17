using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArraysList2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of lists for user info (global)

             List<string> userName = new List<string>();
             List<string> password = new List<string>();

            //main menu
            Console.WriteLine("Would you like to (create account) or (login)?");
            if (Console.ReadLine() == "create account")
            {
                addUser();
            }
            else if (Console.ReadLine() == "login")
            {
                while (1 == 1) {

                    Console.Write("Enter Username:");
                    string unCheck = Console.ReadLine();
                    Console.Write("Enter Password:");
                    string pwCheck = Console.ReadLine();
                    if (userName.Contains(unCheck))
                    {
                        int indexCheck = userName.IndexOf(unCheck);
                        bool pwCorrect = (password[indexCheck] == pwCheck);
                        if (pwCorrect == true)
                        {
                            Console.Write("Welcome, ");
                            Console.WriteLine(unCheck);
                            Console.ReadKey();
                            Environment.Exit(0);
                        }


                    }

                }
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }

            
        }
        public static void addUser()
        {
            int validUsername = 0;
            
                Console.Write("Enter Username:");
                userName.Add(Console.ReadLine());
                for (int i = 0; i < userName.Count(); i++)
                {
                    if (userName[i] == userName[userName.Count()])
                    {
                        Console.WriteLine("Username already in use, please use a different username");
                        i = userName.Count();
                    }
                }
            

            Console.Write("Enter password:");
            password.Add(Console.ReadLine());
        }
    }


        
}

