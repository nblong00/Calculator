using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

            // Variable to close program at end of WHILE loop
            bool conditionsMet = false;

            // Welcome message after program opens
            Console.WriteLine("Hello, welcome to the calculator program!");

            // User enters first number for calculation and it is stored
            Console.Write("Please enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // User enters second number for calculation and it is stored
            Console.Write("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Asking user for input on what calculation to perform. Expecting either 'a', 's', m', or 'd' to be entered
            // But also have logic to account outside of those letters
            Console.WriteLine("What type of operation would you like to do?: ");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or d for division.");
            answer = Console.ReadLine();

            // Caclulation logic dependant on user input
            while (!conditionsMet)
            {
                // Adds num1 and num2 entered by user
                // Sets 'end program' condition to 'true'
                if (answer == "a")
                {
                    result = num1 + num2;
                    conditionsMet = true;
                }
                // Subtracts num1 and num2 entered by user
                // Sets 'end program' condition to 'true'
                else if (answer == "s")
                {
                    result = num1 - num2;
                    conditionsMet = true;
                }
                // Multiplies num1 and num2 entered by user
                // Sets 'end program' condition to 'true'
                else if (answer == "m")
                {
                    result = num1 * num2;
                    conditionsMet = true;
                }
                // Divides num1 and num2 entered by user
                // Sets 'end program' condition to 'true'
                else if (answer == "d")
                {
                    result = num1 / num2;
                    conditionsMet = true;
                }
                // Requires the user input an acceptable character to progress further in program
                else
                {
                    Console.WriteLine("Silly sod, enter either a for addition, s for subtraction, m for multiplication, or d for division");
                    answer = Console.ReadLine();
                }
            }

            // Prints result of calculation
            Console.WriteLine("The result is: " + result);

            // Ending message to user & asks for input
            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Press any key to close program.");

            // Waits for user to provide input to close program
            Console.ReadKey();
        }
    }
}
