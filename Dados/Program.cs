using System;

namespace Dados
{
	class Program
	{
		public static void Main(string[] args)
		{
			Dado dado = new Dado(6);

			for (int i = 0; i < 10; i++) {
				Console.WriteLine(dado.Lancar());
			}
		}
	}
}
