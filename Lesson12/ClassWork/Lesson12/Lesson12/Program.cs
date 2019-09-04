using System;
using Lesson12;

namespace Lesson12
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person(
				"Ivan",
				DateTimeOffset.Parse("17-02-1995"));

			p1.WriteShortDecription();

			Employee e1 = new Employee(
				"Dmitriy",
				DateTimeOffset.Parse("2010-02-19"));
				e1.EmployeeCode = "10";
				e1.HireDay = DateTimeOffset.Parse("20.02.13"); //точки почему-то зашквар

			e1.WriteShortDecription();
		}
	}
}
