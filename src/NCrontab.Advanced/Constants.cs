#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

using System;
using System.Collections.Generic;

namespace NCrontab.Advanced
{
	public static class Constants
	{
		public static readonly Dictionary<CrontabFieldKind, int> MaximumDateTimeValues = new Dictionary<CrontabFieldKind, int>
		{
			{CrontabFieldKind.Second, 60},
			{CrontabFieldKind.Minute, 60},
			{CrontabFieldKind.Hour, 24},
			{CrontabFieldKind.DayOfWeek, 6},
			{CrontabFieldKind.Day, 31},
			{CrontabFieldKind.Month, 12},
			{CrontabFieldKind.Year, 9999}
		};

		public static readonly Dictionary<CronStringFormat, int> ExpectedFieldCounts = new Dictionary<CronStringFormat, int>
		{
			{CronStringFormat.Default, 5},
			{CronStringFormat.WithYears, 6},
			{CronStringFormat.WithSeconds, 6},
			{CronStringFormat.WithSecondsAndYears, 7}
		};

		public static readonly Dictionary<DayOfWeek, int> CronDays = new Dictionary<DayOfWeek, int>
		{
			{DayOfWeek.Sunday, 0},
			{DayOfWeek.Monday, 1},
			{DayOfWeek.Tuesday, 2},
			{DayOfWeek.Wednesday, 3},
			{DayOfWeek.Thursday, 4},
			{DayOfWeek.Friday, 5},
			{DayOfWeek.Saturday, 6}
		};

		public static readonly Dictionary<string, int> Days = new Dictionary<string, int>
		{
			{"SUN", 0},
			{"MON", 1},
			{"TUE", 2},
			{"WED", 3},
			{"THU", 4},
			{"FRI", 5},
			{"SAT", 6}
		};

		public static readonly Dictionary<string, int> Months = new Dictionary<string, int>
		{
			{"JAN", 1},
			{"FEB", 2},
			{"MAR", 3},
			{"APR", 4},
			{"MAY", 5},
			{"JUN", 6},
			{"JUL", 7},
			{"AUG", 8},
			{"SEP", 9},
			{"OCT", 10},
			{"NOV", 11},
			{"DEC", 12}
		};
	}
}