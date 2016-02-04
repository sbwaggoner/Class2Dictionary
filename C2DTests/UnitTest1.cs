using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class2Dictionary;
using System.Linq;

namespace C2DTests
{
	[TestClass]
	public class C2DTests
	{
		[TestMethod]
		public void ConvertClassToDictionaryExtensionTest()
		{
			//Arrange
			var sampleClass= new SampleClass();

			//Act
			var dictionary = sampleClass.ConvertC2D();
			var result = string.Join(", ", dictionary.Select(m => m.Key + ":" + m.Value).ToArray());

			//Assert
			Assert.IsTrue(result == "Id:1, FirstName:Tom, LastName:Swift, Company:Swift Enterprises");
		}
	}
}
