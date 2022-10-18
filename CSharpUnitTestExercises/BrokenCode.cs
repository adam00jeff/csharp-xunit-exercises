using System;
using System.Collections.Generic;

namespace CSharpUnitTestExercises
{
    /*
    * Each of the methods in this class has a bug in it that you need to fix.
    * Simply run the tests and see the error messages from those tests to diagnose
    * the problems. Some may fail due to the logic of the code, others may stop the project
    * building altogether.
    */

    public class BrokenCode
    {

        /*
        * The test for this method throws an exception because there
        * is an error in the code. Identify and fix that error. Use the information
        * provided on the training day for diagnosing problems. The key is to
        * understand the exception message and stack trace.
        */
        public int SumNumbers(IEnumerable<int> numbers)
        {
            var result = 0;
          
            foreach (int i in numbers)
            {
               result += i;
            }
            return result;
        }

        /*
        * The test for this method fails because there
        * is an error in the code. Identify and fix that error. The key is to
        * understand the exception message and stack trace.
        */
        public IEnumerable<string> ReverseStrings(IEnumerable<string> input)
        {
            var result = new List<string>();

            foreach (string s in input)
            {
                if (s == null)
                {
                    result.Add(null);
                }
                else
                {
                    var array = s.ToCharArray();
                    Array.Reverse(array);
                    result.Add(new string(array));
                }

            }

            return result.ToArray();
        }

        /* 
        * This code fails, but for a different reason - see if you can work out why.
        */
        public IEnumerable<string> AltReverseStrings(IEnumerable<string> input)
        {
            var result = new List<string>();

            foreach (string s in input)
            {
                if (s == null)
                {
                    result.Add(null);
                }
                else
                {
                    var array = s.ToCharArray();
                    Array.Reverse(array);
                    result.Add(new string(array));
                }
            }

            return result;
        }
    }
}