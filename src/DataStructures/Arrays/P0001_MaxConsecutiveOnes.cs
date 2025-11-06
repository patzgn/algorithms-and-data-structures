namespace DataStructures.Arrays;

/// <summary>
/// 0001. Max Consecutive Ones
/// <para>
/// Given a binary array nums, return the maximum number of consecutive 1's in the array.
/// <para>
/// </summary>
public static class P0001_MaxConsecutiveOnes
{
    public static int Solve(int[] nums)
    {
        int result = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                count = 0;
            }
            else
            {
                count++;
                if (result < count)
                {
                    result = count;
                }
            }
        }

        return result;
    }
}
