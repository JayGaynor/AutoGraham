using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Getter.Tests
{
	[TestClass]
	public class GetterTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("yes", new Getter.StatsPuller().GetStats("aapl"));
		}
	}
}
