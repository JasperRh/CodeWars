using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Solution 
{
    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            IEnumerable<long> digits = value.ToString().Select(digit => long.Parse(digit.ToString()));
            long sum = digits.Sum(x => Convert.ToInt64(Math.Pow(x, digits.Count())));

            return sum == value;
        }
    }
    
    [TestFixture]
    public class Sample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                    .Returns(true)
                    .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                    .Returns(true)
                    .SetDescription("371 is narcissitic");
        
            }
        }
  
        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => Kata.Narcissistic(n);
    }
}