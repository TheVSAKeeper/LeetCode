namespace LeetCode.TopInterview;

[TestFixture]
public class _169_MajorityElement
{
    [Test]
    [TestCase(new[] { 3, 2, 3 }, 3)]
    [TestCase(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    [TestCase(new[] { 1, 3, 1, 1, 4, 1, 1, 5, 1, 1, 6, 2, 2 }, 1)]
    public void RemoveElementTest(int[] nums, int major)
    {
        Solution solution = new();

        int k = solution.MajorityElement(nums);

        Assert.That(k, Is.EqualTo(major));
    }
}

public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else
            {
                if (candidate == num)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }

        return candidate;
    }
}