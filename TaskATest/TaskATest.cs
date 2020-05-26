using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskA;

namespace TaskATest
{
	[TestClass]
	public class TaskATest
	{
		[TestMethod]
		public void BaseTest()
		{
			Functions functions = new Functions();
			functions.Add(1);
			functions.Add(2);
			functions.Add(2);
			functions.Add(1);
			functions.Add(2);
			functions.Add(3);
			functions.Add(2);
			Assert.AreEqual(3, functions.GetUniqueNum());
		}
		[TestMethod]
		public void DuplicatePairTest()
		{
			Functions functions = new Functions();
			functions.Add(1);
			functions.Add(2);
			functions.Add(2);
			functions.Add(1);
			functions.Add(2);
			functions.Add(3);
			functions.Add(3);
			Assert.AreEqual(2, functions.GetUniqueNum());
		}
		[TestMethod]
		public void OneNumberTest()
		{
			Functions functions = new Functions();
			functions.Add(1);
			Assert.AreEqual(1, functions.GetUniqueNum());
		}
		[TestMethod]
		public void PerfomanceTest()
		{
			Functions functions = new Functions();
			for (int i = 0; i < 900; i++)
			{
				functions.Add(i);
				functions.Add(i);
			}
			functions.Add(11);
			Assert.AreEqual(11, functions.GetUniqueNum());
		}
	}
}
