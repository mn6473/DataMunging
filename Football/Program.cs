/*
 * Console application to process a file of type football.dat.
 */

using System;
using DataMungingClassLibrary;

namespace Football
{
	internal class Program
	{
		private static readonly string fileName = "c:\\datamunging\\football.dat";
		private static readonly int keyColumnIndex = 1;
		private static readonly int maxColumnIndex = 6;
		private static readonly int minColumnIndex = 7;
		private static readonly char[] lineSplitCharacters = { ' ', '\n', '-' };

		// A trim function is called from the DataProcessor to remove unwanted characters
		// from the begin or ending of a column. In the case of the Football data file,
		// there are no unwanted characters that need to be removed so this method just
		// returns the string as it was given.
		private static readonly Func<string, string> trim = (s) => s;

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

			Console.WriteLine($"\nTeam: {key}, Goal Differential: {smallestDifference}");
		}
	}
}
