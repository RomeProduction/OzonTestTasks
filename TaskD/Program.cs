using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskD
{
	class Program
	{
		static void Main(string[] args)
		{
			var v = Functions.Sum("199", "0010");
			Console.WriteLine(v);
			Console.ReadLine();
		}
	}

	public static class Functions
	{
		public static string Sum(string var1, string var2)
		{
			Regex regClearZero = new Regex("^0*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
			if (string.IsNullOrEmpty(var1) && string.IsNullOrEmpty(var2))
			{
				return "0";
			}
			if (string.IsNullOrEmpty(var1) && !string.IsNullOrEmpty(var2))
			{
				return var2;
			}
			if (!string.IsNullOrEmpty(var1) && string.IsNullOrEmpty(var2))
			{
				return var1;
			}
			char[] dgts1, dgts2;
			var1 = regClearZero.Replace(var1, "");
			var2 = regClearZero.Replace(var2, "");
			if (string.IsNullOrEmpty(var1))
			{
				var1 = "0";
			}
			if (string.IsNullOrEmpty(var2))
			{
				var2 = "0";
			}
			if (var1.Length > var2.Length)
			{
				dgts1 = var1.Reverse().ToArray();
				dgts2 = var2.Reverse().ToArray();
			}
			else
			{
				dgts1 = var2.Reverse().ToArray();
				dgts2 = var1.Reverse().ToArray();
			}
			StringBuilder builder = new StringBuilder();
			bool isCarry = false;
			for (int i = 0; i < dgts1.Count(); i++)
			{
				if(i > dgts2.Length && !isCarry)
				{
					builder.Append(dgts1.Skip(i).Take(dgts1.Length).ToArray());
					break;
				}
				var localSum = int.Parse(dgts1[i] + "") + (dgts2.Length > i ? int.Parse(dgts2[i] + "") : 0) + (isCarry ? 1 : 0);
				isCarry = localSum >= 10;
				builder.Append(localSum % 10);
			}
			if (isCarry)
			{
				builder.Append("1");
			}
			var sum = builder.ToString().Reverse();
			return new string(sum.ToArray());
		}
	}
}
