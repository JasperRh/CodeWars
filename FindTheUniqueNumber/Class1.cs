namespace FindTheUniqueNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/585d7d5adb20cf33cb000235
/// </summary>
public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var numberLookup = numbers.ToLookup(x => x);
        return numberLookup.Single(group => group.Count() == 1).First();
    }
    
}

[TestFixture]
public class SolutionTest
{
    [TestCase(new [] {1, 2, 2, 2}, ExpectedResult = 1)]
    [TestCase(new [] {-2, 2, 2, 2}, ExpectedResult = -2)]
    [TestCase(new [] {11, 11, 14, 11, 11}, ExpectedResult = 14)]
    public int BaseTest(IEnumerable<int> numbers)
    {
        return Kata.GetUnique(numbers);
    }
}
