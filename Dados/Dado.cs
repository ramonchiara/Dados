using System;

namespace Dados
{
	public class Dado
	{
		private int lados;

		public Dado(int lados)
		{
			this.lados = lados;
		}

		public int Lancar()
		{
			Random rng = new Random();
			return rng.Next(1, lados + 1);
		}
	}
}
