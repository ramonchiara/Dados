using System;

namespace Dados
{
	public class Dado
	{
		private int lados;
		private static Random rng = new Random();

		public Dado(int lados)
		{
			this.lados = lados;
		}

		public int Lancar()
		{
			return rng.Next(1, lados + 1);
		}
	}
}
