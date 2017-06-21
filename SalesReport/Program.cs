using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
	class Sale
	{
		public string Town { get; set; }
		public string Product { get; set; }
		public decimal Price { get; set; }
		public decimal Quantity { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			var sales = ReadSales();
			var totalSalesByCity = CalculateTotalSalesByCity(sales);
			PrintTotalSales(totalSalesByCity);

		}

		private static void PrintTotalSales(List<Sale> totalSalesByCity)
		{
			foreach (var s in totalSalesByCity)
			{
				Console.WriteLine($"{s.Town} -> {s.Price:f2}");
			}
		}

		private static List<Sale> CalculateTotalSalesByCity(Sale[] sales)
		{
			SortedDictionary<string, decimal> salesByCity = new SortedDictionary<string, decimal>();
			foreach (var s in sales)
			{
				if (!salesByCity.ContainsKey(s.Town))
				{
					salesByCity[s.Town] = 0;
				}
				salesByCity[s.Town] += s.Quantity * s.Price;
			}
			var salesList = salesByCity.Select(s => new Sale() { Town = s.Key, Price = s.Value }).ToList();
			return salesList;
		}

		private static Sale[] ReadSales()
		{
			int n = int.Parse(Console.ReadLine());
			Sale[] sales = new Sale[n];
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				Sale s = new Sale();
				s.Town = input[0];
				s.Product = input[1];
				s.Price = decimal.Parse(input[2]);
				s.Quantity = decimal.Parse(input[3]);
				sales[i] = s;				
			}
			return sales;
		}
	}
}
