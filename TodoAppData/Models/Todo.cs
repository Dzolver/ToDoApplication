using System;
using System.Collections.Generic;
using System.Text;

namespace TodoAppData.Models
{
	public class Todo
	{
		public Todo()
		{
			Id = new Guid();
			CreatedOn = DateTime.Now;
			IsCompleted = false;
		}
		public Guid Id { get; private set; }
		public DateTime CreatedOn { get; private set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public bool IsCompleted { get; private set; }
	}
}
