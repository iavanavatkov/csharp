using System;

namespace BaseDocument
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocuments p1 = new BaseDocuments
				("AAAYAYAYYA",
				"01293198789989",
				DateTimeOffset.Parse("20-01-10"));

			Passport p2 = new Passport
				("AYAYAY", "AYAYAYAYYA", "ASDASD", "asdasd", DateTimeOffset.Parse("12-12-12"));

			p1.WriteToConsole();
			p2.WriteToConsole();
		}
	}
}
