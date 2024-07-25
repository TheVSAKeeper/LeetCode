namespace LeetCode.TopInterview;

[TestFixture]
public class _26_RemoveDuplicatesFromSortedArray
{
    [Test]
    [TestCase(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [TestCase(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4 })]
    [TestCase(new[] { 3, 3, 3, 3, 3 }, new[] { 3 })]
    public void RemoveDuplicatesTest(int[] nums, int[] expectedNums)
    {
        Solution solution = new();

        int k = solution.RemoveDuplicates(nums);

        Assert.Multiple(() =>
        {
            Assert.That(k, Is.EqualTo(expectedNums.Length));
            Assert.That(nums[..expectedNums.Length], Is.EqualTo(expectedNums).AsCollection);
        });
    }
}

public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        int j = 1;

        while (j < nums.Length)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }

            j++;
        }

        return i + 1;
    }
}