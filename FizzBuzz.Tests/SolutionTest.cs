using System.Collections.Generic;
using FizzBuzz;
using JetBrains.Annotations;
using Xunit;

namespace FizzBuzz.Tests;

[TestSubject(typeof(Solution))]
public class SolutionTest
{

    [Fact]
    public void METHOD()
    {
        FizzBuzz.Solution solution = new();
        var expected = GenerateExpectedFizzBuzzListForInputThree();
        IList<string> actual = solution.FizzBuzz(3);
        Assert.Equal(expected, actual);
    }

    private static IList<string> GenerateExpectedFizzBuzzListForInputThree()
    {
        IList<string> expected = new List<string>();
        expected.Add("1");
        expected.Add("2");
        expected.Add("Fizz");
        return expected;
    }
}