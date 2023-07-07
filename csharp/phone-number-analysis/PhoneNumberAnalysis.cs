public static class PhoneNumber
{
	public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
	{
		string[] numbers = phoneNumber.Split('-');

		bool isNewYourk = numbers[0] == "212" ? true : false;
		bool isFake = numbers[1].Contains("555") ? true : false;

		return (isNewYourk, isFake, numbers[2]);
	}

	public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
