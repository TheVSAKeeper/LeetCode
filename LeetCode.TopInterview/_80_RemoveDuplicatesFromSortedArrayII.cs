namespace LeetCode.TopInterview;

[TestFixture]
public class _80_RemoveDuplicatesFromSortedArrayII
{
    [Test]
    [TestCase(new[] { 1, 1, 1, 2, 2, 3 }, new[] { 1, 1, 2, 2, 3 })]
    [TestCase(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new[] { 0, 0, 1, 1, 2, 3, 3 })]
    [TestCase(new[] { 3, 3, 3, 3, 3 }, new[] { 3, 3 })]
    [TestCase(new int[] { }, new int[] { })]
    [TestCase(new[] { 2, 2 }, new[] { 2, 2 })]
    public void RemoveDuplicatesTest(int[] nums, int[] expectedNums)
    {
        Solution solution = new();

        int k = solution.RemoveDuplicatesTwice(nums);

        Assert.Multiple(() =>
        {
            Assert.That(k, Is.EqualTo(expectedNums.Length));
            Assert.That(nums[..expectedNums.Length], Is.EqualTo(expectedNums).AsCollection);
        });
    }
}

public partial class Solution
{
    public int RemoveDuplicatesTwice(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        int i = 2;
        int j = 2;

        while (j < nums.Length)
        {
            if (nums[i - 2] != nums[j])
            {
                nums[i] = nums[j];
                i++;
            }

            j++;
        }

        return i;
    }
}