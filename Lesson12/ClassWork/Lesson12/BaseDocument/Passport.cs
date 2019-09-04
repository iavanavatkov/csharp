using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDocument
{
	class Passport : BaseDocuments
	{
		public string Country { get; set; }
		public string PersonName { get; set; }
		public override string DocName { get; set; }



		public override string DocumentProperties
		{
			get
			{
				return $"[{GetType().Name}] \n" +
					   $"Person name is {PersonName} \n" +
					   $"From {Country} \n" +
					   $"Name of Document is {DocName} \n" +
					   $"Number of Document is {DocNumber} \n" +
					   $"Issue Date is {IssueDate: dd-MM-yyyy} \n";
			}
		}

		public Passport(string personName, string country, string docName, string docNumber, DateTimeOffset issueDate)
					: base(docName, docNumber, issueDate)
		{
			personName = PersonName;
			country = Country;
		}
	}
}
