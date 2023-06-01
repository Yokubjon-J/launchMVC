using Microsoft.AspNetCore.Mvc;
using launchMVC.Models;
using System.Net.Cache;

namespace launchMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            MyViewModel mod = new MyViewModel() { Name = "Sif", Age = 2 };
            return View(mod);
        }

        public IActionResult Create()
        {
            var modVm = new MyViewModel();
            return View(modVm);
        }

        public IActionResult CreateModel(MyViewModel myViewModel) { 
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "2nd Controller";
        }
    }
}
