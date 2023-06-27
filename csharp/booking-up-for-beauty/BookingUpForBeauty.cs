using System;
using System.Globalization;

static class Appointment
{
	public static DateTime Schedule(string appointmentDateDescription)
	{
		if (DateTime.TryParse(appointmentDateDescription, out var date))
			return date;
		else if (DateTime.TryParseExact(appointmentDateDescription, "M/d/yyyy HH:mm:ss",
			new CultureInfo("en-US"), DateTimeStyles.None, out var dateValue))
			return dateValue;

		throw new FormatException($"String '{appointmentDateDescription}' was not recognized as a valid DateTime");
	}

	public static bool HasPassed(DateTime appointmentDate) => 
		DateTime.Compare(DateTime.Now, appointmentDate) > 0;

	public static bool IsAfternoonAppointment(DateTime appointmentDate) => 
		appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

	public static string Description(DateTime appointmentDate) => 
		$"You have an appointment on {appointmentDate.ToString(new CultureInfo("en_US"))}.";

	public static DateTime AnniversaryDate() => 
		new(DateTime.Now.Year, 9, 15);
}
