using System;
using System.Collections.Generic;
using System.Text;

namespace NameAndAge
{
	public class DataBasePreset
	{
		public string Name { get; set; }
		public string Age { get; set; }
		public DataBasePreset(string personName, string personAge)
		{
			Name = personName;
			Age = personAge;
		}
		public string Output
		{
			get
			{
				return $"{Name} сейчас {Age}, но через четыре года ему будет {Int32.Parse(Age) + 4}";
			}
		}


		public void WriteToConsole()
		{
			Console.WriteLine(Output);
		}
	}
}
