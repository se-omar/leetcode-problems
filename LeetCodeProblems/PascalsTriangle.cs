namespace LeetCodeProblems;

public class PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> row = new List<int>();

        for (int i = 0; i < numRows; i++)
        {
            row.Insert(0, 1);
            for (int j = 1; j < i; j++)
            {
                row[j] += row[j+1];
            }
            result.Add(new List<int>(row));
        }

        return result;
    }
}