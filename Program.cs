using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First number in calculation
            int num1;

            // Second number in calculation
            int num2;

            // Result of calculation
            int result = 0;

            // Capturing user answer to keep program open after performing calculation
            string answer;

            // Variables to control various while booleans
            bool conditionsMet = false;
            bool playerContinue = false;
            bool containerToEnd = false;
            bool validComputationInput = false;

            // Welcome message after program opens
            Console.WriteLine("Hello, welcome to the calculator program!");

            // MAIN GAME LOOP
            while (!containerToEnd)
            {
                // User enters first number for calculation and it is stored
                Console.Write("Please enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                // User enters second number for calculation and it is stored
                Console.Write("Please enter your second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                // Asking user for input on what calculation to perform. Expecting either 'a', 's', m', or 'd' to be entered
                // But also have logic to account outside of those letters
                Console.WriteLine("What type of operation would you like to do?");
                Console.Write("Please enter a for addition, s for subtraction, m for multiplication, or d for division: ");

                // Answer will be fed into switch statement
                answer = Console.ReadLine();

                while (!conditionsMet)
                {
                    // Caclulation logic dependant on user input
                    while (!validComputationInput)
                    {
                        switch (answer)
                        {
                            // Adds num1 and num2 entered by user
                            // Sets 'end program' condition to 'true'
                            case "a":
                                result = num1 + num2;
                                conditionsMet = true;
                                validComputationInput = true;
                                break;
                            // Subtracts num1 and num2 entered by user
                            // Sets 'end program' condition to 'true'
                            case "s":
                                result = num1 - num2;
                                conditionsMet = true;
                                validComputationInput = true;
                                break;
                            // Multiplies num1 and num2 entered by user
                            // Sets 'end program' condition to 'true'
                            case "m":
                                result = num1 * num2;
                                conditionsMet = true;
                                validComputationInput = true;
                                break;
                            // Divides num1 and num2 entered by user
                            // Sets 'end program' condition to 'true'
                            case "d":
                                result = num1 / num2;
                                conditionsMet = true;
                                validComputationInput = true;
                                break;
                            // Requires the user input an acceptable character to progress further in program
                            default:
                                Console.WriteLine("Silly sod, enter either a for addition, s for subtraction, m for multiplication, or d for division");
                                answer = Console.ReadLine();
                                break;
                        }
                    }

                    // Prints result of calculation
                    Console.WriteLine("The result is: " + result);

                    // Slow down step
                    System.Threading.Thread.Sleep(1000);

                    Console.Write("Would you like to perform another caculation?: ");

                    // Logic to check if player wants to perform another calculation. 
                    // Forces user to provide expected answer or go through the loop again
                    while (!playerContinue)
                    {
                        // Variable to hold user's answer
                        string anotherCaclulation = Console.ReadLine();
                        switch (anotherCaclulation)
                        {
                            case "yes":
                                conditionsMet = true;
                                playerContinue = true;
                                validComputationInput = false;

                                    break;
                            case "ye":
                                conditionsMet = true;
                                playerContinue = true;
                                validComputationInput = false; 
                                break;
                            case "y":
                                conditionsMet = true;
                                playerContinue = true;
                                validComputationInput= false;
                                break;
                            case "no":
                                Console.WriteLine("So be it.");
                                playerContinue = true;
                                containerToEnd = true;
                                break;
                            case "n":
                                Console.WriteLine("So be it.");
                                playerContinue = true;
                                containerToEnd = true;
                                break;
                            default:
                                Console.WriteLine("No valid answer provided. Type 'yes' or 'no' to continue.");
                                break;
                        }
                    }
                    //Reset earlier WHILE boolean. Useful when player performs another calculation
                    playerContinue = false;
                }
                //Reset earlier WHILE boolean. Useful when player performs another calculation
                conditionsMet = false;
            }

            // Ending message to user & asks for input
            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Press any key to close program.");

            // Waits for user to provide input to close program
            Console.ReadKey();
        }
    }
}
