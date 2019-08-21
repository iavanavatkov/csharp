using System;
using System.Text;
using System.IO;
using System.Linq;

namespace FileSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			const string testMessage = "hello world \n";
			const string fileName = @"C:\Users\mosco\Desktop\test.txt";
			byte[] messageAnseBytes = Encoding.ASCII.GetBytes(testMessage);
			FileStream testFileStream = File.Open(
				fileName,
				FileMode.OpenOrCreate,
				FileAccess.Write, FileShare.Read
				);
			testFileStream.Seek(0, SeekOrigin.End);
			testFileStream.Write(messageAnseBytes);
			testFileStream.Flush();
			testFileStream.Close();
		}
	}
}
