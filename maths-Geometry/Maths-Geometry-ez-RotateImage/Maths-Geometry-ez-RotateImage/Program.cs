namespace Maths_Geometry_ez_RotateImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] matrix = [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            ];

            s.Rotate(matrix);

            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }

    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i= 0; i < (n+1)/2; i++)
            {
                for(int j = i; j < n - i - 1; j++)
                {
                    // save the top left position
                    int temp = matrix[i][j];
                    // move bottom left to top left
                    matrix[i][j] = matrix[n - j - 1][i];
                    // move bottom right to bottom left
                    matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                    // move top right to bottom right
                    matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                    // move top left to top right
                    matrix[j][n - i - 1] = temp;
                }
            }
        }
    }

}
