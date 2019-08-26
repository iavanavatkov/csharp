using System;

namespace ClassWork09
{
	class Program
	{

		static void Main(string[] args)
		{
			int x = 0;
			x = x + 1;

			const int length = 10;
			const int maxValue = 100;
			int[] arr = GetTestArray(length, maxValue);

		//	Console.WriteLine(string.Join(", ", arr));
			WriteOutArrayValues(arr, "Non-sorted");
			//bubble sorting
			BubbleSort(arr);
		//	Console.WriteLine(string.Join(", ", arr));
			WriteOutArrayValues(arr, "Sorted");

		}

		public static int[] GetTestArray(int arrayLength, int maxElementValue)
		{
			var arr = new int[arrayLength];
			var rnd = new Random();

			for (var i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(maxElementValue);
			}
			return arr;
		}

		public static void WriteOutArrayValues(int[] arr, string message)
		{
			Console.WriteLine(message);
			Console.WriteLine(string.Join(", ", arr) + "\n");
		}

		public static int[] BubbleSort(int[] arr)
		{
			for (int j = 0; j < arr.Length - 1; j++)
			{
				for (int i = 0; i < arr.Length - 1 - j; i++)
				{
					if (arr[i] > arr[i + 1])
					{
						int first = arr[i + 1];
						int second = arr[i];
						arr[i] = first;
						arr[i + 1] = second; //можно было решить через только одну доп переменную, но я всё равно доволен.
					}
				}
			}
			return arr;
		}

		public static void UpdateValue(int a)
		{
			a = a + 1;
			Console.WriteLine(a);
		}
	}
}
