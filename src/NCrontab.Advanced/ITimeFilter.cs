#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

namespace NCrontab.Advanced
{
	internal interface ITimeFilter
	{
		int? Next(int value);

		int First();
	}
}