using System;
using System.Collections.Generic;
using System.Linq;

namespace DataMungingClassLibrary
{
	public class DataProcessor
	{
		public DataStore DataStore { get; set; }
		public int KeyColumnIndex { get; set; }
		public int MaxColumnIndex { get; set; }
		public int MinColumnIndex { get; set; }

//		public abstract string Trim(string s);

		public void ProcessData(out string key, out int smallestDifference, char[] lineSplitCharacters, Func<string, string> trimFn)
		{
			string line;
			smallestDifference = Int32.MaxValue;
			key = null;

			while ((line = DataStore.GetNextRecord()) != null)
			{
				// Split the line and filter out empty strings. If two delimiters are adjacent, or a delimiter is found
				// at the beginning or end of this instance, the corresponding element in the array returned by Split()
				// contains an empty string.
				string[] splitLine = line.Split(lineSplitCharacters).Select(x => x.Trim()).Where(x => x.Length > 0).ToArray();
				string[] splitLine1 = line.Split(lineSplitCharacters).Where(x => x.Length > 0).ToArray();

				if (splitLine.Count() > 1 &&  Decimal.TryParse(splitLine[0], out decimal dec))
				{
					//int max = Int32.Parse(Trim(splitLine[MaxColumnIndex]));
					//int min = Int32.Parse(Trim(splitLine[MinColumnIndex]));
					int max = Int32.Parse(trimFn(splitLine[MaxColumnIndex]));
					int min = Int32.Parse(trimFn(splitLine[MinColumnIndex]));

					if (Math.Abs(max - min) < smallestDifference)
					{
						smallestDifference = Math.Abs(max - min);
						key = splitLine[KeyColumnIndex];
					}
				}
			}
		}
	}
}
