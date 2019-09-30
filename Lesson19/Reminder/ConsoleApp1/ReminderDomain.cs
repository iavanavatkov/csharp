using Reminder.Storage.Core;
using System;
using System.Threading;

namespace Reminder.Domain
{
	public class ReminderDomain : IDisposable
	{
		private IReminderStorage _storage;

		private TimeSpan _awaitingRemindersCheckingPeriod;
		private TimeSpan _readyRemindersSendingPeriod;

		private Timer _awaitingRemindersCheckingTimer;
		private Timer _readyRemindersCheckingTimer;

		//public event EventHandler<SendingSucceededEventArgs> Sending

		public Action<ReminderItem> SendReminder {get; set;}

		public ReminderDomain(
			IReminderStorage storage, 
			TimeSpan awaitingRemindersCheckingPeriod,
			TimeSpan readyRemindersSendingPeriod)
		{
			_storage = storage;
			_awaitingRemindersCheckingPeriod = awaitingRemindersCheckingPeriod;
			_readyRemindersSendingPeriod = readyRemindersSendingPeriod;
		}

		public ReminderDomain(IReminderStorage storage)
			: this(storage, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1))
		{
		}

		public void Run()
		{
			_awaitingRemindersCheckingTimer = new Timer(
				CheckAwaitingReminders,
				null,
				TimeSpan.Zero,
				_awaitingRemindersCheckingPeriod);

			_readyRemindersCheckingTimer = new Timer(
				SendReadyReminders,
				null,
				TimeSpan.FromSeconds(1),
				_readyRemindersSendingPeriod);
		}
		
		private void CheckAwaitingReminders(object state)
		{
			var awaitingReminders = _storage.Get(ReminderItemStatus.Awaiting);
			foreach (var awaitingReminder in awaitingReminders)
			{
				if (awaitingReminder.IsReadyToSend)
				{
					_storage.Update(awaitingReminder.Id, ReminderItemStatus.Ready);
				}
			}
		}

		private void SendReadyReminders(object state)
		{
			var readyReminders = _storage.Get(ReminderItemStatus.Ready);
			foreach (var readyReminder in readyReminders)
			{
				try
				{
					//Здесь будет попытка отправить
					SendReminder(readyReminder);
					_storage.Update(readyReminder.Id, ReminderItemStatus.Sent);
				}
				catch
				{
					//update status to failed
					_storage.Update(readyReminder.Id, ReminderItemStatus.Failed);
				}
			}
		}

		public void Dispose()
		{
			if (_awaitingRemindersCheckingTimer != null)
				_awaitingRemindersCheckingTimer?.Dispose();
		}
	}
}