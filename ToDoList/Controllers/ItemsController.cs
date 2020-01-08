using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        //ListItem list = new ListItem();

        [HttpGet("/items")]
        public ActionResult Index()
        {
            List<Item> itemList = Item.getAllItems();
            return View(itemList);
            
            //return View(list.toStirng());
        }
        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Index(string description)
        {
            Item myitem = new Item(description);
            //list.addItem(item);

            return RedirectToAction("Index");

        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
        Item.clearAllItems();
        return View();
        }

        [HttpGet("/items/find")]
        public ActionResult FindItem(int findId)
        {
             Item findItem = Item.Find(findId);
            return View(findItem);
        }

       
    }
}