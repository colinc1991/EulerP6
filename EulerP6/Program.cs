/*
    The sum of the squares of the first ten natural numbers is,
    12 + 22 + ... + 102 = 385

    The square of the sum of the first ten natural numbers is,
    (1 + 2 + ... + 10)2 = 552 = 3025

    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

using System;

namespace EulerP6
{
    class Program
    {
        static void Main(string[] args)
        {
            // get sum of the squares
            double sumOfSquares = GetSumOfSquares();

            // get square of the sum
            double squareOfSum = GetSquareOfSum();

            // subtract the two
            Console.WriteLine($"The answer to {squareOfSum} minus {sumOfSquares} is {squareOfSum - sumOfSquares}");
        }

        static double GetSumOfSquares()
        {
            double total = 0;

            for (double i = 1; i < 101; i++)
            {
                total += (Math.Pow(i,2));
            }

            return total;
        }

        static double GetSquareOfSum()
        {
            int total = 0;

            for (int i = 1; i < 101; i++)
            {
                total += i;
            }

            return Math.Pow(Convert.ToDouble(total), 2);
        }
    }
}
