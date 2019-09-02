using System;
using PetClass;

class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet();
		pet1.Kind = Pet.AnimalKind.Cat;
		pet1.Name = "Tom";
		pet1.Sex = 'M';
		//pet1.Age = 8;
		pet1.DateOfBirth = DateTimeOffset.Parse("2000-03-14 12:46:33");
		pet1.SetBirthPlace("Moscow");
		pet1.WriteOutDescription();

		Pet pet2 = new Pet
		{
			Kind = Pet.AnimalKind.Mouse,
			Name = "Minnie",
			Sex = 'F',
			//Age = 1
			DateOfBirth = DateTimeOffset.Parse("2013-03-14 12:46:33")
		};

		pet2.SetBirthPlace("St.Petersburg");
		pet2.WriteOutDescription(true); //Здесь короткая

		Console.WriteLine("Давай ПЕРЕИМЕНОВЫВАТЬ МЫШЬ");

		pet2.UpdateProperties(Console.ReadLine(), 'm');
		pet2.WriteOutDescription(true); //Здесь короткая
	}
}
