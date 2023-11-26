

using System.Globalization;

namespace practicals
{
	 class Program
	{
		static void Multi(int i )
		{
			
			
			for (i = 1; i < 7; i++ )
			{
				for (int j = 1; j <= 12; j++)
					
					Console.WriteLine($" {i} * {j} = {i * j} ");
				
			}
			
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Multi(4);


		}
	}
}