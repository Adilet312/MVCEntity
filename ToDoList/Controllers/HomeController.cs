using Microsoft.AspNetCore.Mvc;
using System.Linq;
 using ToDoList.Models;

namespace  ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}