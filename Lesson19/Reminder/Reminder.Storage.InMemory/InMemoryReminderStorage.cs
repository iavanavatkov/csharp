﻿using System;
using System.Collections.Generic;
using System.Linq;
using Reminder.Storage.Core;

namespace Reminder.Storage.InMemory
{
	public class InMemoryReminderStorage : IReminderStorage
	{
		internal Dictionary<Guid, ReminderItem> Reminders;

		public void Add(ReminderItem reminderItem)
		{
			Reminders.Add(reminderItem.Id, reminderItem);
		}

		public ReminderItem Get(Guid id)
		{
			return Reminders.ContainsKey(id)
				? Reminders[id]
				: null;
		}

		public List<ReminderItem> Get(ReminderItemStatus status)
		{
			return Reminders
				.Values
				.Where((ReminderItem ri) => ri.Status == status)
				.ToList();
		}

		public void Update(Guid id, ReminderItemStatus status)
		{
			if (Reminders.ContainsKey(id))
				Reminders[id].Status = status;
		}
	}
}
