namespace FizzBuzz;

public class Solution
{
    private List<string> returnValue = new List<string>();
    public IList<string> FizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (isDivisiableByThree(i) && isDivisiableByFive(i))
            {
                returnValue.Add("FizzBuzz");
            }
            else if (isDivisiableByThree(i))
            {
                returnValue.Add("Fizz");
            }
            else if (isDivisiableByFive(i))
            {
                returnValue.Add("Buzz");
            }
            else
            {
                returnValue.Add(i.ToString());
            }
        }
        return returnValue;
    }

    private bool isDivisiableByThree(int input)
    {
        if (input % 3 == 0)
        {
            return true;
        }
        return false;
    }
    
    private bool isDivisiableByFive(int input)
    {
        if (input % 5 == 0)
        {
            return true;
        }
        return false;
    }
}