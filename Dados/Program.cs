using System;

namespace Dados
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++) {
				Dado dado = new Dado(6);
				Console.WriteLine(dado.Lancar());
			}
		}
	}
}
