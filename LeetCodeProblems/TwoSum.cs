namespace LeetCodeProblems;

//https://leetcode.com/problems/two-sum

public class TwoSum
{
    public int[] Solution(int[] nums, int target)
    {
        int[] sol = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    sol[0] = i;
                    sol[1] = j;
                    return sol;
                }
            }
        }

        return sol;
    }
}