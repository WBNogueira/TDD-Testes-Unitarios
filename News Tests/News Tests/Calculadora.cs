using System;
using System.Collections.Generic;
using System.Text;

namespace News_Tests
{
	public class Calculadora
	{
		private List<string> historicos;
		private string data;

		public Calculadora(string data)
        {
			historicos = new List<string>();
			this.data = data;
        }

		public int Somar(int val1, int val2)
		{
			int result = val1 + val2;

			historicos.Insert(0, "Result: " + result + " - data: " + data);

			return result;
		}

		public int Subtrair(int val1, int val2)
		{
			int result = val1 - val2;

			historicos.Insert(0, "Result: " + result + " - data: " + data);

			return result;
		}

		public int Multiplicar(int val1, int val2)
		{
			int result = val1 * val2;

			historicos.Insert(0, "Result: " + result + " - data: " + data);

			return result;
		}

		public int Dividir(int val1, int val2)
		{
			int result = val1 / val2;

			historicos.Insert(0, "Result: " + result + " - data: " + data);

			return result;
		}

		public List<string> Historico()
		{
			historicos.RemoveRange(3, historicos.Count - 3);

			return historicos;
		}
	}
}
