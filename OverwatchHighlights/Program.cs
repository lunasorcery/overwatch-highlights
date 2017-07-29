using System;
using System.IO;

namespace OverwatchHighlights
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WindowHeight = 50;
			Console.BufferHeight = 32766;

			UnlockValidator.Run();

			if (args.Length > 0)
			{
				foreach (var arg in args)
				{
					if (File.Exists(arg))
						LoadAndPrintHighlight(new FileInfo(arg));
					else if (Directory.Exists(arg))
						foreach (var file in Directory.GetFiles(arg))
							LoadAndPrintHighlight(new FileInfo(file));
				}
			}
			else
			{
				var overwatchAppdataFolder = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Blizzard Entertainment/Overwatch"));
				foreach (var userFolder in overwatchAppdataFolder.GetDirectories())
				{
					var highlightsFolder = new DirectoryInfo(Path.Combine(userFolder.FullName, "Highlights"));
					if (highlightsFolder.Exists)
					{
						foreach (var item in highlightsFolder.GetFiles())
						{
							LoadAndPrintHighlight(item);
						}
					}
				}
			}

			Tracer.DumpToConsole();
			Tracer.DumpToFile("tracer.log");

			Console.ReadLine();
		}

		static void LoadAndPrintHighlight(FileInfo file)
		{
			var highlight = Highlight.FromFile(file.FullName);
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(file.FullName);
			Console.ResetColor();
			highlight.Print();
		}
	}
}
