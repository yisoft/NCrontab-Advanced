#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCrontab.Advanced.Tests
{
	// Why do we test constants?  To ensure dictionaries that
	// use them are updated as soon as a new value is added!
	[TestClass]
	public class ConstantTests
	{
		[TestMethod]
		public void VerifyConstants()
		{
			ValidateExists<CronStringFormat>(Constants.ExpectedFieldCounts);
			ValidateExists<CrontabFieldKind>(Constants.MaximumDateTimeValues);
			ValidateExists<DayOfWeek>(Constants.CronDays);
		}

		private static void ValidateExists<T>(IDictionary dictionary)
		{
			Assert.IsNotNull(dictionary);

			foreach (var value in Enum.GetValues(typeof(T)))
				Assert.IsTrue(dictionary.Contains(value), "Contains <{0}>", Enum.GetName(typeof(T), value));
		}
	}
}