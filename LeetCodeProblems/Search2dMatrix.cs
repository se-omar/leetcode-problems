namespace LeetCodeProblems;

public class Search2dMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int low = 0;
        int high = rows * cols - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int x = mid / cols;
            int y = mid % cols;
            if (matrix[x][y] == target) return true;
            if (matrix[x][y] < target) low = mid + 1;
            else high = mid - 1;
        }

        return false;
    }
}