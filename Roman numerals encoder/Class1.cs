using NUnit.Framework;
using System.Linq;

namespace Roman_numerals_encoder;

/// <summary>
/// https://www.codewars.com/kata/51b62bf6a9c58071c600001b/
/// </summary>
public class RomanConvert
{
    public static string Solution(int n)
    {
        char[] numerals = {'0', 'I', 'V', 'X', 'L', 'C', 'D', 'M'};

        string solution = "";

        int[] numbers = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
        int numberSize = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            int numeralIndex = (numberSize - i) + ((numberSize - i) - 1);
            char numeral;
            switch (number)
            {
                case <= 3:
                {
                    numeral = numerals[numeralIndex];
                    for (int j = 0; j < number; j++)
                    {
                        solution += numeral;
                    }
                    break;
                }
                case 4:
                    solution += $"{numerals[numeralIndex]}{numerals[numeralIndex + 1]}";
                    break;
                case 5:
                    solution += numerals[numeralIndex + 1];
                    break;
                case <= 8:
                    numeral = numerals[numeralIndex];
                    solution += numerals[numeralIndex + 1];
                    for (int j = 0; j < number - 5; j++)
                    {
                        solution += numeral;
                    }
                    break;
                case 9:
                    solution += $"{numerals[numeralIndex]}{numerals[numeralIndex + 2]}";
                    break;
            }
        }

        return solution;
    }
}

[TestFixture]
public class RomanConvertTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    public void Test(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }
}