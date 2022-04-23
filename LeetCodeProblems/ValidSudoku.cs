namespace LeetCodeProblems;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        int rowNum = board.Length;
        int colNum = board[0].Length;
        HashSet<char> rows = new HashSet<char>();
        HashSet<char> cols = new HashSet<char>();
        HashSet<char> box = new HashSet<char>();
        //check rows
        for (int i = 0; i < rowNum; i++)
        {
            rows.Clear();
            cols.Clear();
            box.Clear();
            for (int j = 0; j < colNum; j++)
            {
                if (board[i][j] != '.' && !rows.Add(board[i][j])) return false;
                if (board[j][i] != '.' && !cols.Add(board[j][i])) return false;

                int rowIndex = 3 * (i / 3);
                int colIndex = 3 * (i % 3);
                if (board[rowIndex + j / 3][colIndex + j % 3] != '.' &&
                    !box.Add(board[rowIndex + j / 3][colIndex + j % 3])) return false;
            }
        }

        return true;
    }
}