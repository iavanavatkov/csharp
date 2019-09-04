using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	public class Person
	{
		public string Name { get; set; }
		public DateTimeOffset DateOfBirth { get; set; }

		public virtual string ShortDescription
		{
			get
			{
				return $"[{GetType().Name}] " +
						$"name: {Name}, " +
						$"date of birth: {DateOfBirth:dd-MM-yy} ";
			}
		}

		public Person(string name, DateTimeOffset dateOfBirth) //параметры конструкторов можно короче как те, только в камелкасинге
		{
			Name = name;
			DateOfBirth = dateOfBirth;
		}

		public void WriteShortDecription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}
