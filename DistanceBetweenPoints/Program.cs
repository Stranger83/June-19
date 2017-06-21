using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = ReadPoints();
			Point p2 = ReadPoints();

			double distance = CalculateDistance(p1, p2);

			Console.WriteLine($"{distance:f3}");

		}

		private static double CalculateDistance(Point p1, Point p2)
		{
			int deltaX = p1.X - p2.X;
			int deltaY = p1.Y - p2.Y;
			double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			return distance;
		}

		private static Point ReadPoints()
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Point point = new Point();
			point.X = input[0];
			point.Y = input[1];
			return point;
		}
	}
}
