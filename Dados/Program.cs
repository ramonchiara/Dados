using System;

namespace Dados
{
	class Program
	{
		public static void Main(string[] args)
		{
			Dado dado1 = new Dado(6);
			Dado dado2 = new Dado(6);

			for (int i = 0; i < 10; i++) {
				Console.WriteLine("{0} {1}", dado1.Lancar(), dado2.Lancar());
			}
		}
	}
}
