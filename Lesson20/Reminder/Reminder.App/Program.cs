using System;
using System.Net;
using Reminder.Domain;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;
using Reminder.Receiver.Telegram;
using Reminder.Receiver.Core;
using Reminder.Sender.Core;
using Reminder.Parsing;
using Reminder.Sender.Telegram;
using Reminder.App;
using MihaZupan;

namespace Reminder.App
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Telegram Bot Application!");

			var storage = new InMemoryReminderStorage();
			var domain = new ReminderDomain(storage);
			IWebProxy proxy = new HttpToSocks5Proxy("proxy.golyakov.net", 1080);
			string token = "874002335:AAHCWlQVHGvM6if784HJ0rHTfcUg7SbSR5s";

			var sender = new TelegramReminderSender(token, proxy);
			var receiver = new TelegramReminderReceiver(token, proxy);


			receiver.MessageReceived += (s, e) =>
			{
				Console.WriteLine($"Message from contact '{e.ContactId}' with text '{e.Message}'");
				//add new reminderitem to the storage
				var parsedMessage = MessageParser.Parse(e.Message);
				var item = new ReminderItem(parsedMessage.Date, parsedMessage.Message, e.ContactId);

				storage.Add(item);
			};

			receiver.Run();

			domain.SendReminder = (ReminderItem ri) =>
			{
				sender.Send(ri.ContactId, ri.Message);
			};

			domain.Run();

			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
