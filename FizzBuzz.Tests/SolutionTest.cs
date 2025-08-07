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
    
    [Fact]
    public void ShouldReturnFizzBuzzForNumberDivisibleByThreeAndFive()
    {
        FizzBuzz.Solution solution = new();
        IList<string> expected = GenerateExpectedFizzBuzzListForInputFifteen();
        IList<string> actual = solution.FizzBuzz(15);
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
        IList<string> expected = GenerateExpectedFizzBuzzListForInputThree();
        expected.Add("4");
        expected.Add("Buzz");
        return expected;
    }
    
    private static IList<string> GenerateExpectedFizzBuzzListForInputFifteen()
    {
        IList<string> expected = GenerateExpectedFizzBuzzListForInputFive();
        expected.Add("Fizz");
        expected.Add("7");
        expected.Add("8");
        expected.Add("Fizz");
        expected.Add("Buzz");
        expected.Add("11");
        expected.Add("Fizz");
        expected.Add("13");
        expected.Add("14");
        expected.Add("FizzBuzz");
        return expected;
    }
}