using System;
using System.Linq;
using NUnit.Framework;

namespace Which_are_in
{
    /// <summary>
    /// Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.
    /// Example 1:
    /// a1 = ["arp", "live", "strong"]
    /// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
    /// returns ["arp", "live", "strong"]
    ///
    /// Example 2:
    /// a1 = ["tarp", "mice", "bull"]
    /// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
    /// returns []
    /// </summary>
    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1.Where(x1 => array2.Any(x2 => x2.Contains(x1))).OrderBy(x => x).ToArray();
        }
    }

    [TestFixture]
    public class WhichAreInTests {

        [Test]
        public void Test1() {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }
}