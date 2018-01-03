using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Linq;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
	public class ItemsController : Controller
	{
		private ToDoListContext db = new ToDoListContext();
		public IActionResult Index()
		{
			List<Item> model = db.Items.ToList();
			return View(model);
		}
	}
}