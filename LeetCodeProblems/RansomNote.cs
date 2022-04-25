namespace LeetCodeProblems;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] occurrences = new int[26];

        for (int i = 0; i < magazine.Length; i++)
        {
            occurrences[magazine[i] - 'a']++;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (occurrences[ransomNote[i] - 'a']-- < 1)
            {
                return false;
            }
        }

        return true;
    }
}