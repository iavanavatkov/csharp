using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	public class Employee : Person
	{
		public string EmployeeCode { get; set; }
		public DateTimeOffset HireDay { get; set; }
		//public override string ShortDescription
		/*new */
		public override string ShortDescription
		{
			get
			{
				return base.ShortDescription +
						$"Code : {EmployeeCode}, " +
						$"HireDay: {HireDay:dd-MM-yyyy}, ";
			}
			//Теперь можно не писать прочее говно, которое дублируется из класса Персон, включая свойства ети снизу, каеф.
		}

		public Employee(string name, DateTimeOffset dateOfBirth) : base(name, dateOfBirth)
		{

		}
	}
}
