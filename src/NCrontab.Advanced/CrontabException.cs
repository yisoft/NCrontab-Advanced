#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;

namespace NCrontab.Advanced
{
	public class CrontabException : Exception
	{
		public CrontabException()
		{
		}

		public CrontabException(string message) : base(message)
		{
		}

		public CrontabException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}