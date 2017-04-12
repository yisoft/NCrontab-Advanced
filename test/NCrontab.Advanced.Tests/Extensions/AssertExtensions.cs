#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCrontab.Advanced.Tests.Extensions
{
	public static class Assert2
	{
		public static void Throws<T>(Action methodToCall, string message = "", params object[] values) where T : Exception
		{
			var additionalInfo = string.Format(message, values);

			try
			{
				methodToCall();
			}
			catch (T)
			{
				return;
			}
			catch (Exception e)
			{
				throw new AssertFailedException(
					$"Expected exception '{typeof(T).Name}', but '{e.GetType().Name}' was thrown\n\n{e}.  {additionalInfo}");
			}

			Assert.Fail("Expected exception '{0}', but no exception was thrown.  {1}", typeof(T).Name, additionalInfo);
		}
	}
}