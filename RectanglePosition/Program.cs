using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
	class Rectangle
	{
		public int Top { get; set; }
		public int Left { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public int Bottom { get	{ return Top + Height;}	}
		public int Right { get	{ return Left + Width;} }


		public int CalcArea()
		{
			return Width * Height;
		}
		public bool IsInside(Rectangle other)
		{
			var isInLeft = Left >= other.Left;
			var isInRight = Right <= other.Right;
			var isInsideHorizontal = isInLeft && isInRight;
			var isInTop = Top <= other.Top;
			var isInBottom = Bottom <= other.Bottom;
			var isInsideVertical = isInTop && isInBottom;
			return isInsideHorizontal && isInsideVertical;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r1 = ReadRectangle();
			Rectangle r2 = ReadRectangle();
			Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
		}

		private static Rectangle ReadRectangle()
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Rectangle r = new Rectangle
			{
				Top = input[1],
				Left = input[0],
				Width = input[2],
				Height = input[3]
			};
			return r;
		}
	}
}
