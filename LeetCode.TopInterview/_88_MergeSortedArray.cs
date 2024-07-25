namespace LeetCode.TopInterview;

[TestFixture]
public class _88_MergeSortedArray
{
    [Test]
    [TestCase(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [TestCase(new[] { 4, 0, 0, 0, 0, 0 }, 1, new[] { 1, 2, 3, 5, 6 }, 5, new[] { 1, 2, 3, 4, 5, 6 })]
    [TestCase(new[] { 4, 6, 0, 0, 0, 0, 0 }, 2, new[] { 1, 2, 3, 5, 6 }, 5, new[] { 1, 2, 3, 4, 5, 6, 6 })]
    [TestCase(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [TestCase(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        Solution solution = new();

        solution.Merge(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(expected));
    }
}

public partial class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] mergedArray = new int[m + n];
        int i = 0;
        int j = 0;
        int mergedIndex = 0;

        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            {
                mergedArray[mergedIndex] = nums1[i];
                i++;
            }
            else
            {
                mergedArray[mergedIndex] = nums2[j];
                j++;
            }

            mergedIndex++;
        }

        while (i < m)
        {
            mergedArray[mergedIndex] = nums1[i];
            i++;
            mergedIndex++;
        }

        while (j < n)
        {
            mergedArray[mergedIndex] = nums2[j];
            j++;
            mergedIndex++;
        }

        Array.Copy(mergedArray, nums1, m + n);
    }
}