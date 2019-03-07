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
                Console.Write("Enter Username:");
                userName.Add(Console.ReadLine());
                Console.Write("Enter password:");
                password.Add(Console.ReadLine());

            }
            else if (Console.ReadLine() == "login")
            {
                while (1 == 1){

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
            
        }

        
    }

