namespace LeetCodeProblems;

public class FirstUniqueChar
{
    public int Solution(string s)
    {
        int[] occurrences = new int[26];

        for (int i = 0; i < s.Length; i++) occurrences[s[i] - 'a']++;
        

        for (int i = 0; i < s.Length; i++)
            if (occurrences[s[i] - 'a'] == 1) return i;
       
        return -1;
    }
}