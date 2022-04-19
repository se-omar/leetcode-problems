namespace LeetCodeProblems;

//https://leetcode.com/problems/maximum-subarray

public class MaximumSubarray
{
    public int Solution(int[] nums)
    {
        int maxSum = -10000;
        int currentSum = 0;
        foreach (int num in nums)
        {
            currentSum += num;
            if (currentSum < num) currentSum = num;
            if (maxSum < currentSum) maxSum = currentSum;
        }
int[] arr = new int[2];
        return maxSum;
    }
}