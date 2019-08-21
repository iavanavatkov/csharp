using System;
using System.Collections.Generic;

namespace Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> countries = new Dictionary<int, string>(5);

			countries.Add(1, "Russia");
			countries.Add(2, "Great Britain");
			countries.Add(3, "USA");
			countries.Add(4, "France");
			countries.Add(5, "China");

			foreach (KeyValuePair<int, string> keyValue in countries)
				Console.WriteLine($"{keyValue.Key} - {keyValue.Value}"); //одна строчка под циклом может не браться в фигурные скобки, если больше не требуется

			string country = countries[4];  //доступ к элементу по ключу.
			countries[4] = "Spain"; 
			countries.Remove(2);

			Console.WriteLine(string.Join(",", countries));


			////////////////////////////////////////////////////


			Dictionary<string, string> countriesString = new Dictionary<string, string>(5);

			countriesString.Add("1", "Russia");
			countriesString.Add("2", "Great Britain");
			countriesString.Add(3.ToString(), "USA"); //НУЖНЫ СКУОБКИ ЭТИ ПУСТЫЕ ИНАЧЕ НЕ РАБОТАЕТ АЫАЫАЫАЫАА ТО ЖЕ САМОЕ С ТУАППЕР КОРОЧЕ ЕСЛИ РУГАЕТСЯ СТАВЬ СКОБКИ НА ВСЯКИЙ
			countriesString.Add(4.ToString(), "France");
			countriesString.Add(5.ToString(), "China");

			foreach (KeyValuePair<string, string> keyValue in countriesString)
				Console.WriteLine($"{keyValue.Key} - {keyValue.Value}"); //одна строчка под циклом может не браться в фигурные скобки, если больше не требуется

			string countryString = countries[4];  //доступ к элементу по ключу.
			countries[4] = "Spain";
			countries.Remove(2);

			Console.WriteLine(string.Join(",", countries));


			Console.WriteLine("Eta strana ochen horoshaya vot ona smotrite haha {0}", countries[1]); //можно ссылаться на уже имеющиеся данные, товары там, вот это всё, збс
		}
	}
}
