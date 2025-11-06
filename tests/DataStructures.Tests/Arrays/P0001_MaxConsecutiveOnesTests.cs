using DataStructures.Arrays;

namespace DataStructures.Tests.Arrays;

public class P0001_MaxConsecutiveOnesTests
{
    [Fact]
    public void Test01()
    {
        // Arrange
        int[] nums = [1, 1, 0, 1, 1, 1];

        // Act
        var actual = P0001_MaxConsecutiveOnes.Solve(nums);

        // Assert
        Assert.Equal(3, actual);
    }

    [Fact]
    public void Test02()
    {
        // Arrange
        int[] nums = [1, 1, 1, 0, 1, 1];

        // Act
        var actual = P0001_MaxConsecutiveOnes.Solve(nums);

        // Assert
        Assert.Equal(3, actual);
    }
}
