using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OverwatchHighlights
{
	static class Tracer // hiya!
	{
		private static Dictionary<string, List<string>> ms_map = new Dictionary<string, List<string>>();

		/// log a value against a key
		public static void Trace(string key, object value)
		{
			if (!ms_map.ContainsKey(key))
				ms_map[key] = new List<string>();
			ms_map[key].Add(value.ToString());
		}

		/// log a value against a key, but ignore duplicate values
		public static void TraceNoDupe(string key, object value)
		{
			if (!ms_map.ContainsKey(key))
				ms_map[key] = new List<string>();
			if (!ms_map[key].Contains(value.ToString()))
				ms_map[key].Add(value.ToString());
		}

		public static void DumpToConsole()
		{
			DumpToTextWriter(Console.Out);
		}

		public static void DumpToFile(string filename)
		{
			using (StreamWriter sw = new StreamWriter(filename))
			{
				DumpToTextWriter(sw);
			}
		}

		private static void DumpToTextWriter(TextWriter tw)
		{
			tw.WriteLine("-- Tracer log --");
			foreach (var kvp in ms_map.OrderBy(a => a.Key))
			{
				tw.WriteLine($"  {kvp.Key}:");
				foreach (var item in kvp.Value.OrderBy(a => a))
				{
					tw.WriteLine($"    {item}");
				}
			}
		}
	}
}
