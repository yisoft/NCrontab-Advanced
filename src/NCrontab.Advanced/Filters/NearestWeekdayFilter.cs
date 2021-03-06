﻿#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;

namespace NCrontab.Advanced.Filters
{
	/// <summary>
	///     Handles filtering for the nearest weekday to a specified day
	/// </summary>
	public class NearestWeekdayFilter : ICronFilter
	{
		/// <summary>
		///     Constructs a new RangeFilter instance
		/// </summary>
		/// <param name="specificValue">The specific value you wish to match</param>
		/// <param name="kind">The crontab field kind to associate with this filter</param>
		public NearestWeekdayFilter(int specificValue, CrontabFieldKind kind)
		{
			if (specificValue <= 0 || specificValue > Constants.MaximumDateTimeValues[CrontabFieldKind.Day])
				throw new CrontabException(string.Format("<{0}W> is out of bounds for the Day field.", specificValue));

			if (kind != CrontabFieldKind.Day)
				throw new CrontabException(string.Format("<{0}W> can only be used in the Day field.", specificValue));

			SpecificValue = specificValue;
			Kind = kind;
		}

		public int SpecificValue { get; }

		public CrontabFieldKind Kind { get; }

		/// <summary>
		///     Checks if the value is accepted by the filter
		/// </summary>
		/// <param name="value">The value to check</param>
		/// <returns>True if the value matches the condition, False if it does not match.</returns>
		public bool IsMatch(DateTime value)
		{
			var specificDay = new DateTime(value.Year, value.Month, SpecificValue);

			DateTime closestWeekday;

			// ReSharper disable once SwitchStatementMissingSomeCases
			switch (specificDay.DayOfWeek)
			{
				case DayOfWeek.Saturday:
					// If the specified day is Saturday, back up to Friday
					closestWeekday = specificDay.AddDays(-1);

					// If Friday is in the previous month, then move forward to the following Monday
					if (closestWeekday.Month != specificDay.Month)
						closestWeekday = specificDay.AddDays(2);

					break;

				case DayOfWeek.Sunday:
					// If the specified day is Sunday, move forward to Monday
					closestWeekday = specificDay.AddDays(1);

					// If Monday is in the next month, then move backward to the previous Friday
					if (closestWeekday.Month != specificDay.Month)
						closestWeekday = specificDay.AddDays(-2);

					break;

				default:
					// The specified day happens to be a weekday, so use it
					closestWeekday = specificDay;
					break;
			}

			return value.Day == closestWeekday.Day;
		}

		public override string ToString()
		{
			return string.Format("{0}W", SpecificValue);
		}
	}
}