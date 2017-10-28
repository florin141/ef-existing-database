using AwDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateDatabase();
		}

		private static void CreateDatabase()
		{
			var context = new AdventureWorksLt2008R2Context();
			//context.Database.Initialize(true);
			var products = context.Products.Take(25).ToList();
			foreach (Product p in products)
			{
				Console.WriteLine(p.Name);
			}
		}
	}
}
