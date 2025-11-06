namespace DataStructures.Arrays;

/// <summary>
/// P0002. Find Numbers with Even Number of Digits
/// <para>
/// Given an array nums of integers, return how many of them contain an even number of digits.
/// </para>
/// </summary>
public static class P0002_FindNumbersWithEvenNumberOfDigits
{
    public static int Solve(int[] nums)
    {
        int result = 0;

        foreach (int number in nums)
        {
            int numOfDigits = number.ToString().Length;

            if (numOfDigits % 2 == 0)
            {
                result++;
            }
        }

        return result;
    }
}
