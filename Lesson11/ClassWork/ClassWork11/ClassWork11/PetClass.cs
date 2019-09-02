using System;
using System.Collections.Generic;
using System.Text;

namespace PetClass
{
	public class Pet
	{
		public enum AnimalKind { Mouse, Cat, Dog }

		private string _birthPlace;
		private char _sex;

		public AnimalKind Kind;
		public string Name;

		public char Sex
		{
			get
			{
				return _sex;
			}
			set
			{
				if (value == 'f' || value == 'F' || value == 'm' || value == 'M')
				{
					_sex = char.ToUpper(value);
				}
				else
				{
					throw new Exception("Invalid value");
				}
			}
		}

		public DateTimeOffset DateOfBirth;
		//public byte Age { get; set; }
		public int Age()
		{
				TimeSpan age = DateTimeOffset.Now - DateOfBirth;
				return (int)(age.TotalDays / 365.25);
		}

		//internal void UpdateProperties()
		//{
		//	throw new NotImplementedException();
		//}

		public string Description
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {Age()} years old" +
						$" (birth place: {_birthPlace}).";
			}
		}

		public string ShortDescription
		{
			get
			{
				return $"{Name} is a {Kind}.";
			}
		}

		public void SetBirthPlace(string birthPlace)
		{
			_birthPlace = birthPlace;
		}

		public void WriteOutDescription(bool isShortDescription = false) //не объявляем его потому, что нам ничо не надо записывать в переменную или запоминать.
		{
			var output = isShortDescription
				? ShortDescription
				: Description;
			Console.WriteLine(output);
		}

		public void UpdateProperties()
		{
				
		}

		public void UpdateProperties (string name, char sex)
		{
			Name = name;
			Sex = sex;
		}

		public void UpdateProperties(string name, AnimalKind kind)
		{
			Name = name;
			Kind = kind;
		}

		public void UpdateProperties(string name, char sex, AnimalKind kind)// : this (name, sex)
		{
			Name = name;
			Sex = sex;
			Kind = kind;
		}
	}
}
