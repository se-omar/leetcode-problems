// See https://aka.ms/new-console-template for more information

using LeetCodeProblems;

Console.WriteLine("Hello, World!");
int[][] matrix = new int[3][];
matrix[0] = new int[] {1, 3, 5, 7};
matrix[1] = new int[] {10, 11, 16, 20};
matrix[2] = new int[] {23, 30, 34, 60};

Search2dMatrix search2dMatrix = new();
search2dMatrix.SearchMatrix(matrix, 3);