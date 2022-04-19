namespace LeetCodeProblems;


// https://leetcode.com/problems/merge-sorted-array
public class MergeSortedArray
{
    public void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        int[] finalAr = new int[m + n];
        int finalCount = 0;
        int j = 0;
        int i = 0;
        if (m == 0)
        {
            Array.Copy(nums2, nums1, n);
            return;
        }
        if (n == 0) return;

        while (finalCount < m + n)
        {
            if ((nums1[i] == 0 && i >= m) || (j<n && nums2[j] < nums1[i]))
            {
                finalAr[finalCount] = nums2[j];
                j++;
                finalCount++;
            }
            else
            {
                finalAr[finalCount] = nums1[i];
                i++;
                finalCount++;
            }
        }

        Array.Copy(finalAr, nums1, m + n);

        foreach (int el in nums1)
        {
            Console.WriteLine(el);
        }
    }
}