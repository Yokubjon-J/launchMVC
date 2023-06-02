using Microsoft.AspNetCore.Mvc;
using launchMVC.Models;
using System.Net.Cache;

namespace launchMVC.Controllers
{
    public class TestController : Controller
    {
        private static List<MyViewModel> mModels = new List<MyViewModel>();
        public IActionResult Index()
        {
            return View(mModels);
        }

        public IActionResult Create()
        {
            var modVm = new MyViewModel();
            return View(modVm);
        }

        public IActionResult CreateModel(MyViewModel myViewModel) { 
            //return View("Index");
            mModels.Add(myViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "2nd Controller";
        }
    }
}
