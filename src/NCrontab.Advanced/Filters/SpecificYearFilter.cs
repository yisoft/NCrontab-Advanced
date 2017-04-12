#region License and Terms

// Most unit tests are from NCrontab - Crontab for .NET, written by Atif Aziz.
// Ported to Microsoft's unit test framework by Joe Coutcher
// Project can be accessed at https://github.com/atifaziz/NCrontab

#endregion

namespace NCrontab.Advanced.Filters
{
	/// <summary>
	///     Handles filtering for a specific value
	/// </summary>
	public class SpecificYearFilter : SpecificFilter
	{
		/// <summary>
		///     Constructs a new RangeFilter instance
		/// </summary>
		/// <param name="specificValue">The specific value you wish to match</param>
		/// <param name="kind">The crontab field kind to associate with this filter</param>
		public SpecificYearFilter(int specificValue, CrontabFieldKind kind) : base(specificValue, kind)
		{
		}

		public override int? Next(int value)
		{
			return value < SpecificValue ? (int?) SpecificValue : null;
		}
	}
}