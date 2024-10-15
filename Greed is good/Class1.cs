using NUnit.Framework;

namespace Greed_is_good;

/// <summary>
/// https://www.codewars.com/kata/5270d0d18625160ada0000e4/train/csharp
/// </summary>
public static class Kata
{
    public static int Score(int[] dice)
    {
        var numbers = new List<int>(dice);
        var score = 0;
        var triplet = dice.FirstOrDefault(number => dice.Count(x => x == number) >= 3);
        if (triplet > 0)
        {
            if (triplet == 1)
            {
                score += 1000;
            }
            else
            {
                score += (triplet * 100);
            }

            for (var i = 0; i < 3; i++)
            {
                numbers.Remove(triplet);
            }
        }

        var oneCount = numbers.Count(number => number == 1);
        var fiveCount = numbers.Count(number => number == 5);

        score += (oneCount * 100);
        score += (fiveCount * 50);

        return score;
    }
}

public static class ScoreChecker
{
    [Test]
    public static void ShouldBeWorthless()
    {
        Assert.AreEqual(0, Kata.Score(new int[] {2, 3, 4, 6, 2}));
    }
  
    [Test]
    public static void ShouldValueTriplets()
    {
        Assert.AreEqual(400, Kata.Score(new int[] {4, 4, 4, 3, 3}));
    }
  
    [Test]
    public static void ShouldValueMixedSets()
    {
        Assert.AreEqual(450, Kata.Score(new int[] {2, 4, 4, 5, 4}));
    }
}