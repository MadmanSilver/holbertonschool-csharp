using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0} tip", percent.ToString("P", System.Globalization.CultureInfo.CreateSpecificCulture("en-US.utf-8")));
        Console.WriteLine("Currency: {0}", currency.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US.utf-8")));
	}
}
