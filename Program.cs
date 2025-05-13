using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    class Program
    {
		static void Main(string[] args)
		{
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("Enter chessboard size (positive integer - number of squares per side): ");
				if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid size! Please enter a positive integer!");
					Console.ResetColor();
					continue;
				}

				Console.Write("Enter the character to fill black squares: ");
				string fillCharInput = Console.ReadLine();
				if (string.IsNullOrEmpty(fillCharInput))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Character cannot be empty! Please enter a character!");
					Console.ResetColor();
					continue;
				}
				char fillChar = fillCharInput[0];

				Console.Write("Enter the number of symbols per square's side: ");
				if (!int.TryParse(Console.ReadLine(), out int symbolsPerSide) || symbolsPerSide <= 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid number of symbols per side! Please enter a positive integer!");
					Console.ResetColor();
					continue;
				}

				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("Chessboard:");

				for (int row = 0; row < size; row++)
				{
					for (int symbolRow = 0; symbolRow < symbolsPerSide; symbolRow++)
					{
						for (int col = 0; col < size; col++)
						{
							if ((row + col) % 2 == 0)
							{
								for (int i = 0; i < symbolsPerSide; i++)
								{
									Console.Write(" ");
								}
							}
							else
							{
								for (int i = 0; i < symbolsPerSide; i++)
								{
									Console.Write(fillChar);
								}
							}
						}
						Console.WriteLine();
					}
				}
				break;
			}

			Console.ResetColor();
			Console.WriteLine("Press any key to exit!");
			Console.ReadKey();
			Console.Clear();
		}
    }
}
