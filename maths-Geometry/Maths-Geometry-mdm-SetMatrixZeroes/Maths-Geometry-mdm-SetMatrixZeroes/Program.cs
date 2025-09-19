namespace Maths_Geometry_mdm_SetMatrixZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] matrix = [[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]];
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    Console.Write(matrix[r][c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
            solution.SetZeroes(matrix);

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    Console.Write(matrix[r][c] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    public class Solution
    {
        //    Time: o(n*m)    Space: o(1)  
        public void SetZeroes(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            bool firstRowContainsZero = false;
            bool firstColContainsZero = false;

            for (int r = 0; r < n; r++)
            {
                if (matrix[r][0] == 0) firstColContainsZero = true;
            }
            for (int c = 0; c < m; c++)
            {
                if (matrix[0][c] == 0) firstRowContainsZero = true;
            }

            
            for (int r = 1; r < n; r++)
            {
                for (int c = 1; c < m; c++)
                {
                    if (matrix[r][c] == 0)
                    {
                        matrix[0][c] = 0;
                        matrix[r][0] = 0;
                    }
                }
            }
            for (int r = 1; r < n; r++)
            {
                for (int c = 1; c < m; c++)
                {
                    if (matrix[0][c] == 0 || matrix[r][0] == 0)
                    {
                        matrix[r][c] = 0;
                    }
                }
            }

            for (int r = 0; r < n; r++)
            {
                if (firstColContainsZero) matrix[r][0] = 0;
            }
            for (int c = 0; c < m; c++)
            {
                if (firstRowContainsZero) matrix[0][c] = 0;
            }
        }



        ////    Time: o(n*m)    Space: o(n+m)  
        //public void SetZeroes(int[][] matrix)
        //{
        //    int n = matrix.Length;
        //    int m = matrix[0].Length;
        //    bool[] rowFlags = new bool[n];
        //    bool[] colFlags = new bool[m];

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            if (matrix[i][j] == 0)
        //            {
        //                rowFlags[i] = true;
        //                colFlags[j] = true;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            if (rowFlags[i] || colFlags[j])
        //                matrix[i][j] = 0;
        //        }
        //    }
        //}
    }
}
