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
			Console.Write("Kérem adja meg az első számot: ");
			int szam1 = int.Parse(Console.ReadLine());
			Console.Write("Kérem adja meg a második számot: ");
			int szam2 = int.Parse(Console.ReadLine());
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


			Console.ReadKey();
		}

		private static double Osztas(int szam1, int szam2)
		{
			return (double)szam1 / szam2;
		}

		private static int Szorzas(int szam1, int szam2)
		{
			return szam1 * szam2;
		}

		private static int Kivonas(int szam1, int szam2)
		{
			return szam1 / szam2;
		}

		private static int Osszeadas(int szam1, int szam2)
		{
			return szam1 + szam2;
		}
	}
}
