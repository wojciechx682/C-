using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB06_C_Sharp
{
    class Program
    {
        public static object ConsoleInput { get; private set; }
        public static double NaN { get; private set; }

        internal static class RectangularArrays
		{
			public static double[][] RectangularFloatArray(int size1, int size2)
			{
				double[][] newArray = new double[size1][];
				for (int array1 = 0; array1 < size1; array1++)
				{
					newArray[array1] = new double[size2];
				}

				return newArray;
			}
		}


		/*
		 W oparciu o macierz odwrotna

		 2 rownania, 3 niewiadome = jedno rownanie jest parametryczne, Parametr jest wartoscia n

	     mozna zrobic uklad rownan n x n (nizsza ocena)

	     Uklad rownan moze nie miec rozwiazan
		 nieskonczenie wiele rozwiazac
		

		4 rown, 3 niewiadome = uklad rownan sprzeczny

		// Rownania wczytujemy z pliku

		*/

		static void Main(string[] args)
        {
			int i, j, k;

			string file_path_1 = "macierz_1.csv";
			//string file_path_2 = "macierz_2.csv";

			string[] separators = { ",", ".", "!", "?", ";", ":", " ", };

			int count = 0;

			//string createText_1 = "1;1;1;1;10\n" +
			//						"1;2;3;4;30\n" +
			//						"0;1;0;1;6\n" +
			//						"0;2;3;1;17\n";

			string createText_1 =  "2;2;1;-1;6\n" +
									"0;3;1;2;-1\n" +
									"1;2;2;1;4\n" +
									"1;1;1;0;4\n";


			// UKŁAD SPRZECZNY:
			//string createText_1 = "1;2;3\n" +
			//					  "1;2;9\n";


			File.WriteAllText(file_path_1, createText_1);			

			string readText_file_1 = File.ReadAllText(file_path_1);
			
			
			string[] readText_1 = File.ReadAllLines(file_path_1);			

			foreach (string s in readText_1)
			{
				count++;
			}
			double[] array_1 = new double[count * (count+1)]; //4 x 5   rozmiar=20			

			k = 0;
			foreach (string s in readText_1)
			{
				string value = s;

				string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

				foreach (var word in words)
				{
					array_1[k] = double.Parse(word);
					k++;
				}
			}
	
			int n = count; 			

			k = 0;
			double[][] a = RectangularArrays.RectangularFloatArray(n, n + 1);
			double[] x = new double[n];			
			for (i = 0; i < n; i++)
			{
				for (j = 0; j <= n; j++)
				{					
					a[i][j] = array_1[k];
					k++;
				}
			}

			for (i = 0; i < n; i++)
			{
				for (k = i + 1; k < n; k++)
				{
					if (Math.Abs(a[i][i]) < Math.Abs(a[k][i]))
					{
						for (j = 0; j <= n; j++)
						{
							double temp = a[i][j];
							a[i][j] = a[k][j];
							a[k][j] = temp;
						}
					}
				}
			}		
			
			for (i = 0; i < n - 1; i++)
			{
				for (k = i + 1; k < n; k++)
				{
					double t = a[k][i] / a[i][i];
					for (j = 0; j <= n; j++)
					{
						a[k][j] = a[k][j] - t * a[i][j];
					}
				}
			}			
			
			for (i = n - 1; i >= 0; i--)
			{
				x[i] = a[i][n];
				for (j = i + 1; j < n; j++)
				{
					if (j != i)
					{
						x[i] = x[i] - a[i][j] * x[j];
					}
				}
				x[i] = x[i] / a[i][i];
			}

			Console.WriteLine("\nZawartość pliku macierz_1.csv:\n");
			Console.WriteLine(readText_file_1);

			Console.Write("{0,16:4}", "Wartosci zmiennych (niewiadomych x,y,z ...) w ukladzie rownan:\n\n");
			for (i = 0; i < n; i++)
			{				

				if (double.IsNaN(x[i]) == true)
				{
					Console.WriteLine("Uklad rownan ma nieskonczenie wiele rozwiazan \n");
					break;
				}
				else if (double.IsInfinity(x[i]))
				{
					Console.WriteLine("Uklad rownan jest sprzeczny\n");
					break;
				}
				else
				{
					for (i = 0; i < n; i++)
					{
						Console.Write("Zmienna nr." + (i + 1) + " = " + x[i] + "\n");
					}
					Console.WriteLine("\n");
				}
			}
		}
	}
}
