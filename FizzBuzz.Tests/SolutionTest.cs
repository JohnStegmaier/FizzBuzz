using System.Collections.Generic;
using FizzBuzz;
using JetBrains.Annotations;
using Xunit;

namespace FizzBuzz.Tests;

[TestSubject(typeof(Solution))]
public class SolutionTest
{

    [Fact]
    public void ShouldReturnFizzForNumberDivisibleByThree()
    {
        FizzBuzz.Solution solution = new();
        IList<string> expected = GenerateExpectedFizzBuzzListForInputThree();
        IList<string> actual = solution.FizzBuzz(3);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldReturnBuzzForNumberDivisibleByFive()
    {
        FizzBuzz.Solution solution = new();
        IList<string> expected = GenerateExpectedFizzBuzzListForInputFive();
        IList<string> actual = solution.FizzBuzz(5);
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
    
    private static IList<string> GenerateExpectedFizzBuzzListForInputFive()
    {
        IList<string> expected = new List<string>();
        expected.Add("1");
        expected.Add("2");
        expected.Add("Fizz");
        expected.Add("4");
        expected.Add("Buzz");
        return expected;
    }
}