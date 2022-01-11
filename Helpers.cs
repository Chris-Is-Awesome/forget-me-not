using System;

namespace ForgetMeNot
{
	static class Helpers
	{
		public enum TimeUpdateMethod
		{
			Minutes,
			Hours,
			Days,
			Months,
			Years
		}

		public static DateTime UpdateDateTime(DateTime originalDate, int year, int month, int day, int hour = 0, int minute = 0, int second = 0, int millisecond = 0)
		{
			return new DateTime
				(
					year,
					month,
					day,
					hour,
					minute,
					second,
					millisecond
				);
		}

		public static DateTime UpdateTime(DateTime originalValue, int newValue, TimeUpdateMethod whatToUpdate)
		{
			switch (whatToUpdate)
			{
				case TimeUpdateMethod.Minutes:
					return new DateTime
						(
							originalValue.Year,
							originalValue.Month,
							originalValue.Day,
							originalValue.Hour,
							newValue,
							0,
							0
						);
				case TimeUpdateMethod.Hours:
					return new DateTime
						(
							originalValue.Year,
							originalValue.Month,
							originalValue.Day,
							newValue,
							originalValue.Minute,
							0,
							0
						);
				case TimeUpdateMethod.Days:
					return new DateTime
						(
							originalValue.Year,
							originalValue.Month,
							newValue,
							originalValue.Hour,
							originalValue.Minute,
							0,
							0
						);
				case TimeUpdateMethod.Months:
					return new DateTime
						(
							originalValue.Year,
							newValue,
							originalValue.Day,
							originalValue.Hour,
							originalValue.Minute,
							0,
							0
						);
				case TimeUpdateMethod.Years:
					return new DateTime
						(
							newValue,
							originalValue.Month,
							originalValue.Day,
							originalValue.Hour,
							originalValue.Minute,
							0,
							0
						);
				default:
					return originalValue;
			}
		}
	}
}