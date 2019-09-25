using System;
using System.Collections.Generic;
using System.Linq;
using Reminder.Storage.Core;

namespace ClassLibrary1
{
	public class InMemoryReminderStorage : IReminderStorage
	{
		private Dictionary<Guid, ReminderItem> reminders;

		public void Add(ReminderItem reminderItem)
		{
			reminders.Add(reminderItem.Id, reminderItem);
		}
		
		public ReminderItem Get (Guid id)
		{
			if (reminders.ContainsKey(id))
				return reminders[id];

			else
				return null;
		}

		public List<ReminderItem> Get(ReminderItemStatus status)
		{
			return reminders
				.Values
				.Where((ReminderItem ri) => ri.Status == status)
				.ToList();
				//{
				//	//if (ri.Status == Status)
				//	//	return true;
				//	//else
				//	//	return false;
				//});
		}

		public void Update (Guid id, ReminderItemStatus status)
		{
			if(reminders.ContainsKey(id))
				reminders[id].Status = status;
		}
	}
}
