using DataStructures.Arrays;

namespace DataStructures.Tests.Arrays;

public class P0003_SquaresOfSortedArrayTests
{
    [Fact]
    public void Test_01()
    {
        // Arrange
        int[] nums = [-7, -3, 2, 3, 11];

        // Act
        var actual = P0003_SquaresOfSortedArray.Solve(nums);

        // Assert
        Assert.Equal([4, 9, 9, 49, 121], actual);
    }

    [Fact]
    public void Test_02()
    {
        // Arrange
        int[] nums = [-4, -1, 0, 3, 10];

        // Act
        var actual = P0003_SquaresOfSortedArray.Solve(nums);

        // Assert
        Assert.Equal([0, 1, 9, 16, 100], actual);
    }
}
