using System;
using System.Numerics;

namespace CSharpUnitTestExercises
{
    /// <summary>
    ///     This class contains generic methods for number manipulation
    /// </summary>
    public class Numbers
    {
        /// <summary>
        /// Calculate the VAT to be applied to the given value, using a VAT rate of 20%.
        /// The result should ideally rounded up to two decimal places, although
        /// you can skip this if you want
        /// </summary>
        /// <param name="value"> The Value to calculate the VAT on</param>
        /// <returns>The VaT for the value entered, using a rate of 20%</returns>
            public decimal CalculateVAT(decimal value)
        {
            decimal calc = value / 100 * 20;
           decimal calc2 = decimal.Round(calc, 2);
            return calc2;
        }

        /*
         * Calculate the length of a right-angled triangle using
         * the Pythagorean Theorem: the square of the hypotenuse is the sum
         * of the squares of the other two sides.
         * ie: a(squared) + b(squared) = h(squared)
        */
        public double HypotenuseLength(double side1, double side2)
        {
            double hypot;
            hypot =Math.Sqrt(side1*side1 + side2*side2);
            return hypot;
        }

        /* 
         * (Advanced) Calculate the number at a given position in the
         *  Fibonnaci sequence.This sequence is formed by each number being the sum
         *  of the previous two numbers in the sequence. The first two numbers are
         *  1 and 1. Hence the third number is 2 (1 + 1) and the next is 3 (1 + 2).
         *  
         *  You can use any approach you want, including creating extra methods
         *  in this class (particularly useful if you want to use recursion). If
         *  you do want to use recursion and fancy a challenge, try making the
         *  method tail recursive so it's fast and doesn't break for larger numbers.
         *  
         *  Also, beware of integer overflows if you want to handle large Fibonacci
         *  numbers.Remember that int is only a maximum of 32 bits, so can only hold
         *  numbers up to and including "int.MaxValue". 
         *  Even long can only hold numbers up to and including "long.MaxValue"
         *  You'll have to change the method signature to BigInteger to handle really large numbers.
         *  To verify that your implementation can handle very large Fibonacci
         *  numbers, uncomment the fib(20,000) data set from the NumbersTest
         *  test case.
        */
        public BigInteger Fibonacci(BigInteger n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}



