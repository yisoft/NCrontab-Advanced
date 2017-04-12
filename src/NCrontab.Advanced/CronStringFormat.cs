#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

namespace NCrontab.Advanced
{
	/// <summary>
	///     The cron string format to use during parsing
	/// </summary>
	public enum CronStringFormat
	{
		/// <summary>
		///     Defined as "MINUTES HOURS DAYS MONTHS DAYS-OF-WEEK"
		/// </summary>
		Default = 0,

		/// <summary>
		///     Defined as "MINUTES HOURS DAYS MONTHS DAYS-OF-WEEK YEARS"
		/// </summary>
		WithYears = 1,

		/// <summary>
		///     Defined as "SECONDS MINUTES HOURS DAYS MONTHS DAYS-OF-WEEK"
		/// </summary>
		WithSeconds = 2,

		/// <summary>
		///     Defined as "SECONDS MINUTES HOURS DAYS MONTHS DAYS-OF-WEEK YEARS"
		/// </summary>
		WithSecondsAndYears = 3
	}
}