using System;
using System.Linq;


namespace DataMungingClassLibrary
{
	public class MungingController
	{
		public string FileName { get; set; }
		public int KeyColumnIndex { get; set; }
		public int MaxColumnIndex { get; set; }
		public int MinColumnIndex { get; set; }
		public char[] LineSplitCharacters { get; set; }
		public Func<string, string> TrimFn { get; set; }

		public void Run(out string key, out int smallestDifference)
		{
			DataStore ds = new DataStore(FileName);

			// Skip past header line
			ds.GetNextRecord();

			DataProcessor dp = new DataProcessor { DataStore = ds, KeyColumnIndex = KeyColumnIndex, MaxColumnIndex = MaxColumnIndex, MinColumnIndex = MinColumnIndex };

			dp.ProcessData(out key, out smallestDifference, LineSplitCharacters, TrimFn);
		}
	}
}
