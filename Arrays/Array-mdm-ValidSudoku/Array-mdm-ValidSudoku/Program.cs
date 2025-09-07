using System.Collections;

namespace Array_mdm_ValidSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[][] board = new char[][]
            {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','5','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };
            bool result = solution.IsValidSudoku(board);
            Console.WriteLine(result);  
        }
    }

    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            int n = board.Length;
            List<HashSet<char>> rows = Enumerable.Range(0, 9)
                                     .Select(_ => new HashSet<char>())
                                     .ToList();

            List<HashSet<char>> columns = Enumerable.Range(0, 9)
                                     .Select(_ => new HashSet<char>())
                                     .ToList();

            List<HashSet<char>> squares = Enumerable.Range(0, 9)
                                      .Select(_ => new HashSet<char>())
                                      .ToList();

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    if (board[row][column] == '.')
                    {
                        continue;   // Skip empty cells
                    }

                    if (rows[row].Contains(board[row][column]))
                    {
                        return false;       // Duplicate in row
                    }
                    rows[row].Add(board[row][column]);

                    if(columns[column].Contains(board[row][column]))
                    {
                        return false;       // Duplicate in column
                    }
                    columns[column].Add(board[row][column]);

                    int squareIndex = (row / 3) * 3 + (column / 3);
                    if (squares[squareIndex].Contains(board[row][column]))
                    {
                        return false;       // Duplicate in square
                    }
                    squares[squareIndex].Add(board[row][column]);
                }
            }
            return true;
        }
    }

}
