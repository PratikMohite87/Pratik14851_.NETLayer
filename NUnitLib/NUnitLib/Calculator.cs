using System;

namespace NUnitLib
{
    public class Calculator
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public int Subtraction(int first, int second)
        {
            if (first < second)
            {
                throw new ArgumentException($"First number {first} is less than the second number {second}");
            }

            return first - second;
        }

        public decimal division(int first, int second)
        {
            if (first < 0 || second < 0)
                throw new ArgumentException($"you have entered -ve No");
            else if (second == 0)
                throw new DivideByZeroException($"divisor is 0 not allowed");
            else
                return first / second;
        }
    }
}
