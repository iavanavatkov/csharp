using System;
using System.Threading;

namespace Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write(".");
				Thread.Sleep(50);
			}
		}
	}
}
