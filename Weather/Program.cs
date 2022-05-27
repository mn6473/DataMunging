/*
 * Console application to process a file of type weather.dat.
 */

using System;
using DataMungingClassLibrary;

namespace Weather
{
	internal class Program
	{
		private static readonly string fileName = "c:\\datamunging\\weather.dat";
		private static readonly int keyColumnIndex = 0;
		private static readonly int maxColumnIndex = 1;
		private static readonly int minColumnIndex = 2;
		private static readonly char[] lineSplitCharacters = { ' ', '\n' };

		// The temperature columns use an asterisk to mark the highest temperature
		// (in the MaxT column) and the lowest temperature (in MinT). This function
		// removes that asterisk.
		private static readonly Func<string, string> trim = (s) => s.Trim('*');

		static void Main(string[] args)
		{
			MungingController mungingController = new MungingController 
			{ 
				FileName = fileName, 
				KeyColumnIndex = keyColumnIndex, 
				MaxColumnIndex = maxColumnIndex, 
				MinColumnIndex = minColumnIndex,
				LineSplitCharacters = lineSplitCharacters,
				TrimFn = trim
			};

			mungingController.Run(out string key, out int smallestDifference);

			Console.WriteLine($"\nDay: {key}, Temperature Spread: {smallestDifference}");
		}
	}
}
