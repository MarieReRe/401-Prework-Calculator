using System;
using System.Runtime.InteropServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the calculator app!");
            CalculatorApp();
     


        }
        public static void CalculatorApp()
        {
            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            //convert all to lower case in case the user types a capital or whatever combo
            string operand = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter two numbers, hitting enter after each ");
            // parse string input to int type
            int userNumberOne = int.Parse(Console.ReadLine());
            int userNumberTwo = int.Parse(Console.ReadLine());


            //declare total as a float type
            float total = 0;

            //conditionals for operands
            if (operand == "add" || operand == "+")
            {
                total = addNumbers(userNumberOne, userNumberTwo);

            }
            else if (operand == "subtract" || operand == "-")
            {
                total = subtractNumbers(userNumberOne, userNumberTwo);
            }
            else if (operand == "multiply" || operand == "*") ;
            {
                total = multiplyNumbers(userNumberOne, userNumberTwo);
            }

            // tell user the result: 
            Console.WriteLine("The total for your calculation is {0}", total);
      
        }
        // Add Function
        public static int addNumbers(int userNumberOne, int userNumberTwo)
        {
            int total = userNumberOne + userNumberTwo;
            return total;
        }
        // Subtract Function
        public static int subtractNumbers(int userNumberOne, int userNumberTwo)
        {
            int total = userNumberOne - userNumberTwo;
            return total;
        }
        // Multiply Function
        public static int multiplyNumbers(int userNumberOne, int userNumberTwo)
        {
            int total = userNumberOne * userNumberTwo;
            return total;
        }
        // Divide Function

    }
}
