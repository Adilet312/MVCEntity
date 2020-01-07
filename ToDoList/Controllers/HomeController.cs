using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
         
            List<Item> list = Item.getAllItems();
            return View(list);
        }
        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string description)
        {
            Item starterItem = new Item(description);
            return RedirectToAction("Index");

        }

    }
}