using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindClosestTwoPoints
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
			Point[] points = ReadPoints();
			Point[] closestPoints = CalculateTwoClosestPoints(points);

			PrintDistance(closestPoints);
			PrintPoint(closestPoints[0]);
			PrintPoint(closestPoints[1]);
		}

		private static void PrintDistance(Point[] closestPoints)
		{
			double distance = CalculateDistance(closestPoints[0], closestPoints[1]);
			Console.WriteLine($"{distance:f3}");
		}

		private static double CalculateDistance(Point p1, Point p2)
		{
			int deltaX = p1.X - p2.X;
			int deltaY = p1.Y - p2.Y;
			double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			return distance;
		}

		private static void PrintPoint(Point point)
		{
			Console.WriteLine($"({point.X}, {point.Y})");
		}

		private static Point[] CalculateTwoClosestPoints(Point[] points)
		{
			double minDistance = double.MaxValue;
			Point[] closestPoints = null;
			for (int p1 = 0; p1 < points.Length; p1++)
			{
				for (int p2 = p1 + 1; p2 < points.Length; p2++)
				{
					double distance = CalculateDistance(points[p1], points[p2]);
					if (distance < minDistance)
					{
						minDistance = distance;
						closestPoints = new Point[] { points[p1], points[p2] };
					}
				}

			}
			return closestPoints;
		}

		private static Point[] ReadPoints()
		{
			int n = int.Parse(Console.ReadLine());
			Point[] points = new Point[n];
			for (int i = 0; i < n; i++)
			{
				int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				Point p = new Point();
				p.X = input[0];
				p.Y = input[1];
				points[i] = p; 
			}
			return points;
		}
	}
}
