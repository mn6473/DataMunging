using System;
using DataMungingClassLibrary;

namespace Controller
{
	// The design of this application and class library was quick-and-dirty. It is a boilerplate for a more flexible underying data store
	// and data format, but without any requirements, it is good enough for the purposes of this exercise. :-)

	internal class Program
	{
		static void Main(string[] args)
		{
			//if (args.Length != 6)
			//{
			//	Console.WriteLine("\nCommand line format:");
			//	Console.WriteLine(" controller data-file-directory data-file-name key-column-index max-value-column-index min-column-index file-has-footer-line (Y or N)");
			//	Console.WriteLine("\nExample:\n controller c:\\DataMunging football.dat 2 7 9 N");
			//	Console.WriteLine("\nAnother example:\n controller c:\\DataMunging weather.dat 1 2 3 Y");

			//	return;
			//}

			//// Ordinarily the input arguments would be checked for validity
			//string directory = args[0];
			//string fileName = $"{directory}\\{args[1]}";
			//int keyColumn = Int32.Parse(args[2]) - 1;
			//int maxColumn = Int32.Parse(args[3]) - 1;
			//int minColumn = Int32.Parse(args[4]) - 1;
			//bool fileHasFooter = args[5].ToLower() == "y" ? true : false;

			//// Create and open connection to underlying data storage. DataStore's argument would be connection string if a database,
			//// network address for network stream, or something  else.
			//DataStore ds = new DataStore(fileName);

			//DataProcessor dataProcessor = new DataProcessor { DataStore = ds, KeyColumnIndex = keyColumn, MaxColumnIndex = maxColumn, MinColumnIndex = minColumn, KeyIsNumber = fileHasFooter };
			//dataProcessor.ProcessData(out string smallestDifferenceKey, out int smallestDifference);
			//Console.WriteLine($"\nKey: {smallestDifferenceKey}, Smallest spread: {smallestDifference}");
		}
	}
}
