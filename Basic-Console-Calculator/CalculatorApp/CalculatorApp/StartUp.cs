using System;
using System.Linq;

namespace CalculatorApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    if (input == "=")
                    {
                        Console.WriteLine($"The result is: {calculator.FinalResult()}");
                    }
                    else if (input == "+" || input == "-" || input == "*" || input == "/")
                    {
                        StartWithOperator(calculator, input);
                    }
                    else
                    {
                        NumberProcessing(calculator, input);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void NumberProcessing(Calculator calculator, string input)
        {
            calculator.Clear();

            double firstNum = double.Parse(input);
            string operation = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    calculator.Add(firstNum, secondNum);
                    break;
                case "-":
                    calculator.Subtract(firstNum, secondNum);
                    break;
                case "*":
                    calculator.Multiply(firstNum, secondNum);
                    break;
                case "/":
                    calculator.Division(firstNum, secondNum);
                    break;
            }

            Console.WriteLine($"The result is: {calculator.FinalResult()}");
        }

        private static void StartWithOperator(Calculator calculator, string input)
        {
            double firstNumber = double.Parse(Console.ReadLine());

            switch (input)
            {
                case "+":
                    calculator.Add(firstNumber);
                    break;
                case "-":
                    calculator.Subtract(firstNumber);
                    break;
                case "*":
                    calculator.Multiply(firstNumber);
                    break;
                case "/":
                    calculator.Division(firstNumber);
                    break;
            }

            Console.WriteLine($"The result is: {calculator.FinalResult()}");
        }
    }
}
