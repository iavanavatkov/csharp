using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDocument
{
	class BaseDocuments
	{
		public virtual string DocName { get; set; }
		public string DocNumber { get; set; }
		public DateTimeOffset IssueDate { get; set; }
		public virtual string DocumentProperties
		{
			get
			{
				return $"[{GetType().Name} ] \n" +
					   $"Name of Document is {DocName} \n" +
					   $"Number of Document is {DocNumber} \n" +
					   $"Issue Date is {IssueDate: dd-MM-yyyy} \n";
			}
		}

		public BaseDocuments(string docName, string docNumber, DateTimeOffset issueDate)
		{
			docName = DocName;
			docNumber = DocNumber;
			issueDate = IssueDate;
		}

		public void WriteToConsole()
		{
			Console.WriteLine(DocumentProperties);
		}
	}
}
