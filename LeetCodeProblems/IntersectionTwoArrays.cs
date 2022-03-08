namespace LeetCodeProblems;

// https://leetcode.com/problems/intersection-of-two-arrays-ii/

public class IntersectionTwoArrays
{
    public int[] Solution(int[] nums1, int[] nums2)
    {
        List<int> finalAr = new();
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    finalAr.Add(nums1[i]);
                    nums2[j] = -1;
                    break;
                }
            }
        }

        return finalAr.ToArray();
    }
}