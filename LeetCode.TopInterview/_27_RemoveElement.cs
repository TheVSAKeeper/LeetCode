namespace LeetCode.TopInterview;

[TestFixture]
public class _27_RemoveElement
{
    [Test]
    [TestCase(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 })]
    [TestCase(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 0, 1, 3, 4 })]
    [TestCase(new[] { 1 }, 1, new int[] { })]
    [TestCase(new int[] { }, 0, new int[] { })]
    [TestCase(new[] { 2 }, 3, new[] { 2 })]
    [TestCase(new[] { 4, 5 }, 5, new[] { 4 })]
    public void RemoveElementTest(int[] nums, int val, int[] expectedNums)
    {
        Solution solution = new();

        int k = solution.RemoveElement(nums, val);
        Array.Sort(nums, 0, k);

        Assert.Multiple(() =>
        {
            Assert.That(k, Is.EqualTo(expectedNums.Length));
            Assert.That(nums[..expectedNums.Length], Is.EqualTo(expectedNums).AsCollection);
        });
    }
}

public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0;
        int j = nums.Length - 1;

        while (j >= i)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[j];
                j--;
            }
            else
            {
                i++;
            }
        }

        return j + 1;
    }
}