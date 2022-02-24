using HelloWorld.Interfaces;

namespace HelloWorld.Models
{
    public class Calculator : ICalculator
    {
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}