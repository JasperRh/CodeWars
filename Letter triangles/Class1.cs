using System;
using System.Linq;
using NUnit.Framework;

namespace Letter_triangles {
/// <summary>
/// https://www.codewars.com/kata/635e70f47dadea004acb5663/train/csharp
/// </summary>
    public class Kata
    {
        public static string Triangle(string row)
        {
            if (row.Length == 1)
            {
                return row;
            }
            
            char[] charArray = new char[row.Length - 1];
            for (int i = 0; i < row.Length - 1; i++)
            {
                int sum = (row[i] - 96) + (row[i + 1] - 96);
                charArray[i] = Convert.ToChar(sum > 26 ? (sum - 26) + 96 : sum + 96);
            }

            if (charArray.Length > 1)
            {
                return Triangle(string.Join("", charArray));
            }
            
            return charArray.First().ToString();
        }
    }
    
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Examples()
        {
            Assert.AreEqual("l", Kata.Triangle("codewars"));
            Assert.AreEqual("d", Kata.Triangle("triangle"));
            Assert.AreEqual("a", Kata.Triangle("youhavechosentotranslatethiskata"));
            Assert.AreEqual("b", Kata.Triangle("b"));
        }
    }
}