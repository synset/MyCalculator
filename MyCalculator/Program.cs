using System;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            string inputFirstNr = (Console.ReadLine());
            int firstNr;
            Int32.TryParse(inputFirstNr, out firstNr);

            Console.WriteLine("Enter operation of choice ( +, -, / or *)");
            string userOperator = Console.ReadLine();

            Console.WriteLine("Please enter your second number: ");
            string inputSecondNr = (Console.ReadLine());
            int secondNr;
            Int32.TryParse(inputSecondNr, out secondNr);

           
            switch (userOperator)
            {
                
                case "-":
                    int result = firstNr - secondNr;
                    Console.WriteLine(firstNr + " - " + secondNr + " = " + result);
                    break;

                case "+":
                    result = firstNr + secondNr;
                    Console.WriteLine(firstNr + " + " + secondNr + " = " + result);
                    break;

                case "/":
                    result = firstNr / secondNr;
                    Console.WriteLine(firstNr + " / " + secondNr + " = " + result);
                    break;

                case "*":
                    result = firstNr * secondNr;
                    Console.WriteLine(firstNr + " * " + secondNr + " = " + result);
                    break;

                default:
                    Console.WriteLine("Please choose one of the operators: -, +, / or *");
                    break;
            }
        }
    }
}
