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
            int num1;
            int num2;
            int result = 0;

            string answer;

            bool conditionsMet = false;

            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.Write("Please enter first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?: ");

            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or d for division.");

            answer = Console.ReadLine();

            while (!conditionsMet)
            {

                if (answer == "a")
                {
                    result = num1 + num2;
                    conditionsMet = true;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                    conditionsMet = true;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                    conditionsMet = true;
                }
                else if (answer == "d")
                {
                    result = num1 / num2;
                    conditionsMet = true;
                }
                else
                {
                    Console.WriteLine("Silly sod, enter either a for addition, s for subtraction, m for multiplication, or d for division");
                    answer = Console.ReadLine();
                }
            }

            Console.WriteLine("The result is: " + result);

            Console.WriteLine("Thank you for using the calculator!");

            Console.ReadKey();
        }
    }
}
