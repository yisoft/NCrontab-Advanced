#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

namespace NCrontab.Advanced
{
	public enum CrontabFieldKind
	{
		Second = 0, // Keep in order of appearance in expression
		Minute = 1,
		Hour = 2,
		Day = 3,
		Month = 4,
		DayOfWeek = 5,
		Year = 6
	}
}