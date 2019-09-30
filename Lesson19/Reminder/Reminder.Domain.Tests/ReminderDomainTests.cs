using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;
using System;

namespace Reminder.Domain.Tests
{
	[TestClass]
	public class ReminderDomainTests
	{
		[TestMethod]
		public void Method_Run_Should_Ready_To_Send_Reminders_To_Status_Ready_From_Awaiting()
		{
			var storage = new InMemoryReminderStorage();
			storage.Add(new ReminderItem(DateTimeOffset.Now, null, null));
			using (var domain = new ReminderDomain(
				storage,
				TimeSpan.FromMilliseconds(50),
				TimeSpan.FromSeconds(1)))
			{
				domain.Run();
				System.Threading.Thread.Sleep(200);
			}

			var readyList = storage.Get(ReminderItemStatus.Ready);
			Assert.IsNotNull(readyList);
			Assert.AreEqual(1, readyList.Count);
		}
	}
}
