namespace LeetCodeProblems;

public class MatrixReshape
{
    public int[][] MatrixReshape1(int[][] mat, int r, int c)
    {
        int matRow = mat.Length;
        int matCol = mat[0].Length;
        if (r * c != matRow * matCol) return mat;
        
        int[][] finalMat = new int[r][];
        for(int k = 0; k < r; k++) 
        {
            finalMat[k] = new int[c];
        }
        
        int x = 0;
        int y = 0;
        for(int i = 0; i < matRow; i++)
        {
            for(int j = 0; j < matCol; j++)
            {
                if (y >= c)
                {
                    y = 0;
                    x++;
                }
                if(x < r && y < c) finalMat[x][y++] = mat[i][j];
            }
        }

        return finalMat;
    }
}