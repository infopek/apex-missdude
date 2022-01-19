using System;

namespace MissDude
{
	class Program
	{
		static void Main(string[] args)
		{
			int shots = 0;
			int hits = 0;

			ConsoleKeyInfo key = new ConsoleKeyInfo();

			do
			{
				while (!Console.KeyAvailable)
				{
					key = Console.ReadKey(true);

					switch (key.Key)
					{
						case ConsoleKey.UpArrow:	// Hit!! :D
							Console.Clear();

							shots++;
							hits++;

							Console.WriteLine($"Shots: {shots}\nHits: {hits}\nRatio: {Math.Round((float)hits / shots, 2)}");
							break;
						case ConsoleKey.DownArrow:	// Aimlab is free bro
							Console.Clear();

							shots++;

							Console.WriteLine($"Shots: {shots}\nHits: {hits}\nRatio: {Math.Round((float)hits / shots, 2)}");
							break;
						default:
							break;
					}
				}

			} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
		}
	}
}