﻿#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;
using NCrontab.Advanced.Extensions;

namespace NCrontab.Advanced.Filters
{
	/// <summary>
	///     Handles filtering for a specific value
	/// </summary>
	public class SpecificFilter : ICronFilter, ITimeFilter
	{
		/// <summary>
		///     Constructs a new RangeFilter instance
		/// </summary>
		/// <param name="specificValue">The specific value you wish to match</param>
		/// <param name="kind">The crontab field kind to associate with this filter</param>
		public SpecificFilter(int specificValue, CrontabFieldKind kind)
		{
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
			int evalValue;

			switch (Kind)
			{
				case CrontabFieldKind.Second:
					evalValue = value.Second;
					break;
				case CrontabFieldKind.Minute:
					evalValue = value.Minute;
					break;
				case CrontabFieldKind.Hour:
					evalValue = value.Hour;
					break;
				case CrontabFieldKind.Day:
					evalValue = value.Day;
					break;
				case CrontabFieldKind.Month:
					evalValue = value.Month;
					break;
				case CrontabFieldKind.DayOfWeek:
					evalValue = value.DayOfWeek.ToCronDayOfWeek();
					break;
				case CrontabFieldKind.Year:
					evalValue = value.Year;
					break;
				default: throw new ArgumentOutOfRangeException(nameof(Kind), Kind, null);
			}

			return evalValue == SpecificValue;
		}

		public virtual int? Next(int value)
		{
			return SpecificValue;
		}

		public int First()
		{
			return SpecificValue;
		}

		public override string ToString()
		{
			return SpecificValue.ToString();
		}
	}
}