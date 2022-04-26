namespace LeetCodeProblems;

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        int[] occurrences = new int[26];
        
        for (int i = 0; i < s.Length; i++)
        {
            occurrences[s[i] - 'a']++;
        }
        
        for (int i = 0; i < t.Length; i++)
        {
            occurrences[t[i] - 'a']--;
        }

        
        for (int i = 0; i < occurrences.Length; i++)
        {
            if (occurrences[i] != 0) return false;
        }

        return true;
    }
}