namespace DataStructures.Arrays;

/// <summary>
/// P0001. Squares of a Sorted Array
/// <para>
/// Given an integer array nums sorted in non-decreasing order, 
/// return an array of the squares of each number sorted in non-decreasing order.
/// </para>
/// </summary>
public static class P0003_SquaresOfSortedArray
{
    public static int[] Solve(int[] nums)
    {
        int[] squared = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            squared[i] = nums[i] * nums[i];
        }

        Array.Sort(squared);

        return squared;
    }
}
