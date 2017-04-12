#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;

namespace NCrontab.Advanced.Filters
{
	/// <summary>
	///     Handles filtering for the last day of the month
	/// </summary>
	public class LastDayOfMonthFilter : ICronFilter
	{
		public LastDayOfMonthFilter(CrontabFieldKind kind)
		{
			if (kind != CrontabFieldKind.Day)
				throw new CrontabException("The <L> filter can only be used with the Day field.");

			Kind = kind;
		}

		public CrontabFieldKind Kind { get; }

		/// <summary>
		///     Checks if the value is accepted by the filter
		/// </summary>
		/// <param name="value">The value to check</param>
		/// <returns>True if the value matches the condition, False if it does not match.</returns>
		public bool IsMatch(DateTime value)
		{
			return DateTime.DaysInMonth(value.Year, value.Month) == value.Day;
		}

		public override string ToString()
		{
			return "L";
		}
	}
}