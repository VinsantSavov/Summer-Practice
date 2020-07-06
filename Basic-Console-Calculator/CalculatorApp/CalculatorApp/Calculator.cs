using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }

        public double Result { get; private set; }

        public void Add(double number)
        {
            this.Result += number;
        }

        public void Add(double firstNum, double secondNum)
        {
            this.Result = firstNum + secondNum;
        }

        public void Subtract(double number)
        {
            this.Result -= number;
        }

        public void Subtract(double firstNum, double secondNum)
        {
            this.Result = firstNum - secondNum;
        }


        public void Multiply(double number)
        {
            this.Result *= number;
        }

        public void Multiply(double firstNum, double secondNum)
        {
            this.Result = firstNum * secondNum;
        }

        public void Division(double number)
        {
            if (number == 0)
            {
                throw new InvalidOperationException("Division by zero is not permitted");
            }

            this.Result /= number;
        }

        public void Division(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                throw new InvalidOperationException("Division by zero is not permitted");
            }

            this.Result = firstNum / secondNum;
        }

        public double FinalResult()
        {
            return this.Result;
        }

        public void Clear()
        {
            this.Result = 0;
        }
    }
}
