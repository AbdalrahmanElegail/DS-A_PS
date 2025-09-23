using System.Drawing;

namespace maths_Geometry_DetectSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountSquares countSquares = new CountSquares();
            int[] point1 = { 1, 2};
            int[] point2 = { 1, 2};
            int[] point3 = { 1, 3};
            int[] point4 = { 3, 1};

            countSquares.Add(point1);
            countSquares.Add(point2);
            countSquares.Add(point3);

            int count = countSquares.Count(point4);
            Console.WriteLine(count);
        }
    }
    public class CountSquares
    {
        private Dictionary<(int,int), int> _points = new();
        public CountSquares()
        {
            _points = new();
        }

        public void Add(int[] point)
        {
            if (_points.ContainsKey((point[0], point[1])))
                _points[(point[0], point[1])]++;
            else
                _points[(point[0], point[1])] = 1;
        }

        public int Count(int[] point)
        {
            int count = 0;
            (int, int) checkPoint = (point[0], point[1]);

            foreach (var pointPair in _points)
            {

            }
            return count;
        }
    }

}
