namespace LeetCodeProblems;

public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        Array.Sort(nums);
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1]) return true;
        }
        return false;
    }
}