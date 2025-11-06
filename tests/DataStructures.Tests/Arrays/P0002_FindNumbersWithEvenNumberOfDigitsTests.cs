using System;
using DataStructures.Arrays;

namespace DataStructures.Tests.Arrays;

public class P0002_FindNumbersWithEvenNumberOfDigitsTests
{
    [Fact]
    public void Test_01()
    {
        // Arrange
        int[] nums = [12, 345, 2, 6, 7896];

        // Act
        var actual = P0002_FindNumbersWithEvenNumberOfDigits.Solve(nums);

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void Test_02()
    {
        // Arrange
        int[] nums = [555, 901, 482, 1771];

        // Act
        var actual = P0002_FindNumbersWithEvenNumberOfDigits.Solve(nums);

        // Assert
        Assert.Equal(1, actual);
    }
}
