using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskD;

namespace TaskDTest
{
	[TestClass]
	public class TaskDTest
	{
		[TestMethod]
		public void SumDifferenctCountOfDigit()
		{
			string variable1 = "1";
			string variable2 = "199";
			string res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "200", "Sum with different count digit");
		}
		[TestMethod]
		public void EasySum()
		{
			var variable1 = "1";
			var variable2 = "2";
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "3", "Easy sum");
		}
		[TestMethod]
		public void SumNumberStartWithZero()
		{
			var variable1 = "1";
			var variable2 = "002";
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "3", "Start with zero");
		}
		[TestMethod]
		public void SumWithEmpty()
		{
			var variable1 = "1";
			var variable2 = "";
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "1", "Empty sum");
		}
		[TestMethod]
		public void SumWithBothEmpty()
		{
			var variable1 = "";
			var variable2 = "";
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "0", "Both empty sum");
		}
		[TestMethod]
		public void Sum900Zero()
		{
			var variable1 = new string('0', 900);
			var variable2 = new string('0', 900);
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "0", "zero");
		}
		[TestMethod]
		public void LongSum()
		{
			var variable1 = new string('9', 900);
			var variable2 = "1";
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "1" + new string('0', 900), " long sum");
		}
		[TestMethod]
		public void SumFirstDigit()
		{
			var variable1 = "1001";
			var variable2 = "1";
			var res = Functions.Sum(variable1, variable2);
			Assert.AreEqual(res, "1002", "sum first digit");
		}
	}
}
