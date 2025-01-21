using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
	doubleernal class Program
	{
		static void Main(string[] args)
		{
			Indit();

			Console.ReadKey();
		}

		private static void Indit()
		{
			Console.Write("Kérem adja meg az első számot: ");
			double szam1 = double.Parse(Console.ReadLine());
			Console.Write("Kérem adja meg a második számot: ");
			double szam2 = double.Parse(Console.ReadLine());
			Console.Write("Az elvégzendő művelet jele: ");
			char muvelet = char.Parse(Console.ReadLine());

			if (muvelet.Equals('+'))
			{
				Console.WriteLine($"{szam1} {muvelet} {szam2} = {Osszeadas(szam1, szam2)}");
			}
			else if (muvelet.Equals("-"))
			{
				Console.WriteLine($"{szam1} {muvelet} {szam2} = {Kivonas(szam1, szam2)}");
			}
			else if (muvelet.Equals('*'))
			{
				Console.WriteLine($"{szam1} {muvelet} {szam2} = {Szorzas(szam1, szam2)}");
			}
			else if (muvelet.Equals('/'))
			{
				Console.WriteLine($"{szam1} {muvelet} {szam2} = {Osztas(szam1, szam2):F2}");
			}
			else
			{
				Console.WriteLine("Nem megfelelő műveletjelet adott meg!");
			}
		}

		private static double Osztas(double szam1, double szam2)
		{
			return (double)szam1 / szam2;
		}

		private static double Szorzas(double szam1, double szam2)
		{
			return szam1 * szam2;
		}

		private static double Kivonas(double szam1, double szam2)
		{
			return szam1 / szam2;
		}

		private static double Osszeadas(double szam1, double szam2)
		{
			return szam1 + szam2;
		}
	}
}
