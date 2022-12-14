using System.Linq;
using NUnit.Framework;

namespace Solution 
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int parenthesesCount = 0;
            foreach (char character in input)
            {
                if (character == '(')
                {
                    parenthesesCount++;
                }
                else if(character == ')')
                {
                    parenthesesCount--;
                    
                    if (parenthesesCount < 0)
                    {
                        return false;
                    }
                }
            }

            return parenthesesCount == 0;
        }
    }
    
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses( "()" ));
        }
    
        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Parentheses.ValidParentheses( ")((((" ));
        }
    }
}