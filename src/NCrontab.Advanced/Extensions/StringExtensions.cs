#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

namespace NCrontab.Advanced.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNullOrWhiteSpace(this string value)
		{
			return value == null || value.Trim().Length == 0;
		}
	}
}