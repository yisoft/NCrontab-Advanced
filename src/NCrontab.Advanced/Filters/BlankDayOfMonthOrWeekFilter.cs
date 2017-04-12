#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;

namespace NCrontab.Advanced.Filters
{
	/// <summary>
	///     No specific value filter for day-of-week and day-of -month fields
	///     <remarks>
	///         http://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontrigger.html
	///         https://en.wikipedia.org/wiki/Cron#CRON_expression
	///     </remarks>
	/// </summary>
	public class BlankDayOfMonthOrWeekFilter : ICronFilter
	{
		public BlankDayOfMonthOrWeekFilter(CrontabFieldKind kind)
		{
			if (kind != CrontabFieldKind.DayOfWeek && kind != CrontabFieldKind.Day)
				throw new CrontabException("The <?> filter can only be used in the Day-of-Week or Day-of-Month fields.");

			Kind = kind;
		}

		public CrontabFieldKind Kind { get; }

		public bool IsMatch(DateTime value)
		{
			return true;
		}

		public int? Next(int value)
		{
			var max = Constants.MaximumDateTimeValues[Kind];
			if (Kind == CrontabFieldKind.Day
			    || Kind == CrontabFieldKind.Month
			    || Kind == CrontabFieldKind.DayOfWeek)
				throw new CrontabException("Cannot call Next for Day, Month or DayOfWeek types");

			var newValue = (int?) value + 1;

			if (newValue >= max) newValue = null;

			return newValue;
		}

		public int First()
		{
			if (Kind == CrontabFieldKind.Day
			    || Kind == CrontabFieldKind.Month
			    || Kind == CrontabFieldKind.DayOfWeek)
				throw new CrontabException("Cannot call First for Day, Month or DayOfWeek types");

			return 0;
		}

		public override string ToString()
		{
			return "?";
		}
	}
}