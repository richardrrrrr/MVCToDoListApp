using Microsoft.AspNetCore.Mvc;
using MVCToDoListApp.Models;
namespace MVCToDoListApp.Controllers
{
	
	public class ToDoListController : Controller
	{
		private readonly ApplicationDbContext _Dbcontext;

		public ToDoListController(ApplicationDbContext dbcontext)
		{
			_Dbcontext = dbcontext;
		}
		public IActionResult ToDoList()
		{
			var ToDoListItems = _Dbcontext.ToDoItems.ToList();
			return View(ToDoListItems);
		}

		public IActionResult CreateToDoItem()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDoItem(ToDoItem toDoItem)
		{
			if(ModelState.IsValid)
		}

	}
}
