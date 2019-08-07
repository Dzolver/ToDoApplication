using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoAppData.Models;

namespace TodoApp.Controllers
{
	[Route("api/[controller]")]
	public class TodoController : Controller
	{
		readonly TodoAppContext Context;
		public TodoController(TodoAppContext context)
			=> Context = context;

		[HttpGet]
		public IActionResult GetTodo()
		{
			//var todos = Context.Todo.ToList();
			var todosID = Context.Todo.Select(t => t.Id);
			IList<Guid> idList = new List<Guid>();

			foreach(Guid id in todosID)
			{
				idList.Add(id);
			}
			return Ok(idList);
		}

		[HttpPost]
		public IActionResult CreateTodo()
		{
			var todo = new Todo()
			{
				Title = "Do Laundry!",
				Body = @"You're laundry is
						looking a little sad."
			};

			Context.Add(todo);
			Context.SaveChanges();

			return Ok("Successfully created a todo item!");
		}

	}
}