using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
	internal class Program
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
				kiir(szam1, szam2, muvelet, Osszeadas);
			}
			else if (muvelet.Equals("-"))
			{
				kiir(szam1, szam2, muvelet, Kivonas);
			}
			else if (muvelet.Equals('*'))
			{
				kiir(szam1, szam2, muvelet, Szorzas);
			}
			else if (muvelet.Equals('/'))
			{
				kiir(szam1, szam2, muvelet, Osztas);
			}
			else if (muvelet.Equals('%'))
			{
				kiir(szam1, szam2, muvelet, Szazalek);
			}
			else
			{
				Console.WriteLine("Nem megfelelő műveletjelet adott meg!");
			}
		}
		static void kiir(double szam1, double szam2, char muvelet, Func<double, double, double> metodus)
		{
			Console.WriteLine($"{szam1} {muvelet} {szam2} = {metodus(szam1, szam2)}");
		}
		private static double Szazalek(double szam1, double szam2)
		{
			return (szam1 / szam2) * 100;
		}

		private static double Osztas(double szam1, double szam2)
		{
			return szam1 / szam2;
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
