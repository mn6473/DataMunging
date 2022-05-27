using System;
using System.IO;

namespace DataMungingClassLibrary
{
	// In a real-world application, this class would inherit from an interface and different
	// types of data store classes for a file, database, etc. would inherit from that interface.
	public class DataStore
	{
		private StreamReader sr { get; set; }

		public DataStore(string fileName) => sr = new StreamReader(fileName);

		public string GetHeaderRecord() => GetNextRecord();

		public string GetNextRecord() => sr.ReadLine();
	}
}
