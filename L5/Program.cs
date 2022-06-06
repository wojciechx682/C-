using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Reflection.Emit;
using System.Collections.Specialized;

namespace L5_C_Sharp
{
	class Program
	{    
        static void print_matrix(float[][] array, int n, int m)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(array[i][j]);
					Console.Write("  ");
				}
				Console.Write("\n");
			}			
			return;
		}
		static void print_matrix_inverse(float[][] array, int n, int m)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = n; j < m; j++)
				{					
					Console.Write("{0:f3}   ", array[i][j]);										
				}
				Console.Write("\n");				
			}			
		}

		static void inverse_of_matrix(float[][] matrix, int size)
		{
			float temp;
			Console.Write("\nMacierz\n");
			Console.Write("----------------------------------------\n");
			print_matrix(matrix, size, size);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < 2 * size; j++)
				{
					if (j == (i + size))
					{
						matrix[i][j] = 1F;
					}
				}
			}

			Console.Write("\nMacierz rozszerzona\n");
			Console.Write("----------------------------------------\n");
			print_matrix(matrix, size, size*2);

			for (int i = size - 1; i > 0; i--)
			{
				if (matrix[i - 1][0] < matrix[i][0])
				{
					for (int j = 0; j < 2 * size; j++)
					{
						temp = matrix[i][j];
						matrix[i][j] = matrix[i - 1][j];
						matrix[i - 1][j] = temp;
					}
				}

				if (matrix[i - 1][0] < matrix[i][0])
				{
					temp = matrix[i][size];
					matrix[i][size] = matrix[i - 1][size];
					matrix[i - 1][size] = temp;
				}
			}

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j != i)
					{
						temp = matrix[j][i] / matrix[i][i];
						for (int k = 0; k < 2 * size; k++)
						{
							matrix[j][k] -= matrix[i][k] * temp;
						}
					}
				}
			}

			for (int i = 0; i < size; i++)
			{
				temp = matrix[i][i];
				for (int j = 0; j < 2 * size; j++)
				{
					matrix[i][j] = matrix[i][j] / temp;
				}
			}

			Console.Write("\nMacierz odwrotna \n");
			Console.Write("----------------------------------------\n");
			print_matrix_inverse(matrix, size, 2 * size);
			Console.Write("\n");
			return;
		}

		static void Main(string[] args)
		{			

			string file_path = "macierz.csv";

			string[] separators = { ",", ".", "!", "?", ";", ":", " ", };			

			int count = 0;

			if (!File.Exists(file_path))
			{				              
				string createText = "1;5;3;2;6\n" +
					 "5;9;2;4;5\n" +
					 "3;7;8;4;4\n" +
					 "1;3;3;2;9\n" +
					 "2;1;3;7;8\n";
				File.WriteAllText(file_path, createText);
			}

			Console.WriteLine("\nZawartość pliku macierz.csv:\n");
			string readText_file = File.ReadAllText(file_path);
			Console.WriteLine(readText_file);
			string[] readText = File.ReadAllLines(file_path);

			
			foreach (string s in readText)
			{
				count++;				
			}
			int[] array = new int[count*count];	//Tworzy macierz o odpowienim wymiarze, na podstawie liczby wierszy z pliku .csv
			
			
			int k = 0;
			foreach (string s in readText)
			{						
				string value = s;

				string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

				foreach (var word in words)
				{
					array[k] = int.Parse(word);			
					k++;
				}
			}
	
			k = 0;

			int size = count; // Size okresla wymiar macierzy (np. 4 x 4) 
			
			var random = new Random();

			float[][] matrix = new float[size][];

			for (int i = 0; i < size; i++)
			{
				matrix[i] = new float[size * 2]; 
				
				for (int j = 0; j < size; j++)
				{					
					matrix[i][j] = array[k];
					k++;
				}				
			}

			Console.WriteLine("Wymiary macierzy: " + count + " x " + count);

			inverse_of_matrix(matrix, size);
		}					
		static int rand()
		{
			throw new NotImplementedException();
		}				
    }
}
