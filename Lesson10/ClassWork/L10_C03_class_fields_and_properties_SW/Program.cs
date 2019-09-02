using System;

public class Pet
{
	public enum AnimalKind { Mouse, Cat, Dog }

	private string _birthPlace;

	public AnimalKind Kind;
	public string Name;

	public char Sex { get; set; }
	public byte Age { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet();
		pet1.Kind = Pet.AnimalKind.Cat;
		pet1.Name = "Tom";
		pet1.Sex = 'M';
		pet1.Age = 8;
		Console.WriteLine(
			$"{pet1.Name} is a {pet1.Kind} " +
			$"({pet1.Sex}) of {pet1.Age} years old.");

		Pet pet2 = new Pet
		{
			Kind = Pet.AnimalKind.Mouse,
			Name = "Minnie",
			Sex = 'F',
			Age = 1
		};
		Console.WriteLine(
			$"{pet2.Name} is a {pet2.Kind} " +
			$"({pet2.Sex}) of {pet2.Age} years old.");
	}
}
