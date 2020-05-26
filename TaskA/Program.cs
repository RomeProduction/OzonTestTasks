using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskA
{
	class Program
	{
		static void Main(string[] args)
		{
			Functions functions = new Functions();
			functions.Add(1);
			functions.Add(2);
			functions.Add(2);
			functions.Add(1);
			functions.Add(2);
			functions.Add(3);
			functions.Add(2);
			Console.WriteLine(functions.GetUniqueNum());
		}
	}
	public class Functions
	{
		private Dictionary<int, int> dicCount;
		public Functions()
		{
			dicCount = new Dictionary<int, int>(100);
		}
		public void Add(int num)
		{
			if (dicCount.ContainsKey(num))
			{
				dicCount[num] = dicCount[num] + 1;
			}
			else
			{
				dicCount.Add(num, 1);
			}
		}
		public int GetUniqueNum()
		{
			var uniqueNum = dicCount.FirstOrDefault(x => x.Value % 2 != 0).Key;
			return uniqueNum;
		}
	}
}
