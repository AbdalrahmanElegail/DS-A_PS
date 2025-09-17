namespace Maths_Geometry_mdm_SpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] matrix = [[2, 5, 8], [4, 0, -1]];
            List<int> result = solution.SpiralOrder(matrix);
            Console.WriteLine(string.Join(", ", result));
        }
    }
    public class Solution
    {
        public List<int> SpiralOrder(int[][] matrix)
        {
            int circles = (Math.Min(matrix.Length, matrix[0].Length)+1) / 2;
            int n = matrix.Length;
            int m = matrix[0].Length;
            List<int> result = new List<int>();
            for(int c = 0; c < circles; c++)
            {
                //get top line
                for (int j=c; j<m-c; j++)
                {
                    result.Add(matrix[c][j]);
                }
                //get right line
                for (int i=c+1; i<n-c; i++)
                {
                    result.Add(matrix[i][m-1-c]);
                }
                //get bottom line
                if (n-1-c != c)
                {
                    for (int j=m-2-c; j>=c; j--)
                    {
                        result.Add(matrix[n-1-c][j]);
                    }
                }
                //get left line
                if (m-1-c!= c)
                {
                    for (int i=n-2-c; i>c; i--)
                    {
                        result.Add(matrix[i][c]);
                    } 
                }
            }
            return result;
        }
    }
}