namespace LeetCodeProblems;

public class FirstUniqueChar
{
    public int Solution(string s)
    {
        List<char> bannedChars = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            bool found = false;
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    bannedChars.Add(s[i]);
                    found = true;
                    break;
                }
            }

            if (found == false && !bannedChars.Contains(s[i])) return i;
        }

        return -1;
    }
}