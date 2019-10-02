using System.Net;

namespace Reminder.App
{
	internal class TelegramReminderReciever
	{
		private string token;
		private IWebProxy proxy;

		public TelegramReminderReciever(string token, IWebProxy proxy)
		{
			this.token = token;
			this.proxy = proxy;
		}
	}
}