using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game");
            bool playAgain = true;
            while (playAgain == true)
            {
                string name = Input("What is your name?");
                Console.Write("Hello, ");
                Console.Write(name);
                Console.WriteLine("!");
                int attemptIndex = 1;
                int theSecretNumber = GenerateNumber();
                int userGuessedNumber = GetGuess();
                bool isMatch = checkGuess(theSecretNumber, userGuessedNumber);
                while (isMatch == false)
                {
                    userGuessedNumber = GetGuess();
                    isMatch = checkGuess(theSecretNumber, userGuessedNumber);
                    attemptIndex++;
                }
                Console.Write("Congratulations! You found the secret number ");
                Console.Write(theSecretNumber);
                Console.WriteLine("!");
                Console.Write("It took you ");
                Console.Write(attemptIndex);
                Console.WriteLine(" tries to find the secret number!");
                bool validInputExit = false;
                while (validInputExit == false)
                {
                    Console.WriteLine("Would you like to play again? (enter y/n)");
                    string response = Console.ReadLine();
                    if (response == "y")
                    {
                        playAgain = true;
                        validInputExit = true;
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine("Thank you for playing! See you again soon!");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("That wasn't a choice!");
                        validInputExit = false;
                    }
                }
            }
        }
        static string Input(string promptString)
        {
            Console.WriteLine(promptString);
            string inputString = Console.ReadLine();
            return inputString;
        }
        static int IntInput(string promptString)
        {
            bool isIntInput = false;
            int inputInt = 0;
            while (isIntInput == false){
                try
                {
                    string inputString = Input(promptString);
                    inputInt = Convert.ToInt32(inputString);
                    isIntInput = true;
                }
                catch (FormatException)
                {
                    isIntInput = false;
                    continue;
                }
            }
            return inputInt;           
        }
        static int GenerateNumber()
        {
            Random rand = new Random();
            int theSecretNumber = rand.Next(1, 100);
            return theSecretNumber;
        }
        static int GetGuess()
        {
           int userGuessedNumber = IntInput("Please enter an integer between 1 and 100");
           return userGuessedNumber;           
        }
        static void printHint(int theSecretNumber, int userGuessedNumber)
        {
            if (theSecretNumber < userGuessedNumber)
            {
                Console.WriteLine("Your guess was too high");
            }
            else
            {
                Console.WriteLine("Your guess was too low");
            }
            return;
        }
        static bool checkGuess(int theSecretNumber,int userGuessedNumber)
        {
            bool isMatch = false;
            if (theSecretNumber == userGuessedNumber)
            {
                isMatch = true;
            }
            else
            {
                printHint(theSecretNumber, userGuessedNumber);
            }
            return isMatch;
        }
    }
}
